using System;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Reactive.Testing;
using RTC;
using ReactiveRTM.Core;
using ReactiveRTM.Extensions;
using omg.org.RTC;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ComponentTest
{
[TestClass]
public class ComponentTest : ReactiveTest
{
    [TestMethod]
    public void TargetComponentの入出力チェック()
    {
        var scheduler = new TestScheduler();

        // OutPortから出力されたデータを蓄えるためのもの。
        var recorder = scheduler.CreateObserver<TimedLong>();

        // InPortにデータを入力するためのもの。1秒ごとにデータを送る。
        var publisher = scheduler.CreateHotObservable(
            OnNext(TimeSpan.FromSeconds(1).Ticks, new TimedLong() {data = 1}),
            OnNext(TimeSpan.FromSeconds(2).Ticks, new TimedLong() {data = 2}),
            OnNext(TimeSpan.FromSeconds(3).Ticks, new TimedLong() {data = 3}),
            OnNext(TimeSpan.FromSeconds(4).Ticks, new TimedLong() {data = 4}),
            OnNext(TimeSpan.FromSeconds(5).Ticks, new TimedLong() {data = 5})
            );

        var comp = new TargetComponent();

        // コンポーネントのスケジューラをTestSchedulerに差し替える
        comp.ExecutionContextScheduler = scheduler;

        // 入出力ポートに接続
        comp.InPort.Connect(publisher);
        comp.OutPort.Connect(recorder);

        // コンポーネントを活性化
        var retRecorder = scheduler.CreateObserver<ReturnCode_t>();
        comp.ActivateAsync().ToObservable().Subscribe(retRecorder);
        scheduler.AdvanceBy(100);
        retRecorder.Messages.Count.Is(2);
        retRecorder.Messages.First().Value.Value.Is(ReturnCode_t.RTC_OK);

        // 時間を5秒進める
        scheduler.AdvanceBy(TimeSpan.FromSeconds(5).Ticks);

        // 入力データの値が2倍されて出力されていることを確認
        recorder.Messages.Count.Is(5);
        ReactiveAssert.AreElementsEqual(
            recorder.Messages.Select(x => x.Value.Value),
            new[] {
                    new TimedLong() {data = 2},
                    new TimedLong() {data = 4},
                    new TimedLong() {data = 6},
                    new TimedLong() {data = 8},
                    new TimedLong() {data = 10}
                });
    }
}

    // テスト対象となるコンポーネント
    public class TargetComponent : ReactiveComponent
    {
        public ReactiveInPort<TimedLong> InPort { get; private set; }
        public ReactiveOutPort<TimedLong> OutPort { get; private set; }

        public TargetComponent()
            : base("TargetComponent")
        {
            InPort = new ReactiveInPort<TimedLong>("in");
            OutPort = new ReactiveOutPort<TimedLong>("out");
        }

        IDisposable _disposer;

        protected override ReturnCode_t OnActivated(int execHandle)
        {
            // InPortから入ってきたデータを2倍してOutPortに出力
            _disposer = InPort
                .Select(x => new TimedLong(x.tm, x.data * 2))
                .Subscribe(OutPort);

            return ReturnCode_t.RTC_OK;
        }

        protected override ReturnCode_t OnDeactivated(int execHandle)
        {
            _disposer.Dispose();
            return ReturnCode_t.RTC_OK;
        }
    }
}

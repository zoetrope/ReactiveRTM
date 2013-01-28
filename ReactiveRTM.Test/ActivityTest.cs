using System;
using System.Reactive.Linq;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.Reactive.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReactiveRTM.Core;
using ReactiveRTM.Extensions;
using omg.org.RTC;
using System.Reactive.Threading.Tasks;

namespace ReactiveRTM.Test
{

    [TestClass]
    public class ActivityTest : ReactiveTest
    {

        [TestMethod]
        public void OnExecuteを動かしてみる()
        {
            var comp = new SimpleComponent("test");

            var testScheduler = new TestScheduler();
            var recorder = testScheduler.CreateObserver<ReturnCode_t>();

            comp.ExecutionContextScheduler = testScheduler;

            // OnExecuteが呼ばれるたびにカウンタをインクリメント
            var executeCounter = 0;
            comp.OnExecute = _ =>
            {
                executeCounter = executeCounter + 1;
                return ReturnCode_t.RTC_OK; 
            };

            // コンポーネントを活性化
            comp.ActivateAsync().ToObservable().Subscribe(recorder);
            

            // 時間がたっていないので何も起きていない
            executeCounter.Is(0);
            recorder.Messages.Count.Is(0);

            // 時間を進める
            testScheduler.AdvanceBy(100);

            // 活性化に成功したことを確認
            recorder.Messages.Count.Is(2);
            recorder.Messages.First().Value.Value.Is(ReturnCode_t.RTC_OK);

            executeCounter.Is(0);

            // 時間を5秒進める
            testScheduler.AdvanceBy(TimeSpan.FromSeconds(5).Ticks);

            // OnExecuteは1秒に1回呼ばれる
            executeCounter.Is(5);

        }

        [TestMethod]
        public void OnExecuteを動かしてみる2()
        {
            var comp = new TestTargetComponent();

            var testScheduler = new TestScheduler();
            var recorder = testScheduler.CreateObserver<ReturnCode_t>();

            comp.ExecutionContextScheduler = testScheduler;


            // コンポーネントを活性化
            comp.ActivateAsync().ToObservable().Subscribe(recorder);

            // 時間がたっていないので何も起きていない
            comp.ExecuteCounter.Is(0);
            recorder.Messages.Count.Is(0);

            // 時間を進める
            testScheduler.AdvanceBy(100);

            // 活性化に成功したことを確認
            recorder.Messages.Count.Is(2);
            recorder.Messages.First().Value.Value.Is(ReturnCode_t.RTC_OK);

            comp.ExecuteCounter.Is(0);

            // 時間を5秒進める
            testScheduler.AdvanceBy(TimeSpan.FromSeconds(5).Ticks);

            // OnExecuteは1秒に1回呼ばれる
            comp.ExecuteCounter.Is(5);

        }

    }

    public class TestTargetComponent : ReactiveComponent
    {
        public TestTargetComponent()
            : base("Test")
        {
            ExecuteCounter = 0;
        }

        public int ExecuteCounter { get; set; }

        protected override ReturnCode_t OnExecute(int execHandle)
        {
            // OnExecuteが呼ばれるたびにカウンタをインクリメント
            ExecuteCounter = ExecuteCounter + 1;
            return ReturnCode_t.RTC_OK;
        }
    }

}

using System;
using System.Reactive.Linq;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Reactive.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RTC;
using ReactiveRTM.Core;
using ReactiveRTM.Extensions;
using omg.org.RTC;

namespace ComponentTest
{
    [TestClass]
    public class UnitTest1 : ReactiveTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var scheduler = new TestScheduler();
            var recorder = scheduler.CreateObserver<TimedLong>();
            var publisher = scheduler.CreateHotObservable(
                OnNext(TimeSpan.FromSeconds(1).Ticks, new TimedLong(new Time(), 1)),
                OnNext(TimeSpan.FromSeconds(2).Ticks, new TimedLong(new Time(), 2)),
                OnNext(TimeSpan.FromSeconds(3).Ticks, new TimedLong(new Time(), 3)),
                OnNext(TimeSpan.FromSeconds(4).Ticks, new TimedLong(new Time(), 4))
                );

            var comp = new TargetComponent();

            comp.ExecutionContextScheduler = scheduler;

            comp.InPort.Connect(publisher);
            comp.OutPort.Connect(recorder);

            var rec2 = scheduler.CreateObserver<ReturnCode_t>();
            comp.ActivateAsync().Subscribe(rec2);
            scheduler.AdvanceBy(100);
            rec2.Messages.Count.Is(1);

            scheduler.AdvanceBy(TimeSpan.FromSeconds(5).Ticks);

            recorder.Messages.Count.Is(5);
        }
    }

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
            Console.WriteLine("Activate");
            _disposer = InPort
                .Do(x=>Console.WriteLine(x.data))
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

using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.Reactive.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RTC;
using ReactiveRTM.Corba;
using ReactiveRTM.Core;
using omg.org.RTC;

namespace ReactiveRTM.Test
{
    [TestClass]
    public class DataPortTest : ReactiveTest
    {


        [TestMethod]
        public void ポート接続確認()
        {
            var inport = new ReactiveInPort<TimedLong>("inport");
            var outport = new ReactiveOutPort<TimedLong>("outport");

            var connector = new PortConnector(inport.PortService, outport.PortService);

            connector.ConnectAsync().Result.Is(ReturnCode_t.RTC_OK);
        }

        [TestMethod]
        public void ポート切断確認()
        {
            var inport = new ReactiveInPort<TimedLong>("inport");
            var outport = new ReactiveOutPort<TimedLong>("outport");

            var connector = new PortConnector(inport.PortService, outport.PortService);

            connector.ConnectAsync().Result.Is(ReturnCode_t.RTC_OK);

            connector.DisconnectAsync().Result.Is(ReturnCode_t.RTC_OK);
        }


        [TestMethod]
        public void 疎通確認()
        {
            var inport = new ReactiveInPort<TimedLong>("inport");
            var outport = new ReactiveOutPort<TimedLong>("outport");

            var testScheduler = new TestScheduler();
            var recorder = testScheduler.CreateObserver<TimedLong>();

            var connector = new PortConnector(inport.PortService, outport.PortService);

            connector.ConnectAsync().Result.Is(ReturnCode_t.RTC_OK);

            inport.Subscribe(recorder);

            var testData = new TimedLong(new Time(), 123);

            outport.Write(testData);

            //scheduler.AdvanceBy(TimeSpan.FromSeconds(10).Ticks);

            recorder.Messages.Count.Is(1);
            recorder.Messages.Is(OnNext(0, testData));
        }
    }
}

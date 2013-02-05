using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReactiveRTM.Core;

namespace ReactiveRTM.Test.Core
{
    [TestClass]
    public class RtcManagerTest
    {
        [TestMethod]
        public void ParseOptionTest()
        {
            var manager = new RtcManager(new[]{"-f",@"..\..\TestData\rtc1.yaml"});

            manager.RtcSetting.Corba.CommonSetting.Name.Is("IIOPChannel");
        }
        [TestMethod]
        public void ParseOptionTest2()
        {
            var manager = new RtcManager(new[] { "-f", @"..\..\TestData\rtc2.yaml" });

        }
    }
}

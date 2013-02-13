using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReactiveRTM.Core;
using ReactiveRTM.Utility;

namespace ReactiveRTM.Test.Core
{
    [TestClass]
    public class RtcManagerTest
    {
        [TestMethod]
        public void ParseOptionTest()
        {
            var opt = new RtcSettingManager(@"..\..\TestData\rtc1.yaml");
            opt.RtcSetting.Corba.Common.Name.Is("IIOPChannel");
        }
        [TestMethod]
        public void ParseOptionTest2()
        {
            var opt = new RtcSettingManager(@"..\..\TestData\rtc2.yaml");
        }
    }
}

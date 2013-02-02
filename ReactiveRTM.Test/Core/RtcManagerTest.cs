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
            var manager = new RtcManager(new[]{"-f","rtc.yaml"});
        }
    }
}

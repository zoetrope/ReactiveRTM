using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReactiveRTM.Utility;

namespace ReactiveRTM.Test.Utility
{
    [TestClass]
    public class RtcSettingTest
    {
        [TestMethod]
        public void ParseFullSettingFile()
        {
            var manager = new RtcSettingManager(@"..\..\TestData\rtc1.yaml");

            var setting = manager.RtcSetting;
            
            setting.IsNotNull();

            setting.Catalogs.IsNotNull(); 
            setting.Corba.IsNotNull();
            setting.ExecutionContext.IsNotNull();
            setting.Logger.IsNotNull();
            setting.Manager.IsNotNull();
            setting.Naming.IsNotNull();
            setting.SdoService.IsNotNull();
            setting.Timer.IsNotNull();
            
        }
        [TestMethod]
        public void ParseNotFullSettingFile()
        {
            var manager = new RtcSettingManager(@"..\..\TestData\rtc2.yaml");
            var setting = manager.RtcSetting;

            setting.IsNotNull();

            setting.Catalogs.IsNotNull();
            setting.Corba.IsNotNull();
            setting.ExecutionContext.IsNotNull();
            setting.Logger.IsNotNull();
            setting.Manager.IsNotNull();
            setting.Naming.IsNotNull();
            setting.SdoService.IsNotNull();
            setting.Timer.IsNotNull();
        }
        [TestMethod]
        public void ParseUnknownFile()
        {
            var manager = new RtcSettingManager(@"..\..\TestData\unknown.yaml");
            var setting = manager.RtcSetting;

            setting.IsNotNull();

            setting.Naming.Enable.Is(true);

            setting.Catalogs.IsNotNull();
            setting.Corba.IsNotNull();
            setting.ExecutionContext.IsNotNull();
            setting.Logger.IsNotNull();
            setting.Manager.IsNotNull();
            setting.Naming.IsNotNull();
            setting.SdoService.IsNotNull();
            setting.Timer.IsNotNull();

        }
    }
}

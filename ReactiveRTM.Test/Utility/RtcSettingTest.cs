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
            var setting = RtcSetting.Load(@"..\..\TestData\rtc1.yaml");

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
            var setting = RtcSetting.Load(@"..\..\TestData\rtc2.yaml");

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
            var setting = RtcSetting.Load(@"..\..\TestData\unknown.yaml");

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

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Codeplex.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReactiveRTM.Core;

namespace ReactiveRTM.Test
{
    [TestClass]
    public class SimpleServiceTest
    {
        [TestMethod]
        public void 呼び出し確認()
        {
            dynamic cons = new SimpleServiceConsumer("test");
            var prov = new SimpleServiceProvider("test");

            prov.RegisterMethod("Test", (double i) => i * i);

            var dummy = prov.AdapterForTest;

            cons.SetDummy((MarshalByRefObject)dummy);

            double ret = cons.Test(10);
            ret.Is(100);
        }


    }

}

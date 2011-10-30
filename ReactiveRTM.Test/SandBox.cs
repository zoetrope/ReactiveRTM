using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RTC;

namespace ReactiveRTM.Test
{
    [TestClass]
    public class SandBox
    {
        [TestMethod]
        public void 配列要素のコピー()
        {
            var data = new TimedLongSeq();
            data.data = new int[3]{1,2,3};

            var data2 = data;

            data.data[0] = 3;
            data.data[1] = 2;
            data.data[2] = 1;

            data2.data[0].Is(1);
            data2.data[1].Is(2);
            data2.data[2].Is(3);
        }
    }
}

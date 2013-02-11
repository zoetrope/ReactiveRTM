using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReactiveRTM.Core;
using Newtonsoft.Json.Bson;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reactive.Concurrency;

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

        [TestMethod]
        public void BSONがつかえるかどうか()
        {
            var js = new JsonSerializer();

            var ms = new MemoryStream();
            var bw = new BsonWriter(ms);

            js.Serialize(bw, new { Name = "hoge", Age = 13 });

            Console.WriteLine(BitConverter.ToString(ms.ToArray()));


            ms.Seek(0, SeekOrigin.Begin);



            // deserialize product from BSON

            var br = new BsonReader(ms);

            dynamic ret = js.Deserialize(br);

            Console.WriteLine(ret.Name);
            Console.WriteLine(ret.Age);
        }


    }

}

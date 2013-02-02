using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using ReactiveRTM.Adapter;
using ReactiveRTM.Corba;
using ReactiveRTM.Core;
using ReactiveRTM.openrtm.aist.go.jp.OpenRTM;
using NDesk.Options;

namespace ReactiveRTM.Core
{
    public class RtcManager : IDisposable
    {
        private NamingServiceClient _client;

        public RtcManager()
        {
            CorbaUtility.Initialize();
        }

        public RtcManager(IEnumerable<string> args)
            : this()
        {
            ParseOption(args);
        }

        public RtcManager(string host, int port)
            : this()
        {
            _client = new NamingServiceClient(host, port);
        }

        private void ParseOption(IEnumerable<string> args)
        {
            string data = null;
            bool help = false;
            int verbose = 0;
            bool version=false;

            var p = new OptionSet() {
                { "f|file=",      v => data = v },
                { "v|version",  v => version = true },
                { "h|?|help",   v => help = v != null },
            };
            var extra = p.Parse(args);


        }

        public void RegisterComponent(ReactiveComponentBase comp)
        {
            _client.RegisterObject(comp.Name + ".rtc", (MarshalByRefObject)comp.Component);
        }

        public void Run()
        {
            Thread.Sleep(Timeout.Infinite);
        }

        public void Dispose()
        {
            CorbaUtility.Destroy();
        }

        public IObservableComponent GetComponent(string name)
        {
            var comp = _client.GetObject<global::omg.org.RTC.RTObject>(name);
            var stub = new DataFlowComponentStub((global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent)comp);
            return new ObservableComponent(stub);
        }
    }
}

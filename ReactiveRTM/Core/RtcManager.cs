﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using ReactiveRTM.Adapter;
using ReactiveRTM.Corba;
using ReactiveRTM.Core;
using openrtm.aist.go.jp.OpenRTM;

namespace ReactiveRTM.Core
{
    public class RtcManager : IDisposable
    {
        private CorbaNamingServiceClient _client;

        public RtcManager(string host, int port)
        {
            CorbaUtility.Initialize();
            _client = new CorbaNamingServiceClient(host, port);
        }

        public void RegisterComponent(ReactiveComponentBase comp)
        {
            _client.RegisterObject(comp.Name + ".rtc", (MarshalByRefObject) comp.Component);
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
            var comp = _client.GetObject<DataFlowComponent>(name);
            return new ObservableComponent(comp);
        }
    }
}

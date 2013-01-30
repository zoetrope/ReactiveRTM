using System;
using ReactiveRTM.Adapter;
using ReactiveRTM.Extensions;
using ReactiveRTM.omg.org.RTC;

namespace ReactiveRTM.Core
{
    public abstract class ReactivePortBase : IConnectable
    {

        public PortService PortService { get; private set; }

        public IObservable<ConnectorProfile> ConnectionChangedAsObservable()
        {
            throw new NotImplementedException();
        }

        protected ReactivePortBase(string name)
        {
            Name = name;
        }

        public void Initialize(PortProfileHolder prof)
        {
            PortService = new PortServiceAdapter(this, prof);
        }

        public string Name { get; set; }

        public void Connection()
        {
            var prof = new ConnectorProfileHolder();
            prof.Ports.Add(PortService);
            prof.Name = "dummy"; //名前見直し？
            prof.ConnectorID = "";
            prof.DataFlowType="push";
            prof.InterfaceType= "corba_cdr";
            prof.SubscriptionType="flush";
        }

        public void SetOwner(DataFlowComponent comp)
        {
        }

        public abstract ReturnCode_t SetConnectionInfo(ConnectorProfileHolder connectorProfile);
        public abstract ReturnCode_t Connect(ConnectorProfileHolder connectorProfile);
        public abstract ReturnCode_t Disconnect(ConnectorProfileHolder connectorProfile);
        
    }
}

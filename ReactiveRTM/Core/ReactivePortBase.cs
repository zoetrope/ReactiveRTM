using System;
using ReactiveRTM.Adapter;
using ReactiveRTM.Extensions;
using ReactiveRTM.RTC;

namespace ReactiveRTM.Core
{
    public abstract class PortServiceBase<TDataType> :ReactivePortBase, IDisposable
    {
        public void Initialize(string name)
        {
        }

        private Action _action;
        public void SetDisposing(Action action)
        {
            _action = action;
        }

        public void Dispose()
        {
            _action();
        }
    }


    public abstract class ReactivePortBase : IConnectable
    {

        public PortService PortService { get; private set; }

        public IObservable<ConnectorProfile> ConnectionChangedAsObservable()
        {
            throw new NotImplementedException();
        }

        protected ReactivePortBase()
        { 
        }

        protected ReactivePortBase(string name)
        {
            Name = name;
        }

        public void Initialize(PortProfile prof)
        {
            PortService = new PortServiceImpl(this, prof);
        }

        public string Name { get; set; }

        public void Connection()
        {
            var prof = new ConnectorProfile();
            prof.Ports.Add(PortService);
            prof.Name = "dummy"; //名前見直し？
            prof.ConnectorId = "";
            prof.SetDataFlowType("push");
            prof.SetInterfaceType("corba_cdr");
            prof.SetSubscriptionType("flush");
        }

        public void SetOwner(DataFlowComponent comp)
        {
        }

        public abstract ReturnCode_t SetConnectionInfo(ConnectorProfile connectorProfile);
        public abstract ReturnCode_t Connect(ConnectorProfile connectorProfile);
        public abstract ReturnCode_t Disconnect(ConnectorProfile connectorProfile);
        
    }
}

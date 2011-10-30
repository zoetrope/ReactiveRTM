using System;
using ReactiveRTM.Adapter;
using ReactiveRTM.Extensions;
using omg.org.RTC;
using org.omg.SDOPackage;

namespace ReactiveRTM.Core
{
    public class ConnectionChangedEventArgs : EventArgs
    {
        public ConnectorProfile ConnectorProfile { get; set; }
    }

    public abstract class ReactivePortBase : IConnectable
    {

        public PortService PortService { get; private set; }

        public event EventHandler<ConnectionChangedEventArgs> ConnectionChanged;

        public ReactivePortBase(string name)
        {
            Name = name;
        }

        public void Initialize(PortProfile prof)
        {
            PortService = new PortServiceAdapter(this, prof);
        }

        public string Name { get; set; }

        public void Connection()
        {
            var prof = new ConnectorProfile();
            prof.ports = new[] { PortService };
            prof.name = "dummy"; //名前見直し？
            prof.connector_id = "";
            ConnectorProfileExtensions.AddDataFlowType(ref prof, "push");
            ConnectorProfileExtensions.AddInterfaceType(ref prof, "corba_cdr");
            ConnectorProfileExtensions.AddSubscriptionType(ref prof, "flush");
        }

        public void SetOwner(DataFlowComponent comp)
        {
        }

        public abstract ReturnCode_t SetConnectionInfo(ref ConnectorProfile connectorProfile);
        public abstract ReturnCode_t Connect(ref ConnectorProfile connectorProfile);
        public abstract ReturnCode_t Disconnect(ref ConnectorProfile connectorProfile);
        
    }
}

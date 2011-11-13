using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReactiveRTM.Extensions;
using omg.org.RTC;
using org.omg.SDOPackage;

namespace ReactiveRTM.Core
{
    public class ConnectorProfileHolder
    {
        private ConnectorProfile _profile;

        public ConnectorProfileHolder()
        {
            _profile.ports = new PortService[0];
            _profile.properties = new NameValue[0];
        }

        public ConnectorProfileHolder(ConnectorProfile prof)
        {
            _profile = prof;
        }

        public string Name
        {
            get { return _profile.name; }
            set { _profile.name = value; }
        }
        public string ConnectorID
        {
            get { return _profile.connector_id; }
            set { _profile.connector_id = value; }
        }
        public List<PortService> Ports
        {
            get { return _profile.ports.ToList(); }
            set { _profile.ports = value.ToArray(); }
        }

        /// <summary>
        /// push/pull
        /// </summary>
        public string DataFlowType
        {
            get { return _profile.properties.GetStringValue("dataport.dataflow_type"); }
            set { NameValueExtensions.AddStringValue(ref _profile.properties, "dataport.dataflow_type", value); }
        }

        /// <summary>
        /// corba_cdr
        /// </summary>
        public string InterfaceType
        {
            get { return _profile.properties.GetStringValue("dataport.interface_type"); }
            set { NameValueExtensions.AddStringValue(ref _profile.properties, "dataport.interface_type", value); }
        }

        /// <summary>
        /// new/flush/periodic
        /// </summary>
        public string SubscriptionType
        {
            get { return _profile.properties.GetStringValue("dataport.subscription_type"); }
            set { NameValueExtensions.AddStringValue(ref _profile.properties, "dataport.subscription_type", value); }
        }
        public string InPortIor
        {
            get { return _profile.properties.GetStringValue("dataport.corba_cdr.inport_ior"); }
            set { NameValueExtensions.AddStringValue(ref _profile.properties, "dataport.corba_cdr.inport_ior", value); }
        }

        internal ConnectorProfile GetConnectorProfile()
        {
            return _profile;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReactiveRTM.Extensions;
using omg.org.RTC;
using org.omg.SDOPackage;

namespace ReactiveRTM.Core
{
    public static class ConnectorProfileExtensions
    {
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

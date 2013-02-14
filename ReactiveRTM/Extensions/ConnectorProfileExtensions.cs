using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReactiveRTM.Extensions;
using ReactiveRTM.RTC;

namespace ReactiveRTM.Extensions
{
    public static class ConnectorProfileExtensions
    {
        /// <summary>
        /// push/pull
        /// </summary>
        public static string GetDataFlowType(this ConnectorProfile profile)
        {
            return (string)profile.Properties["dataport.dataflow_type"];
        }
        public static void SetDataFlowType(this ConnectorProfile profile, string value)
        {
            profile.Properties["dataport.dataflow_type"] = value;
        }

        /// <summary>
        /// corba_cdr
        /// </summary>
        public static string GetInterfaceType(this ConnectorProfile profile)
        {
            return (string)profile.Properties["dataport.interface_type"];
        }
        public static void SetInterfaceType(this ConnectorProfile profile, string value)
        {
            profile.Properties["dataport.interface_type"] = value;
        }

        /// <summary>
        /// new/flush/periodic
        /// </summary>
        public static string GetSubscriptionType(this ConnectorProfile profile)
        {
            return (string)profile.Properties["dataport.subscription_type"];
        }
        public static void SetSubscriptionType(this ConnectorProfile profile, string value)
        {
            profile.Properties["dataport.subscription_type"] = value;
        }
        public static string GetInPortIor(this ConnectorProfile profile)
        {
            return (string)profile.Properties["dataport.corba_cdr.inport_ior"];
        }
        public static void SetInPortIor(this ConnectorProfile profile, string value)
        {
            profile.Properties["dataport.corba_cdr.inport_ior"] = value;
        }

    }
}

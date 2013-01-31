using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReactiveRTM.Extensions;
using ReactiveRTM.omg.org.RTC;

namespace ReactiveRTM.Core
{
    public static class ConnectorProfileExtensions
    {
        /// <summary>
        /// push/pull
        /// </summary>
        public static string GetDataFlowType(this ConnectorProfile profile)
        {
            return profile.Properties.GetStringValue("dataport.dataflow_type"); 
        }
            public static void SetDataFlowType(this ConnectorProfile profile, string value)
        {
            NameValueExtensions.AddStringValue(ref profile.Properties, "dataport.dataflow_type", value); 
        }

        /// <summary>
        /// corba_cdr
            /// </summary>
            public static string GetInterfaceType(this ConnectorProfile profile)
            {
                return profile.Properties.GetStringValue("dataport.interface_type");
            }
            public static void SetInterfaceType(this ConnectorProfile profile, string value)
            {
                NameValueExtensions.AddStringValue(ref profile.Properties, "dataport.interface_type", value);
            }

        /// <summary>
        /// new/flush/periodic
            /// </summary>
            public static string GetSubscriptionType(this ConnectorProfile profile)
            {
                return profile.Properties.GetStringValue("dataport.subscription_type");
            }
            public static void SetSubscriptionType(this ConnectorProfile profile, string value)
            {
                NameValueExtensions.AddStringValue(ref profile.Properties, "dataport.subscription_type", value);
            }
            public static string GetInPortIor(this ConnectorProfile profile)
            {
                return profile.Properties.GetStringValue("dataport.corba_cdr.inport_ior");
            }
            public static void SetInPortIor(this ConnectorProfile profile, string value)
            {
                NameValueExtensions.AddStringValue(ref profile.Properties, "dataport.corba_cdr.inport_ior", value);
            }

    }
}

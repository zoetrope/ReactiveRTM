using omg.org.RTC;

namespace ReactiveRTM.Extensions
{
    public static class ConnectorProfileExtensions
    {

        public static string GetDataFlowType(this ConnectorProfile target)
        {
            return target.properties.GetStringValue("dataport.dataflow_type");
        }

        public static string GetInterfaceType(this ConnectorProfile target)
        {
            return target.properties.GetStringValue("dataport.interface_type");
        }

        public static string GetSubscriptionType(this ConnectorProfile target)
        {
            return target.properties.GetStringValue("dataport.subscription_type");
        }

        public static string GetInPortIor(this ConnectorProfile target)
        {
            return target.properties.GetStringValue("dataport.corba_cdr.inport_ior");
        }


        public static void AddDataFlowType(ref ConnectorProfile target, string value)
        {
            NameValueExtensions.AddStringValue(ref target.properties, "dataport.dataflow_type", value);

        }

        public static void AddInterfaceType(ref ConnectorProfile target, string value)
        {
            NameValueExtensions.AddStringValue(ref target.properties, "dataport.interface_type", value);

        }

        public static void AddSubscriptionType(ref ConnectorProfile target, string value)
        {
            NameValueExtensions.AddStringValue(ref target.properties, "dataport.subscription_type", value);

        }

        public static void AddInPortIor(ref ConnectorProfile target, string value)
        {
            NameValueExtensions.AddStringValue(ref target.properties, "dataport.corba_cdr.inport_ior", value);
        }
         
    }
}

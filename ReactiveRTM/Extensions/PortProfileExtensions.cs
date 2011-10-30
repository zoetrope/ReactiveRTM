using System;
using System.Linq;
using omg.org.RTC;
using org.omg.SDOPackage;

namespace ReactiveRTM.Extensions
{
    
    public enum PortType
    {
        DataInPort,
        DataOutPort,
        ServiceProvider,
        ServiceConsumer
    }

    public static class PortProfileExtensions
    {
        public static string GetDataType(this PortProfile target)
        {
            var portType = target.properties.GetStringValue("port.port_type");

            switch (portType)
            {
                case "DataInPort":
                    return target.properties.GetStringValue("dataport.data_type");
                case "DataOutPort":
                    return target.properties.GetStringValue("dataport.data_type");
                case "CorbaPort":
                    return target.interfaces.First().type_name;
                default:
                    throw new ArgumentException();
            }
        }


        public static PortType GetPortType(this PortProfile target)
        {
            var portType = target.properties.GetStringValue("port.port_type");

            switch (portType)
            {
                case "DataInPort":
                    return PortType.DataInPort;
                case "DataOutPort":
                    return PortType.DataOutPort;
                case "CorbaPort":
                    switch (target.interfaces.First().polarity)
                    {
                        case PortInterfacePolarity.PROVIDED:
                            return PortType.ServiceProvider;
                        case PortInterfacePolarity.REQUIRED:
                            return PortType.ServiceConsumer;
                        default:
                            throw new ArgumentException();
                    }
                default:
                    throw new ArgumentException();
            }
        }

        public static PortType GetPartnerType(PortProfile profile)
        {
            PortType type = profile.GetPortType();

            switch (type)
            {
                case PortType.DataInPort:
                    return PortType.DataOutPort;

                case PortType.DataOutPort:
                    return PortType.DataInPort;

                case PortType.ServiceProvider:
                    return PortType.ServiceConsumer;

                case PortType.ServiceConsumer:
                    return PortType.ServiceProvider;
            }

            throw new ArgumentException();
        }

        public static string GetSubscriptionType(this PortProfile target)
        {
            return target.properties.GetStringValue("dataport.subscription_type");
        }

        public static string GetDataflowType(this PortProfile target)
        {
            return target.properties.GetStringValue("dataport.dataflow_type");
        }

        public static string GetInterfaceType(this PortProfile target)
        {
            return target.properties.GetStringValue("dataport.interface_type");
        }


        public static void AddSubscriptionType(ref PortProfile target, string value)
        {
            NameValueExtensions.AddStringValue(ref target.properties, "dataport.subscription_type", value);
        }

        public static void AddDataFlowType(ref PortProfile target, string value)
        {
            NameValueExtensions.AddStringValue(ref target.properties, "dataport.dataflow_type", value);
        }

        public static void AddInterfaceType(ref PortProfile target, string value)
        {
            NameValueExtensions.AddStringValue(ref target.properties, "dataport.interface_type", value);
        }



    }
}


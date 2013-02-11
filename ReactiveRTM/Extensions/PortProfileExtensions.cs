using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReactiveRTM.Extensions;
using ReactiveRTM.RTC;

namespace ReactiveRTM.Core
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
        public static string GetDataType(this PortProfile profile)
        {
            var portType = profile.Properties["port.port_type"] as string;

            switch (portType)
            {
                case "DataInPort":
                    return profile.Properties["dataport.data_type"] as string;
                case "DataOutPort":
                    return profile.Properties["dataport.data_type"] as string;
                case "CorbaPort":
                    return profile.Interfaces.First().TypeName;
                default:
                    throw new ArgumentException();
            }
        }
        public static void SetDataType(this PortProfile profile, string value)
        {
            profile.Properties["dataport.data_type"] = value;
        }


        public static PortType GetPortType(this PortProfile profile)
        {
            var portType = profile.Properties["port.port_type"] as string;

            switch (portType)
            {
                case "DataInPort":
                    return PortType.DataInPort;
                case "DataOutPort":
                    return PortType.DataOutPort;
                case "CorbaPort":
                    switch (profile.Interfaces.First().Polarity)
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
        public static void SetPortType(this PortProfile profile, PortType value)
        {
            string portType;
            switch (value)
            {
                case PortType.DataInPort:
                    portType = "DataInPort";
                    break;
                case PortType.DataOutPort:
                    portType = "DataOutPort";
                    break;
                default:
                    throw new ArgumentException();
            }
            profile.Properties["port.port_type"] = portType;
        }


        public static PortType GetPartnerType(this PortProfile profile)
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

        public static string GetSubscriptionType(this PortProfile profile)
        {
            return profile.Properties["dataport.subscription_type"] as string;
        }
        public static void SetSubscriptionType(this PortProfile profile, string value)
        {
            profile.Properties["dataport.subscription_type"] = value;
        }

        public static string GetDataflowType(this PortProfile profile)
        {
            return profile.Properties["dataport.dataflow_type"] as string;
        }
        public static void SetDataflowType(this PortProfile profile, string value)
        {
            profile.Properties["dataport.dataflow_type"] = value;
        }

        public static string GetInterfaceType(this PortProfile profile)
        {
            return profile.Properties["dataport.interface_type"] as string;
        }
        public static void SetInterfaceType(this PortProfile profile, string value)
        {
            profile.Properties["dataport.interface_type"] = value;
        }


    }
}

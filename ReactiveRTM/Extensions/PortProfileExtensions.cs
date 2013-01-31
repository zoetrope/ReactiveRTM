using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReactiveRTM.Extensions;
using ReactiveRTM.omg.org.RTC;

namespace ReactiveRTM.Core
{

    public enum PortType
    {
        DataInPort,
        DataOutPort,
        ServiceProvider,
        ServiceConsumer
    }
    public class PortProfileHolder
    {

        private PortProfile _profile;

        public PortProfileHolder()
        {
            _profile.connector_profiles = new ConnectorProfile[0];
            _profile.interfaces = new PortInterfaceProfile[0];
            _profile.properties = new NameValue[0];
        }

        public PortProfileHolder(PortProfile prof)
        {
            _profile = prof;
        }

        public string Name
        {
            get { return _profile.name; }
            set { _profile.name = value; }
        }
        public RTObject Owner
        {
            get { return _profile.owner; }
            set { _profile.owner = value; }
        }
        public PortService PortRef
        {
            get { return _profile.port_ref; }
            set { _profile.port_ref = value; }
        }

        public List<ConnectorProfile> ConnectorProfiles {
            get { return _profile.connector_profiles.Select(x => new ConnectorProfile(x)).ToList(); }
        }

        public string DataType
        {
            get
            {
                var portType = _profile.properties.GetStringValue("port.port_type");

                switch (portType)
                {
                    case "DataInPort":
                        return _profile.properties.GetStringValue("dataport.data_type");
                    case "DataOutPort":
                        return _profile.properties.GetStringValue("dataport.data_type");
                    case "CorbaPort":
                        return _profile.interfaces.First().type_name;
                    default:
                        throw new ArgumentException();
                }
            }
            set {
                NameValueExtensions.AddStringValue(ref _profile.properties, "dataport.data_type", value);
            }
        }

        public PortType PortType
        {
            get
            {
                var portType = _profile.properties.GetStringValue("port.port_type");

                switch (portType)
                {
                    case "DataInPort":
                        return PortType.DataInPort;
                    case "DataOutPort":
                        return PortType.DataOutPort;
                    case "CorbaPort":
                        switch (_profile.interfaces.First().polarity)
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
            set
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
                        throw new InvalidParameter();
                }
                NameValueExtensions.AddStringValue(ref _profile.properties, "port.port_type", portType);
            }
        }

        public PortType GetPartnerType()
        {
            PortType type = PortType;

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

        public string SubscriptionType
        {
            get { return _profile.properties.GetStringValue("dataport.subscription_type"); }
            set { NameValueExtensions.AddStringValue(ref _profile.properties, "dataport.subscription_type", value); }
        }
        public string DataflowType
        {
            get { return _profile.properties.GetStringValue("dataport.dataflow_type"); }
            set { NameValueExtensions.AddStringValue(ref _profile.properties, "dataport.dataflow_type", value); }
        }
        public string InterfaceType
        {
            get { return _profile.properties.GetStringValue("dataport.interface_type"); }
            set { NameValueExtensions.AddStringValue(ref _profile.properties, "dataport.interface_type", value); }
        }


        internal PortProfile GetPortProfile()
        {
            return _profile;
        }

    }
}

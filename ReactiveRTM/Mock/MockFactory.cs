using System.Linq;
using OpenRTM;
using ReactiveRTM.Extensions;
using ReactiveRTM.omg.org.RTC;
using System.Collections.Generic;

namespace ReactiveRTM.Mock
{

    public static class MockFactory
    {
        public static NamingServiceMock CreateNamingService(string host, int port)
        {
            var proxy = new MockProxy<NamingServiceMock>(new NamingServiceMock(host,port));
            return proxy.GetTransparentProxy();
        }

        public static RTObjectMock CreateRTObject(string typeName, string instanceName, params PortService[] ports)
        {
            var profile = new ComponentProfile()
            {
                Category = "",
                InstanceName = instanceName,
                Description = "",
                TypeName = typeName,
                Vendor = "",
                Version = "",
                PortProfiles = ports.Select(p => p.GetPortProfile()).ToList(),
                Parent = null,
                Properties = new Dictionary<string,object>()
            };

            var proxy = new MockProxy<RTObjectMock>(new RTObjectMock(profile, ports.ToList()));

            return proxy.GetTransparentProxy();
        }

        public static OutPortServiceMock CreateOutPortService(string name, string dataType)
        {
            var portProfile = new PortProfile()
            {
                Name = name,
                ConnectorProfiles = new ConnectorProfile[0],
                Interfaces = new PortInterfaceProfile[0],
                Owner = null,
                PortRef = null,
                Properties = new[]{
                    NameValueExtensions.Create("port.port_type","DataOutPort"),
                    NameValueExtensions.Create("dataport.data_type",dataType),
                    NameValueExtensions.Create("dataport.subscription_type","flush,new,periodic"),
                    NameValueExtensions.Create("dataport.dataflow_type","push,pull"),
                    NameValueExtensions.Create("dataport.interface_type","corba_cdr"),
                }
            };

            var proxy = new MockProxy<OutPortServiceMock>(new OutPortServiceMock(portProfile));
            return proxy.GetTransparentProxy();
        }

        public static InPortServiceMock CreateInPortService(string name, string dataType, InPortCdr inportCdr)
        {
            var portProfile = new PortProfile()
            {
                Name = name,
                ConnectorProfiles = new ConnectorProfile[0],
                Interfaces = new PortInterfaceProfile[0],
                Owner = null,
                PortRef = null,
                Properties = new[]{
                    NameValueExtensions.Create("port.port_type","DataInPort"),
                    NameValueExtensions.Create("dataport.data_type",dataType),
                    NameValueExtensions.Create("dataport.subscription_type","flush,new,periodic"),
                    NameValueExtensions.Create("dataport.dataflow_type","push,pull"),
                    NameValueExtensions.Create("dataport.interface_type","corba_cdr"),
                }
            };

            var proxy = new MockProxy<InPortServiceMock>(new InPortServiceMock(portProfile, inportCdr));
            return proxy.GetTransparentProxy();
        }
        
    }

}

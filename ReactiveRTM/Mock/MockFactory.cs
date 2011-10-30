using System.Linq;
using OpenRTM;
using ReactiveRTM.Extensions;
using omg.org.RTC;
using org.omg.SDOPackage;

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
                category = "",
                instance_name = instanceName,
                description = "",
                type_name = typeName,
                vendor = "",
                version = "",
                port_profiles = ports.Select(p => p.get_port_profile()).ToArray(),
                parent = null,
                properties = new NameValue[0]
            };

            var proxy = new MockProxy<RTObjectMock>(new RTObjectMock(profile, ports.ToList()));

            return proxy.GetTransparentProxy();
        }

        public static OutPortServiceMock CreateOutPortService(string name, string dataType)
        {
            var portProfile = new PortProfile()
            {
                name = name,
                connector_profiles = new ConnectorProfile[0],
                interfaces = new PortInterfaceProfile[0],
                owner = null,
                port_ref = null,
                properties = new[]{
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
                name = name,
                connector_profiles = new ConnectorProfile[0],
                interfaces = new PortInterfaceProfile[0],
                owner = null,
                port_ref = null,
                properties = new[]{
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

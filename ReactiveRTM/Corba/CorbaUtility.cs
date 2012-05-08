using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using Ch.Elca.Iiop;
using Ch.Elca.Iiop.Idl;
using omg.org.CORBA;

namespace ReactiveRTM.Corba
{
    public static class CorbaUtility
    {
        private static IiopChannel _channel;
        private static readonly object _channelLock = new object();

        static CorbaUtility()
		{
            //Initialize();
        }

        public static void Initialize()
        {
            //TODO: 設定は外から渡せるようにする。
            var setting = new Dictionary<string, string>()
                {
                    // Common Settings
                    //{"name","IIOPChannel"},
                    //{"priority","0"},
                    //{"endian","true"},

                    // Client Settings
                    //{"clientReceiveTimeOut","3000"},
                    //{"clientSendTimeOut","3000"},
                    {"clientRequestTimeOut","3000"},
                    //{"unusedConnectionKeepAlive","300000"},
                    //{"clientConnectionLimit","5"},
                    //{"allowRequestMultiplex","true"},
                    //{"maxNumberOfMultiplexedRequests","1000"},
                    //{"maxNumberOfRetries","0"},
                    //{"retryDelay","0"},

                    // Server Settings
                    {"port","0"},
                    //{"machineName",""},
                    //{"bindTo",""},
                    //{"useIpAddress","true"},
                    //{"serverThreadsMaxPerConnection","25"}
                };

            lock (_channelLock)
            {
                if (_channel == null)
                {
                    _channel = new IiopChannel(setting);
                    ChannelServices.RegisterChannel(_channel, false);
                }
            }
        }

        public static void Destroy()
        {
            lock (_channelLock)
            {
                ChannelServices.UnregisterChannel(_channel);
                _channel = null;
            }
        }

        public static string GetIor(object obj)
        {
            OrbServices orb = OrbServices.GetSingleton();

            return orb.object_to_string(obj);
        }

        public static TObject ToObject<TObject>(string ior)
        {
            OrbServices orb = OrbServices.GetSingleton();

            return (TObject)orb.string_to_object(ior);
        }

        public static string GetRepositoryId(Type type)
        {
            return type.GetCustomAttributes(typeof(RepositoryIDAttribute), true)
                .Cast<RepositoryIDAttribute>().First().Id;
        }

        public static string GetRepositoryId<TType>()
        {
            return typeof (TType).GetCustomAttributes(typeof (RepositoryIDAttribute), true)
                .Cast<RepositoryIDAttribute>().First().Id;
        }
    }
}

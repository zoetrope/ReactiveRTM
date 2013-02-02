using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using Ch.Elca.Iiop;
using Ch.Elca.Iiop.Idl;
using omg.org.CORBA;
using ReactiveRTM.Core;

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

        public static void Initialize(CorbaSetting setting)
        {
            var corbaSetting = new Dictionary<string, string>()
                {
                    {"name",setting.CommonSetting.Name},
                    {"priority",setting.CommonSetting.Priority.ToString()},
                    {"endian",setting.CommonSetting.Endian.ToString()},

                    {"clientReceiveTimeOut",setting.ClientSetting.ClientReceiveTimeOut.ToString()},
                    {"clientSendTimeOut",setting.ClientSetting.ClientSendTimeOut.ToString()},
                    {"clientRequestTimeOut",setting.ClientSetting.ClientRequestTimeOut.ToString()},
                    {"unusedConnectionKeepAlive",setting.ClientSetting.UnusedConnectionKeepAlive.ToString()},
                    {"clientConnectionLimit",setting.ClientSetting.ClientConnectionLimit.ToString()},
                    {"allowRequestMultiplex",setting.ClientSetting.AllowRequestMultiplex.ToString()},
                    {"maxNumberOfMultiplexedRequests",setting.ClientSetting.MaxNumberOfMultiplexedRequests.ToString()},
                    {"maxNumberOfRetries",setting.ClientSetting.MaxNumberOfRetries.ToString()},
                    {"retryDelay",setting.ClientSetting.RetryDelay.ToString()},

                    {"port",setting.ServerSetting.Port.ToString()},
                    {"machineName",setting.ServerSetting.MachineName},
                    {"bindTo",setting.ServerSetting.BindTo},
                    {"useIpAddress",setting.ServerSetting.UseIpAddress.ToString()},
                    {"serverThreadsMaxPerConnection",setting.ServerSetting.ServerThreadsMaxPerConnection.ToString()}
                };

            lock (_channelLock)
            {
                if (_channel == null)
                {
                    _channel = new IiopChannel(corbaSetting);
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

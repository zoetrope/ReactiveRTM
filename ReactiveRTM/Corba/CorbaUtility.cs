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

        public static void Initialize(CorbaSetting setting)
        {
            var corbaSetting = new Dictionary<string, string>();

            if (setting.Common != null)
            {
                corbaSetting.SetOption("name", setting.Common.Name);
                corbaSetting.SetOption("priority", setting.Common.Priority);
                corbaSetting.SetOption("endian", setting.Common.Endian);
            }

            if (setting.Client != null)
            {
                corbaSetting.SetOption("clientReceiveTimeOut", setting.Client.ClientReceiveTimeOut);
                corbaSetting.SetOption("clientSendTimeOut", setting.Client.ClientSendTimeOut);
                corbaSetting.SetOption("clientRequestTimeOut", setting.Client.ClientRequestTimeOut);
                corbaSetting.SetOption("unusedConnectionKeepAlive", setting.Client.UnusedConnectionKeepAlive);
                corbaSetting.SetOption("clientConnectionLimit", setting.Client.ClientConnectionLimit);
                corbaSetting.SetOption("allowRequestMultiplex", setting.Client.AllowRequestMultiplex);
                corbaSetting.SetOption("maxNumberOfMultiplexedRequests", setting.Client.MaxNumberOfMultiplexedRequests);
                corbaSetting.SetOption("maxNumberOfRetries", setting.Client.MaxNumberOfRetries);
                corbaSetting.SetOption("retryDelay", setting.Client.RetryDelay);
            }

            if (setting.Server != null)
            {
                corbaSetting.SetOption("port", setting.Server.Port);
                corbaSetting.SetOption("machineName", setting.Server.MachineName);
                corbaSetting.SetOption("bindTo", setting.Server.BindTo);
                corbaSetting.SetOption("useIpAddress", setting.Server.UseIpAddress);
                corbaSetting.SetOption("serverThreadsMaxPerConnection", setting.Server.ServerThreadsMaxPerConnection);
            }

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
                // UnregisterChannel to hang in .NET 4.5
                // http://sourceforge.net/projects/iiop-net/forums/forum/274081/topic/6672349
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

    static class CorbaSettingExtensions
    {
        public static void SetOption<T>(this Dictionary<string, string> corbaSetting, string name, T param)
        {
            if (param == null) return;
            if (param is string && string.IsNullOrEmpty(param as string)) return;
            corbaSetting[name] = param.ToString();
        }
    }
}

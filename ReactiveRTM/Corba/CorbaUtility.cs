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

            if (setting != null)
            {
                if (setting.CommonSetting != null)
                {
                    corbaSetting.SetOption("name", setting.CommonSetting.Name);
                    corbaSetting.SetOption("priority", setting.CommonSetting.Priority);
                    corbaSetting.SetOption("endian", setting.CommonSetting.Endian);
                }

                if (setting.ClientSetting != null)
                {
                    corbaSetting.SetOption("clientReceiveTimeOut", setting.ClientSetting.ClientReceiveTimeOut);
                    corbaSetting.SetOption("clientSendTimeOut", setting.ClientSetting.ClientSendTimeOut);
                    corbaSetting.SetOption("clientRequestTimeOut", setting.ClientSetting.ClientRequestTimeOut);
                    corbaSetting.SetOption("unusedConnectionKeepAlive", setting.ClientSetting.UnusedConnectionKeepAlive);
                    corbaSetting.SetOption("clientConnectionLimit", setting.ClientSetting.ClientConnectionLimit);
                    corbaSetting.SetOption("allowRequestMultiplex", setting.ClientSetting.AllowRequestMultiplex);
                    corbaSetting.SetOption("maxNumberOfMultiplexedRequests", setting.ClientSetting.MaxNumberOfMultiplexedRequests);
                    corbaSetting.SetOption("maxNumberOfRetries", setting.ClientSetting.MaxNumberOfRetries);
                    corbaSetting.SetOption("retryDelay", setting.ClientSetting.RetryDelay);
                }

                if (setting.ServerSetting != null)
                {
                    corbaSetting.SetOption("port", setting.ServerSetting.Port);
                    corbaSetting.SetOption("machineName", setting.ServerSetting.MachineName);
                    corbaSetting.SetOption("bindTo", setting.ServerSetting.BindTo);
                    corbaSetting.SetOption("useIpAddress", setting.ServerSetting.UseIpAddress);
                    corbaSetting.SetOption("serverThreadsMaxPerConnection", setting.ServerSetting.ServerThreadsMaxPerConnection);
                }
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

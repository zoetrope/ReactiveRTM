using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveRTM.Core
{
    public class RtcSetting
    {
        public CorbaSetting CorbaSetting { get; set; }
    }


    public class CorbaSetting
    {
        public CorbaCommonSetting CommonSetting { get; set; }
        public CorbaClientSetting ClientSetting { get; set; }
        public CorbaServerSetting ServerSetting { get; set; }
    }
    public class CorbaCommonSetting
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public bool Endian { get; set; }
    }
    public class CorbaClientSetting
    {
        public int ClientReceiveTimeOut { get; set; }
        public int ClientSendTimeOut { get; set; }
        public int ClientRequestTimeOut { get; set; }
        public int UnusedConnectionKeepAlive { get; set; }
        public int ClientConnectionLimit { get; set; }
        public bool AllowRequestMultiplex { get; set; }
        public int MaxNumberOfMultiplexedRequests { get; set; }
        public int MaxNumberOfRetries { get; set; }
        public int RetryDelay { get; set; }
    }
    public class CorbaServerSetting
    {
        public int Port { get; set; }
        public string MachineName { get; set; }
        public string BindTo { get; set; }
        public bool UseIpAddress { get; set; }
        public int ServerThreadsMaxPerConnection { get; set; }
    }
}

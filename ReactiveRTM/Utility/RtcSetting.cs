using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveRTM.Core
{
#if LANG_JP
    /// <summary>
    /// 設定
    /// </summary>
#else
    /// <summary>
    /// Configuration
    /// </summary>    
#endif
    public class RtcSetting
    {
        public NamingSetting Naming { get; set; }
        public List<CatalogSetting> Catalogs { get; set; }
        public LoggerSetting Logger { get; set; }
        public ManagerSetting Manager { get; set; }
        public TimerSetting Timer { get; set; }
        public ExecutionContextSetting ExecutionContext { get; set; }
        public SdoServiceSetting SdoService { get; set; }
        public CorbaSetting Corba { get; set; }

        public RtcSetting()
        {
            Naming = new NamingSetting();
            Catalogs = new List<CatalogSetting>();
            Logger = new LoggerSetting();
            Manager = new ManagerSetting();
            Timer = new TimerSetting();
            ExecutionContext = new ExecutionContextSetting();
            SdoService = new SdoServiceSetting();
            Corba = new CorbaSetting();
        }
    }

#if LANG_JP
    /// <summary>
    /// ネーミングサービスに関する設定
    /// </summary>
#else
    /// <summary>
    /// Configuration About Naming Services
    /// </summary>    
#endif
    public class NamingSetting
    {
        public bool Enable { get; set; }
        public string Formats { get; set; }
        public List<string> NamingServers { get; set; }
        public string Type { get; set; }
        public NamingUpdateSetting Update { get; set; }

        public NamingSetting()
        {
            Enable = true;
            Formats = "%h.host/%n.rtc";
            NamingServers = new List<string>() { "localhost:2809" };
            Type = "Corba";
            Update = new NamingUpdateSetting();
        }
    }

#if LANG_JP
    /// <summary>
    /// ネーミングサービスの更新に関する設定
    /// </summary>
#else
    /// <summary>
    /// Configuration About Update for Naming Service
    /// </summary>    
#endif
    public class NamingUpdateSetting
    {
        public bool Enable { get; set; }
        public int Interval { get; set; }
        public bool Rebind { get; set; }

        public NamingUpdateSetting()
        {
            Enable = false;
            Interval = 10;
            Rebind = true;
        }
    }

#if LANG_JP
    /// <summary>
    /// ロードモジュール関する設定
    /// </summary>
#else
    /// <summary>
    /// Configuration About Load Modules
    /// </summary>    
#endif
    public class CatalogSetting
    {
        public string Catalog { get; set; }
        public List<string> Args { get; set; }
    }

#if LANG_JP
    /// <summary>
    /// ロギングに関する設定
    /// </summary>
#else
    /// <summary>
    /// Configuration About Logging
    /// </summary> 
#endif
    public class LoggerSetting
    {
        public bool Enable { get; set; }
        public string Level { get; set; }
        public bool? ShowLogName { get; set; }
        public bool? ShowDataTime { get; set; }
        public string DateTimeFormat { get; set; }
        public string Adapter { get; set; }

        public LoggerSetting()
        {
            Enable = true;
            Level = "DEBUG";
            Adapter = "RtcLogger";
        }
    }

#if LANG_JP
    /// <summary>
    /// Managerに関する設定
    /// </summary>
#else
    /// <summary>
    /// Configuration About Manager
    /// </summary> 
#endif
    public class ManagerSetting
    {
        public string Name { get; set; }
        public string NamingFormats { get; set; }
        public bool IsMaster { get; set; }
        public string CorbaServant { get; set; }
        public string MasterManager { get; set; }
        public bool ShutdownOnNortcs { get; set; }
        public bool ShutdownAuto { get; set; }
        public double AutoShutdownDuration { get; set; }
        public List<PrecreateComponent> PrecreateComponents { get; set; }

        public ManagerSetting()
        {
            Name = "Manager";
            NamingFormats = "%M.manager";
            IsMaster = false;

            ShutdownOnNortcs = false;
            ShutdownAuto = false;
            AutoShutdownDuration = 10.0;

            PrecreateComponents = new List<PrecreateComponent>();
        }
    }

    public class PrecreateComponent
    {
        public string TypeName { get; set; }
        public string InstanceName { get; set; }
    }

#if LANG_JP
    /// <summary>
    /// タイマーに関する設定
    /// </summary>
#else
    /// <summary>
    /// Configuration About Timer
    /// </summary> 
#endif
    public class TimerSetting
    {
        public bool Enable { get; set; }
        public double Tick { get; set; }

        public TimerSetting()
        {
            Enable = false;
            Tick = 10;
        }
    }

#if LANG_JP
    /// <summary>
    /// 実行コンテキストに関する設定
    /// </summary>
#else
    /// <summary>
    /// Configuration About ExecutionContext
    /// </summary> 
#endif
    public class ExecutionContextSetting
    {
        public string Type { get; set; }
        public int? Rate { get; set; }
    }

    public class SdoServiceSetting
    {
        public ProviderSetting Provider { get; set; }
        public ConsumerSetting Consumer { get; set; }

        public SdoServiceSetting()
        {
            Provider = new ProviderSetting();
            Consumer = new ConsumerSetting();
        }
    }
    public class ProviderSetting
    {
        public List<string> AvailableServices { get; set; }
        public List<string> EnabledServices { get; set; }
        public List<string> ProvidingServices { get; set; }

        public ProviderSetting()
        {
            AvailableServices = new List<string>();
            EnabledServices = new List<string>();
            ProvidingServices = new List<string>();
        }
    }
    public class ConsumerSetting
    {
        public List<string> AvailableServices { get; set; }
        public List<string> EnabledServices { get; set; }

        public ConsumerSetting()
        {
            AvailableServices = new List<string>();
            EnabledServices = new List<string>();
        }
    }



#if LANG_JP
    /// <summary>
    /// IIOP.NETに関する設定
    /// </summary>
#else
    /// <summary>
    /// Configuration About IIOP.NET
    /// </summary> 
#endif
    public class CorbaSetting
    {
        public CorbaCommonSetting Common { get; set; }
        public CorbaClientSetting Client { get; set; }
        public CorbaServerSetting Server { get; set; }

        public CorbaSetting()
        {
            Common = new CorbaCommonSetting();
            Client = new CorbaClientSetting();
            Server = new CorbaServerSetting();
        }
    }

#if LANG_JP
    /// <summary>
    /// IIOP.NETに関する設定(共通)
    /// </summary>
#else
    /// <summary>
    /// Configuration About IIOP.NET(Common)
    /// </summary> 
#endif
    public class CorbaCommonSetting
    {
        public string Name { get; set; }
        public int? Priority { get; set; }
        public string Endian { get; set; }
    }

#if LANG_JP
    /// <summary>
    /// IIOP.NETに関する設定(クライアント)
    /// </summary>
#else
    /// <summary>
    /// Configuration About IIOP.NET(Client)
    /// </summary> 
#endif
    public class CorbaClientSetting
    {
        public int? ClientReceiveTimeOut { get; set; }
        public int? ClientSendTimeOut { get; set; }
        public int? ClientRequestTimeOut { get; set; }
        public int? UnusedConnectionKeepAlive { get; set; }
        public int? ClientConnectionLimit { get; set; }
        public bool? AllowRequestMultiplex { get; set; }
        public int? MaxNumberOfMultiplexedRequests { get; set; }
        public int? MaxNumberOfRetries { get; set; }
        public int? RetryDelay { get; set; }
    }
#if LANG_JP
    /// <summary>
    /// IIOP.NETに関する設定(サーバ)
    /// </summary>
#else
    /// <summary>
    /// Configuration About IIOP.NET(Server)
    /// </summary> 
#endif
    public class CorbaServerSetting
    {
        public int? Port { get; set; }
        public string MachineName { get; set; }
        public string BindTo { get; set; }
        public bool? UseIpAddress { get; set; }
        public int? ServerThreadsMaxPerConnection { get; set; }
    }
}

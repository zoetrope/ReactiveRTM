using System;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using ReactiveRTM.Corba;
using omg.org.RTC;
using DataFlowComponent = openrtm.aist.go.jp.OpenRTM.DataFlowComponent;

namespace ReactiveRTM.Core
{

    public class StateChangedEventArgs
    {
        public int ExecutionContextHandle { get; set; }
        public LifeCycleState State { get; set; }
    }

    public enum ECEventType
    {
        Attached,
        Detached,
        RateChanged,
        Startup,
        Shutdown
    }

    public class ECStatusChangedEventArgs
    {
        public int ContextId { get; set; }
        public ECEventType EventType { get; set; }
    }

    public enum PortEventType
    {
        Add,
        Remove,
        Connect,
        Disconnect
    }

    public class PortStatusChangedEventArgs
    {
        public string PortName { get; set; }
        public PortEventType EventType { get; set; }
    }

    public enum ConfigurationEventType
    {
        UpdateConfigset,
        UpdateParameter,
        SetConfigSet,
        AddConfigSet,
        RemoveConfigSet,
        ActivateConfigSet
    }

    public class ConfigurationEventArgs
    {
        public ConfigurationEventType EventType { get; set; }
        public string ConfigurationSetName { get; set; }
        public string ConfigurationParamName { get; set; }
    }

    public interface IObservableComponent
    {
        IObservable<ComponentProfile> ComponentProfileChangedAsObservable();
        IObservable<StateChangedEventArgs> StateChangedAsObservable();
        IObservable<ECStatusChangedEventArgs> ECStatusChangedAsObservable();
        IObservable<PortStatusChangedEventArgs> PortStatusChangedAsObservable();
        IObservable<ConfigurationEventArgs> ConfigurationStatusChangedAsObservable();
        IObservable<Unit> HeartBeatReceivedAsObservable();

        DataFlowComponent Component { get; }
        IScheduler ExecutionContextScheduler { get; }
    }
}

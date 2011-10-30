using System;
using System.Reactive.Linq;
using ReactiveRTM.Corba;
using omg.org.RTC;
using DataFlowComponent = openrtm.aist.go.jp.OpenRTM.DataFlowComponent;

namespace ReactiveRTM.Core
{

    public class ComponentProfileChangedEventArgs : EventArgs
    {
        public ComponentProfile Profile { get; set; }
    }

    public class StateChangedEventArgs : EventArgs
    {
        public LifeCycleState State { get; set; }
        public int ExecutionContextHandle { get; set; }
    }

    public enum ECEventType
    {
        ATTACHED,
        DETACHED,
        RATE_CHANGED,
        STARTUP,
        SHUTDOWN
    }

    public class ECStatusChangedEventArgs : EventArgs
    {
        public int ContextID { get; set; }
        public ECEventType EventType { get; set; }
    }

    public enum PortEventType
    {
        ADD,
        REMOVE,
        CONNECT,
        DISCONNECT
    }

    public class PortStatusChangedEventArgs : EventArgs
    {
        public string PortName { get; set; }
        public PortEventType EventType { get; set; }
    }

    public enum ConfigurationEventType
    {
        UPDATE_CONFIGSET,
        UPDATE_PARAMETER,
        SET_CONFIG_SET,
        ADD_CONFIG_SET,
        REMOVE_CONFIG_SET,
        ACTIVATE_CONFIG_SET
    }

    public class ConfigurationEventArgs : EventArgs
    {
        public ConfigurationEventType EventType { get; set; }
        public string ConfigurationSetName { get; set; }
        public string ConfigurationParamName { get; set; }
    }

    public interface IObservableComponent
    {
        event EventHandler<ComponentProfileChangedEventArgs> ComponentProfileChanged;
        event EventHandler<StateChangedEventArgs> StateChanged;
        event EventHandler<ECStatusChangedEventArgs> ECStatusChanged;
        event EventHandler<PortStatusChangedEventArgs> PortStatusChanged;
        event EventHandler<ConfigurationEventArgs> ConfigurationStatusChanged;
        event EventHandler HeartBeatReceived;
        DataFlowComponent Component { get; }

    }


    public static class ObservableComponentExtension
    {
        public static IObservable<ComponentProfile> ComponentProfileChangedAsObservable(this IObservableComponent target)
        {
            return Observable.FromEvent<EventHandler<ComponentProfileChangedEventArgs>, ComponentProfileChangedEventArgs>(
                    h => (sender, e) => h(e),
                    h => target.ComponentProfileChanged += h,
                    h => target.ComponentProfileChanged -= h)
                .Select(e => e.Profile);
        }
        public static IObservable<LifeCycleState> StateChangedAsObservable(this IObservableComponent target)
        {
            return Observable.FromEvent<EventHandler<StateChangedEventArgs>, StateChangedEventArgs>(
                    h => (sender, e) => h(e),
                    h => target.StateChanged += h,
                    h => target.StateChanged -= h)
                .Select(e => e.State);
        }
        public static IObservable<ECStatusChangedEventArgs> ECStatusChangedAsObservable(this IObservableComponent target)
        {
            return Observable.FromEvent<EventHandler<ECStatusChangedEventArgs>, ECStatusChangedEventArgs>(
                    h => (sender, e) => h(e),
                    h => target.ECStatusChanged += h,
                    h => target.ECStatusChanged -= h);
        }
        public static IObservable<PortStatusChangedEventArgs> PortStatusChangedAsObservable(this IObservableComponent target)
        {
            return Observable.FromEvent<EventHandler<PortStatusChangedEventArgs>, PortStatusChangedEventArgs>(
                    h => (sender, e) => h(e),
                    h => target.PortStatusChanged += h,
                    h => target.PortStatusChanged -= h);
        }
        public static IObservable<ConfigurationEventArgs> ConfigurationStatusChangedAsObservable(this IObservableComponent target)
        {
            return Observable.FromEvent<EventHandler<ConfigurationEventArgs>, ConfigurationEventArgs>(
                    h => (sender, e) => h(e),
                    h => target.ConfigurationStatusChanged += h,
                    h => target.ConfigurationStatusChanged -= h);
        }
//        public static IObservable<EventHandler> HeartBeatReceivedAsObservable(this IObservableComponent target)
//        {
//            return Observable.FromEvent<EventHandler>(
//                    h => target.HeartBeatReceived += h,
//                    h => target.HeartBeatReceived -= h);
//        }

    }
}

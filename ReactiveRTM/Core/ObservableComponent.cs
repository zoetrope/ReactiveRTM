using System;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using OpenRTM;
using ReactiveRTM.Adapter;
using ReactiveRTM.Corba;
using ReactiveRTM.Extensions;
using omg.org.RTC;
using org.omg.SDOPackage;
using DataFlowComponent = openrtm.aist.go.jp.OpenRTM.DataFlowComponent;

namespace ReactiveRTM.Core
{

    public class ObservableComponent : IObservableComponent
    {
        public event EventHandler<ComponentProfileChangedEventArgs> ComponentProfileChanged;
        public event EventHandler<StateChangedEventArgs> StateChanged;
        public event EventHandler<ECStatusChangedEventArgs> ECStatusChanged;
        public event EventHandler<PortStatusChangedEventArgs> PortStatusChanged;
        public event EventHandler<ConfigurationEventArgs> ConfigurationStatusChanged;
        public event EventHandler HeartBeatReceived;
        

        private ServiceProfile _profile;

        public ObservableComponent(DataFlowComponent comp)
        {
            _component = comp;
 
            var observer = new ComponentObserverAdapter();

            var conf = Component.get_configuration();

            _profile = new ServiceProfile();
            _profile.id = Guid.NewGuid().ToString();
            _profile.interface_type = "IDL:OpenRTM/ComponentObserver:1.0";
            _profile.properties = new NameValue[0];

            NameValueExtensions.AddStringValue(ref _profile.properties, "observed_status", "ALL");
            NameValueExtensions.AddStringValue(ref _profile.properties, "heartbeat.enable", "YES");
            NameValueExtensions.AddStringValue(ref _profile.properties, "heartbeat.interval", "1");
            
            _profile.service = observer;

            if (conf.add_service_profile(_profile))
            {
                observer.Subscribe(Notify);
            }

        }

        private DataFlowComponent _component;
        public DataFlowComponent Component
        {
            get { return _component; }
        }

        public IScheduler ExecutionContextScheduler
        {
            get;
            set;
        }

        internal void Notify(UpdateStatus status)
        {
            switch (status.StatusKind)
            {
                case StatusKind.COMPONENT_PROFILE:
                    NotifyComponentProfileChanged(status.Hint);
                    break;
                case StatusKind.CONFIGURATION:
                    NotifyConfigurationStatusChanged(status.Hint);
                    break;
                case StatusKind.EC_STATUS:
                    NotifyECStatusChanged(status.Hint);
                    break;
                case StatusKind.HEARTBEAT:
                    NotifyHeartBeatReceived();
                    break;
                case StatusKind.PORT_PROFILE:
                    NotifyPortStatusChanged(status.Hint);
                    break;
                case StatusKind.RTC_STATUS:
                    NotifyStateChanged(status.Hint);
                    break;
            }
        }

        private void NotifyComponentProfileChanged(string hint)
        {
            var handler = ComponentProfileChanged;

            if (handler == null) return; ;

            Component.get_component_profileAsync(CorbaUtility.DefaultTimeout, ExecutionContextScheduler)
                .Subscribe(x => handler(this, new ComponentProfileChangedEventArgs() { Profile = x }));

        }

        private void NotifyConfigurationStatusChanged(string hint)
        {
            var handler = ConfigurationStatusChanged;

            if (handler == null) return; ;

            Component.get_component_profileAsync(CorbaUtility.DefaultTimeout, ExecutionContextScheduler)
                .Subscribe(x => handler(this, new ConfigurationEventArgs()));

        }

        private void NotifyECStatusChanged(string hint)
        {
            var handler = ECStatusChanged;

            if (handler == null) return; ;

            Component.get_component_profileAsync(CorbaUtility.DefaultTimeout, ExecutionContextScheduler)
                .Subscribe(x => handler(this, new ECStatusChangedEventArgs()));

        }

        private void NotifyHeartBeatReceived()
        {
            var handler = HeartBeatReceived;

            if (handler == null) return; ;

            Component.get_component_profileAsync(CorbaUtility.DefaultTimeout, ExecutionContextScheduler)
                .Subscribe(x => handler(this, new HandledEventArgs()));

        }

        private void NotifyPortStatusChanged(string hint)
        {
            var handler = PortStatusChanged;

            if (handler == null) return; ;

            Component.get_component_profileAsync(CorbaUtility.DefaultTimeout, ExecutionContextScheduler)
                .Subscribe(x => handler(this, new PortStatusChangedEventArgs()));

        }

        private void NotifyStateChanged(string hint)
        {
            var handler = StateChanged;

            if (handler == null) return;

            LifeCycleState state;

            var items = hint.Split(':');
            if (items.Length != 2) return;

            switch (items[0])
            {
                case "ACTIVE":
                    state = LifeCycleState.ACTIVE_STATE;
                    break;
                case "INACTIVE":
                    state = LifeCycleState.INACTIVE_STATE;
                    break;
                case "ERROR":
                    state = LifeCycleState.ERROR_STATE;
                    break;
                default:
                    return;
            }
            int execHandle;
            if (!int.TryParse(items[1], out execHandle))
            {
                return;
            }

            Observable.Start(() => handler(this, new StateChangedEventArgs()
            {
                State = state,
                ExecutionContextHandle = execHandle
            }));

            /*
            Component.get_owned_contextsAsync()
                .Select(_ => _.First())
                .Select(x => x.get_component_stateAsync(Component))
                .SelectMany(_ => _)
                .Subscribe(x => handler(this, new StateChangedEventArgs() { State = x }));
             */

        }
    }


}

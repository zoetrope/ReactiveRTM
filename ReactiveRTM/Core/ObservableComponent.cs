using System;
using System.ComponentModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Reactive.Threading.Tasks;
using ReactiveRTM.Adapter;
using ReactiveRTM.Corba;
using ReactiveRTM.Extensions;
using ReactiveRTM.SDOPackage;
using ReactiveRTM.OpenRTM;
using ReactiveRTM.RTC;
using System.Collections.Generic;

using DataFlowComponent = ReactiveRTM.OpenRTM.DataFlowComponent;

namespace ReactiveRTM.Core
{

    public class ObservableComponent : IObservableComponent
    {

        private ServiceProfile _profile;

        public ObservableComponent(DataFlowComponent comp)
        {
            _component = comp;

            var observer = new ComponentObserverImpl();

            var conf = _component.GetConfiguration();

            _profile = new ServiceProfile();
            _profile.Id = Guid.NewGuid().ToString();
            _profile.InterfaceType = "IDL:OpenRTM/ComponentObserver:1.0";
            _profile.Properties = new Dictionary<string, object>();

            _profile.Properties["observed_status"] = "ALL";
            _profile.Properties["heartbeat.enable"] = "YES";
            _profile.Properties["heartbeat.interval"] = "1";

            _profile.Service = observer;

            if (conf.AddServiceProfile(_profile))
            {
                observer.Subscribe(Notify);
            }

            ExecutionContextScheduler = new EventLoopScheduler();

        }

        private DataFlowComponent _component;

        public DataFlowComponent Component
        {
            get { return _component; }
        }

        public IScheduler ExecutionContextScheduler { get; set; }

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
            Component.GetComponentProfileAsync()
                .ToObservable() //TODO:
                .SubscribeOn(ExecutionContextScheduler)
                .Subscribe(x => _componentProfileSubject.OnNext(x));

        }

        private void NotifyConfigurationStatusChanged(string hint)
        {
            Component.GetComponentProfileAsync()
                .ToObservable() //TODO:
                .SubscribeOn(ExecutionContextScheduler)
                .Subscribe(x => _configurationStatusSubject.OnNext(new ConfigurationEventArgs()));

        }

        private void NotifyECStatusChanged(string hint)
        {
            Component.GetComponentProfileAsync()
                .ToObservable() //TODO:
                .SubscribeOn(ExecutionContextScheduler)
                .Subscribe(x => _ecStatusSubject.OnNext(new ECStatusChangedEventArgs()));

        }

        private void NotifyHeartBeatReceived()
        {
            Component.GetComponentProfileAsync()
                .ToObservable() //TODO:
                .SubscribeOn(ExecutionContextScheduler)
                .Subscribe(x => _heartBeatSubject.OnNext(Unit.Default));

        }

        private void NotifyPortStatusChanged(string hint)
        {
            Component.GetComponentProfileAsync()
                .ToObservable() //TODO:
                .SubscribeOn(ExecutionContextScheduler)
                .Subscribe(x => _portStatusSubject.OnNext(new PortStatusChangedEventArgs()));

        }

        private void NotifyStateChanged(string hint)
        {
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

            Observable.Start(() => _stateSubject.OnNext(new StateChangedEventArgs()
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

        private Subject<ComponentProfile> _componentProfileSubject = new Subject<ComponentProfile>();

        public IObservable<ComponentProfile> ComponentProfileChangedAsObservable()
        {
            return _componentProfileSubject;
        }

        private Subject<StateChangedEventArgs> _stateSubject = new Subject<StateChangedEventArgs>();

        public IObservable<StateChangedEventArgs> StateChangedAsObservable()
        {
            return _stateSubject;
        }

        private Subject<ECStatusChangedEventArgs> _ecStatusSubject = new Subject<ECStatusChangedEventArgs>();

        public IObservable<ECStatusChangedEventArgs> ECStatusChangedAsObservable()
        {
            return _ecStatusSubject;
        }

        private Subject<PortStatusChangedEventArgs> _portStatusSubject = new Subject<PortStatusChangedEventArgs>();

        public IObservable<PortStatusChangedEventArgs> PortStatusChangedAsObservable()
        {
            return _portStatusSubject;
        }

        private Subject<ConfigurationEventArgs> _configurationStatusSubject = new Subject<ConfigurationEventArgs>();

        public IObservable<ConfigurationEventArgs> ConfigurationStatusChangedAsObservable()
        {
            return _configurationStatusSubject;
        }

        private Subject<Unit> _heartBeatSubject = new Subject<Unit>();

        public IObservable<Unit> HeartBeatReceivedAsObservable()
        {
            return _heartBeatSubject;
        }


    }
}

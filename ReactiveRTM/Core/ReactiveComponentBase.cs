using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using ReactiveRTM.Adapter;
using ReactiveRTM.Corba;
using ReactiveRTM.RTC;

using DataFlowComponent = ReactiveRTM.OpenRTM.DataFlowComponent;
using ReactiveRTM.Servant;

namespace ReactiveRTM.Core
{
    public abstract class ReactiveComponentBase : IObservableComponent, IComponentActionListener
    {
        protected ReactiveComponentBase(string instantName, string category = "", string typeName = "", string description = "", string vendor = "", string version = "")
        {
            Name = instantName;

            _component = new DataFlowComponentServant(this, instantName, category, typeName, description, vendor, version);

            Component.Initialize();

        }

        public string Name { get; set; }

        public IScheduler ExecutionContextScheduler {
            get { return _component.ExecutionContextScheduler; }
            set { _component.ExecutionContextScheduler = value;}
        }

        private DataFlowComponentServant _component;


        internal void RaiseStateChanged(LifeCycleState state)
        {
            var args = new StateChangedEventArgs() {State = state};
            _stateSubject.OnNext(args);
        }

        public class ReturnCodeException : Exception
        {
            public ReturnCodeException(ReturnCode_t ret, string message = "")
                :base(message)
            {
                ReturnCode = ret;
            }

            public ReturnCode_t ReturnCode { get; set; }
        }


        public DataFlowComponent Component
        {
            get { return _component; }
        }

        public void AddPort(ReactivePortBase reactivePort)
        {
            _component.AddPort(reactivePort);
        }

        #region Implementation of IComponentActionListener

        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual ReturnCode_t RaiseOnInitialize()
        {
            RaiseStateChanged(LifeCycleState.INACTIVE_STATE);
            return ReturnCode_t.RTC_OK;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract ReturnCode_t RaiseOnFinalize();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract ReturnCode_t RaiseOnStartup(int execHandle);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract ReturnCode_t RaiseOnShutdown(int execHandle);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual ReturnCode_t RaiseOnActivated(int execHandle)
        {
            RaiseStateChanged(LifeCycleState.ACTIVE_STATE);
            return ReturnCode_t.RTC_OK;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual ReturnCode_t RaiseOnDeactivated(int execHandle)
        {
            RaiseStateChanged(LifeCycleState.INACTIVE_STATE);
            return ReturnCode_t.RTC_OK;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual ReturnCode_t RaiseOnAborting(int execHandle)
        {
            RaiseStateChanged(LifeCycleState.ERROR_STATE);
            return ReturnCode_t.RTC_OK;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract ReturnCode_t RaiseOnError(int execHandle);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual ReturnCode_t RaiseOnReset(int execHandle)
        {
            RaiseStateChanged(LifeCycleState.INACTIVE_STATE);
            return ReturnCode_t.RTC_OK;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract ReturnCode_t RaiseOnExecute(int execHandle);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract ReturnCode_t RaiseOnStateUpdate(int execHandle);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract ReturnCode_t RaiseOnRateChanged(int execHandle);

        #endregion

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

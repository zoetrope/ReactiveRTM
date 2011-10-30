using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Text;
using ReactiveRTM.Adapter;
using ReactiveRTM.Corba;
using omg.org.RTC;
using DataFlowComponent = openrtm.aist.go.jp.OpenRTM.DataFlowComponent;

namespace ReactiveRTM.Core
{
    public abstract class ReactiveComponentBase : IObservableComponent, IComponentActionListener
    {
        protected ReactiveComponentBase(string name)
        {
            Name = name;

            ExecutionContextScheduler = new EventLoopScheduler();

            _component = new DataFlowComponentAdapter(this, ExecutionContextScheduler, name);

            Component.initialize();

        }

        public string Name { get; set; }

        public IScheduler ExecutionContextScheduler { get; set; }

        private DataFlowComponentAdapter _component;


        internal void RaiseStateChanged(LifeCycleState state)
        {
            var handler = StateChanged;
            if (handler != null)
            {
                var args = new StateChangedEventArgs() { State = state };
                handler(this, args);
            }

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



        public event EventHandler<ComponentProfileChangedEventArgs> ComponentProfileChanged;
        public event EventHandler<StateChangedEventArgs> StateChanged;
        public event EventHandler<ECStatusChangedEventArgs> ECStatusChanged;
        public event EventHandler<PortStatusChangedEventArgs> PortStatusChanged;
        public event EventHandler<ConfigurationEventArgs> ConfigurationStatusChanged;
        public event EventHandler HeartBeatReceived;

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
        public abstract ReturnCode_t RaiseOnStartup(int exec_handle);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract ReturnCode_t RaiseOnShutdown(int exec_handle);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual ReturnCode_t RaiseOnActivated(int exec_handle)
        {
            RaiseStateChanged(LifeCycleState.ACTIVE_STATE);
            return ReturnCode_t.RTC_OK;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual ReturnCode_t RaiseOnDeactivated(int exec_handle)
        {
            RaiseStateChanged(LifeCycleState.INACTIVE_STATE);
            return ReturnCode_t.RTC_OK;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual ReturnCode_t RaiseOnAborting(int exec_handle)
        {
            RaiseStateChanged(LifeCycleState.ERROR_STATE);
            return ReturnCode_t.RTC_OK;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract ReturnCode_t RaiseOnError(int exec_handle);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual ReturnCode_t RaiseOnReset(int exec_handle)
        {
            RaiseStateChanged(LifeCycleState.INACTIVE_STATE);
            return ReturnCode_t.RTC_OK;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract ReturnCode_t RaiseOnExecute(int exec_handle);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract ReturnCode_t RaiseOnStateUpdate(int exec_handle);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract ReturnCode_t RaiseOnRateChanged(int exec_handle);

        #endregion
    }
}

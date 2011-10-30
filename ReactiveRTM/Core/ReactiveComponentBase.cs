using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Concurrency;
using System.Text;
using ReactiveRTM.Adapter;
using omg.org.RTC;

namespace ReactiveRTM.Core
{
    public abstract class ReactiveComponentBase : IObservableComponent, IComponentActionListener
    {
        protected ReactiveComponentBase(string name)
        {
            Name = name;

            ExecutionContextScheduler = new EventLoopScheduler();

            Component = new DataFlowComponentAdapter(this,ExecutionContextScheduler, name);

            Component.initialize();

        }

        public string Name { get; set; }

        public IScheduler ExecutionContextScheduler { get; set; }

        internal DataFlowComponentAdapter Component { get; set; }

        internal void RaiseStateChanged(LifeCycleState state)
        {
            var handler = StateChanged;
            if (handler != null)
            {
                var args = new StateChangedEventArgs() { State = state };
                handler(this, args);
            }

        }

        public ReturnCode_t Activate()
        {
            return Component.get_context(0).activate_component(Component);
        }

        public ReturnCode_t Deactivate()
        {
            return Component.get_context(0).deactivate_component(Component);
        }

        public ReturnCode_t Reset()
        {
            throw new NotImplementedException();
        }

        public ReturnCode_t Exit()
        {
            throw new NotImplementedException();
        }

        public LifeCycleState State
        {
            get { throw new NotImplementedException(); }
        }

        public ComponentProfile Profile
        {
            get { throw new NotImplementedException(); }
        }


        public event EventHandler<ComponentProfileChangedEventArgs> ComponentProfileChanged;
        public event EventHandler<StateChangedEventArgs> StateChanged;
        public event EventHandler<ECStatusChangedEventArgs> ECStatusChanged;
        public event EventHandler<PortStatusChangedEventArgs> PortStatusChanged;
        public event EventHandler<ConfigurationEventArgs> ConfigurationStatusChanged;
        public event EventHandler HeartBeatReceived;

        public void AddPort(ReactivePortBase reactivePort)
        {
            Component.AddPort(reactivePort);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Text;
using ReactiveRTM.omg.org.RTC;

namespace ReactiveRTM.Adapter
{

    public class ExecutionContextServiceAdapter : IExecutionContextService
    {
        public override object InitializeLifetimeService()
        {
            return null;
        }

        private IDataFlowComponent _component;
        private IDisposable _executor;
        private TimeSpan _timeSpan;
        private LifeCycleState _state;
        private bool _isRunning;
        private ExecutionContextProfile _profile;

        public ExecutionContextServiceAdapter()
        {
            _state = LifeCycleState.CREATED_STATE;
            _timeSpan = TimeSpan.FromSeconds(1);
            _isRunning = false;
            _state = LifeCycleState.INACTIVE_STATE;

            ExecutionContextScheduler = new EventLoopScheduler();

            _profile = new ExecutionContextProfile(ExecutionKind.PERIODIC, get_rate(), null, new RTObject[0], new NameValue[0]);
        }

        public bool is_running()
        {
            return _isRunning;
        }

        public ReturnCode_t start()
        {
            _isRunning = true;
            return ReturnCode_t.RTC_OK;
        }

        public ReturnCode_t _stop()
        {
            _isRunning = false;
            return ReturnCode_t.RTC_OK;
        }

        public double get_rate()
        {
            return 1.0 / _timeSpan.Seconds;
        }

        public ReturnCode_t set_rate(double rate)
        {
            _timeSpan = TimeSpan.FromMilliseconds(1000.0 / rate);
            return ReturnCode_t.RTC_OK;
        }

        public ReturnCode_t add_component(LightweightRTObject comp)
        {
            _component = (DataFlowComponent)comp;
            return ReturnCode_t.RTC_OK;
        }

        public ReturnCode_t remove_component(LightweightRTObject comp)
        {
            _component = null;
            return ReturnCode_t.RTC_OK;
        }

        public ReturnCode_t activate_component(LightweightRTObject comp)
        {
            Observable.Start(() =>
            {
                _state = LifeCycleState.ACTIVE_STATE;
                _component.on_activated(0);
            }, ExecutionContextScheduler)
            .Subscribe(_ =>
            {
                _executor = Observable
                    .Interval(_timeSpan,ExecutionContextScheduler)
                    .Subscribe(__ => _component.on_execute(0));
            });

            return ReturnCode_t.RTC_OK;
        }

        public ReturnCode_t deactivate_component(LightweightRTObject comp)
        {
            _executor.Dispose();

            _state = LifeCycleState.INACTIVE_STATE;

            _component.on_deactivated(0);

            return ReturnCode_t.RTC_OK;
        }

        public ReturnCode_t reset_component(LightweightRTObject comp)
        {
            throw new NotImplementedException();
        }

        public LifeCycleState get_component_state(LightweightRTObject comp)
        {
            return _state;
        }

        public ExecutionKind get_kind()
        {
            return ExecutionKind.PERIODIC;
        }

        public ExecutionContextProfile get_profile()
        {
            return _profile;
        }

        public IScheduler ExecutionContextScheduler { get; set; }
    }

}

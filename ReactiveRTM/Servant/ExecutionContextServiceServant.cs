using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Text;
using ReactiveRTM.RTC;

namespace ReactiveRTM.Servant
{

    public class ExecutionContextServiceServant : ExecutionContextService, IServant
    {
        private DataFlowComponent _component;
        private IDisposable _executor;
        private TimeSpan _timeSpan;
        private LifeCycleState _state;
        private bool _isRunning;
        private ExecutionContextProfile _profile;

        public ExecutionContextServiceServant()
        {
            _state = LifeCycleState.CREATED_STATE;
            _timeSpan = TimeSpan.FromSeconds(1);
            _isRunning = false;
            _state = LifeCycleState.INACTIVE_STATE;

            ExecutionContextScheduler = new EventLoopScheduler();

            _profile = new ExecutionContextProfile();
        }
        
        public IScheduler ExecutionContextScheduler { get; set; }

        public ExecutionContextProfile GetProfile()
        {
            return _profile;
        }

        public bool IsRunning()
        {
            return _isRunning;
        }

        public ReturnCode_t Start()
        {
            _isRunning = true;
            return ReturnCode_t.RTC_OK;
        }

        public ReturnCode_t Stop()
        {
            _isRunning = false;
            return ReturnCode_t.RTC_OK;
        }

        public double GetRate()
        {
            return 1.0 / _timeSpan.Seconds;
        }

        public ReturnCode_t SetRate(double rate)
        {
            _timeSpan = TimeSpan.FromMilliseconds(1000.0 / rate);
            return ReturnCode_t.RTC_OK;
        }

        public ReturnCode_t AddComponent(LightweightRTObject comp)
        {
            _component = (DataFlowComponent)comp;
            return ReturnCode_t.RTC_OK;
        }

        public ReturnCode_t RemoveComponent(LightweightRTObject comp)
        {
            _component = null;
            return ReturnCode_t.RTC_OK;
        }

        public ReturnCode_t ActivateComponent(LightweightRTObject comp)
        {
            Observable.Start(() =>
            {
                _state = LifeCycleState.ACTIVE_STATE;
                _component.OnActivated(0);
            }, ExecutionContextScheduler)
            .Subscribe(_ =>
            {
                _executor = Observable
                    .Interval(_timeSpan, ExecutionContextScheduler)
                    .Subscribe(__ => _component.OnExecute(0));
            });

            return ReturnCode_t.RTC_OK;
        }

        public ReturnCode_t DeactivateComponent(LightweightRTObject comp)
        {
            _executor.Dispose();

            _state = LifeCycleState.INACTIVE_STATE;

            _component.OnDeactivated(0);

            return ReturnCode_t.RTC_OK;
        }

        public ReturnCode_t ResetComponent(LightweightRTObject comp)
        {
            throw new NotImplementedException();
        }

        public LifeCycleState GetComponentState(LightweightRTObject comp)
        {
            return _state;
        }

        public ExecutionKind GetKind()
        {
            return ExecutionKind.PERIODIC;
        }
    }

}

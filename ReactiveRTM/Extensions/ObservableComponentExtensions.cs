using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using ReactiveRTM.Corba;
using ReactiveRTM.Core;
using omg.org.RTC;

namespace ReactiveRTM.Extensions
{

    public static class ObservableComponentExtensions
    {
        public static IObservable<ReturnCode_t> ActivateAsync(this IObservableComponent target, int execHandle = 0, TimeSpan? timeout = null)
        {
            if (timeout == null) timeout = CorbaUtility.DefaultTimeout;

            var asyncActivate = target.Component.get_owned_contextsAsync(timeout.Value)
                .Do(ecs => { if (ecs.Length <= execHandle) throw new ArgumentOutOfRangeException("execHandle"); })
                .Select(ecs => ecs[execHandle].activate_componentAsync(target.Component, timeout.Value))
                .Switch()
                .Do(ret => { if (ret != ReturnCode_t.RTC_OK) throw new ReactiveComponentBase.ReturnCodeException(ret); });


            return target.StateChangedAsObservable()
                .Where(state => state == LifeCycleState.ACTIVE_STATE)
                .Zip(asyncActivate, (state, ret) => ret)
                .Timeout(timeout.Value)
                .Catch((ReactiveComponentBase.ReturnCodeException ex) => Observable.Return(ex.ReturnCode));
        }

        public static IObservable<ReturnCode_t> DeactivateAsync(this IObservableComponent target, int execHandle = 0, TimeSpan? timeout = null)
        {
            if (timeout == null) timeout = CorbaUtility.DefaultTimeout;

            var asyncDeactivate = target.Component.get_owned_contextsAsync(timeout.Value)
                .Do(ecs => { if (ecs.Length <= execHandle) throw new ArgumentOutOfRangeException("execHandle"); })
                .Select(ecs => ecs[execHandle].deactivate_componentAsync(target.Component, timeout.Value))
                .Switch()
                .Do(ret => { if (ret != ReturnCode_t.RTC_OK) throw new ReactiveComponentBase.ReturnCodeException(ret); });


            return target.StateChangedAsObservable()
                .Where(state => state == LifeCycleState.INACTIVE_STATE)
                .Zip(asyncDeactivate, (state, ret) => ret)
                .Timeout(timeout.Value)
                .Catch((ReactiveComponentBase.ReturnCodeException ex) => Observable.Return(ex.ReturnCode));

        }

        public static IObservable<ReturnCode_t> ResetAsync(this IObservableComponent target, int execHandle = 0, TimeSpan? timeout = null)
        {
            if (timeout == null) timeout = CorbaUtility.DefaultTimeout;

            var asyncReset = target.Component.get_owned_contextsAsync(timeout.Value)
                .Do(ecs => { if (ecs.Length <= execHandle) throw new ArgumentOutOfRangeException("execHandle"); })
                .Select(ecs => ecs[execHandle].reset_componentAsync(target.Component, timeout.Value))
                .Switch()
                .Do(ret => { if (ret != ReturnCode_t.RTC_OK) throw new ReactiveComponentBase.ReturnCodeException(ret); });


            return target.StateChangedAsObservable()
                .Where(state => state == LifeCycleState.INACTIVE_STATE)
                .Zip(asyncReset, (state, ret) => ret)
                .Timeout(timeout.Value)
                .Catch((ReactiveComponentBase.ReturnCodeException ex) => Observable.Return(ex.ReturnCode));
        }

        public static IObservable<ReturnCode_t> ExitAsync(this IObservableComponent target, int execHandle = 0, TimeSpan? timeout = null)
        {
            throw new NotImplementedException();
        }

        public static IObservable<LifeCycleState> GetStateAsync(this IObservableComponent target, int execHandle = 0, TimeSpan? timeout = null)
        {
            if (timeout == null) timeout = CorbaUtility.DefaultTimeout;

            return target.Component.get_owned_contextsAsync(timeout.Value)
                .Do(ecs => { if (ecs.Length <= execHandle) throw new ArgumentOutOfRangeException("execHandle"); })
                .Select(ecs => ecs[execHandle].get_component_stateAsync(target.Component, timeout.Value))
                .Switch();
        }

        public static IObservable<ComponentProfile> GetComponentProfileAsync(this IObservableComponent target, TimeSpan? timeout = null)
        {
            if (timeout == null) timeout = CorbaUtility.DefaultTimeout;

            return target.Component.get_component_profileAsync(timeout.Value);
        }
    }

}

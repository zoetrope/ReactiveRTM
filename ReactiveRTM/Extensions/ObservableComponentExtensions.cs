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
        public static IObservable<ReturnCode_t> ActivateAsync(this IObservableComponent target, int execHandle = 0)
        {
            return target.Component.get_owned_contextsAsync()
                .SubscribeOn(target.ExecutionContextScheduler)
                .Select(ecs => ecs[execHandle].activate_componentAsync(target.Component)
                    .SubscribeOn(target.ExecutionContextScheduler))
                .Switch();
        }

        public static IObservable<LifeCycleState> Activate(this IObservableComponent target, int execHandle = 0, TimeSpan? timeout=null)
        {
            var obs = target.StateChangedAsObservable()
                .Take(1)
                .PublishLast();

            obs.Connect();

            return ActivateAsync(target)
                .Select(ret => obs)
                .Switch();
        }


        public static IObservable<ReturnCode_t> DeactivateAsync(this IObservableComponent target, int execHandle = 0, TimeSpan? timeout = null)
        {
            return target.Component.get_owned_contextsAsync()
                .SubscribeOn(target.ExecutionContextScheduler)
                .Select(ecs => ecs[execHandle].deactivate_componentAsync(target.Component)
                    .SubscribeOn(target.ExecutionContextScheduler))
                .Switch();

        }

        public static IObservable<ReturnCode_t> ResetAsync(this IObservableComponent target, int execHandle = 0, TimeSpan? timeout = null)
        {
            return target.Component.get_owned_contextsAsync()
                .SubscribeOn(target.ExecutionContextScheduler)
                .Select(ecs => ecs[execHandle].reset_componentAsync(target.Component)
                    .SubscribeOn(target.ExecutionContextScheduler))
                .Switch();
        }

        public static IObservable<ReturnCode_t> ExitAsync(this IObservableComponent target, int execHandle = 0, TimeSpan? timeout = null)
        {
            throw new NotImplementedException();
        }

        public static IObservable<LifeCycleState> GetStateAsync(this IObservableComponent target, int execHandle = 0, TimeSpan? timeout = null)
        {
            if (timeout == null) timeout = CorbaUtility.DefaultTimeout;

            return target.Component.get_owned_contextsAsync()
                .Select(ecs => ecs[execHandle].get_component_stateAsync(target.Component))
                .Switch();
        }

        public static IObservable<ComponentProfile> GetComponentProfileAsync(this IObservableComponent target, TimeSpan? timeout = null)
        {
            if (timeout == null) timeout = CorbaUtility.DefaultTimeout;

            return target.Component.get_component_profileAsync();
        }
    }

}

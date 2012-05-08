using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
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
            return target.Component.GetOwnedContextsAsync()
                .ToObservable()//TODO:
                .SubscribeOn(target.ExecutionContextScheduler)
                .Select(ecs => ecs[execHandle].ActivateComponentAsync(target.Component)
                    .ToObservable()//TODO:
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
            return target.Component.GetOwnedContextsAsync()
                .ToObservable()//TODO:
                .SubscribeOn(target.ExecutionContextScheduler)
                .Select(ecs => ecs[execHandle].DeactivateComponentAsync(target.Component)
                    .ToObservable()//TODO:
                    .SubscribeOn(target.ExecutionContextScheduler))
                .Switch();

        }

        public static IObservable<ReturnCode_t> ResetAsync(this IObservableComponent target, int execHandle = 0, TimeSpan? timeout = null)
        {
            return target.Component.GetOwnedContextsAsync()
                .ToObservable()//TODO:
                .SubscribeOn(target.ExecutionContextScheduler)
                .Select(ecs => ecs[execHandle].ResetComponentAsync(target.Component)
                    .ToObservable()//TODO:
                    .SubscribeOn(target.ExecutionContextScheduler))
                .Switch();
        }

        public static IObservable<ReturnCode_t> ExitAsync(this IObservableComponent target, int execHandle = 0, TimeSpan? timeout = null)
        {
            throw new NotImplementedException();
        }

        public static IObservable<LifeCycleState> GetStateAsync(this IObservableComponent target, int execHandle = 0, TimeSpan? timeout = null)
        {
            return target.Component.GetOwnedContextsAsync()
                .ToObservable()//TODO:
                .Select(ecs => ecs[execHandle].GetComponentStateAsync(target.Component).ToObservable())//TODO:
                .Switch();
        }

        public static IObservable<ComponentProfile> GetComponentProfileAsync(this IObservableComponent target, TimeSpan? timeout = null)
        {
            return target.Component.GetComponentProfileAsync().ToObservable();//TDOO
        }
    }

}

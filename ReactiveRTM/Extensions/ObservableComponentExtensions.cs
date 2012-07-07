using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Text;
using System.Threading.Tasks;
using ReactiveRTM.Corba;
using ReactiveRTM.Core;
using omg.org.RTC;

namespace ReactiveRTM.Extensions
{

    public static class ObservableComponentExtensions
    {
        public static Task<ReturnCode_t> ActivateAsync(this IObservableComponent target, int execHandle = 0)
        {
            return target.Component.GetOwnedContextsAsync()
                .ContinueWith(x => x.Result[execHandle].ActivateComponentAsync(target.Component))
                .Unwrap();
        }

        public static Task<StateChangedEventArgs> Activate(this IObservableComponent target, int execHandle = 0, TimeSpan? timeout = null)
        {
            var obs = target.StateChangedAsObservable()
                .Take(1)
                .PublishLast();

            obs.Connect();

            return ActivateAsync(target).ContinueWith(x => obs.ToTask()).Unwrap();//TODO: 失敗したとき？
        }


        public static Task<ReturnCode_t> DeactivateAsync(this IObservableComponent target, int execHandle = 0, TimeSpan? timeout = null)
        {
            return target.Component.GetOwnedContextsAsync()
                .ContinueWith(x => x.Result[execHandle].DeactivateComponentAsync(target.Component))
                .Unwrap();

        }

        public static Task<ReturnCode_t> ResetAsync(this IObservableComponent target, int execHandle = 0, TimeSpan? timeout = null)
        {
            return target.Component.GetOwnedContextsAsync()
                .ContinueWith(x => x.Result[execHandle].ResetComponentAsync(target.Component))
                .Unwrap();
        }

        public static Task<ReturnCode_t> ExitAsync(this IObservableComponent target, int execHandle = 0, TimeSpan? timeout = null)
        {
            throw new NotImplementedException();
        }

        public static Task<LifeCycleState> GetStateAsync(this IObservableComponent target, int execHandle = 0, TimeSpan? timeout = null)
        {
            return target.Component.GetOwnedContextsAsync()
                .ContinueWith(x => x.Result[execHandle].GetComponentStateAsync(target.Component))
                .Unwrap();
        }

        public static Task<ComponentProfile> GetComponentProfileAsync(this IObservableComponent target, TimeSpan? timeout = null)
        {
            return target.Component.GetComponentProfileAsync();
        }
    }

}

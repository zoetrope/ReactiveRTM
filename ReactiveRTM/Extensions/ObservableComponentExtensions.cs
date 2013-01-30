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
        public static async Task<ReturnCode_t> ActivateAsync(this IObservableComponent target, int execHandle = 0)
        {
            var comps = await target.Component.GetOwnedContextsAsync();
            return await comps[execHandle].ActivateComponentAsync(target.Component);
        }
        
        public static async Task<ReturnCode_t> DeactivateAsync(this IObservableComponent target, int execHandle = 0, TimeSpan? timeout = null)
        {
            var comps = await target.Component.GetOwnedContextsAsync();
            return await comps[execHandle].DeactivateComponentAsync(target.Component);

        }

        public static async Task<ReturnCode_t> ResetAsync(this IObservableComponent target, int execHandle = 0, TimeSpan? timeout = null)
        {
            var comps = await target.Component.GetOwnedContextsAsync();
            return await comps[execHandle].ResetComponentAsync(target.Component);
        }

        public static async Task<ReturnCode_t> ExitAsync(this IObservableComponent target, int execHandle = 0, TimeSpan? timeout = null)
        {
            throw new NotImplementedException();
        }

        public static async Task<LifeCycleState> GetStateAsync(this IObservableComponent target, int execHandle = 0, TimeSpan? timeout = null)
        {
            var comps = await target.Component.GetOwnedContextsAsync();
            return await comps[execHandle].GetComponentStateAsync(target.Component);
        }

        public static Task<ComponentProfile> GetComponentProfileAsync(this IObservableComponent target, TimeSpan? timeout = null)
        {
            return target.Component.GetComponentProfileAsync();
        }
    }

}

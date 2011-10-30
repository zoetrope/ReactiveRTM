using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using omg.org.RTC;

namespace ReactiveRTM.Core
{
    public sealed class SimpleComponent :ReactiveComponentBase
    {
        public SimpleComponent(string name)
            :base(name)
        {
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ReturnCode_t RaiseOnInitialize()
        {
            var onInitialize = OnInitialize;
            var ret = ReturnCode_t.RTC_OK; ;

            if (onInitialize != null)
            {
                ret = onInitialize();
            }

            base.RaiseOnInitialize();
            return ret;
        }
        public Func<ReturnCode_t> OnInitialize { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ReturnCode_t RaiseOnFinalize()
        {
            var onFinalize = OnFinalize;

            if (onFinalize != null)
            {
                return onFinalize();
            }

            return ReturnCode_t.RTC_OK;
        }
        public Func<ReturnCode_t> OnFinalize { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ReturnCode_t RaiseOnStartup(int execHandle)
        {
            var onStartup = OnStartup;

            if (onStartup != null)
            {
                return onStartup(execHandle);
            }

            return ReturnCode_t.RTC_OK;
        }
        public Func<int, ReturnCode_t> OnStartup { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ReturnCode_t RaiseOnShutdown(int execHandle)
        {
            var onShutdown = OnShutdown;

            if (onShutdown != null)
            {
                return onShutdown(execHandle);
            }

            return ReturnCode_t.RTC_OK;
        }
        public Func<int, ReturnCode_t> OnShutdown { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ReturnCode_t RaiseOnActivated(int execHandle)
        {
            var onActivate = OnActivated;
            var ret = ReturnCode_t.RTC_OK; ;

            if (onActivate != null)
            {
                ret = onActivate(execHandle);
            }

            base.RaiseOnActivated(execHandle);
            return ret;
        }
        public Func<int, ReturnCode_t> OnActivated { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ReturnCode_t RaiseOnDeactivated(int execHandle)
        {
            var onDeactivated = OnDeactivated;
            var ret = ReturnCode_t.RTC_OK; ;

            if (onDeactivated != null)
            {
                ret = onDeactivated(execHandle);
            }

            base.RaiseOnDeactivated(execHandle);
            return ret;
        }
        public Func<int, ReturnCode_t> OnDeactivated { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ReturnCode_t RaiseOnAborting(int execHandle)
        {
            var onAborting = OnAborting;
            var ret = ReturnCode_t.RTC_OK; ;

            if (onAborting != null)
            {
                ret = onAborting(execHandle);
            }

            base.RaiseOnAborting(execHandle);
            return ret;
        }
        public Func<int, ReturnCode_t> OnAborting { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ReturnCode_t RaiseOnError(int execHandle)
        {
            var onError = OnError;

            if (onError != null)
            {
                return onError(execHandle);
            }

            return ReturnCode_t.RTC_OK;
        }
        public Func<int, ReturnCode_t> OnError { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ReturnCode_t RaiseOnReset(int execHandle)
        {
            var onReset = OnReset;
            var ret = ReturnCode_t.RTC_OK; ;

            if (onReset != null)
            {
                ret = onReset(execHandle);
            }

            base.RaiseOnReset(execHandle);
            return ret;
        }
        public Func<int, ReturnCode_t> OnReset { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ReturnCode_t RaiseOnExecute(int execHandle)
        {
            var onExecute = OnExecute;

            if (onExecute != null)
            {
                return onExecute(execHandle);
            }

            return ReturnCode_t.RTC_OK;
        }
        public Func<int, ReturnCode_t> OnExecute { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ReturnCode_t RaiseOnStateUpdate(int execHandle)
        {
            var onStateUpdate = OnStateUpdate;

            if (onStateUpdate != null)
            {
                return onStateUpdate(execHandle);
            }

            return ReturnCode_t.RTC_OK;
        }
        public Func<int, ReturnCode_t> OnStateUpdate { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ReturnCode_t RaiseOnRateChanged(int execHandle)
        {
            var onRateChanged = OnRateChanged;

            if (onRateChanged != null)
            {
                return onRateChanged(execHandle);
            }

            return ReturnCode_t.RTC_OK;
        }

        public Func<int, ReturnCode_t> OnRateChanged { get; set; }




    }
}

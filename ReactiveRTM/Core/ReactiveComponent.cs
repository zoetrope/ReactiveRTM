using System;
using System.Collections.Generic;
using System.ComponentModel;
using ReactiveRTM.Adapter;
using ReactiveRTM.omg.org.RTC;
using System.ComponentModel.Composition;

namespace ReactiveRTM.Core
{
    [InheritedExport]
    public abstract class ReactiveComponent : ReactiveComponentBase
    {

        public List<ReactivePortBase> InPorts { get; set; }
        public List<ReactivePortBase> OutPorts { get; set; }

        private TimeSpan _timeSpan;
        private IDisposable _executor;


        public ReactiveComponent(string category = "", string description = "", string instantName = "", string typeName = "", string vendor = "", string version = "")
            :base(category, description, instantName, typeName, vendor, version)
        {
            
            
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public override sealed ReturnCode_t RaiseOnInitialize()
        {
            var ret = OnInitialize();
            base.RaiseOnInitialize();
            return ret;
        }
        protected virtual ReturnCode_t OnInitialize()
        {
            return ReturnCode_t.RTC_OK;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override sealed ReturnCode_t RaiseOnFinalize()
        {
            return OnFinalize();
        }
        protected virtual ReturnCode_t OnFinalize()
        {
            return ReturnCode_t.RTC_OK;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override sealed ReturnCode_t RaiseOnStartup(int execHandle)
        {
            return OnStartup(execHandle);
        }
        protected virtual ReturnCode_t OnStartup(int execHandle)
        {
            return ReturnCode_t.RTC_OK;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override sealed ReturnCode_t RaiseOnShutdown(int execHandle)
        {
            return OnShutdown(execHandle);
        }
        protected virtual ReturnCode_t OnShutdown(int execHandle)
        {
            return ReturnCode_t.RTC_OK;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override sealed ReturnCode_t RaiseOnActivated(int execHandle)
        {
            var ret = OnActivated(execHandle);
            base.RaiseOnActivated(execHandle);
            return ret;
        }
        protected virtual ReturnCode_t OnActivated(int execHandle)
        {
            return ReturnCode_t.RTC_OK;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override sealed ReturnCode_t RaiseOnDeactivated(int execHandle)
        {
            var ret = OnDeactivated(execHandle);
            base.RaiseOnDeactivated(execHandle);
            return ret;
        }
        protected virtual ReturnCode_t OnDeactivated(int execHandle)
        {
            return ReturnCode_t.RTC_OK;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override sealed ReturnCode_t RaiseOnAborting(int execHandle)
        {
            var ret = OnAborting(execHandle);
            base.RaiseOnAborting(execHandle);
            return ret;
        }
        protected virtual ReturnCode_t OnAborting(int execHandle)
        {
            return ReturnCode_t.RTC_OK;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override sealed ReturnCode_t RaiseOnError(int execHandle)
        {
            return OnError(execHandle);
        }
        protected virtual ReturnCode_t OnError(int execHandle)
        {
            return ReturnCode_t.RTC_OK;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override sealed ReturnCode_t RaiseOnReset(int execHandle)
        {
            var ret = OnReset(execHandle);
            base.RaiseOnReset(execHandle);
            return ret;
        }
        protected virtual ReturnCode_t OnReset(int execHandle)
        {
            return ReturnCode_t.RTC_OK;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override sealed ReturnCode_t RaiseOnExecute(int execHandle)
        {
            return OnExecute(execHandle);
        }
        protected virtual ReturnCode_t OnExecute(int execHandle)
        {
            return ReturnCode_t.RTC_OK;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override sealed ReturnCode_t RaiseOnStateUpdate(int execHandle)
        {
            return OnStateUpdate(execHandle);
        }
        protected virtual ReturnCode_t OnStateUpdate(int execHandle)
        {
            return ReturnCode_t.RTC_OK;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override sealed ReturnCode_t RaiseOnRateChanged(int execHandle)
        {
            return OnRateChanged(execHandle);
        }
        protected virtual ReturnCode_t OnRateChanged(int execHandle)
        {
            return ReturnCode_t.RTC_OK;
        }
    }


}

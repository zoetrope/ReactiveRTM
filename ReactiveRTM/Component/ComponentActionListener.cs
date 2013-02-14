using ReactiveRTM.RTC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReactiveRTM.Component
{
    internal interface IComponentActionListener
    {
        ReturnCode_t RaiseOnInitialize();

        ReturnCode_t RaiseOnFinalize();

        ReturnCode_t RaiseOnStartup(int execHandle);

        ReturnCode_t RaiseOnShutdown(int execHandle);

        ReturnCode_t RaiseOnActivated(int execHandle);

        ReturnCode_t RaiseOnDeactivated(int execHandle);

        ReturnCode_t RaiseOnAborting(int execHandle);

        ReturnCode_t RaiseOnError(int execHandle);

        ReturnCode_t RaiseOnReset(int execHandle);

        ReturnCode_t RaiseOnExecute(int execHandle);

        ReturnCode_t RaiseOnStateUpdate(int execHandle);

        ReturnCode_t RaiseOnRateChanged(int execHandle);
    }
}

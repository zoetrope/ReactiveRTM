using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using omg.org.RTC;

namespace ReactiveRTM.Core
{
    public interface IComponentActionListener
    {
        ReturnCode_t RaiseOnInitialize();

        ReturnCode_t RaiseOnFinalize();

        ReturnCode_t RaiseOnStartup(int exec_handle);

        ReturnCode_t RaiseOnShutdown(int exec_handle);

        ReturnCode_t RaiseOnActivated(int exec_handle);

        ReturnCode_t RaiseOnDeactivated(int exec_handle);

        ReturnCode_t RaiseOnAborting(int exec_handle);

        ReturnCode_t RaiseOnError(int exec_handle);

        ReturnCode_t RaiseOnReset(int exec_handle);

        ReturnCode_t RaiseOnExecute(int exec_handle);

        ReturnCode_t RaiseOnStateUpdate(int exec_handle);

        ReturnCode_t RaiseOnRateChanged(int exec_handle);
    }
}

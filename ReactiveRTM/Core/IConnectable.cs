using ReactiveRTM.RTC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReactiveRTM.Core
{
    public interface IConnectable
    {
        ReturnCode_t SetConnectionInfo(ConnectorProfile connectorProfile);
        ReturnCode_t Connect(ConnectorProfile connectorProfile);
        ReturnCode_t Disconnect(ConnectorProfile connectorProfile);
    }
}

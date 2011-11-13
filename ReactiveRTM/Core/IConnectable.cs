using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using omg.org.RTC;

namespace ReactiveRTM.Core
{
    public interface IConnectable
    {
        ReturnCode_t SetConnectionInfo(ConnectorProfileHolder connectorProfile);
        ReturnCode_t Connect(ConnectorProfileHolder connectorProfile);
        ReturnCode_t Disconnect(ConnectorProfileHolder connectorProfile);
    }
}

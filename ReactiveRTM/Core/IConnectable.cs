using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using omg.org.RTC;

namespace ReactiveRTM.Core
{
    public interface IConnectable
    {
        ReturnCode_t SetConnectionInfo(ref ConnectorProfile connectorProfile);
        ReturnCode_t Connect(ref ConnectorProfile connectorProfile);
        ReturnCode_t Disconnect(ref ConnectorProfile connectorProfile);
    }
}

using System;
using ReactiveRTM.OpenRTM;
using System.Collections.Generic;

namespace ReactiveRTM.Port
{
    /// <summary>
    /// put処理を移譲するInPortCdr
    /// </summary>
    public class DelegateInPortCdr : InPortCdr
    {
        private readonly Func<Byte[], PortStatus> _action;


        public DelegateInPortCdr(Func<Byte[], PortStatus> action)
        {
            _action = action;
        }


        public ReactiveRTM.OpenRTM.PortStatus Put(List<byte> data)
        {
            return _action(data.ToArray());
        }
    }
}

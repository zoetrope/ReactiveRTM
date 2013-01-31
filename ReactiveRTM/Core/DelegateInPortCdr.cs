using System;
using ReactiveRTM.OpenRTM;
using System.Collections.Generic;

namespace ReactiveRTM.Core
{
    /// <summary>
    /// put処理を移譲するInPortCdr
    /// </summary>
    public class DelegateInPortCdr : InPortCdr
    {
        public override object InitializeLifetimeService()
        {
            // CORBAメソッドがタイムアウトしないようにnullを返す
            return null;
        }

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

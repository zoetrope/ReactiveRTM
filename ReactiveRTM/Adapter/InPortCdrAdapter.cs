using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using OpenRTM;

namespace ReactiveRTM.Adapter
{
    public class DataReceivedEventArgs : EventArgs
    {
        public byte[] Data { get; set; }
    }

    public class InPortCdrAdapter : MarshalByRefObject, InPortCdr
    {
        public override object InitializeLifetimeService()
        {
            return null;
        }

        //ここにイベントを置く？
        public event EventHandler<DataReceivedEventArgs> DataReceived;

        public InPortCdrAdapter()
        {
            
        }

        public PortStatus put(byte[] data)
        {
            var handler = DataReceived;
            if (handler != null)
            {
                handler(this, new DataReceivedEventArgs() { Data = data });
            }

            return PortStatus.PORT_OK;
        }
    }

    
    internal static class ReactiveComponentExtension
    {
        internal static IObservable<byte[]> DataReceivedAsObservable(this InPortCdrAdapter target)
        {
            return Observable.FromEvent<EventHandler<DataReceivedEventArgs>, DataReceivedEventArgs>(
                    h => (sender, e) => h(e),
                    h => target.DataReceived += h,
                    h => target.DataReceived -= h)
                .Select(e => e.Data);
        }

    }
}

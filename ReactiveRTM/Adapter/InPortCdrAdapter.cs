using ReactiveRTM.OpenRTM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;

namespace ReactiveRTM.Adapter
{
    public class DataReceivedEventArgs : EventArgs
    {
        public List<byte> Data { get; set; }
    }

    public class InPortCdrImpl : InPortCdr
    {
        //ここにイベントを置く？
        public event EventHandler<DataReceivedEventArgs> DataReceived;

        public InPortCdrImpl()
        {
            
        }

        public PortStatus Put(List<byte> data)
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
        internal static IObservable<List<byte>> DataReceivedAsObservable(this InPortCdrImpl target)
        {
            return Observable.FromEventPattern<EventHandler<DataReceivedEventArgs>, DataReceivedEventArgs>(
                    h => h.Invoke,
                    h => target.DataReceived += h,
                    h => target.DataReceived -= h)
                .Select(e => e.EventArgs.Data);
        }

    }
}

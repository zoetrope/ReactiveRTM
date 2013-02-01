using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using ReactiveRTM.Core;
using ReactiveRTM.RTC;
using ReactiveRTM.omg.org.RTC;

/// <summary>
/// データポートの合成のサンプル
/// </summary>
class Program
{
    public static void Main(string[] args)
    {
    }
}

class PortCombination : ReactiveComponent
{
    private ReactiveOutPort<TimedLong> _outport = new ReactiveOutPort<TimedLong>("out");
    private ReactiveInPort<TimedLong> _inport1 = new ReactiveInPort<TimedLong>("in1");
    private ReactiveInPort<TimedLong> _inport2 = new ReactiveInPort<TimedLong>("in2");

    public PortCombination()
        : base("PortCombination")
    {
        AddPort(_outport);
        AddPort(_inport1);
        AddPort(_inport2);
    }

    private CompositeDisposable _disposer = new CompositeDisposable();

    protected override ReturnCode_t OnActivated(int execHandle)
    {
        var combinationType = "Zip";

        IDisposable d;

        switch (combinationType)
        {
            case "Zip":
                d = Observable.Zip(_inport1, _inport2,
                    (indata1, indata2) => new TimedLong() { Tm = DateTime.Now, Data = indata1.Data + indata2.Data })
                    .Subscribe(data => _outport.WriteAsync(data));
                break;

            case "Merge":
                d = Observable.Merge(_inport1, _inport2)
                    .Subscribe(data => _outport.WriteAsync(data));
                break;

            case "CombineLatest":
                d = Observable.CombineLatest(_inport1, _inport2,
                    (indata1, indata2) => new TimedLong() { Tm = DateTime.Now, Data = indata1.Data + indata2.Data })
                    .Subscribe(data => _outport.WriteAsync(data));
                break;
            default:
                d = Disposable.Empty;
                break;
        }
        _disposer.Add(d);

        return ReturnCode_t.RTC_OK;
    }

    protected override ReturnCode_t OnDeactivated(int execHandle)
    {
        _disposer.Dispose();

        return ReturnCode_t.RTC_OK;
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReactiveRTM.Core;
using ReactiveRTM.RTC;

/// <summary>
/// データポートからの入力データをコンソールに出力する
/// </summary>
class Program
{
    public static void Main(string[] args)
    {
        using (var manager = new RtcManager(args))
        {
            var comp = new ConsoleOut();

            manager.RegisterComponent(comp);

            manager.Run();
        }
    }
}

class ConsoleOut : ReactiveComponent
{
    private ReactiveInPort<TimedLong> _inport = new ReactiveInPort<TimedLong>("in");

    public ConsoleOut()
        : base("ConsoleOut")
    {
        AddPort(_inport);
    }

    private IDisposable _disposer;
    protected override ReturnCode_t OnActivated(int execHandle)
    {
        _disposer = _inport.Subscribe(x => Console.WriteLine(x.Data));

        return ReturnCode_t.RTC_OK;
    }

    protected override ReturnCode_t OnDeactivated(int execHandle)
    {
        _disposer.Dispose();
        return ReturnCode_t.RTC_OK;
    }


}


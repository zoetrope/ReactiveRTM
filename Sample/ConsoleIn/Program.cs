using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReactiveRTM.Core;
using ReactiveRTM.RTC;
using ReactiveRTM.omg.org.RTC;

/// <summary>
/// コンソール入力のデータをデータポートに出力するサンプル
/// </summary>
class Program
{
    public static void Main(string[] args)
    {
        using (var manager = new RtcManager(args))
        {
            var comp = new ConsoleIn();

            manager.RegisterComponent(comp);

            manager.Run();
        }
    }
}

class ConsoleIn : ReactiveComponent
{
    private ReactiveOutPort<TimedLong> _outport = new ReactiveOutPort<TimedLong>("out");

    public ConsoleIn()
        :base("ConsoleIn")
    {
        AddPort(_outport);
    }

    

    protected override ReturnCode_t OnExecute(int execHandle)
    {
        _outport.Write(new TimedLong() { Tm = DateTime.Now, Data = 123 });

        return ReturnCode_t.RTC_OK;
    }

}


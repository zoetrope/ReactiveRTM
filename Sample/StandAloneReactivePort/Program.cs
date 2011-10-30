using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using RTC;
using ReactiveRTM;
using ReactiveRTM.Core;
using ReactiveRTM.Extensions;

/// <summary>
/// ポートを単独で使うサンプル
/// </summary>
class Program
{
    public static void Main(string[] args)
    {

        using (var manager = new RtcManager("localhost", 2809))
        {
            var comp = manager.GetComponent("ConsoleIn0.rtc");

            var prof = comp.GetStateAsync().First();
            Console.WriteLine(prof);
        }

        //var inport = new ReactiveInPort<TimedLong>("test");

        //inport.Subscribe(x => Console.WriteLine(x.data));

        //inport.ConnectAsync("ConsoleIn.rtc:ConsoleIn.out");
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using ReactiveRTM;
using ReactiveRTM.Core;
using omg.org.RTC;

/// <summary>
/// コンポーネントを監視するサンプル
/// </summary>
class Program
{
    public static void Main(string[] args)
    {
        using (var manager = new RtcManager("localhost", 2809))
        {
            var comp = manager.GetComponent("ConsoleOut.rtc");


            comp.StateChangedAsObservable()
                //.Where(state => state == LifeCycleState.ACTIVE_STATE)
                .Subscribe(state => Console.WriteLine(state));

            Console.ReadKey();

        }
    }
}

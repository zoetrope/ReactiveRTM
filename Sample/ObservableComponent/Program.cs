using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using ReactiveRTM;
using ReactiveRTM.Core;
using ReactiveRTM.Extensions;
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
            var comp = manager.GetComponent("ConsoleOut0.rtc");


            var subject = new Subject<LifeCycleState>();

            comp.StateChangedAsObservable().Subscribe(subject);

            comp.ActivateAsync().First();

            subject.First();

        }
    }
}

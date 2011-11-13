﻿using System;
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

            var obs = comp.StateChangedAsObservable()
              .Where(state => state == LifeCycleState.ACTIVE_STATE)
              .PublishLast();

            obs.Connect();

            comp.ActivateAsync().First();

            //obs.First();

            obs.Timeout(TimeSpan.FromSeconds(5))
              .Catch((TimeoutException ex) => { 
                // 例外処理
                return Observable.Empty<LifeCycleState>();
              })
              .First();
              
        }
    }
}

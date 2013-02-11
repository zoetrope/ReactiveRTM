using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReactiveRTM;
using ReactiveRTM.Core;
using ReactiveRTM.RTC;

/// <summary>
/// 周期的にHello Worldを表示するサンプル
/// </summary>
class Program
{
    public static void Main(string[] args)
    {
        using (var manager = new RtcManager(args))
        {
            var comp = new SimpleComponent("HelloWorld")
                           {
                               OnExecute = _ => {
                                   Console.WriteLine("Hello Wolrd!");
                                   return ReturnCode_t.RTC_OK;
                               }
                           };
            
            manager.RegisterComponent(comp);

            manager.Run();
        }
    }
}


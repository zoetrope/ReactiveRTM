using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using RTC;
using ReactiveRTM.Core;
using omg.org.RTC;

/// <summary>
/// 実行スレッドを実行コンテキストのスレッドに切り替えるサンプル
/// </summary>
class Program
{
    public static void Main(string[] args)
    {
    }
}

class ECSchedulerTest : ReactiveComponent
{
    private ReactiveInPort<TimedLong> _inport = new ReactiveInPort<TimedLong>("in");

    public ECSchedulerTest()
        : base("ECSchedulerTest")
    {
        AddPort(_inport);
    }

    private CompositeDisposable _disposer;

    protected override ReturnCode_t OnActivated(int execHandle)
    {
        var d = _inport.Where(x => x.data > 100)
            .ObserveOn(ExecutionContextScheduler)
            .Subscribe(x => Console.WriteLine(x.data));

        _disposer.Add(d);

        return ReturnCode_t.RTC_OK;
    }

    protected override ReturnCode_t OnAborting(int execHandle)
    {
        _disposer.Dispose();

        return base.OnAborting(execHandle);
    }

}
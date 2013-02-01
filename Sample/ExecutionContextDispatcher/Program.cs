using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using ReactiveRTM.Core;
using ReactiveRTM.Extensions;
using ReactiveRTM.omg.org.RTC;
using ReactiveRTM.RTC;

/// <summary>
/// 実行スレッドを実行コンテキストのスレッドに切り替えるサンプル
/// </summary>
class Program
{
    public static void Main(string[] args)
    {
        var comp = new ECSchedulerTest();

        comp.ActivateAsync().Wait();

        var subject = new Subject<TimedLong>();
        comp.InPort.Connect(subject);

        foreach (var i in Enumerable.Range(0,1000))
        {
            subject.OnNext(new TimedLong() { Tm = DateTime.Now, Data = i });
            Thread.Sleep(500);
        }
        
    }
}

class ECSchedulerTest : ReactiveComponent
{
    public ReactiveInPort<TimedLong> InPort { get; private set; }

    public ECSchedulerTest()
        : base("ECSchedulerTest")
    {
        InPort = new ReactiveInPort<TimedLong>("in");
        AddPort(InPort);
    }

    private IDisposable _disposer;
    private DangerousObject _object = new DangerousObject();

    protected override ReturnCode_t OnActivated(int execHandle)
    {
        _disposer = InPort
            .ObserveOn(ExecutionContextScheduler)
            .Subscribe(_ => _object.Do());
        
        return ReturnCode_t.RTC_OK;
    }

    protected override ReturnCode_t OnExecute(int execHandle)
    {
        _object.IsDanger = true;

        Thread.Sleep(TimeSpan.FromSeconds(1));

        _object.IsDanger = false;

        return ReturnCode_t.RTC_OK;
    }

    protected override ReturnCode_t OnDeactivated(int execHandle)
    {
        _disposer.Dispose();

        return ReturnCode_t.RTC_OK;
    }

    private class DangerousObject
    {
        public bool IsDanger { get; set; }

        public void Do()
        {
            if (IsDanger) throw new Exception();
        }
    }
}
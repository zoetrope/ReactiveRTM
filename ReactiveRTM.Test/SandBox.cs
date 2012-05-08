using System;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.Reactive.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RTC;

namespace ReactiveRTM.Test
{
    [TestClass]
    public class SandBox : ReactiveTest
    {
        [TestMethod]
        public void 配列要素のコピー()
        {
            var data = new TimedLongSeq();
            data.data = new int[3]{1,2,3};

            var data2 = data;

            data.data[0] = 3;
            data.data[1] = 2;
            data.data[2] = 1;

            data2.data[0].Is(3);
            data2.data[1].Is(2);
            data2.data[2].Is(1);
        }

        [TestMethod]
        public void 自作する必要はないのか()
        {

            var scheduler = new EventLoopScheduler();


            Observable.Interval(TimeSpan.FromSeconds(1))
                .ObserveOn(scheduler)
                .Subscribe(_ =>
                {
                    Console.WriteLine("entry1");
                    Thread.Sleep(500);
                    Console.WriteLine("exit1");
                });

            Observable.Interval(TimeSpan.FromSeconds(1))
                .ObserveOn(scheduler)
                .Subscribe(_ =>
                {
                    Console.WriteLine("entry2");
                    Thread.Sleep(300);
                    Console.WriteLine("exit2");
                });

            Thread.Sleep(10000);
        }

        [TestMethod]
        public void Publishを理解()
        {
            var subject = new Subject<int>();

            
        }

        [TestMethod]
        public void ObservableStartをTestSchedulerで動かすには()
        {
            var testScheduler = new TestScheduler();
            var recorder = testScheduler.CreateObserver<int>();

            bool isRun = false;
            Observable.Start(() =>
            {
                isRun = true;
                return 1234;
            }, testScheduler)
            .Subscribe(recorder);

            recorder.Messages.Count.Is(0);

            testScheduler.AdvanceBy(1);

            recorder.Messages.Count.Is(2);

            ReactiveAssert.AreElementsEqual(recorder.Messages,
                new[] { OnNext(1, 1234), OnCompleted<int>(1) });

        }

        [TestMethod]
        public void SubscribeOnとは()
        {
            var testScheduler = new TestScheduler();
            var recorder = testScheduler.CreateObserver<int>();

            bool isRun = false;
            Observable.Start(() =>
            {
                isRun = true;
                return 1234;
            })
            .SubscribeOn(testScheduler)
            .Subscribe(recorder);

            recorder.Messages.Count.Is(0);

            testScheduler.AdvanceBy(1);

            recorder.Messages.Count.Is(2);

            ReactiveAssert.AreElementsEqual(recorder.Messages,
                new[] { OnNext(1, 1234), OnCompleted<int>(1) });
        }


        [TestMethod]
        public void 複数のObservableを監視するには()
        {
            var scheduler = new TestScheduler();

            var subject1 = scheduler.CreateHotObservable(OnNext(100, 1), OnNext(200, 3));
            var subject2 = scheduler.CreateHotObservable(OnNext(100, 2), OnNext(200, 4));

            var aggSubject = new Subject<int>();

            var recorder = scheduler.CreateObserver<int>();

            aggSubject.Do(Console.WriteLine).Subscribe(recorder);

            subject1.Subscribe(aggSubject);

            scheduler.AdvanceBy(100);

            subject2.Subscribe(aggSubject);

            scheduler.AdvanceBy(200);
            
        }

        [TestMethod]
        public void CamelCaseに変換する()
        {
            SnakeCaseToCamelCase("snake1").Is("Snake1");
            SnakeCaseToCamelCase("snake_case2").Is("SnakeCase2");
            SnakeCaseToCamelCase("snake_case_3").Is("SnakeCase3");
            SnakeCaseToCamelCase("snake_case4_").Is("SnakeCase4");
            SnakeCaseToCamelCase("_snake5").Is("Snake5");

        }

        private string SnakeCaseToCamelCase(string snake)
        {
            bool nextIsLarge = true;
            string camel = "";

            foreach (var c in snake)
            {
                if(c == '_')
                {
                    nextIsLarge = true;
                    continue;
                }
                if(nextIsLarge)
                {
                    camel += c.ToString().ToUpper();
                    nextIsLarge = false;
                }
                else
                {
                    camel += c;
                }
            }
            return camel;
        }
    }
}

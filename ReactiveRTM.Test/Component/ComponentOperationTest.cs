﻿using System;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReactiveRTM.Extensions;
using ReactiveRTM.RTC;
using ReactiveRTM.Component;

namespace ReactiveRTM.Test
{
    [TestClass]
    public class ActivateTest
    {

        [TestMethod]
        public void コンポーネントの活性化()
        {
            var comp = new SimpleComponent("test");

            bool calledActivated = false;
            comp.OnActivated = _ =>
            {
                calledActivated = true;
                return ReturnCode_t.RTC_OK;
            };

            comp.ActivateAsync().Result.Is(ReturnCode_t.RTC_OK);

            calledActivated.Is(true);
        }

        [TestMethod]
        public void 存在しない実行コンテキストを指定したら例外()
        {
            var comp = new SimpleComponent("test");
            AssertEx.Throws<ArgumentOutOfRangeException>(() => comp.ActivateAsync(1).Wait());
        }

        [TestMethod]
        public void 状態が変化しなかったらタイムアウト()
        {
            var comp = new SimpleComponent("test");
            comp.OnActivated = _ =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(3));
                return ReturnCode_t.RTC_OK;
            };

            AssertEx.Throws<TimeoutException>(() =>
                    comp.ActivateAsync()
                    .ToObservable()
                    .Timeout(TimeSpan.FromSeconds(1))
                    .First()
                );
        }

        [TestMethod]
        public void 活性化しているのにActivateしたら失敗()
        {
            var comp = new SimpleComponent("test");
            comp.ActivateAsync().Result.Is(ReturnCode_t.RTC_OK);
            comp.ActivateAsync().Result.Is(ReturnCode_t.PRECONDITION_NOT_MET);
        }
    }
    [TestClass]
    public class DeactivateTest
    {

        [TestMethod]
        public void コンポーネントの非活性化()
        {
            var comp = new SimpleComponent("test");

            bool calledDeactivated = false;
            comp.OnDeactivated = _ =>
            {
                calledDeactivated = true;
                return ReturnCode_t.RTC_OK;
            };

            comp.ActivateAsync().Result.Is(ReturnCode_t.RTC_OK);
            comp.DeactivateAsync().Result.Is(ReturnCode_t.RTC_OK);

            calledDeactivated.Is(true);
        }

        [TestMethod]
        public void 存在しない実行コンテキストを指定したら例外()
        {
            var comp = new SimpleComponent("test");
            AssertEx.Throws<ArgumentOutOfRangeException>(() => comp.DeactivateAsync(1).Wait());
        }

        [TestMethod]
        public void 状態が変化しなかったらタイムアウト()
        {
            var comp = new SimpleComponent("test");
            comp.OnDeactivated = _ =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(3));
                return ReturnCode_t.RTC_OK;
            };

            comp.ActivateAsync().Result.Is(ReturnCode_t.RTC_OK);
            AssertEx.Throws<TimeoutException>(() =>
                    comp.DeactivateAsync(timeout: TimeSpan.FromSeconds(1)).Wait()
                );
        }

        [TestMethod]
        public void 活性化してないのにDeactivateしたら失敗()
        {
            var comp = new SimpleComponent("test");
            comp.DeactivateAsync().Result.Is(ReturnCode_t.PRECONDITION_NOT_MET);
        }
    }


    [TestClass]
    public class ResetTest
    {

        [TestMethod]
        public void コンポーネントのリセット()
        {
            var comp = new SimpleComponent("test");

            comp.OnActivated = _ => ReturnCode_t.RTC_ERROR;

            bool calledReset = false;
            comp.OnReset = _ =>
            {
                calledReset = true;
                return ReturnCode_t.RTC_OK;
            };

            comp.ActivateAsync().Result.Is(ReturnCode_t.RTC_OK);
            comp.ResetAsync().Result.Is(ReturnCode_t.RTC_OK);

            calledReset.Is(true);
        }

        [TestMethod]
        public void 存在しない実行コンテキストを指定したら例外()
        {
            var comp = new SimpleComponent("test");
            AssertEx.Throws<ArgumentOutOfRangeException>(() => comp.ResetAsync(1).Wait());
        }

        [TestMethod]
        public void 状態が変化しなかったらタイムアウト()
        {
            var comp = new SimpleComponent("test");

            comp.OnActivated = _ => ReturnCode_t.RTC_ERROR;
            comp.OnReset = _ =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(3));
                return ReturnCode_t.RTC_OK;
            };

            comp.ActivateAsync().Result.Is(ReturnCode_t.RTC_OK);
            AssertEx.Throws<TimeoutException>(() =>
                    comp.ResetAsync(timeout: TimeSpan.FromSeconds(1)).Wait()
                );
        }

        [TestMethod]
        public void エラーが起きていないのにResetしたら失敗()
        {
            var comp = new SimpleComponent("test");
            comp.ResetAsync().Result.Is(ReturnCode_t.PRECONDITION_NOT_MET);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReactiveRTM.Core;

namespace ReactiveRTM.Test.Core
{
    [TestClass]
    public class ComponentCompositionTest
    {
        private RtcManager _manager;
        [TestInitialize]
        public void Initialize()
        {
            _manager = new RtcManager(new[] { "-f", @"..\..\TestData\catalog.yaml" });
        }

        [TestCleanup]
        public void Cleanup()
        {
            _manager.Dispose();
        }

        [TestMethod]
        public void 型名指定でシングルトン()
        {
            var comp1_1 = _manager.CreateComponent<TestComp1>();
            comp1_1.IsNotNull();
            var comp1_2 = _manager.CreateComponent<TestComp1>();
            comp1_1.Is(comp1_2);

        }
        [TestMethod]
        public void 名前指定でシングルトン()
        {
            var comp2_1 = _manager.CreateComponent("ReactiveRTM.Test.Core.TestComp2");
            comp2_1.IsNotNull();
            var comp2_2 = _manager.CreateComponent("ReactiveRTM.Test.Core.TestComp2");
            comp2_1.Is(comp2_2);
        }
        [TestMethod]
        public void 型名指定で複数インスタンス()
        {
            var comp3_1 = _manager.CreateComponent<TestComp3>();
            comp3_1.IsNotNull();
            var comp3_2 = _manager.CreateComponent<TestComp3>();
            comp3_1.IsNot(comp3_2);
        }
        [TestMethod]
        public void 名前指定で複数インスタンス()
        {
            var comp4_1 = _manager.CreateComponent("TestComponent4");
            comp4_1.IsNotNull();
            var comp4_2 = _manager.CreateComponent<TestComp4>();
            comp4_1.IsNot(comp4_2);
        }
        [TestMethod]
        public void 同じ名前はエラー()
        {
            var comp4_1 = _manager.CreateComponent("TestComponentEx");
        }
        [TestMethod]
        public void Export属性がついてないのはエラー()
        {
            var comp4_2 = _manager.CreateComponent<TestComp7>();
        }
    }

    //[Export()]
    public class TestComp1 : ReactiveComponent
    {
    }

    //[Export("TestComponent2", typeof(ReactiveComponent))]
    public class TestComp2 : ReactiveComponent
    {
    }

    //[Export]
    //[PartCreationPolicy(CreationPolicy.NonShared)]
    public class TestComp3 : ReactiveComponent
    {
    }

    //[Export("TestComponent4")]
    //[PartCreationPolicy(CreationPolicy.NonShared)]
    public class TestComp4 : ReactiveComponent
    {
    }

    //[Export("TestComponentEx")]
    //[PartCreationPolicy(CreationPolicy.NonShared)]
    public class TestComp5 : ReactiveComponent
    {
    }
    //[Export("TestComponentEx")]
    //[PartCreationPolicy(CreationPolicy.NonShared)]
    public class TestComp6 : ReactiveComponent
    {
    }

    public class TestComp7 : ReactiveComponent
    {
    }
}

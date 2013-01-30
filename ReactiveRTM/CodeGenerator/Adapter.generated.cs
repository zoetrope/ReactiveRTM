using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading.Tasks;
using ReactiveRTM.Corba;
using ReactiveRTM.Generated;

 
namespace ReactiveRTM.omg.org.RTC
{
    public interface IExecutionContext
    {
        System.Boolean IsRunning();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Start();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Stop();
        System.Double GetRate();
        ReactiveRTM.omg.org.RTC.ReturnCode_t SetRate(System.Double rate);
        ReactiveRTM.omg.org.RTC.ReturnCode_t AddComponent(ReactiveRTM.omg.org.RTC.LightweightRTObject comp);
        ReactiveRTM.omg.org.RTC.ReturnCode_t RemoveComponent(ReactiveRTM.omg.org.RTC.LightweightRTObject comp);
        ReactiveRTM.omg.org.RTC.ReturnCode_t ActivateComponent(ReactiveRTM.omg.org.RTC.LightweightRTObject comp);
        ReactiveRTM.omg.org.RTC.ReturnCode_t DeactivateComponent(ReactiveRTM.omg.org.RTC.LightweightRTObject comp);
        ReactiveRTM.omg.org.RTC.ReturnCode_t ResetComponent(ReactiveRTM.omg.org.RTC.LightweightRTObject comp);
        ReactiveRTM.omg.org.RTC.LifeCycleState GetComponentState(ReactiveRTM.omg.org.RTC.LightweightRTObject comp);
        ReactiveRTM.omg.org.RTC.ExecutionKind GetKind();
    }

    public class ExecutionContextAdapter : MarshalByRefObject, global::omg.org.RTC.ExecutionContext
    {
        private IExecutionContext _target;

        public ExecutionContextAdapter(IExecutionContext target)
        {
            _target = target;
        }
        public System.Boolean IsRunning()
        {
            var ret = _target.IsRunning();
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t Start()
        {
            var ret = _target.Start();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t Stop()
        {
            var ret = _target.Stop();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Double GetRate()
        {
            var ret = _target.GetRate();
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t SetRate(System.Double rate)
        {
            var ret = _target.SetRate(rate);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t AddComponent(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.AddComponent(comp);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t RemoveComponent(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.RemoveComponent(comp);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t ActivateComponent(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.ActivateComponent(comp);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t DeactivateComponent(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.DeactivateComponent(comp);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t ResetComponent(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.ResetComponent(comp);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.LifeCycleState GetComponentState(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.GetComponentState(comp);
            return (global::omg.org.RTC.LifeCycleState)ret;
        }
        public global::omg.org.RTC.ExecutionKind GetKind()
        {
            var ret = _target.GetKind();
            return (global::omg.org.RTC.ExecutionKind)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IComponentAction
    {
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnInitialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnFinalize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnStartup(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnActivated(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnAborting(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnError(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnReset(System.Int32 exec_handle);
    }

    public class ComponentActionAdapter : MarshalByRefObject, global::omg.org.RTC.ComponentAction
    {
        private IComponentAction _target;

        public ComponentActionAdapter(IComponentAction target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ReturnCode_t OnInitialize()
        {
            var ret = _target.OnInitialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnFinalize()
        {
            var ret = _target.OnFinalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnStartup(System.Int32 exec_handle)
        {
            var ret = _target.OnStartup(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 exec_handle)
        {
            var ret = _target.OnShutdown(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnActivated(System.Int32 exec_handle)
        {
            var ret = _target.OnActivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 exec_handle)
        {
            var ret = _target.OnDeactivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnAborting(System.Int32 exec_handle)
        {
            var ret = _target.OnAborting(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnError(System.Int32 exec_handle)
        {
            var ret = _target.OnError(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnReset(System.Int32 exec_handle)
        {
            var ret = _target.OnReset(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface ILightweightRTObject
    {
        ReactiveRTM.omg.org.RTC.ReturnCode_t Initialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Finalize();
        System.Boolean IsAlive(ReactiveRTM.omg.org.RTC.ExecutionContext exec_context);
        ReactiveRTM.omg.org.RTC.ReturnCode_t Exit();
        System.Int32 AttachContext(ReactiveRTM.omg.org.RTC.ExecutionContext exec_context);
        ReactiveRTM.omg.org.RTC.ReturnCode_t DetachContext(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ExecutionContextStub GetContext(System.Int32 exec_handle);
        List<ReactiveRTM.omg.org.RTC.ExecutionContextStub> GetOwnedContexts();
        List<ReactiveRTM.omg.org.RTC.ExecutionContextStub> GetParticipatingContexts();
        System.Int32 GetContextHandle(ReactiveRTM.omg.org.RTC.ExecutionContext cxt);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnInitialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnFinalize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnStartup(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnActivated(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnAborting(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnError(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnReset(System.Int32 exec_handle);
    }

    public class LightweightRTObjectAdapter : MarshalByRefObject, global::omg.org.RTC.LightweightRTObject
    {
        private ILightweightRTObject _target;

        public LightweightRTObjectAdapter(ILightweightRTObject target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ReturnCode_t Initialize()
        {
            var ret = _target.Initialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t Finalize()
        {
            var ret = _target.Finalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Boolean IsAlive(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.IsAlive(exec_context);
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t Exit()
        {
            var ret = _target.Exit();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Int32 AttachContext(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.AttachContext(exec_context);
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t DetachContext(System.Int32 exec_handle)
        {
            var ret = _target.DetachContext(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ExecutionContext GetContext(System.Int32 exec_handle)
        {
            var ret = _target.GetContext(exec_handle);
            return ((global::omg.org.RTC.ExecutionContext)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ExecutionContext[] GetOwnedContexts()
        {
            var ret = _target.GetOwnedContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ExecutionContext[] GetParticipatingContexts()
        {
            var ret = _target.GetParticipatingContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public System.Int32 GetContextHandle(global::omg.org.RTC.ExecutionContext cxt)
        {
            var ret = _target.GetContextHandle(cxt);
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnInitialize()
        {
            var ret = _target.OnInitialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnFinalize()
        {
            var ret = _target.OnFinalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnStartup(System.Int32 exec_handle)
        {
            var ret = _target.OnStartup(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 exec_handle)
        {
            var ret = _target.OnShutdown(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnActivated(System.Int32 exec_handle)
        {
            var ret = _target.OnActivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 exec_handle)
        {
            var ret = _target.OnDeactivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnAborting(System.Int32 exec_handle)
        {
            var ret = _target.OnAborting(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnError(System.Int32 exec_handle)
        {
            var ret = _target.OnError(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnReset(System.Int32 exec_handle)
        {
            var ret = _target.OnReset(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IDataFlowComponentAction
    {
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnExecute(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnStateUpdate(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnRateChanged(System.Int32 exec_handle);
    }

    public class DataFlowComponentActionAdapter : MarshalByRefObject, global::omg.org.RTC.DataFlowComponentAction
    {
        private IDataFlowComponentAction _target;

        public DataFlowComponentActionAdapter(IDataFlowComponentAction target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ReturnCode_t OnExecute(System.Int32 exec_handle)
        {
            var ret = _target.OnExecute(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnStateUpdate(System.Int32 exec_handle)
        {
            var ret = _target.OnStateUpdate(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnRateChanged(System.Int32 exec_handle)
        {
            var ret = _target.OnRateChanged(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IDataFlowComponent
    {
        ReactiveRTM.omg.org.RTC.ReturnCode_t Initialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Finalize();
        System.Boolean IsAlive(ReactiveRTM.omg.org.RTC.ExecutionContext exec_context);
        ReactiveRTM.omg.org.RTC.ReturnCode_t Exit();
        System.Int32 AttachContext(ReactiveRTM.omg.org.RTC.ExecutionContext exec_context);
        ReactiveRTM.omg.org.RTC.ReturnCode_t DetachContext(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ExecutionContextStub GetContext(System.Int32 exec_handle);
        List<ReactiveRTM.omg.org.RTC.ExecutionContextStub> GetOwnedContexts();
        List<ReactiveRTM.omg.org.RTC.ExecutionContextStub> GetParticipatingContexts();
        System.Int32 GetContextHandle(ReactiveRTM.omg.org.RTC.ExecutionContext cxt);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnInitialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnFinalize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnStartup(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnActivated(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnAborting(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnError(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnReset(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnExecute(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnStateUpdate(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnRateChanged(System.Int32 exec_handle);
    }

    public class DataFlowComponentAdapter : MarshalByRefObject, global::omg.org.RTC.DataFlowComponent
    {
        private IDataFlowComponent _target;

        public DataFlowComponentAdapter(IDataFlowComponent target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ReturnCode_t Initialize()
        {
            var ret = _target.Initialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t Finalize()
        {
            var ret = _target.Finalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Boolean IsAlive(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.IsAlive(exec_context);
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t Exit()
        {
            var ret = _target.Exit();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Int32 AttachContext(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.AttachContext(exec_context);
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t DetachContext(System.Int32 exec_handle)
        {
            var ret = _target.DetachContext(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ExecutionContext GetContext(System.Int32 exec_handle)
        {
            var ret = _target.GetContext(exec_handle);
            return ((global::omg.org.RTC.ExecutionContext)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ExecutionContext[] GetOwnedContexts()
        {
            var ret = _target.GetOwnedContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ExecutionContext[] GetParticipatingContexts()
        {
            var ret = _target.GetParticipatingContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public System.Int32 GetContextHandle(global::omg.org.RTC.ExecutionContext cxt)
        {
            var ret = _target.GetContextHandle(cxt);
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnInitialize()
        {
            var ret = _target.OnInitialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnFinalize()
        {
            var ret = _target.OnFinalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnStartup(System.Int32 exec_handle)
        {
            var ret = _target.OnStartup(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 exec_handle)
        {
            var ret = _target.OnShutdown(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnActivated(System.Int32 exec_handle)
        {
            var ret = _target.OnActivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 exec_handle)
        {
            var ret = _target.OnDeactivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnAborting(System.Int32 exec_handle)
        {
            var ret = _target.OnAborting(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnError(System.Int32 exec_handle)
        {
            var ret = _target.OnError(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnReset(System.Int32 exec_handle)
        {
            var ret = _target.OnReset(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnExecute(System.Int32 exec_handle)
        {
            var ret = _target.OnExecute(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnStateUpdate(System.Int32 exec_handle)
        {
            var ret = _target.OnStateUpdate(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnRateChanged(System.Int32 exec_handle)
        {
            var ret = _target.OnRateChanged(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IFsm
    {
        ReactiveRTM.omg.org.RTC.ReturnCode_t Initialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Finalize();
        System.Boolean IsAlive(ReactiveRTM.omg.org.RTC.ExecutionContext exec_context);
        ReactiveRTM.omg.org.RTC.ReturnCode_t Exit();
        System.Int32 AttachContext(ReactiveRTM.omg.org.RTC.ExecutionContext exec_context);
        ReactiveRTM.omg.org.RTC.ReturnCode_t DetachContext(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ExecutionContextStub GetContext(System.Int32 exec_handle);
        List<ReactiveRTM.omg.org.RTC.ExecutionContextStub> GetOwnedContexts();
        List<ReactiveRTM.omg.org.RTC.ExecutionContextStub> GetParticipatingContexts();
        System.Int32 GetContextHandle(ReactiveRTM.omg.org.RTC.ExecutionContext cxt);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnInitialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnFinalize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnStartup(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnActivated(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnAborting(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnError(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnReset(System.Int32 exec_handle);
    }

    public class FsmAdapter : MarshalByRefObject, global::omg.org.RTC.Fsm
    {
        private IFsm _target;

        public FsmAdapter(IFsm target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ReturnCode_t Initialize()
        {
            var ret = _target.Initialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t Finalize()
        {
            var ret = _target.Finalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Boolean IsAlive(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.IsAlive(exec_context);
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t Exit()
        {
            var ret = _target.Exit();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Int32 AttachContext(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.AttachContext(exec_context);
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t DetachContext(System.Int32 exec_handle)
        {
            var ret = _target.DetachContext(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ExecutionContext GetContext(System.Int32 exec_handle)
        {
            var ret = _target.GetContext(exec_handle);
            return ((global::omg.org.RTC.ExecutionContext)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ExecutionContext[] GetOwnedContexts()
        {
            var ret = _target.GetOwnedContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ExecutionContext[] GetParticipatingContexts()
        {
            var ret = _target.GetParticipatingContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public System.Int32 GetContextHandle(global::omg.org.RTC.ExecutionContext cxt)
        {
            var ret = _target.GetContextHandle(cxt);
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnInitialize()
        {
            var ret = _target.OnInitialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnFinalize()
        {
            var ret = _target.OnFinalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnStartup(System.Int32 exec_handle)
        {
            var ret = _target.OnStartup(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 exec_handle)
        {
            var ret = _target.OnShutdown(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnActivated(System.Int32 exec_handle)
        {
            var ret = _target.OnActivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 exec_handle)
        {
            var ret = _target.OnDeactivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnAborting(System.Int32 exec_handle)
        {
            var ret = _target.OnAborting(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnError(System.Int32 exec_handle)
        {
            var ret = _target.OnError(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnReset(System.Int32 exec_handle)
        {
            var ret = _target.OnReset(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IFsmParticipantAction
    {
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnAction(System.Int32 exec_handle);
    }

    public class FsmParticipantActionAdapter : MarshalByRefObject, global::omg.org.RTC.FsmParticipantAction
    {
        private IFsmParticipantAction _target;

        public FsmParticipantActionAdapter(IFsmParticipantAction target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ReturnCode_t OnAction(System.Int32 exec_handle)
        {
            var ret = _target.OnAction(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IFsmParticipant
    {
        ReactiveRTM.omg.org.RTC.ReturnCode_t Initialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Finalize();
        System.Boolean IsAlive(ReactiveRTM.omg.org.RTC.ExecutionContext exec_context);
        ReactiveRTM.omg.org.RTC.ReturnCode_t Exit();
        System.Int32 AttachContext(ReactiveRTM.omg.org.RTC.ExecutionContext exec_context);
        ReactiveRTM.omg.org.RTC.ReturnCode_t DetachContext(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ExecutionContextStub GetContext(System.Int32 exec_handle);
        List<ReactiveRTM.omg.org.RTC.ExecutionContextStub> GetOwnedContexts();
        List<ReactiveRTM.omg.org.RTC.ExecutionContextStub> GetParticipatingContexts();
        System.Int32 GetContextHandle(ReactiveRTM.omg.org.RTC.ExecutionContext cxt);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnInitialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnFinalize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnStartup(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnActivated(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnAborting(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnError(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnReset(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnAction(System.Int32 exec_handle);
    }

    public class FsmParticipantAdapter : MarshalByRefObject, global::omg.org.RTC.FsmParticipant
    {
        private IFsmParticipant _target;

        public FsmParticipantAdapter(IFsmParticipant target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ReturnCode_t Initialize()
        {
            var ret = _target.Initialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t Finalize()
        {
            var ret = _target.Finalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Boolean IsAlive(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.IsAlive(exec_context);
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t Exit()
        {
            var ret = _target.Exit();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Int32 AttachContext(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.AttachContext(exec_context);
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t DetachContext(System.Int32 exec_handle)
        {
            var ret = _target.DetachContext(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ExecutionContext GetContext(System.Int32 exec_handle)
        {
            var ret = _target.GetContext(exec_handle);
            return ((global::omg.org.RTC.ExecutionContext)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ExecutionContext[] GetOwnedContexts()
        {
            var ret = _target.GetOwnedContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ExecutionContext[] GetParticipatingContexts()
        {
            var ret = _target.GetParticipatingContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public System.Int32 GetContextHandle(global::omg.org.RTC.ExecutionContext cxt)
        {
            var ret = _target.GetContextHandle(cxt);
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnInitialize()
        {
            var ret = _target.OnInitialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnFinalize()
        {
            var ret = _target.OnFinalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnStartup(System.Int32 exec_handle)
        {
            var ret = _target.OnStartup(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 exec_handle)
        {
            var ret = _target.OnShutdown(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnActivated(System.Int32 exec_handle)
        {
            var ret = _target.OnActivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 exec_handle)
        {
            var ret = _target.OnDeactivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnAborting(System.Int32 exec_handle)
        {
            var ret = _target.OnAborting(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnError(System.Int32 exec_handle)
        {
            var ret = _target.OnError(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnReset(System.Int32 exec_handle)
        {
            var ret = _target.OnReset(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnAction(System.Int32 exec_handle)
        {
            var ret = _target.OnAction(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IMode
    {
    }

    public class ModeAdapter : MarshalByRefObject, global::omg.org.RTC.Mode
    {
        private IMode _target;

        public ModeAdapter(IMode target)
        {
            _target = target;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IModeCapable
    {
        ReactiveRTM.omg.org.RTC.ModeStub GetDefaultMode();
        ReactiveRTM.omg.org.RTC.ModeStub GetCurrentMode();
        ReactiveRTM.omg.org.RTC.ModeStub GetCurrentModeInContext(ReactiveRTM.omg.org.RTC.ExecutionContext exec_context);
        ReactiveRTM.omg.org.RTC.ModeStub GetPendingMode();
        ReactiveRTM.omg.org.RTC.ModeStub GetPendingModeInContext(ReactiveRTM.omg.org.RTC.ExecutionContext exec_context);
        ReactiveRTM.omg.org.RTC.ReturnCode_t SetMode(ReactiveRTM.omg.org.RTC.Mode new_mode,System.Boolean immediate);
    }

    public class ModeCapableAdapter : MarshalByRefObject, global::omg.org.RTC.ModeCapable
    {
        private IModeCapable _target;

        public ModeCapableAdapter(IModeCapable target)
        {
            _target = target;
        }
        public global::omg.org.RTC.Mode GetDefaultMode()
        {
            var ret = _target.GetDefaultMode();
            return ((global::omg.org.RTC.Mode)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.Mode GetCurrentMode()
        {
            var ret = _target.GetCurrentMode();
            return ((global::omg.org.RTC.Mode)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.Mode GetCurrentModeInContext(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.GetCurrentModeInContext(exec_context);
            return ((global::omg.org.RTC.Mode)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.Mode GetPendingMode()
        {
            var ret = _target.GetPendingMode();
            return ((global::omg.org.RTC.Mode)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.Mode GetPendingModeInContext(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.GetPendingModeInContext(exec_context);
            return ((global::omg.org.RTC.Mode)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ReturnCode_t SetMode(global::omg.org.RTC.Mode new_mode,System.Boolean immediate)
        {
            var ret = _target.SetMode(new_mode,immediate);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IMultiModeComponentAction
    {
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnModeChanged(System.Int32 exec_handle);
    }

    public class MultiModeComponentActionAdapter : MarshalByRefObject, global::omg.org.RTC.MultiModeComponentAction
    {
        private IMultiModeComponentAction _target;

        public MultiModeComponentActionAdapter(IMultiModeComponentAction target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ReturnCode_t OnModeChanged(System.Int32 exec_handle)
        {
            var ret = _target.OnModeChanged(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IMultiModeObject
    {
        ReactiveRTM.omg.org.RTC.ReturnCode_t Initialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Finalize();
        System.Boolean IsAlive(ReactiveRTM.omg.org.RTC.ExecutionContext exec_context);
        ReactiveRTM.omg.org.RTC.ReturnCode_t Exit();
        System.Int32 AttachContext(ReactiveRTM.omg.org.RTC.ExecutionContext exec_context);
        ReactiveRTM.omg.org.RTC.ReturnCode_t DetachContext(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ExecutionContextStub GetContext(System.Int32 exec_handle);
        List<ReactiveRTM.omg.org.RTC.ExecutionContextStub> GetOwnedContexts();
        List<ReactiveRTM.omg.org.RTC.ExecutionContextStub> GetParticipatingContexts();
        System.Int32 GetContextHandle(ReactiveRTM.omg.org.RTC.ExecutionContext cxt);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnInitialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnFinalize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnStartup(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnActivated(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnAborting(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnError(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnReset(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ModeStub GetDefaultMode();
        ReactiveRTM.omg.org.RTC.ModeStub GetCurrentMode();
        ReactiveRTM.omg.org.RTC.ModeStub GetCurrentModeInContext(ReactiveRTM.omg.org.RTC.ExecutionContext exec_context);
        ReactiveRTM.omg.org.RTC.ModeStub GetPendingMode();
        ReactiveRTM.omg.org.RTC.ModeStub GetPendingModeInContext(ReactiveRTM.omg.org.RTC.ExecutionContext exec_context);
        ReactiveRTM.omg.org.RTC.ReturnCode_t SetMode(ReactiveRTM.omg.org.RTC.Mode new_mode,System.Boolean immediate);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnModeChanged(System.Int32 exec_handle);
    }

    public class MultiModeObjectAdapter : MarshalByRefObject, global::omg.org.RTC.MultiModeObject
    {
        private IMultiModeObject _target;

        public MultiModeObjectAdapter(IMultiModeObject target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ReturnCode_t Initialize()
        {
            var ret = _target.Initialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t Finalize()
        {
            var ret = _target.Finalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Boolean IsAlive(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.IsAlive(exec_context);
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t Exit()
        {
            var ret = _target.Exit();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Int32 AttachContext(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.AttachContext(exec_context);
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t DetachContext(System.Int32 exec_handle)
        {
            var ret = _target.DetachContext(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ExecutionContext GetContext(System.Int32 exec_handle)
        {
            var ret = _target.GetContext(exec_handle);
            return ((global::omg.org.RTC.ExecutionContext)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ExecutionContext[] GetOwnedContexts()
        {
            var ret = _target.GetOwnedContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ExecutionContext[] GetParticipatingContexts()
        {
            var ret = _target.GetParticipatingContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public System.Int32 GetContextHandle(global::omg.org.RTC.ExecutionContext cxt)
        {
            var ret = _target.GetContextHandle(cxt);
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnInitialize()
        {
            var ret = _target.OnInitialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnFinalize()
        {
            var ret = _target.OnFinalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnStartup(System.Int32 exec_handle)
        {
            var ret = _target.OnStartup(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 exec_handle)
        {
            var ret = _target.OnShutdown(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnActivated(System.Int32 exec_handle)
        {
            var ret = _target.OnActivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 exec_handle)
        {
            var ret = _target.OnDeactivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnAborting(System.Int32 exec_handle)
        {
            var ret = _target.OnAborting(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnError(System.Int32 exec_handle)
        {
            var ret = _target.OnError(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnReset(System.Int32 exec_handle)
        {
            var ret = _target.OnReset(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.Mode GetDefaultMode()
        {
            var ret = _target.GetDefaultMode();
            return ((global::omg.org.RTC.Mode)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.Mode GetCurrentMode()
        {
            var ret = _target.GetCurrentMode();
            return ((global::omg.org.RTC.Mode)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.Mode GetCurrentModeInContext(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.GetCurrentModeInContext(exec_context);
            return ((global::omg.org.RTC.Mode)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.Mode GetPendingMode()
        {
            var ret = _target.GetPendingMode();
            return ((global::omg.org.RTC.Mode)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.Mode GetPendingModeInContext(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.GetPendingModeInContext(exec_context);
            return ((global::omg.org.RTC.Mode)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ReturnCode_t SetMode(global::omg.org.RTC.Mode new_mode,System.Boolean immediate)
        {
            var ret = _target.SetMode(new_mode,immediate);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnModeChanged(System.Int32 exec_handle)
        {
            var ret = _target.OnModeChanged(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IRTObject
    {
        ReactiveRTM.omg.org.RTC.ComponentProfile GetComponentProfile();
        List<ReactiveRTM.omg.org.RTC.PortServiceStub> GetPorts();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Initialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Finalize();
        System.Boolean IsAlive(ReactiveRTM.omg.org.RTC.ExecutionContext exec_context);
        ReactiveRTM.omg.org.RTC.ReturnCode_t Exit();
        System.Int32 AttachContext(ReactiveRTM.omg.org.RTC.ExecutionContext exec_context);
        ReactiveRTM.omg.org.RTC.ReturnCode_t DetachContext(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ExecutionContextStub GetContext(System.Int32 exec_handle);
        List<ReactiveRTM.omg.org.RTC.ExecutionContextStub> GetOwnedContexts();
        List<ReactiveRTM.omg.org.RTC.ExecutionContextStub> GetParticipatingContexts();
        System.Int32 GetContextHandle(ReactiveRTM.omg.org.RTC.ExecutionContext cxt);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnInitialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnFinalize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnStartup(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnActivated(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnAborting(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnError(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnReset(System.Int32 exec_handle);
        System.String GetSdoId();
        System.String GetSdoType();
        ReactiveRTM.org.omg.SDOPackage.DeviceProfile GetDeviceProfile();
        List<ReactiveRTM.org.omg.SDOPackage.ServiceProfile> GetServiceProfiles();
        ReactiveRTM.org.omg.SDOPackage.ServiceProfile GetServiceProfile(System.String id);
        ReactiveRTM.org.omg.SDOPackage.SDOServiceStub GetSdoService(System.String id);
        ReactiveRTM.org.omg.SDOPackage.ConfigurationStub GetConfiguration();
        ReactiveRTM.org.omg.SDOPackage.MonitoringStub GetMonitoring();
        List<ReactiveRTM.org.omg.SDOPackage.OrganizationStub> GetOrganizations();
        List<ReactiveRTM.org.omg.SDOPackage.NameValue> GetStatusList();
        System.Object GetStatus(System.String nme);
        List<ReactiveRTM.org.omg.SDOPackage.OrganizationStub> GetOwnedOrganizations();
    }

    public class RTObjectAdapter : MarshalByRefObject, global::omg.org.RTC.RTObject
    {
        private IRTObject _target;

        public RTObjectAdapter(IRTObject target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ComponentProfile GetComponentProfile()
        {
            var ret = _target.GetComponentProfile();
            return ((global::omg.org.RTC.ComponentProfile)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.PortService[] GetPorts()
        {
            var ret = _target.GetPorts();
            return ret.Select(x=>((global::omg.org.RTC.PortService)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ReturnCode_t Initialize()
        {
            var ret = _target.Initialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t Finalize()
        {
            var ret = _target.Finalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Boolean IsAlive(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.IsAlive(exec_context);
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t Exit()
        {
            var ret = _target.Exit();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Int32 AttachContext(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.AttachContext(exec_context);
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t DetachContext(System.Int32 exec_handle)
        {
            var ret = _target.DetachContext(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ExecutionContext GetContext(System.Int32 exec_handle)
        {
            var ret = _target.GetContext(exec_handle);
            return ((global::omg.org.RTC.ExecutionContext)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ExecutionContext[] GetOwnedContexts()
        {
            var ret = _target.GetOwnedContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ExecutionContext[] GetParticipatingContexts()
        {
            var ret = _target.GetParticipatingContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public System.Int32 GetContextHandle(global::omg.org.RTC.ExecutionContext cxt)
        {
            var ret = _target.GetContextHandle(cxt);
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnInitialize()
        {
            var ret = _target.OnInitialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnFinalize()
        {
            var ret = _target.OnFinalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnStartup(System.Int32 exec_handle)
        {
            var ret = _target.OnStartup(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 exec_handle)
        {
            var ret = _target.OnShutdown(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnActivated(System.Int32 exec_handle)
        {
            var ret = _target.OnActivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 exec_handle)
        {
            var ret = _target.OnDeactivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnAborting(System.Int32 exec_handle)
        {
            var ret = _target.OnAborting(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnError(System.Int32 exec_handle)
        {
            var ret = _target.OnError(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnReset(System.Int32 exec_handle)
        {
            var ret = _target.OnReset(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.String GetSdoId()
        {
            var ret = _target.GetSdoId();
            return ret;
        }
        public System.String GetSdoType()
        {
            var ret = _target.GetSdoType();
            return ret;
        }
        public global::org.omg.SDOPackage.DeviceProfile GetDeviceProfile()
        {
            var ret = _target.GetDeviceProfile();
            return ((global::org.omg.SDOPackage.DeviceProfile)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.ServiceProfile[] GetServiceProfiles()
        {
            var ret = _target.GetServiceProfiles();
            return ret.Select(x=>((global::org.omg.SDOPackage.ServiceProfile)((IStub)x).GetTarget())).ToArray();
        }
        public global::org.omg.SDOPackage.ServiceProfile GetServiceProfile(System.String id)
        {
            var ret = _target.GetServiceProfile(id);
            return ((global::org.omg.SDOPackage.ServiceProfile)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.SDOService GetSdoService(System.String id)
        {
            var ret = _target.GetSdoService(id);
            return ((global::org.omg.SDOPackage.SDOService)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.Configuration GetConfiguration()
        {
            var ret = _target.GetConfiguration();
            return ((global::org.omg.SDOPackage.Configuration)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.Monitoring GetMonitoring()
        {
            var ret = _target.GetMonitoring();
            return ((global::org.omg.SDOPackage.Monitoring)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.Organization[] GetOrganizations()
        {
            var ret = _target.GetOrganizations();
            return ret.Select(x=>((global::org.omg.SDOPackage.Organization)((IStub)x).GetTarget())).ToArray();
        }
        public global::org.omg.SDOPackage.NameValue[] GetStatusList()
        {
            var ret = _target.GetStatusList();
            return ret.Select(x=>((global::org.omg.SDOPackage.NameValue)((IStub)x).GetTarget())).ToArray();
        }
        public global::System.Object GetStatus(System.String nme)
        {
            var ret = _target.GetStatus(nme);
            return (global::System.Object)ret;
        }
        public global::org.omg.SDOPackage.Organization[] GetOwnedOrganizations()
        {
            var ret = _target.GetOwnedOrganizations();
            return ret.Select(x=>((global::org.omg.SDOPackage.Organization)((IStub)x).GetTarget())).ToArray();
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IPortService
    {
        ReactiveRTM.omg.org.RTC.PortProfile GetPortProfile();
        List<ReactiveRTM.omg.org.RTC.ConnectorProfile> GetConnectorProfiles();
        ReactiveRTM.omg.org.RTC.ConnectorProfile GetConnectorProfile(System.String connector_id);
        ReactiveRTM.omg.org.RTC.ReturnCode_t Connect(ReactiveRTM.omg.org.RTC.ConnectorProfile connector_profile);
        ReactiveRTM.omg.org.RTC.ReturnCode_t Disconnect(System.String connector_id);
        ReactiveRTM.omg.org.RTC.ReturnCode_t DisconnectAll();
        ReactiveRTM.omg.org.RTC.ReturnCode_t NotifyConnect(ReactiveRTM.omg.org.RTC.ConnectorProfile connector_profile);
        ReactiveRTM.omg.org.RTC.ReturnCode_t NotifyDisconnect(System.String connector_id);
    }

    public class PortServiceAdapter : MarshalByRefObject, global::omg.org.RTC.PortService
    {
        private IPortService _target;

        public PortServiceAdapter(IPortService target)
        {
            _target = target;
        }
        public global::omg.org.RTC.PortProfile GetPortProfile()
        {
            var ret = _target.GetPortProfile();
            return ((global::omg.org.RTC.PortProfile)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ConnectorProfile[] GetConnectorProfiles()
        {
            var ret = _target.GetConnectorProfiles();
            return ret.Select(x=>((global::omg.org.RTC.ConnectorProfile)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ConnectorProfile GetConnectorProfile(System.String connector_id)
        {
            var ret = _target.GetConnectorProfile(connector_id);
            return ((global::omg.org.RTC.ConnectorProfile)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ReturnCode_t Connect(global::omg.org.RTC.ConnectorProfile connector_profile)
        {
 
            var tmpconnector_profile = new ReactiveRTM.omg.org.RTC.ConnectorProfile(connector_profile);
            var ret = _target.Connect(ref tmpconnector_profile);
 
            connector_profile = ((global::omg.org.RTC.ConnectorProfile)((IStub)tmpconnector_profile).GetTarget());
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t Disconnect(System.String connector_id)
        {
            var ret = _target.Disconnect(connector_id);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t DisconnectAll()
        {
            var ret = _target.DisconnectAll();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t NotifyConnect(global::omg.org.RTC.ConnectorProfile connector_profile)
        {
 
            var tmpconnector_profile = new ReactiveRTM.omg.org.RTC.ConnectorProfile(connector_profile);
            var ret = _target.NotifyConnect(ref tmpconnector_profile);
 
            connector_profile = ((global::omg.org.RTC.ConnectorProfile)((IStub)tmpconnector_profile).GetTarget());
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t NotifyDisconnect(System.String connector_id)
        {
            var ret = _target.NotifyDisconnect(connector_id);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IFsmObject
    {
        ReactiveRTM.omg.org.RTC.ReturnCode_t SendStimulus(System.String message,System.Int32 exec_handle);
    }

    public class FsmObjectAdapter : MarshalByRefObject, global::omg.org.RTC.FsmObject
    {
        private IFsmObject _target;

        public FsmObjectAdapter(IFsmObject target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ReturnCode_t SendStimulus(System.String message,System.Int32 exec_handle)
        {
            var ret = _target.SendStimulus(message,exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IFsmService
    {
        ReactiveRTM.omg.org.RTC.FsmProfile GetFsmProfile();
        ReactiveRTM.omg.org.RTC.ReturnCode_t SetFsmProfile(ReactiveRTM.omg.org.RTC.FsmProfile fsm_profile);
    }

    public class FsmServiceAdapter : MarshalByRefObject, global::omg.org.RTC.FsmService
    {
        private IFsmService _target;

        public FsmServiceAdapter(IFsmService target)
        {
            _target = target;
        }
        public global::omg.org.RTC.FsmProfile GetFsmProfile()
        {
            var ret = _target.GetFsmProfile();
            return ((global::omg.org.RTC.FsmProfile)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ReturnCode_t SetFsmProfile(global::omg.org.RTC.FsmProfile fsm_profile)
        {
            var ret = _target.SetFsmProfile(fsm_profile);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IExecutionContextService
    {
        ReactiveRTM.omg.org.RTC.ExecutionContextProfile GetProfile();
        System.Boolean IsRunning();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Start();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Stop();
        System.Double GetRate();
        ReactiveRTM.omg.org.RTC.ReturnCode_t SetRate(System.Double rate);
        ReactiveRTM.omg.org.RTC.ReturnCode_t AddComponent(ReactiveRTM.omg.org.RTC.LightweightRTObject comp);
        ReactiveRTM.omg.org.RTC.ReturnCode_t RemoveComponent(ReactiveRTM.omg.org.RTC.LightweightRTObject comp);
        ReactiveRTM.omg.org.RTC.ReturnCode_t ActivateComponent(ReactiveRTM.omg.org.RTC.LightweightRTObject comp);
        ReactiveRTM.omg.org.RTC.ReturnCode_t DeactivateComponent(ReactiveRTM.omg.org.RTC.LightweightRTObject comp);
        ReactiveRTM.omg.org.RTC.ReturnCode_t ResetComponent(ReactiveRTM.omg.org.RTC.LightweightRTObject comp);
        ReactiveRTM.omg.org.RTC.LifeCycleState GetComponentState(ReactiveRTM.omg.org.RTC.LightweightRTObject comp);
        ReactiveRTM.omg.org.RTC.ExecutionKind GetKind();
    }

    public class ExecutionContextServiceAdapter : MarshalByRefObject, global::omg.org.RTC.ExecutionContextService
    {
        private IExecutionContextService _target;

        public ExecutionContextServiceAdapter(IExecutionContextService target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ExecutionContextProfile GetProfile()
        {
            var ret = _target.GetProfile();
            return ((global::omg.org.RTC.ExecutionContextProfile)((IStub)ret).GetTarget());
        }
        public System.Boolean IsRunning()
        {
            var ret = _target.IsRunning();
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t Start()
        {
            var ret = _target.Start();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t Stop()
        {
            var ret = _target.Stop();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Double GetRate()
        {
            var ret = _target.GetRate();
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t SetRate(System.Double rate)
        {
            var ret = _target.SetRate(rate);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t AddComponent(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.AddComponent(comp);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t RemoveComponent(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.RemoveComponent(comp);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t ActivateComponent(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.ActivateComponent(comp);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t DeactivateComponent(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.DeactivateComponent(comp);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t ResetComponent(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.ResetComponent(comp);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.LifeCycleState GetComponentState(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.GetComponentState(comp);
            return (global::omg.org.RTC.LifeCycleState)ret;
        }
        public global::omg.org.RTC.ExecutionKind GetKind()
        {
            var ret = _target.GetKind();
            return (global::omg.org.RTC.ExecutionKind)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}
 
namespace ReactiveRTM.OpenRTM
{
    public interface IComponentObserver
    {
        void UpdateStatus(ReactiveRTM.OpenRTM.StatusKind status_kind,System.String hint);
    }

    public class ComponentObserverAdapter : MarshalByRefObject, global::OpenRTM.ComponentObserver
    {
        private IComponentObserver _target;

        public ComponentObserverAdapter(IComponentObserver target)
        {
            _target = target;
        }
        public void UpdateStatus(global::OpenRTM.StatusKind status_kind,System.String hint)
        {
            _target.UpdateStatus(status_kind,hint);
            return;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IInPortCdr
    {
        ReactiveRTM.OpenRTM.PortStatus Put(ReactiveRTM.System.Byte[] data);
    }

    public class InPortCdrAdapter : MarshalByRefObject, global::OpenRTM.InPortCdr
    {
        private IInPortCdr _target;

        public InPortCdrAdapter(IInPortCdr target)
        {
            _target = target;
        }
        public global::OpenRTM.PortStatus Put(global::System.Byte[] data)
        {
            var ret = _target.Put(data);
            return (global::OpenRTM.PortStatus)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IOutPortCdr
    {
        ReactiveRTM.OpenRTM.PortStatus Get(ReactiveRTM.System.Byte[] data);
    }

    public class OutPortCdrAdapter : MarshalByRefObject, global::OpenRTM.OutPortCdr
    {
        private IOutPortCdr _target;

        public OutPortCdrAdapter(IOutPortCdr target)
        {
            _target = target;
        }
        public global::OpenRTM.PortStatus Get(global::System.Byte[] data)
        {
 
            var tmpdata = data.Select(x=>x).ToList();
            var ret = _target.Get(out tmpdata);
 
            data = tmpdata.Select(x=>x).ToArray();
            return (global::OpenRTM.PortStatus)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface ILogger
    {
        void Publish(ReactiveRTM.OpenRTM.LogRecord record);
        void Close();
    }

    public class LoggerAdapter : MarshalByRefObject, global::OpenRTM.Logger
    {
        private ILogger _target;

        public LoggerAdapter(ILogger target)
        {
            _target = target;
        }
        public void Publish(global::OpenRTM.LogRecord record)
        {
            _target.Publish(record);
            return;
        }
        public void Close()
        {
            _target.Close();
            return;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}
 
namespace ReactiveRTM.openrtm.aist.go.jp.OpenRTM
{
    public interface IDataFlowComponent
    {
        ReactiveRTM.omg.org.RTC.ComponentProfile GetComponentProfile();
        List<ReactiveRTM.omg.org.RTC.PortServiceStub> GetPorts();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Initialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Finalize();
        System.Boolean IsAlive(ReactiveRTM.omg.org.RTC.ExecutionContext exec_context);
        ReactiveRTM.omg.org.RTC.ReturnCode_t Exit();
        System.Int32 AttachContext(ReactiveRTM.omg.org.RTC.ExecutionContext exec_context);
        ReactiveRTM.omg.org.RTC.ReturnCode_t DetachContext(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ExecutionContextStub GetContext(System.Int32 exec_handle);
        List<ReactiveRTM.omg.org.RTC.ExecutionContextStub> GetOwnedContexts();
        List<ReactiveRTM.omg.org.RTC.ExecutionContextStub> GetParticipatingContexts();
        System.Int32 GetContextHandle(ReactiveRTM.omg.org.RTC.ExecutionContext cxt);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnInitialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnFinalize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnStartup(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnActivated(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnAborting(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnError(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnReset(System.Int32 exec_handle);
        System.String GetSdoId();
        System.String GetSdoType();
        ReactiveRTM.org.omg.SDOPackage.DeviceProfile GetDeviceProfile();
        List<ReactiveRTM.org.omg.SDOPackage.ServiceProfile> GetServiceProfiles();
        ReactiveRTM.org.omg.SDOPackage.ServiceProfile GetServiceProfile(System.String id);
        ReactiveRTM.org.omg.SDOPackage.SDOServiceStub GetSdoService(System.String id);
        ReactiveRTM.org.omg.SDOPackage.ConfigurationStub GetConfiguration();
        ReactiveRTM.org.omg.SDOPackage.MonitoringStub GetMonitoring();
        List<ReactiveRTM.org.omg.SDOPackage.OrganizationStub> GetOrganizations();
        List<ReactiveRTM.org.omg.SDOPackage.NameValue> GetStatusList();
        System.Object GetStatus(System.String nme);
        List<ReactiveRTM.org.omg.SDOPackage.OrganizationStub> GetOwnedOrganizations();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnExecute(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnStateUpdate(System.Int32 exec_handle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnRateChanged(System.Int32 exec_handle);
    }

    public class DataFlowComponentAdapter : MarshalByRefObject, global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent
    {
        private IDataFlowComponent _target;

        public DataFlowComponentAdapter(IDataFlowComponent target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ComponentProfile GetComponentProfile()
        {
            var ret = _target.GetComponentProfile();
            return ((global::omg.org.RTC.ComponentProfile)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.PortService[] GetPorts()
        {
            var ret = _target.GetPorts();
            return ret.Select(x=>((global::omg.org.RTC.PortService)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ReturnCode_t Initialize()
        {
            var ret = _target.Initialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t Finalize()
        {
            var ret = _target.Finalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Boolean IsAlive(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.IsAlive(exec_context);
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t Exit()
        {
            var ret = _target.Exit();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Int32 AttachContext(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.AttachContext(exec_context);
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t DetachContext(System.Int32 exec_handle)
        {
            var ret = _target.DetachContext(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ExecutionContext GetContext(System.Int32 exec_handle)
        {
            var ret = _target.GetContext(exec_handle);
            return ((global::omg.org.RTC.ExecutionContext)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ExecutionContext[] GetOwnedContexts()
        {
            var ret = _target.GetOwnedContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ExecutionContext[] GetParticipatingContexts()
        {
            var ret = _target.GetParticipatingContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public System.Int32 GetContextHandle(global::omg.org.RTC.ExecutionContext cxt)
        {
            var ret = _target.GetContextHandle(cxt);
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnInitialize()
        {
            var ret = _target.OnInitialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnFinalize()
        {
            var ret = _target.OnFinalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnStartup(System.Int32 exec_handle)
        {
            var ret = _target.OnStartup(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 exec_handle)
        {
            var ret = _target.OnShutdown(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnActivated(System.Int32 exec_handle)
        {
            var ret = _target.OnActivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 exec_handle)
        {
            var ret = _target.OnDeactivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnAborting(System.Int32 exec_handle)
        {
            var ret = _target.OnAborting(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnError(System.Int32 exec_handle)
        {
            var ret = _target.OnError(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnReset(System.Int32 exec_handle)
        {
            var ret = _target.OnReset(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.String GetSdoId()
        {
            var ret = _target.GetSdoId();
            return ret;
        }
        public System.String GetSdoType()
        {
            var ret = _target.GetSdoType();
            return ret;
        }
        public global::org.omg.SDOPackage.DeviceProfile GetDeviceProfile()
        {
            var ret = _target.GetDeviceProfile();
            return ((global::org.omg.SDOPackage.DeviceProfile)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.ServiceProfile[] GetServiceProfiles()
        {
            var ret = _target.GetServiceProfiles();
            return ret.Select(x=>((global::org.omg.SDOPackage.ServiceProfile)((IStub)x).GetTarget())).ToArray();
        }
        public global::org.omg.SDOPackage.ServiceProfile GetServiceProfile(System.String id)
        {
            var ret = _target.GetServiceProfile(id);
            return ((global::org.omg.SDOPackage.ServiceProfile)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.SDOService GetSdoService(System.String id)
        {
            var ret = _target.GetSdoService(id);
            return ((global::org.omg.SDOPackage.SDOService)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.Configuration GetConfiguration()
        {
            var ret = _target.GetConfiguration();
            return ((global::org.omg.SDOPackage.Configuration)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.Monitoring GetMonitoring()
        {
            var ret = _target.GetMonitoring();
            return ((global::org.omg.SDOPackage.Monitoring)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.Organization[] GetOrganizations()
        {
            var ret = _target.GetOrganizations();
            return ret.Select(x=>((global::org.omg.SDOPackage.Organization)((IStub)x).GetTarget())).ToArray();
        }
        public global::org.omg.SDOPackage.NameValue[] GetStatusList()
        {
            var ret = _target.GetStatusList();
            return ret.Select(x=>((global::org.omg.SDOPackage.NameValue)((IStub)x).GetTarget())).ToArray();
        }
        public global::System.Object GetStatus(System.String nme)
        {
            var ret = _target.GetStatus(nme);
            return (global::System.Object)ret;
        }
        public global::org.omg.SDOPackage.Organization[] GetOwnedOrganizations()
        {
            var ret = _target.GetOwnedOrganizations();
            return ret.Select(x=>((global::org.omg.SDOPackage.Organization)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ReturnCode_t OnExecute(System.Int32 exec_handle)
        {
            var ret = _target.OnExecute(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnStateUpdate(System.Int32 exec_handle)
        {
            var ret = _target.OnStateUpdate(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t OnRateChanged(System.Int32 exec_handle)
        {
            var ret = _target.OnRateChanged(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IExtTrigExecutionContextService
    {
        void Tick();
        ReactiveRTM.omg.org.RTC.ExecutionContextProfile GetProfile();
        System.Boolean IsRunning();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Start();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Stop();
        System.Double GetRate();
        ReactiveRTM.omg.org.RTC.ReturnCode_t SetRate(System.Double rate);
        ReactiveRTM.omg.org.RTC.ReturnCode_t AddComponent(ReactiveRTM.omg.org.RTC.LightweightRTObject comp);
        ReactiveRTM.omg.org.RTC.ReturnCode_t RemoveComponent(ReactiveRTM.omg.org.RTC.LightweightRTObject comp);
        ReactiveRTM.omg.org.RTC.ReturnCode_t ActivateComponent(ReactiveRTM.omg.org.RTC.LightweightRTObject comp);
        ReactiveRTM.omg.org.RTC.ReturnCode_t DeactivateComponent(ReactiveRTM.omg.org.RTC.LightweightRTObject comp);
        ReactiveRTM.omg.org.RTC.ReturnCode_t ResetComponent(ReactiveRTM.omg.org.RTC.LightweightRTObject comp);
        ReactiveRTM.omg.org.RTC.LifeCycleState GetComponentState(ReactiveRTM.omg.org.RTC.LightweightRTObject comp);
        ReactiveRTM.omg.org.RTC.ExecutionKind GetKind();
    }

    public class ExtTrigExecutionContextServiceAdapter : MarshalByRefObject, global::openrtm.aist.go.jp.OpenRTM.ExtTrigExecutionContextService
    {
        private IExtTrigExecutionContextService _target;

        public ExtTrigExecutionContextServiceAdapter(IExtTrigExecutionContextService target)
        {
            _target = target;
        }
        public void Tick()
        {
            _target.Tick();
            return;
        }
        public global::omg.org.RTC.ExecutionContextProfile GetProfile()
        {
            var ret = _target.GetProfile();
            return ((global::omg.org.RTC.ExecutionContextProfile)((IStub)ret).GetTarget());
        }
        public System.Boolean IsRunning()
        {
            var ret = _target.IsRunning();
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t Start()
        {
            var ret = _target.Start();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t Stop()
        {
            var ret = _target.Stop();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Double GetRate()
        {
            var ret = _target.GetRate();
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t SetRate(System.Double rate)
        {
            var ret = _target.SetRate(rate);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t AddComponent(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.AddComponent(comp);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t RemoveComponent(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.RemoveComponent(comp);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t ActivateComponent(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.ActivateComponent(comp);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t DeactivateComponent(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.DeactivateComponent(comp);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t ResetComponent(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.ResetComponent(comp);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.LifeCycleState GetComponentState(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.GetComponentState(comp);
            return (global::omg.org.RTC.LifeCycleState)ret;
        }
        public global::omg.org.RTC.ExecutionKind GetKind()
        {
            var ret = _target.GetKind();
            return (global::omg.org.RTC.ExecutionKind)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}
 
namespace ReactiveRTM.org.omg.SDOPackage
{
    public interface ISDO
    {
        System.String GetSdoId();
        System.String GetSdoType();
        ReactiveRTM.org.omg.SDOPackage.DeviceProfile GetDeviceProfile();
        List<ReactiveRTM.org.omg.SDOPackage.ServiceProfile> GetServiceProfiles();
        ReactiveRTM.org.omg.SDOPackage.ServiceProfile GetServiceProfile(System.String id);
        ReactiveRTM.org.omg.SDOPackage.SDOServiceStub GetSdoService(System.String id);
        ReactiveRTM.org.omg.SDOPackage.ConfigurationStub GetConfiguration();
        ReactiveRTM.org.omg.SDOPackage.MonitoringStub GetMonitoring();
        List<ReactiveRTM.org.omg.SDOPackage.OrganizationStub> GetOrganizations();
        List<ReactiveRTM.org.omg.SDOPackage.NameValue> GetStatusList();
        System.Object GetStatus(System.String nme);
        List<ReactiveRTM.org.omg.SDOPackage.OrganizationStub> GetOwnedOrganizations();
    }

    public class SDOAdapter : MarshalByRefObject, global::org.omg.SDOPackage.SDO
    {
        private ISDO _target;

        public SDOAdapter(ISDO target)
        {
            _target = target;
        }
        public System.String GetSdoId()
        {
            var ret = _target.GetSdoId();
            return ret;
        }
        public System.String GetSdoType()
        {
            var ret = _target.GetSdoType();
            return ret;
        }
        public global::org.omg.SDOPackage.DeviceProfile GetDeviceProfile()
        {
            var ret = _target.GetDeviceProfile();
            return ((global::org.omg.SDOPackage.DeviceProfile)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.ServiceProfile[] GetServiceProfiles()
        {
            var ret = _target.GetServiceProfiles();
            return ret.Select(x=>((global::org.omg.SDOPackage.ServiceProfile)((IStub)x).GetTarget())).ToArray();
        }
        public global::org.omg.SDOPackage.ServiceProfile GetServiceProfile(System.String id)
        {
            var ret = _target.GetServiceProfile(id);
            return ((global::org.omg.SDOPackage.ServiceProfile)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.SDOService GetSdoService(System.String id)
        {
            var ret = _target.GetSdoService(id);
            return ((global::org.omg.SDOPackage.SDOService)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.Configuration GetConfiguration()
        {
            var ret = _target.GetConfiguration();
            return ((global::org.omg.SDOPackage.Configuration)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.Monitoring GetMonitoring()
        {
            var ret = _target.GetMonitoring();
            return ((global::org.omg.SDOPackage.Monitoring)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.Organization[] GetOrganizations()
        {
            var ret = _target.GetOrganizations();
            return ret.Select(x=>((global::org.omg.SDOPackage.Organization)((IStub)x).GetTarget())).ToArray();
        }
        public global::org.omg.SDOPackage.NameValue[] GetStatusList()
        {
            var ret = _target.GetStatusList();
            return ret.Select(x=>((global::org.omg.SDOPackage.NameValue)((IStub)x).GetTarget())).ToArray();
        }
        public global::System.Object GetStatus(System.String nme)
        {
            var ret = _target.GetStatus(nme);
            return (global::System.Object)ret;
        }
        public global::org.omg.SDOPackage.Organization[] GetOwnedOrganizations()
        {
            var ret = _target.GetOwnedOrganizations();
            return ret.Select(x=>((global::org.omg.SDOPackage.Organization)((IStub)x).GetTarget())).ToArray();
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface ISDOService
    {
    }

    public class SDOServiceAdapter : MarshalByRefObject, global::org.omg.SDOPackage.SDOService
    {
        private ISDOService _target;

        public SDOServiceAdapter(ISDOService target)
        {
            _target = target;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface ISDOSystemElement
    {
        List<ReactiveRTM.org.omg.SDOPackage.OrganizationStub> GetOwnedOrganizations();
    }

    public class SDOSystemElementAdapter : MarshalByRefObject, global::org.omg.SDOPackage.SDOSystemElement
    {
        private ISDOSystemElement _target;

        public SDOSystemElementAdapter(ISDOSystemElement target)
        {
            _target = target;
        }
        public global::org.omg.SDOPackage.Organization[] GetOwnedOrganizations()
        {
            var ret = _target.GetOwnedOrganizations();
            return ret.Select(x=>((global::org.omg.SDOPackage.Organization)((IStub)x).GetTarget())).ToArray();
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IConfiguration
    {
        System.Boolean SetDeviceProfile(ReactiveRTM.org.omg.SDOPackage.DeviceProfile dProfile);
        System.Boolean AddServiceProfile(ReactiveRTM.org.omg.SDOPackage.ServiceProfile sProfile);
        System.Boolean AddOrganization(ReactiveRTM.org.omg.SDOPackage.Organization organization_object);
        System.Boolean RemoveServiceProfile(System.String id);
        System.Boolean RemoveOrganization(System.String organization_id);
        List<ReactiveRTM.org.omg.SDOPackage.Parameter> GetConfigurationParameters();
        List<ReactiveRTM.org.omg.SDOPackage.NameValue> GetConfigurationParameterValues();
        System.Object GetConfigurationParameterValue(System.String name);
        System.Boolean SetConfigurationParameter(System.String name,ReactiveRTM.System.Object value);
        List<ReactiveRTM.org.omg.SDOPackage.ConfigurationSet> GetConfigurationSets();
        ReactiveRTM.org.omg.SDOPackage.ConfigurationSet GetConfigurationSet(System.String config_id);
        System.Boolean SetConfigurationSetValues(ReactiveRTM.org.omg.SDOPackage.ConfigurationSet configuration_set);
        ReactiveRTM.org.omg.SDOPackage.ConfigurationSet GetActiveConfigurationSet();
        System.Boolean AddConfigurationSet(ReactiveRTM.org.omg.SDOPackage.ConfigurationSet configuration_set);
        System.Boolean RemoveConfigurationSet(System.String config_id);
        System.Boolean ActivateConfigurationSet(System.String config_id);
    }

    public class ConfigurationAdapter : MarshalByRefObject, global::org.omg.SDOPackage.Configuration
    {
        private IConfiguration _target;

        public ConfigurationAdapter(IConfiguration target)
        {
            _target = target;
        }
        public System.Boolean SetDeviceProfile(global::org.omg.SDOPackage.DeviceProfile dProfile)
        {
            var ret = _target.SetDeviceProfile(dProfile);
            return ret;
        }
        public System.Boolean AddServiceProfile(global::org.omg.SDOPackage.ServiceProfile sProfile)
        {
            var ret = _target.AddServiceProfile(sProfile);
            return ret;
        }
        public System.Boolean AddOrganization(global::org.omg.SDOPackage.Organization organization_object)
        {
            var ret = _target.AddOrganization(organization_object);
            return ret;
        }
        public System.Boolean RemoveServiceProfile(System.String id)
        {
            var ret = _target.RemoveServiceProfile(id);
            return ret;
        }
        public System.Boolean RemoveOrganization(System.String organization_id)
        {
            var ret = _target.RemoveOrganization(organization_id);
            return ret;
        }
        public global::org.omg.SDOPackage.Parameter[] GetConfigurationParameters()
        {
            var ret = _target.GetConfigurationParameters();
            return ret.Select(x=>((global::org.omg.SDOPackage.Parameter)((IStub)x).GetTarget())).ToArray();
        }
        public global::org.omg.SDOPackage.NameValue[] GetConfigurationParameterValues()
        {
            var ret = _target.GetConfigurationParameterValues();
            return ret.Select(x=>((global::org.omg.SDOPackage.NameValue)((IStub)x).GetTarget())).ToArray();
        }
        public global::System.Object GetConfigurationParameterValue(System.String name)
        {
            var ret = _target.GetConfigurationParameterValue(name);
            return (global::System.Object)ret;
        }
        public System.Boolean SetConfigurationParameter(System.String name,global::System.Object value)
        {
            var ret = _target.SetConfigurationParameter(name,value);
            return ret;
        }
        public global::org.omg.SDOPackage.ConfigurationSet[] GetConfigurationSets()
        {
            var ret = _target.GetConfigurationSets();
            return ret.Select(x=>((global::org.omg.SDOPackage.ConfigurationSet)((IStub)x).GetTarget())).ToArray();
        }
        public global::org.omg.SDOPackage.ConfigurationSet GetConfigurationSet(System.String config_id)
        {
            var ret = _target.GetConfigurationSet(config_id);
            return ((global::org.omg.SDOPackage.ConfigurationSet)((IStub)ret).GetTarget());
        }
        public System.Boolean SetConfigurationSetValues(global::org.omg.SDOPackage.ConfigurationSet configuration_set)
        {
            var ret = _target.SetConfigurationSetValues(configuration_set);
            return ret;
        }
        public global::org.omg.SDOPackage.ConfigurationSet GetActiveConfigurationSet()
        {
            var ret = _target.GetActiveConfigurationSet();
            return ((global::org.omg.SDOPackage.ConfigurationSet)((IStub)ret).GetTarget());
        }
        public System.Boolean AddConfigurationSet(global::org.omg.SDOPackage.ConfigurationSet configuration_set)
        {
            var ret = _target.AddConfigurationSet(configuration_set);
            return ret;
        }
        public System.Boolean RemoveConfigurationSet(System.String config_id)
        {
            var ret = _target.RemoveConfigurationSet(config_id);
            return ret;
        }
        public System.Boolean ActivateConfigurationSet(System.String config_id)
        {
            var ret = _target.ActivateConfigurationSet(config_id);
            return ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IMonitoring
    {
    }

    public class MonitoringAdapter : MarshalByRefObject, global::org.omg.SDOPackage.Monitoring
    {
        private IMonitoring _target;

        public MonitoringAdapter(IMonitoring target)
        {
            _target = target;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IOrganization
    {
        System.String GetOrganizationId();
        ReactiveRTM.org.omg.SDOPackage.OrganizationProperty GetOrganizationProperty();
        System.Object GetOrganizationPropertyValue(System.String name);
        System.Boolean AddOrganizationProperty(ReactiveRTM.org.omg.SDOPackage.OrganizationProperty organization_property);
        System.Boolean SetOrganizationPropertyValue(System.String name,ReactiveRTM.System.Object value);
        System.Boolean RemoveOrganizationProperty(System.String name);
        ReactiveRTM.org.omg.SDOPackage.SDOSystemElementStub GetOwner();
        System.Boolean SetOwner(ReactiveRTM.org.omg.SDOPackage.SDOSystemElement sdo);
        List<ReactiveRTM.org.omg.SDOPackage.SDOStub> GetMembers();
        System.Boolean SetMembers(ReactiveRTM.org.omg.SDOPackage.SDO[] sdos);
        System.Boolean AddMembers(ReactiveRTM.org.omg.SDOPackage.SDO[] sdo_list);
        System.Boolean RemoveMember(System.String id);
        ReactiveRTM.org.omg.SDOPackage.DependencyType GetDependency();
        System.Boolean SetDependency(ReactiveRTM.org.omg.SDOPackage.DependencyType dependency);
    }

    public class OrganizationAdapter : MarshalByRefObject, global::org.omg.SDOPackage.Organization
    {
        private IOrganization _target;

        public OrganizationAdapter(IOrganization target)
        {
            _target = target;
        }
        public System.String GetOrganizationId()
        {
            var ret = _target.GetOrganizationId();
            return ret;
        }
        public global::org.omg.SDOPackage.OrganizationProperty GetOrganizationProperty()
        {
            var ret = _target.GetOrganizationProperty();
            return ((global::org.omg.SDOPackage.OrganizationProperty)((IStub)ret).GetTarget());
        }
        public global::System.Object GetOrganizationPropertyValue(System.String name)
        {
            var ret = _target.GetOrganizationPropertyValue(name);
            return (global::System.Object)ret;
        }
        public System.Boolean AddOrganizationProperty(global::org.omg.SDOPackage.OrganizationProperty organization_property)
        {
            var ret = _target.AddOrganizationProperty(organization_property);
            return ret;
        }
        public System.Boolean SetOrganizationPropertyValue(System.String name,global::System.Object value)
        {
            var ret = _target.SetOrganizationPropertyValue(name,value);
            return ret;
        }
        public System.Boolean RemoveOrganizationProperty(System.String name)
        {
            var ret = _target.RemoveOrganizationProperty(name);
            return ret;
        }
        public global::org.omg.SDOPackage.SDOSystemElement GetOwner()
        {
            var ret = _target.GetOwner();
            return ((global::org.omg.SDOPackage.SDOSystemElement)((IStub)ret).GetTarget());
        }
        public System.Boolean SetOwner(global::org.omg.SDOPackage.SDOSystemElement sdo)
        {
            var ret = _target.SetOwner(sdo);
            return ret;
        }
        public global::org.omg.SDOPackage.SDO[] GetMembers()
        {
            var ret = _target.GetMembers();
            return ret.Select(x=>((global::org.omg.SDOPackage.SDO)((IStub)x).GetTarget())).ToArray();
        }
        public System.Boolean SetMembers(global::org.omg.SDOPackage.SDO[] sdos)
        {
            var ret = _target.SetMembers(sdos);
            return ret;
        }
        public System.Boolean AddMembers(global::org.omg.SDOPackage.SDO[] sdo_list)
        {
            var ret = _target.AddMembers(sdo_list);
            return ret;
        }
        public System.Boolean RemoveMember(System.String id)
        {
            var ret = _target.RemoveMember(id);
            return ret;
        }
        public global::org.omg.SDOPackage.DependencyType GetDependency()
        {
            var ret = _target.GetDependency();
            return (global::org.omg.SDOPackage.DependencyType)ret;
        }
        public System.Boolean SetDependency(global::org.omg.SDOPackage.DependencyType dependency)
        {
            var ret = _target.SetDependency(dependency);
            return ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}
 
namespace ReactiveRTM.RTC
{
    public interface IActArray
    {
        ReactiveRTM.RTC.ActArrayGeometry GetGeometry();
        void GoHome(System.Int16 index);
        void Power(System.Boolean enable);
        void Brakes(System.Boolean engage);
        void ConfigSpeed(System.Int16 index,System.Double speed);
        void ConfigAccel(System.Int16 index,System.Double accel);
    }

    public class ActArrayAdapter : MarshalByRefObject, global::RTC.ActArray
    {
        private IActArray _target;

        public ActArrayAdapter(IActArray target)
        {
            _target = target;
        }
        public global::RTC.ActArrayGeometry GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.ActArrayGeometry)((IStub)ret).GetTarget());
        }
        public void GoHome(System.Int16 index)
        {
            _target.GoHome(index);
            return;
        }
        public void Power(System.Boolean enable)
        {
            _target.Power(enable);
            return;
        }
        public void Brakes(System.Boolean engage)
        {
            _target.Brakes(engage);
            return;
        }
        public void ConfigSpeed(System.Int16 index,System.Double speed)
        {
            _target.ConfigSpeed(index,speed);
            return;
        }
        public void ConfigAccel(System.Int16 index,System.Double accel)
        {
            _target.ConfigAccel(index,accel);
            return;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IAIO
    {
        System.Int16 NumChannels();
        void SetReferenceLevel(System.Int16 index,System.Double level);
        System.Double GetResolution(System.Int16 index);
    }

    public class AIOAdapter : MarshalByRefObject, global::RTC.AIO
    {
        private IAIO _target;

        public AIOAdapter(IAIO target)
        {
            _target = target;
        }
        public System.Int16 NumChannels()
        {
            var ret = _target.NumChannels();
            return ret;
        }
        public void SetReferenceLevel(System.Int16 index,System.Double level)
        {
            _target.SetReferenceLevel(index,level);
            return;
        }
        public System.Double GetResolution(System.Int16 index)
        {
            var ret = _target.GetResolution(index);
            return ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IBumper
    {
        ReactiveRTM.RTC.BumperGeometry GetGeometry();
    }

    public class BumperAdapter : MarshalByRefObject, global::RTC.Bumper
    {
        private IBumper _target;

        public BumperAdapter(IBumper target)
        {
            _target = target;
        }
        public global::RTC.BumperGeometry GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.BumperGeometry)((IStub)ret).GetTarget());
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface ICamera
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
        ReactiveRTM.RTC.CameraInfo GetCameraInfo();
    }

    public class CameraAdapter : MarshalByRefObject, global::RTC.Camera
    {
        private ICamera _target;

        public CameraAdapter(ICamera target)
        {
            _target = target;
        }
        public global::RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.Geometry3D)((IStub)ret).GetTarget());
        }
        public global::RTC.CameraInfo GetCameraInfo()
        {
            var ret = _target.GetCameraInfo();
            return ((global::RTC.CameraInfo)((IStub)ret).GetTarget());
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IDIO
    {
        System.Int16 NumBits();
        System.Boolean GetBit(System.Int16 index);
        void SetBit(System.Int16 index,System.Boolean newValue);
    }

    public class DIOAdapter : MarshalByRefObject, global::RTC.DIO
    {
        private IDIO _target;

        public DIOAdapter(IDIO target)
        {
            _target = target;
        }
        public System.Int16 NumBits()
        {
            var ret = _target.NumBits();
            return ret;
        }
        public System.Boolean GetBit(System.Int16 index)
        {
            var ret = _target.GetBit(index);
            return ret;
        }
        public void SetBit(System.Int16 index,System.Boolean newValue)
        {
            _target.SetBit(index,newValue);
            return;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IFiducial
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
        ReactiveRTM.RTC.FiducialFOV GetFOV();
        void SetFOV(ReactiveRTM.RTC.FiducialFOV newFOV);
    }

    public class FiducialAdapter : MarshalByRefObject, global::RTC.Fiducial
    {
        private IFiducial _target;

        public FiducialAdapter(IFiducial target)
        {
            _target = target;
        }
        public global::RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.Geometry3D)((IStub)ret).GetTarget());
        }
        public global::RTC.FiducialFOV GetFOV()
        {
            var ret = _target.GetFOV();
            return ((global::RTC.FiducialFOV)((IStub)ret).GetTarget());
        }
        public void SetFOV(global::RTC.FiducialFOV newFOV)
        {
            _target.SetFOV(newFOV);
            return;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IGPS
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
    }

    public class GPSAdapter : MarshalByRefObject, global::RTC.GPS
    {
        private IGPS _target;

        public GPSAdapter(IGPS target)
        {
            _target = target;
        }
        public global::RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.Geometry3D)((IStub)ret).GetTarget());
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IGripper
    {
        ReactiveRTM.RTC.GripperGeometry GetGeometry();
        void Open();
        void Close();
    }

    public class GripperAdapter : MarshalByRefObject, global::RTC.Gripper
    {
        private IGripper _target;

        public GripperAdapter(IGripper target)
        {
            _target = target;
        }
        public global::RTC.GripperGeometry GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.GripperGeometry)((IStub)ret).GetTarget());
        }
        public void Open()
        {
            _target.Open();
            return;
        }
        public void Close()
        {
            _target.Close();
            return;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IIMU
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
    }

    public class IMUAdapter : MarshalByRefObject, global::RTC.IMU
    {
        private IIMU _target;

        public IMUAdapter(IIMU target)
        {
            _target = target;
        }
        public global::RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.Geometry3D)((IStub)ret).GetTarget());
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IINS
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
    }

    public class INSAdapter : MarshalByRefObject, global::RTC.INS
    {
        private IINS _target;

        public INSAdapter(IINS target)
        {
            _target = target;
        }
        public global::RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.Geometry3D)((IStub)ret).GetTarget());
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface ILimb
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
        void Power(System.Boolean enable);
        void Brakes(System.Boolean engage);
        void SetSpeed(System.Double speed);
    }

    public class LimbAdapter : MarshalByRefObject, global::RTC.Limb
    {
        private ILimb _target;

        public LimbAdapter(ILimb target)
        {
            _target = target;
        }
        public global::RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.Geometry3D)((IStub)ret).GetTarget());
        }
        public void Power(System.Boolean enable)
        {
            _target.Power(enable);
            return;
        }
        public void Brakes(System.Boolean engage)
        {
            _target.Brakes(engage);
            return;
        }
        public void SetSpeed(System.Double speed)
        {
            _target.SetSpeed(speed);
            return;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IOGMap
    {
        ReactiveRTM.RTC.OGMapConfig GetConfig();
        ReactiveRTM.RTC.OGMapTile GetTile(ReactiveRTM.RTC.OGMapTile tile);
    }

    public class OGMapAdapter : MarshalByRefObject, global::RTC.OGMap
    {
        private IOGMap _target;

        public OGMapAdapter(IOGMap target)
        {
            _target = target;
        }
        public global::RTC.OGMapConfig GetConfig()
        {
            var ret = _target.GetConfig();
            return ((global::RTC.OGMapConfig)((IStub)ret).GetTarget());
        }
        public global::RTC.OGMapTile GetTile(global::RTC.OGMapTile tile)
        {
            var ret = _target.GetTile(tile);
            return ((global::RTC.OGMapTile)((IStub)ret).GetTarget());
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IMulticamera
    {
        ReactiveRTM.RTC.MulticameraGeometry GetGeometry();
        List<ReactiveRTM.RTC.CameraInfo> GetCameraInfos();
    }

    public class MulticameraAdapter : MarshalByRefObject, global::RTC.Multicamera
    {
        private IMulticamera _target;

        public MulticameraAdapter(IMulticamera target)
        {
            _target = target;
        }
        public global::RTC.MulticameraGeometry GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.MulticameraGeometry)((IStub)ret).GetTarget());
        }
        public global::RTC.CameraInfo[] GetCameraInfos()
        {
            var ret = _target.GetCameraInfos();
            return ret.Select(x=>((global::RTC.CameraInfo)((IStub)x).GetTarget())).ToArray();
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IPanTilt
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
    }

    public class PanTiltAdapter : MarshalByRefObject, global::RTC.PanTilt
    {
        private IPanTilt _target;

        public PanTiltAdapter(IPanTilt target)
        {
            _target = target;
        }
        public global::RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.Geometry3D)((IStub)ret).GetTarget());
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IPathPlanner2D
    {
        void SetTask(ReactiveRTM.RTC.Waypoint2D[] coarsePath);
    }

    public class PathPlanner2DAdapter : MarshalByRefObject, global::RTC.PathPlanner2D
    {
        private IPathPlanner2D _target;

        public PathPlanner2DAdapter(IPathPlanner2D target)
        {
            _target = target;
        }
        public void SetTask(global::RTC.Waypoint2D[] coarsePath)
        {
            _target.SetTask(coarsePath);
            return;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IPathPlanner3D
    {
        void SetTask(ReactiveRTM.RTC.Waypoint3D[] coarsePath);
    }

    public class PathPlanner3DAdapter : MarshalByRefObject, global::RTC.PathPlanner3D
    {
        private IPathPlanner3D _target;

        public PathPlanner3DAdapter(IPathPlanner3D target)
        {
            _target = target;
        }
        public void SetTask(global::RTC.Waypoint3D[] coarsePath)
        {
            _target.SetTask(coarsePath);
            return;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IPathFollower2D
    {
        void SetPath(ReactiveRTM.RTC.Waypoint2D[] path);
        void Enable(System.Boolean enable);
        System.Int16 GetCurrentWaypointIndex();
        ReactiveRTM.RTC.Waypoint2D GetCurrentWaypoint();
    }

    public class PathFollower2DAdapter : MarshalByRefObject, global::RTC.PathFollower2D
    {
        private IPathFollower2D _target;

        public PathFollower2DAdapter(IPathFollower2D target)
        {
            _target = target;
        }
        public void SetPath(global::RTC.Waypoint2D[] path)
        {
            _target.SetPath(path);
            return;
        }
        public void Enable(System.Boolean enable)
        {
            _target.Enable(enable);
            return;
        }
        public System.Int16 GetCurrentWaypointIndex()
        {
            var ret = _target.GetCurrentWaypointIndex();
            return ret;
        }
        public global::RTC.Waypoint2D GetCurrentWaypoint()
        {
            var ret = _target.GetCurrentWaypoint();
            return ((global::RTC.Waypoint2D)((IStub)ret).GetTarget());
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IPathFollower3D
    {
        void SetPath(ReactiveRTM.RTC.Waypoint3D[] path);
        void Enable(System.Boolean enable);
        System.Int16 GetCurrentWaypointIndex();
        ReactiveRTM.RTC.Waypoint3D GetCurrentWaypoint();
    }

    public class PathFollower3DAdapter : MarshalByRefObject, global::RTC.PathFollower3D
    {
        private IPathFollower3D _target;

        public PathFollower3DAdapter(IPathFollower3D target)
        {
            _target = target;
        }
        public void SetPath(global::RTC.Waypoint3D[] path)
        {
            _target.SetPath(path);
            return;
        }
        public void Enable(System.Boolean enable)
        {
            _target.Enable(enable);
            return;
        }
        public System.Int16 GetCurrentWaypointIndex()
        {
            var ret = _target.GetCurrentWaypointIndex();
            return ret;
        }
        public global::RTC.Waypoint3D GetCurrentWaypoint()
        {
            var ret = _target.GetCurrentWaypoint();
            return ((global::RTC.Waypoint3D)((IStub)ret).GetTarget());
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IPointCloudServices
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
    }

    public class PointCloudServicesAdapter : MarshalByRefObject, global::RTC.PointCloudServices
    {
        private IPointCloudServices _target;

        public PointCloudServicesAdapter(IPointCloudServices target)
        {
            _target = target;
        }
        public global::RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.Geometry3D)((IStub)ret).GetTarget());
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IOdometry2D
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
        void SetOdometry(ReactiveRTM.RTC.Pose2D newOdometry);
    }

    public class Odometry2DAdapter : MarshalByRefObject, global::RTC.Odometry2D
    {
        private IOdometry2D _target;

        public Odometry2DAdapter(IOdometry2D target)
        {
            _target = target;
        }
        public global::RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.Geometry3D)((IStub)ret).GetTarget());
        }
        public void SetOdometry(global::RTC.Pose2D newOdometry)
        {
            _target.SetOdometry(newOdometry);
            return;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IOdometry3D
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
        void SetOdometry(ReactiveRTM.RTC.Pose3D newOdometry);
    }

    public class Odometry3DAdapter : MarshalByRefObject, global::RTC.Odometry3D
    {
        private IOdometry3D _target;

        public Odometry3DAdapter(IOdometry3D target)
        {
            _target = target;
        }
        public global::RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.Geometry3D)((IStub)ret).GetTarget());
        }
        public void SetOdometry(global::RTC.Pose3D newOdometry)
        {
            _target.SetOdometry(newOdometry);
            return;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IVelocityControl2D
    {
        ReactiveRTM.RTC.Geometry2D GetGeometry();
    }

    public class VelocityControl2DAdapter : MarshalByRefObject, global::RTC.VelocityControl2D
    {
        private IVelocityControl2D _target;

        public VelocityControl2DAdapter(IVelocityControl2D target)
        {
            _target = target;
        }
        public global::RTC.Geometry2D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.Geometry2D)((IStub)ret).GetTarget());
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IVelocityControl3D
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
    }

    public class VelocityControl3DAdapter : MarshalByRefObject, global::RTC.VelocityControl3D
    {
        private IVelocityControl3D _target;

        public VelocityControl3DAdapter(IVelocityControl3D target)
        {
            _target = target;
        }
        public global::RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.Geometry3D)((IStub)ret).GetTarget());
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IPoseControl2D
    {
        ReactiveRTM.RTC.Geometry2D GetGeometry();
    }

    public class PoseControl2DAdapter : MarshalByRefObject, global::RTC.PoseControl2D
    {
        private IPoseControl2D _target;

        public PoseControl2DAdapter(IPoseControl2D target)
        {
            _target = target;
        }
        public global::RTC.Geometry2D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.Geometry2D)((IStub)ret).GetTarget());
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IPoseControl3D
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
    }

    public class PoseControl3DAdapter : MarshalByRefObject, global::RTC.PoseControl3D
    {
        private IPoseControl3D _target;

        public PoseControl3DAdapter(IPoseControl3D target)
        {
            _target = target;
        }
        public global::RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.Geometry3D)((IStub)ret).GetTarget());
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface ICarlikeControl
    {
        ReactiveRTM.RTC.Geometry2D GetGeometry();
    }

    public class CarlikeControlAdapter : MarshalByRefObject, global::RTC.CarlikeControl
    {
        private ICarlikeControl _target;

        public CarlikeControlAdapter(ICarlikeControl target)
        {
            _target = target;
        }
        public global::RTC.Geometry2D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.Geometry2D)((IStub)ret).GetTarget());
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IHeadingControl2D
    {
        ReactiveRTM.RTC.Geometry2D GetGeometry();
    }

    public class HeadingControl2DAdapter : MarshalByRefObject, global::RTC.HeadingControl2D
    {
        private IHeadingControl2D _target;

        public HeadingControl2DAdapter(IHeadingControl2D target)
        {
            _target = target;
        }
        public global::RTC.Geometry2D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.Geometry2D)((IStub)ret).GetTarget());
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IHeadingControl3D
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
    }

    public class HeadingControl3DAdapter : MarshalByRefObject, global::RTC.HeadingControl3D
    {
        private IHeadingControl3D _target;

        public HeadingControl3DAdapter(IHeadingControl3D target)
        {
            _target = target;
        }
        public global::RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.Geometry3D)((IStub)ret).GetTarget());
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IRanger
    {
        ReactiveRTM.RTC.RangerGeometry GetGeometry();
        void Power(System.Boolean enable);
        void EnableIntensities(System.Boolean enable);
        ReactiveRTM.RTC.RangerConfig GetConfig();
        void SetConfig(ReactiveRTM.RTC.RangerConfig newConfig);
    }

    public class RangerAdapter : MarshalByRefObject, global::RTC.Ranger
    {
        private IRanger _target;

        public RangerAdapter(IRanger target)
        {
            _target = target;
        }
        public global::RTC.RangerGeometry GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.RangerGeometry)((IStub)ret).GetTarget());
        }
        public void Power(System.Boolean enable)
        {
            _target.Power(enable);
            return;
        }
        public void EnableIntensities(System.Boolean enable)
        {
            _target.EnableIntensities(enable);
            return;
        }
        public global::RTC.RangerConfig GetConfig()
        {
            var ret = _target.GetConfig();
            return ((global::RTC.RangerConfig)((IStub)ret).GetTarget());
        }
        public void SetConfig(global::RTC.RangerConfig newConfig)
        {
            _target.SetConfig(newConfig);
            return;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
    public interface IRFID
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
        void Write(System.String GUID,ReactiveRTM.System.Byte[] data);
        List<System.Byte> Read(System.String GUID);
    }

    public class RFIDAdapter : MarshalByRefObject, global::RTC.RFID
    {
        private IRFID _target;

        public RFIDAdapter(IRFID target)
        {
            _target = target;
        }
        public global::RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return ((global::RTC.Geometry3D)((IStub)ret).GetTarget());
        }
        public void Write(System.String GUID,global::System.Byte[] data)
        {
            _target.Write(GUID,data);
            return;
        }
        public global::System.Byte[] Read(System.String GUID)
        {
            var ret = _target.Read(GUID);
            return ret.Select(x=>x).ToArray();
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}
 
namespace ReactiveRTM.RTM
{
    public interface IManager
    {
        ReactiveRTM.omg.org.RTC.ReturnCode_t LoadModule(System.String pathname,System.String initfunc);
        ReactiveRTM.omg.org.RTC.ReturnCode_t UnloadModule(System.String pathname);
        List<ReactiveRTM.RTM.ModuleProfile> GetLoadableModules();
        List<ReactiveRTM.RTM.ModuleProfile> GetLoadedModules();
        List<ReactiveRTM.RTM.ModuleProfile> GetFactoryProfiles();
        ReactiveRTM.omg.org.RTC.RTObjectStub CreateComponent(System.String module_name);
        ReactiveRTM.omg.org.RTC.ReturnCode_t DeleteComponent(System.String instance_name);
        List<ReactiveRTM.omg.org.RTC.RTObjectStub> GetComponents();
        List<ReactiveRTM.omg.org.RTC.ComponentProfile> GetComponentProfiles();
        ReactiveRTM.RTM.ManagerProfile GetProfile();
        List<ReactiveRTM.org.omg.SDOPackage.NameValue> GetConfiguration();
        ReactiveRTM.omg.org.RTC.ReturnCode_t SetConfiguration(System.String name,System.String value);
        System.Boolean IsMaster();
        List<ReactiveRTM.RTM.ManagerStub> GetMasterManagers();
        ReactiveRTM.omg.org.RTC.ReturnCode_t AddMasterManager(ReactiveRTM.RTM.Manager mgr);
        ReactiveRTM.omg.org.RTC.ReturnCode_t RemoveMasterManager(ReactiveRTM.RTM.Manager mgr);
        List<ReactiveRTM.RTM.ManagerStub> GetSlaveManagers();
        ReactiveRTM.omg.org.RTC.ReturnCode_t AddSlaveManager(ReactiveRTM.RTM.Manager mgr);
        ReactiveRTM.omg.org.RTC.ReturnCode_t RemoveSlaveManager(ReactiveRTM.RTM.Manager mgr);
        ReactiveRTM.omg.org.RTC.ReturnCode_t Fork();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Shutdown();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Restart();
        System.Object GetService(System.String name);
    }

    public class ManagerAdapter : MarshalByRefObject, global::RTM.Manager
    {
        private IManager _target;

        public ManagerAdapter(IManager target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ReturnCode_t LoadModule(System.String pathname,System.String initfunc)
        {
            var ret = _target.LoadModule(pathname,initfunc);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t UnloadModule(System.String pathname)
        {
            var ret = _target.UnloadModule(pathname);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::RTM.ModuleProfile[] GetLoadableModules()
        {
            var ret = _target.GetLoadableModules();
            return ret.Select(x=>((global::RTM.ModuleProfile)((IStub)x).GetTarget())).ToArray();
        }
        public global::RTM.ModuleProfile[] GetLoadedModules()
        {
            var ret = _target.GetLoadedModules();
            return ret.Select(x=>((global::RTM.ModuleProfile)((IStub)x).GetTarget())).ToArray();
        }
        public global::RTM.ModuleProfile[] GetFactoryProfiles()
        {
            var ret = _target.GetFactoryProfiles();
            return ret.Select(x=>((global::RTM.ModuleProfile)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.RTObject CreateComponent(System.String module_name)
        {
            var ret = _target.CreateComponent(module_name);
            return ((global::omg.org.RTC.RTObject)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ReturnCode_t DeleteComponent(System.String instance_name)
        {
            var ret = _target.DeleteComponent(instance_name);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.RTObject[] GetComponents()
        {
            var ret = _target.GetComponents();
            return ret.Select(x=>((global::omg.org.RTC.RTObject)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ComponentProfile[] GetComponentProfiles()
        {
            var ret = _target.GetComponentProfiles();
            return ret.Select(x=>((global::omg.org.RTC.ComponentProfile)((IStub)x).GetTarget())).ToArray();
        }
        public global::RTM.ManagerProfile GetProfile()
        {
            var ret = _target.GetProfile();
            return ((global::RTM.ManagerProfile)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.NameValue[] GetConfiguration()
        {
            var ret = _target.GetConfiguration();
            return ret.Select(x=>((global::org.omg.SDOPackage.NameValue)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ReturnCode_t SetConfiguration(System.String name,System.String value)
        {
            var ret = _target.SetConfiguration(name,value);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Boolean IsMaster()
        {
            var ret = _target.IsMaster();
            return ret;
        }
        public global::RTM.Manager[] GetMasterManagers()
        {
            var ret = _target.GetMasterManagers();
            return ret.Select(x=>((global::RTM.Manager)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ReturnCode_t AddMasterManager(global::RTM.Manager mgr)
        {
            var ret = _target.AddMasterManager(mgr);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t RemoveMasterManager(global::RTM.Manager mgr)
        {
            var ret = _target.RemoveMasterManager(mgr);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::RTM.Manager[] GetSlaveManagers()
        {
            var ret = _target.GetSlaveManagers();
            return ret.Select(x=>((global::RTM.Manager)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ReturnCode_t AddSlaveManager(global::RTM.Manager mgr)
        {
            var ret = _target.AddSlaveManager(mgr);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t RemoveSlaveManager(global::RTM.Manager mgr)
        {
            var ret = _target.RemoveSlaveManager(mgr);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t Fork()
        {
            var ret = _target.Fork();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t Shutdown()
        {
            var ret = _target.Shutdown();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t Restart()
        {
            var ret = _target.Restart();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::System.MarshalByRefObject GetService(System.String name)
        {
            var ret = _target.GetService(name);
            return (global::System.MarshalByRefObject)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}

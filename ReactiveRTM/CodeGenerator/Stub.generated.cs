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
    public class ExecutionContextStub : IStub
    {
		private global::omg.org.RTC.ExecutionContext _target;

		public ExecutionContextStub()
		{
		}

		public ExecutionContextStub(global::omg.org.RTC.ExecutionContext target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::omg.org.RTC.ExecutionContext)target;
		}

 
        public Task<System.Boolean> IsRunningAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.is_running();
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> StartAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.start();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> StopAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target._stop();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<System.Double> GetRateAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_rate();
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> SetRateAsync(global::System.Double rate)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.set_rate(rate);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> AddComponentAsync(global::omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.add_component(comp);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> RemoveComponentAsync(global::omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.remove_component(comp);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> ActivateComponentAsync(global::omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.activate_component(comp);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> DeactivateComponentAsync(global::omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.deactivate_component(comp);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> ResetComponentAsync(global::omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.reset_component(comp);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.LifeCycleState> GetComponentStateAsync(global::omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_component_state(comp);
				return (omg.org.RTC.LifeCycleState)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ExecutionKind> GetKindAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_kind();
				return (omg.org.RTC.ExecutionKind)ret;
			});
        }
    }
    public class ComponentActionStub : IStub
    {
		private global::omg.org.RTC.ComponentAction _target;

		public ComponentActionStub()
		{
		}

		public ComponentActionStub(global::omg.org.RTC.ComponentAction target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::omg.org.RTC.ComponentAction)target;
		}

 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnInitializeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_initialize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnFinalizeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_finalize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnStartupAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_startup(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnShutdownAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_shutdown(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnActivatedAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_activated(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnDeactivatedAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_deactivated(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnAbortingAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_aborting(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnErrorAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_error(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnResetAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_reset(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
    }
    public class LightweightRTObjectStub : IStub
    {
		private global::omg.org.RTC.LightweightRTObject _target;

		public LightweightRTObjectStub()
		{
		}

		public LightweightRTObjectStub(global::omg.org.RTC.LightweightRTObject target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::omg.org.RTC.LightweightRTObject)target;
		}
 
		public static explicit operator omg.org.RTC.ComponentAction(ReactiveRTM.omg.org.RTC.LightweightRTObjectStub child)
		{
			return new omg.org.RTC.ComponentActionStub((omg.org.RTC.ComponentAction)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.omg.org.RTC.LightweightRTObjectStub(omg.org.RTC.ComponentActionStub parent)
		{
			return new ReactiveRTM.omg.org.RTC.LightweightRTObjectStub((global::omg.org.RTC.LightweightRTObject)((IStub)parent).GetTarget());
		}

 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> InitializeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.initialize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> FinalizeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target._finalize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<System.Boolean> IsAliveAsync(global::omg.org.RTC.ExecutionContext exec_context)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.is_alive(exec_context);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> ExitAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target._exit();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<System.Int32> AttachContextAsync(global::omg.org.RTC.ExecutionContext exec_context)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.attach_context(exec_context);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> DetachContextAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.detach_context(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ExecutionContextStub> GetContextAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_context(exec_handle);
				return new ReactiveRTM.omg.org.RTC.ExecutionContextStub(ret);
			});
        }
 
        public Task<List<ReactiveRTM.omg.org.RTC.ExecutionContextStub>> GetOwnedContextsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_owned_contexts();
				return ret.Select(x=>new ReactiveRTM.omg.org.RTC.ExecutionContextStub(x)).ToList();
			});
        }
 
        public Task<List<ReactiveRTM.omg.org.RTC.ExecutionContextStub>> GetParticipatingContextsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_participating_contexts();
				return ret.Select(x=>new ReactiveRTM.omg.org.RTC.ExecutionContextStub(x)).ToList();
			});
        }
 
        public Task<System.Int32> GetContextHandleAsync(global::omg.org.RTC.ExecutionContext cxt)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_context_handle(cxt);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnInitializeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_initialize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnFinalizeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_finalize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnStartupAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_startup(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnShutdownAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_shutdown(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnActivatedAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_activated(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnDeactivatedAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_deactivated(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnAbortingAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_aborting(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnErrorAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_error(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnResetAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_reset(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
    }
    public class DataFlowComponentActionStub : IStub
    {
		private global::omg.org.RTC.DataFlowComponentAction _target;

		public DataFlowComponentActionStub()
		{
		}

		public DataFlowComponentActionStub(global::omg.org.RTC.DataFlowComponentAction target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::omg.org.RTC.DataFlowComponentAction)target;
		}

 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnExecuteAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_execute(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnStateUpdateAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_state_update(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnRateChangedAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_rate_changed(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
    }
    public class DataFlowComponentStub : IStub
    {
		private global::omg.org.RTC.DataFlowComponent _target;

		public DataFlowComponentStub()
		{
		}

		public DataFlowComponentStub(global::omg.org.RTC.DataFlowComponent target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::omg.org.RTC.DataFlowComponent)target;
		}
 
		public static explicit operator omg.org.RTC.LightweightRTObject(ReactiveRTM.omg.org.RTC.DataFlowComponentStub child)
		{
			return new omg.org.RTC.LightweightRTObjectStub((omg.org.RTC.LightweightRTObject)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.omg.org.RTC.DataFlowComponentStub(omg.org.RTC.LightweightRTObjectStub parent)
		{
			return new ReactiveRTM.omg.org.RTC.DataFlowComponentStub((global::omg.org.RTC.DataFlowComponent)((IStub)parent).GetTarget());
		}
 
		public static explicit operator omg.org.RTC.ComponentAction(ReactiveRTM.omg.org.RTC.DataFlowComponentStub child)
		{
			return new omg.org.RTC.ComponentActionStub((omg.org.RTC.ComponentAction)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.omg.org.RTC.DataFlowComponentStub(omg.org.RTC.ComponentActionStub parent)
		{
			return new ReactiveRTM.omg.org.RTC.DataFlowComponentStub((global::omg.org.RTC.DataFlowComponent)((IStub)parent).GetTarget());
		}
 
		public static explicit operator omg.org.RTC.DataFlowComponentAction(ReactiveRTM.omg.org.RTC.DataFlowComponentStub child)
		{
			return new omg.org.RTC.DataFlowComponentActionStub((omg.org.RTC.DataFlowComponentAction)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.omg.org.RTC.DataFlowComponentStub(omg.org.RTC.DataFlowComponentActionStub parent)
		{
			return new ReactiveRTM.omg.org.RTC.DataFlowComponentStub((global::omg.org.RTC.DataFlowComponent)((IStub)parent).GetTarget());
		}

 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> InitializeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.initialize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> FinalizeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target._finalize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<System.Boolean> IsAliveAsync(global::omg.org.RTC.ExecutionContext exec_context)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.is_alive(exec_context);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> ExitAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target._exit();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<System.Int32> AttachContextAsync(global::omg.org.RTC.ExecutionContext exec_context)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.attach_context(exec_context);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> DetachContextAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.detach_context(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ExecutionContextStub> GetContextAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_context(exec_handle);
				return new ReactiveRTM.omg.org.RTC.ExecutionContextStub(ret);
			});
        }
 
        public Task<List<ReactiveRTM.omg.org.RTC.ExecutionContextStub>> GetOwnedContextsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_owned_contexts();
				return ret.Select(x=>new ReactiveRTM.omg.org.RTC.ExecutionContextStub(x)).ToList();
			});
        }
 
        public Task<List<ReactiveRTM.omg.org.RTC.ExecutionContextStub>> GetParticipatingContextsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_participating_contexts();
				return ret.Select(x=>new ReactiveRTM.omg.org.RTC.ExecutionContextStub(x)).ToList();
			});
        }
 
        public Task<System.Int32> GetContextHandleAsync(global::omg.org.RTC.ExecutionContext cxt)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_context_handle(cxt);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnInitializeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_initialize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnFinalizeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_finalize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnStartupAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_startup(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnShutdownAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_shutdown(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnActivatedAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_activated(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnDeactivatedAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_deactivated(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnAbortingAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_aborting(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnErrorAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_error(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnResetAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_reset(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnExecuteAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_execute(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnStateUpdateAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_state_update(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnRateChangedAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_rate_changed(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
    }
    public class FsmStub : IStub
    {
		private global::omg.org.RTC.Fsm _target;

		public FsmStub()
		{
		}

		public FsmStub(global::omg.org.RTC.Fsm target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::omg.org.RTC.Fsm)target;
		}
 
		public static explicit operator omg.org.RTC.LightweightRTObject(ReactiveRTM.omg.org.RTC.FsmStub child)
		{
			return new omg.org.RTC.LightweightRTObjectStub((omg.org.RTC.LightweightRTObject)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.omg.org.RTC.FsmStub(omg.org.RTC.LightweightRTObjectStub parent)
		{
			return new ReactiveRTM.omg.org.RTC.FsmStub((global::omg.org.RTC.Fsm)((IStub)parent).GetTarget());
		}
 
		public static explicit operator omg.org.RTC.ComponentAction(ReactiveRTM.omg.org.RTC.FsmStub child)
		{
			return new omg.org.RTC.ComponentActionStub((omg.org.RTC.ComponentAction)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.omg.org.RTC.FsmStub(omg.org.RTC.ComponentActionStub parent)
		{
			return new ReactiveRTM.omg.org.RTC.FsmStub((global::omg.org.RTC.Fsm)((IStub)parent).GetTarget());
		}

 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> InitializeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.initialize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> FinalizeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target._finalize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<System.Boolean> IsAliveAsync(global::omg.org.RTC.ExecutionContext exec_context)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.is_alive(exec_context);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> ExitAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target._exit();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<System.Int32> AttachContextAsync(global::omg.org.RTC.ExecutionContext exec_context)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.attach_context(exec_context);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> DetachContextAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.detach_context(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ExecutionContextStub> GetContextAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_context(exec_handle);
				return new ReactiveRTM.omg.org.RTC.ExecutionContextStub(ret);
			});
        }
 
        public Task<List<ReactiveRTM.omg.org.RTC.ExecutionContextStub>> GetOwnedContextsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_owned_contexts();
				return ret.Select(x=>new ReactiveRTM.omg.org.RTC.ExecutionContextStub(x)).ToList();
			});
        }
 
        public Task<List<ReactiveRTM.omg.org.RTC.ExecutionContextStub>> GetParticipatingContextsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_participating_contexts();
				return ret.Select(x=>new ReactiveRTM.omg.org.RTC.ExecutionContextStub(x)).ToList();
			});
        }
 
        public Task<System.Int32> GetContextHandleAsync(global::omg.org.RTC.ExecutionContext cxt)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_context_handle(cxt);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnInitializeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_initialize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnFinalizeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_finalize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnStartupAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_startup(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnShutdownAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_shutdown(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnActivatedAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_activated(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnDeactivatedAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_deactivated(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnAbortingAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_aborting(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnErrorAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_error(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnResetAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_reset(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
    }
    public class FsmParticipantActionStub : IStub
    {
		private global::omg.org.RTC.FsmParticipantAction _target;

		public FsmParticipantActionStub()
		{
		}

		public FsmParticipantActionStub(global::omg.org.RTC.FsmParticipantAction target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::omg.org.RTC.FsmParticipantAction)target;
		}

 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnActionAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_action(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
    }
    public class FsmParticipantStub : IStub
    {
		private global::omg.org.RTC.FsmParticipant _target;

		public FsmParticipantStub()
		{
		}

		public FsmParticipantStub(global::omg.org.RTC.FsmParticipant target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::omg.org.RTC.FsmParticipant)target;
		}
 
		public static explicit operator omg.org.RTC.LightweightRTObject(ReactiveRTM.omg.org.RTC.FsmParticipantStub child)
		{
			return new omg.org.RTC.LightweightRTObjectStub((omg.org.RTC.LightweightRTObject)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.omg.org.RTC.FsmParticipantStub(omg.org.RTC.LightweightRTObjectStub parent)
		{
			return new ReactiveRTM.omg.org.RTC.FsmParticipantStub((global::omg.org.RTC.FsmParticipant)((IStub)parent).GetTarget());
		}
 
		public static explicit operator omg.org.RTC.ComponentAction(ReactiveRTM.omg.org.RTC.FsmParticipantStub child)
		{
			return new omg.org.RTC.ComponentActionStub((omg.org.RTC.ComponentAction)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.omg.org.RTC.FsmParticipantStub(omg.org.RTC.ComponentActionStub parent)
		{
			return new ReactiveRTM.omg.org.RTC.FsmParticipantStub((global::omg.org.RTC.FsmParticipant)((IStub)parent).GetTarget());
		}
 
		public static explicit operator omg.org.RTC.FsmParticipantAction(ReactiveRTM.omg.org.RTC.FsmParticipantStub child)
		{
			return new omg.org.RTC.FsmParticipantActionStub((omg.org.RTC.FsmParticipantAction)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.omg.org.RTC.FsmParticipantStub(omg.org.RTC.FsmParticipantActionStub parent)
		{
			return new ReactiveRTM.omg.org.RTC.FsmParticipantStub((global::omg.org.RTC.FsmParticipant)((IStub)parent).GetTarget());
		}

 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> InitializeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.initialize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> FinalizeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target._finalize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<System.Boolean> IsAliveAsync(global::omg.org.RTC.ExecutionContext exec_context)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.is_alive(exec_context);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> ExitAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target._exit();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<System.Int32> AttachContextAsync(global::omg.org.RTC.ExecutionContext exec_context)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.attach_context(exec_context);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> DetachContextAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.detach_context(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ExecutionContextStub> GetContextAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_context(exec_handle);
				return new ReactiveRTM.omg.org.RTC.ExecutionContextStub(ret);
			});
        }
 
        public Task<List<ReactiveRTM.omg.org.RTC.ExecutionContextStub>> GetOwnedContextsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_owned_contexts();
				return ret.Select(x=>new ReactiveRTM.omg.org.RTC.ExecutionContextStub(x)).ToList();
			});
        }
 
        public Task<List<ReactiveRTM.omg.org.RTC.ExecutionContextStub>> GetParticipatingContextsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_participating_contexts();
				return ret.Select(x=>new ReactiveRTM.omg.org.RTC.ExecutionContextStub(x)).ToList();
			});
        }
 
        public Task<System.Int32> GetContextHandleAsync(global::omg.org.RTC.ExecutionContext cxt)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_context_handle(cxt);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnInitializeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_initialize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnFinalizeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_finalize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnStartupAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_startup(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnShutdownAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_shutdown(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnActivatedAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_activated(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnDeactivatedAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_deactivated(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnAbortingAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_aborting(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnErrorAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_error(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnResetAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_reset(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnActionAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_action(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
    }
    public class ModeStub : IStub
    {
		private global::omg.org.RTC.Mode _target;

		public ModeStub()
		{
		}

		public ModeStub(global::omg.org.RTC.Mode target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::omg.org.RTC.Mode)target;
		}

    }
    public class ModeCapableStub : IStub
    {
		private global::omg.org.RTC.ModeCapable _target;

		public ModeCapableStub()
		{
		}

		public ModeCapableStub(global::omg.org.RTC.ModeCapable target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::omg.org.RTC.ModeCapable)target;
		}

 
        public Task<ReactiveRTM.omg.org.RTC.ModeStub> GetDefaultModeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_default_mode();
				return new ReactiveRTM.omg.org.RTC.ModeStub(ret);
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ModeStub> GetCurrentModeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_current_mode();
				return new ReactiveRTM.omg.org.RTC.ModeStub(ret);
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ModeStub> GetCurrentModeInContextAsync(global::omg.org.RTC.ExecutionContext exec_context)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_current_mode_in_context(exec_context);
				return new ReactiveRTM.omg.org.RTC.ModeStub(ret);
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ModeStub> GetPendingModeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_pending_mode();
				return new ReactiveRTM.omg.org.RTC.ModeStub(ret);
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ModeStub> GetPendingModeInContextAsync(global::omg.org.RTC.ExecutionContext exec_context)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_pending_mode_in_context(exec_context);
				return new ReactiveRTM.omg.org.RTC.ModeStub(ret);
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> SetModeAsync(global::omg.org.RTC.Mode new_mode,global::System.Boolean immediate)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.set_mode(new_mode,immediate);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
    }
    public class MultiModeComponentActionStub : IStub
    {
		private global::omg.org.RTC.MultiModeComponentAction _target;

		public MultiModeComponentActionStub()
		{
		}

		public MultiModeComponentActionStub(global::omg.org.RTC.MultiModeComponentAction target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::omg.org.RTC.MultiModeComponentAction)target;
		}

 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnModeChangedAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_mode_changed(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
    }
    public class MultiModeObjectStub : IStub
    {
		private global::omg.org.RTC.MultiModeObject _target;

		public MultiModeObjectStub()
		{
		}

		public MultiModeObjectStub(global::omg.org.RTC.MultiModeObject target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::omg.org.RTC.MultiModeObject)target;
		}
 
		public static explicit operator omg.org.RTC.LightweightRTObject(ReactiveRTM.omg.org.RTC.MultiModeObjectStub child)
		{
			return new omg.org.RTC.LightweightRTObjectStub((omg.org.RTC.LightweightRTObject)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.omg.org.RTC.MultiModeObjectStub(omg.org.RTC.LightweightRTObjectStub parent)
		{
			return new ReactiveRTM.omg.org.RTC.MultiModeObjectStub((global::omg.org.RTC.MultiModeObject)((IStub)parent).GetTarget());
		}
 
		public static explicit operator omg.org.RTC.ComponentAction(ReactiveRTM.omg.org.RTC.MultiModeObjectStub child)
		{
			return new omg.org.RTC.ComponentActionStub((omg.org.RTC.ComponentAction)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.omg.org.RTC.MultiModeObjectStub(omg.org.RTC.ComponentActionStub parent)
		{
			return new ReactiveRTM.omg.org.RTC.MultiModeObjectStub((global::omg.org.RTC.MultiModeObject)((IStub)parent).GetTarget());
		}
 
		public static explicit operator omg.org.RTC.ModeCapable(ReactiveRTM.omg.org.RTC.MultiModeObjectStub child)
		{
			return new omg.org.RTC.ModeCapableStub((omg.org.RTC.ModeCapable)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.omg.org.RTC.MultiModeObjectStub(omg.org.RTC.ModeCapableStub parent)
		{
			return new ReactiveRTM.omg.org.RTC.MultiModeObjectStub((global::omg.org.RTC.MultiModeObject)((IStub)parent).GetTarget());
		}
 
		public static explicit operator omg.org.RTC.MultiModeComponentAction(ReactiveRTM.omg.org.RTC.MultiModeObjectStub child)
		{
			return new omg.org.RTC.MultiModeComponentActionStub((omg.org.RTC.MultiModeComponentAction)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.omg.org.RTC.MultiModeObjectStub(omg.org.RTC.MultiModeComponentActionStub parent)
		{
			return new ReactiveRTM.omg.org.RTC.MultiModeObjectStub((global::omg.org.RTC.MultiModeObject)((IStub)parent).GetTarget());
		}

 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> InitializeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.initialize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> FinalizeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target._finalize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<System.Boolean> IsAliveAsync(global::omg.org.RTC.ExecutionContext exec_context)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.is_alive(exec_context);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> ExitAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target._exit();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<System.Int32> AttachContextAsync(global::omg.org.RTC.ExecutionContext exec_context)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.attach_context(exec_context);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> DetachContextAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.detach_context(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ExecutionContextStub> GetContextAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_context(exec_handle);
				return new ReactiveRTM.omg.org.RTC.ExecutionContextStub(ret);
			});
        }
 
        public Task<List<ReactiveRTM.omg.org.RTC.ExecutionContextStub>> GetOwnedContextsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_owned_contexts();
				return ret.Select(x=>new ReactiveRTM.omg.org.RTC.ExecutionContextStub(x)).ToList();
			});
        }
 
        public Task<List<ReactiveRTM.omg.org.RTC.ExecutionContextStub>> GetParticipatingContextsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_participating_contexts();
				return ret.Select(x=>new ReactiveRTM.omg.org.RTC.ExecutionContextStub(x)).ToList();
			});
        }
 
        public Task<System.Int32> GetContextHandleAsync(global::omg.org.RTC.ExecutionContext cxt)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_context_handle(cxt);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnInitializeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_initialize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnFinalizeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_finalize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnStartupAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_startup(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnShutdownAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_shutdown(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnActivatedAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_activated(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnDeactivatedAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_deactivated(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnAbortingAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_aborting(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnErrorAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_error(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnResetAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_reset(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ModeStub> GetDefaultModeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_default_mode();
				return new ReactiveRTM.omg.org.RTC.ModeStub(ret);
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ModeStub> GetCurrentModeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_current_mode();
				return new ReactiveRTM.omg.org.RTC.ModeStub(ret);
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ModeStub> GetCurrentModeInContextAsync(global::omg.org.RTC.ExecutionContext exec_context)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_current_mode_in_context(exec_context);
				return new ReactiveRTM.omg.org.RTC.ModeStub(ret);
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ModeStub> GetPendingModeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_pending_mode();
				return new ReactiveRTM.omg.org.RTC.ModeStub(ret);
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ModeStub> GetPendingModeInContextAsync(global::omg.org.RTC.ExecutionContext exec_context)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_pending_mode_in_context(exec_context);
				return new ReactiveRTM.omg.org.RTC.ModeStub(ret);
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> SetModeAsync(global::omg.org.RTC.Mode new_mode,global::System.Boolean immediate)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.set_mode(new_mode,immediate);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnModeChangedAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_mode_changed(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
    }
    public class RTObjectStub : IStub
    {
		private global::omg.org.RTC.RTObject _target;

		public RTObjectStub()
		{
		}

		public RTObjectStub(global::omg.org.RTC.RTObject target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::omg.org.RTC.RTObject)target;
		}
 
		public static explicit operator omg.org.RTC.LightweightRTObject(ReactiveRTM.omg.org.RTC.RTObjectStub child)
		{
			return new omg.org.RTC.LightweightRTObjectStub((omg.org.RTC.LightweightRTObject)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.omg.org.RTC.RTObjectStub(omg.org.RTC.LightweightRTObjectStub parent)
		{
			return new ReactiveRTM.omg.org.RTC.RTObjectStub((global::omg.org.RTC.RTObject)((IStub)parent).GetTarget());
		}
 
		public static explicit operator omg.org.RTC.ComponentAction(ReactiveRTM.omg.org.RTC.RTObjectStub child)
		{
			return new omg.org.RTC.ComponentActionStub((omg.org.RTC.ComponentAction)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.omg.org.RTC.RTObjectStub(omg.org.RTC.ComponentActionStub parent)
		{
			return new ReactiveRTM.omg.org.RTC.RTObjectStub((global::omg.org.RTC.RTObject)((IStub)parent).GetTarget());
		}
 
		public static explicit operator org.omg.SDOPackage.SDO(ReactiveRTM.omg.org.RTC.RTObjectStub child)
		{
			return new org.omg.SDOPackage.SDOStub((org.omg.SDOPackage.SDO)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.omg.org.RTC.RTObjectStub(org.omg.SDOPackage.SDOStub parent)
		{
			return new ReactiveRTM.omg.org.RTC.RTObjectStub((global::omg.org.RTC.RTObject)((IStub)parent).GetTarget());
		}
 
		public static explicit operator org.omg.SDOPackage.SDOSystemElement(ReactiveRTM.omg.org.RTC.RTObjectStub child)
		{
			return new org.omg.SDOPackage.SDOSystemElementStub((org.omg.SDOPackage.SDOSystemElement)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.omg.org.RTC.RTObjectStub(org.omg.SDOPackage.SDOSystemElementStub parent)
		{
			return new ReactiveRTM.omg.org.RTC.RTObjectStub((global::omg.org.RTC.RTObject)((IStub)parent).GetTarget());
		}

 
        public Task<ReactiveRTM.omg.org.RTC.ComponentProfile> GetComponentProfileAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_component_profile();
				return new ReactiveRTM.omg.org.RTC.ComponentProfile(ret);
			});
        }
 
        public Task<List<ReactiveRTM.omg.org.RTC.PortServiceStub>> GetPortsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_ports();
				return ret.Select(x=>new ReactiveRTM.omg.org.RTC.PortServiceStub(x)).ToList();
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> InitializeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.initialize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> FinalizeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target._finalize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<System.Boolean> IsAliveAsync(global::omg.org.RTC.ExecutionContext exec_context)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.is_alive(exec_context);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> ExitAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target._exit();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<System.Int32> AttachContextAsync(global::omg.org.RTC.ExecutionContext exec_context)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.attach_context(exec_context);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> DetachContextAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.detach_context(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ExecutionContextStub> GetContextAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_context(exec_handle);
				return new ReactiveRTM.omg.org.RTC.ExecutionContextStub(ret);
			});
        }
 
        public Task<List<ReactiveRTM.omg.org.RTC.ExecutionContextStub>> GetOwnedContextsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_owned_contexts();
				return ret.Select(x=>new ReactiveRTM.omg.org.RTC.ExecutionContextStub(x)).ToList();
			});
        }
 
        public Task<List<ReactiveRTM.omg.org.RTC.ExecutionContextStub>> GetParticipatingContextsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_participating_contexts();
				return ret.Select(x=>new ReactiveRTM.omg.org.RTC.ExecutionContextStub(x)).ToList();
			});
        }
 
        public Task<System.Int32> GetContextHandleAsync(global::omg.org.RTC.ExecutionContext cxt)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_context_handle(cxt);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnInitializeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_initialize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnFinalizeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_finalize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnStartupAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_startup(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnShutdownAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_shutdown(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnActivatedAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_activated(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnDeactivatedAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_deactivated(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnAbortingAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_aborting(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnErrorAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_error(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnResetAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_reset(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<System.String> GetSdoIdAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_sdo_id();
				return ret;
			});
        }
 
        public Task<System.String> GetSdoTypeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_sdo_type();
				return ret;
			});
        }
 
        public Task<ReactiveRTM.org.omg.SDOPackage.DeviceProfile> GetDeviceProfileAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_device_profile();
				return new ReactiveRTM.org.omg.SDOPackage.DeviceProfile(ret);
			});
        }
 
        public Task<List<ReactiveRTM.org.omg.SDOPackage.ServiceProfile>> GetServiceProfilesAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_service_profiles();
				return ret.Select(x=>new ReactiveRTM.org.omg.SDOPackage.ServiceProfile(x)).ToList();
			});
        }
 
        public Task<ReactiveRTM.org.omg.SDOPackage.ServiceProfile> GetServiceProfileAsync(global::System.String id)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_service_profile(id);
				return new ReactiveRTM.org.omg.SDOPackage.ServiceProfile(ret);
			});
        }
 
        public Task<ReactiveRTM.org.omg.SDOPackage.SDOServiceStub> GetSdoServiceAsync(global::System.String id)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_sdo_service(id);
				return new ReactiveRTM.org.omg.SDOPackage.SDOServiceStub(ret);
			});
        }
 
        public Task<ReactiveRTM.org.omg.SDOPackage.ConfigurationStub> GetConfigurationAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_configuration();
				return new ReactiveRTM.org.omg.SDOPackage.ConfigurationStub(ret);
			});
        }
 
        public Task<ReactiveRTM.org.omg.SDOPackage.MonitoringStub> GetMonitoringAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_monitoring();
				return new ReactiveRTM.org.omg.SDOPackage.MonitoringStub(ret);
			});
        }
 
        public Task<List<ReactiveRTM.org.omg.SDOPackage.OrganizationStub>> GetOrganizationsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_organizations();
				return ret.Select(x=>new ReactiveRTM.org.omg.SDOPackage.OrganizationStub(x)).ToList();
			});
        }
 
        public Task<List<ReactiveRTM.org.omg.SDOPackage.NameValue>> GetStatusListAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_status_list();
				return ret.Select(x=>new ReactiveRTM.org.omg.SDOPackage.NameValue(x)).ToList();
			});
        }
 
        public Task<System.Object> GetStatusAsync(global::System.String nme)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_status(nme);
				return (System.Object)ret;
			});
        }
 
        public Task<List<ReactiveRTM.org.omg.SDOPackage.OrganizationStub>> GetOwnedOrganizationsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_owned_organizations();
				return ret.Select(x=>new ReactiveRTM.org.omg.SDOPackage.OrganizationStub(x)).ToList();
			});
        }
    }
    public class PortServiceStub : IStub
    {
		private global::omg.org.RTC.PortService _target;

		public PortServiceStub()
		{
		}

		public PortServiceStub(global::omg.org.RTC.PortService target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::omg.org.RTC.PortService)target;
		}
 
		public static explicit operator org.omg.SDOPackage.SDOService(ReactiveRTM.omg.org.RTC.PortServiceStub child)
		{
			return new org.omg.SDOPackage.SDOServiceStub((org.omg.SDOPackage.SDOService)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.omg.org.RTC.PortServiceStub(org.omg.SDOPackage.SDOServiceStub parent)
		{
			return new ReactiveRTM.omg.org.RTC.PortServiceStub((global::omg.org.RTC.PortService)((IStub)parent).GetTarget());
		}

 
        public Task<ReactiveRTM.omg.org.RTC.PortProfile> GetPortProfileAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_port_profile();
				return new ReactiveRTM.omg.org.RTC.PortProfile(ret);
			});
        }
 
        public Task<List<ReactiveRTM.omg.org.RTC.ConnectorProfile>> GetConnectorProfilesAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_connector_profiles();
				return ret.Select(x=>new ReactiveRTM.omg.org.RTC.ConnectorProfile(x)).ToList();
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ConnectorProfile> GetConnectorProfileAsync(global::System.String connector_id)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_connector_profile(connector_id);
				return new ReactiveRTM.omg.org.RTC.ConnectorProfile(ret);
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> ConnectAsync(global::omg.org.RTC.ConnectorProfile connector_profile)
        {
            return Task.Factory.StartNew(()=>{
 
			    var tmpconnector_profile = ((global::omg.org.RTC.ConnectorProfile)((IStub)connector_profile).GetTarget());
				var ret = _target.connect(ref tmpconnector_profile);
 
			    connector_profile = new ReactiveRTM.omg.org.RTC.ConnectorProfile(tmpconnector_profile);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> DisconnectAsync(global::System.String connector_id)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.disconnect(connector_id);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> DisconnectAllAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.disconnect_all();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> NotifyConnectAsync(global::omg.org.RTC.ConnectorProfile connector_profile)
        {
            return Task.Factory.StartNew(()=>{
 
			    var tmpconnector_profile = ((global::omg.org.RTC.ConnectorProfile)((IStub)connector_profile).GetTarget());
				var ret = _target.notify_connect(ref tmpconnector_profile);
 
			    connector_profile = new ReactiveRTM.omg.org.RTC.ConnectorProfile(tmpconnector_profile);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> NotifyDisconnectAsync(global::System.String connector_id)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.notify_disconnect(connector_id);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
    }
    public class FsmObjectStub : IStub
    {
		private global::omg.org.RTC.FsmObject _target;

		public FsmObjectStub()
		{
		}

		public FsmObjectStub(global::omg.org.RTC.FsmObject target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::omg.org.RTC.FsmObject)target;
		}

 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> SendStimulusAsync(global::System.String message,global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.send_stimulus(message,exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
    }
    public class FsmServiceStub : IStub
    {
		private global::omg.org.RTC.FsmService _target;

		public FsmServiceStub()
		{
		}

		public FsmServiceStub(global::omg.org.RTC.FsmService target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::omg.org.RTC.FsmService)target;
		}
 
		public static explicit operator org.omg.SDOPackage.SDOService(ReactiveRTM.omg.org.RTC.FsmServiceStub child)
		{
			return new org.omg.SDOPackage.SDOServiceStub((org.omg.SDOPackage.SDOService)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.omg.org.RTC.FsmServiceStub(org.omg.SDOPackage.SDOServiceStub parent)
		{
			return new ReactiveRTM.omg.org.RTC.FsmServiceStub((global::omg.org.RTC.FsmService)((IStub)parent).GetTarget());
		}

 
        public Task<ReactiveRTM.omg.org.RTC.FsmProfile> GetFsmProfileAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_fsm_profile();
				return new ReactiveRTM.omg.org.RTC.FsmProfile(ret);
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> SetFsmProfileAsync(global::omg.org.RTC.FsmProfile fsm_profile)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.set_fsm_profile(fsm_profile);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
    }
    public class ExecutionContextServiceStub : IStub
    {
		private global::omg.org.RTC.ExecutionContextService _target;

		public ExecutionContextServiceStub()
		{
		}

		public ExecutionContextServiceStub(global::omg.org.RTC.ExecutionContextService target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::omg.org.RTC.ExecutionContextService)target;
		}
 
		public static explicit operator omg.org.RTC.ExecutionContext(ReactiveRTM.omg.org.RTC.ExecutionContextServiceStub child)
		{
			return new omg.org.RTC.ExecutionContextStub((omg.org.RTC.ExecutionContext)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.omg.org.RTC.ExecutionContextServiceStub(omg.org.RTC.ExecutionContextStub parent)
		{
			return new ReactiveRTM.omg.org.RTC.ExecutionContextServiceStub((global::omg.org.RTC.ExecutionContextService)((IStub)parent).GetTarget());
		}
 
		public static explicit operator org.omg.SDOPackage.SDOService(ReactiveRTM.omg.org.RTC.ExecutionContextServiceStub child)
		{
			return new org.omg.SDOPackage.SDOServiceStub((org.omg.SDOPackage.SDOService)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.omg.org.RTC.ExecutionContextServiceStub(org.omg.SDOPackage.SDOServiceStub parent)
		{
			return new ReactiveRTM.omg.org.RTC.ExecutionContextServiceStub((global::omg.org.RTC.ExecutionContextService)((IStub)parent).GetTarget());
		}

 
        public Task<ReactiveRTM.omg.org.RTC.ExecutionContextProfile> GetProfileAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_profile();
				return new ReactiveRTM.omg.org.RTC.ExecutionContextProfile(ret);
			});
        }
 
        public Task<System.Boolean> IsRunningAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.is_running();
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> StartAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.start();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> StopAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target._stop();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<System.Double> GetRateAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_rate();
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> SetRateAsync(global::System.Double rate)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.set_rate(rate);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> AddComponentAsync(global::omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.add_component(comp);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> RemoveComponentAsync(global::omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.remove_component(comp);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> ActivateComponentAsync(global::omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.activate_component(comp);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> DeactivateComponentAsync(global::omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.deactivate_component(comp);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> ResetComponentAsync(global::omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.reset_component(comp);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.LifeCycleState> GetComponentStateAsync(global::omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_component_state(comp);
				return (omg.org.RTC.LifeCycleState)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ExecutionKind> GetKindAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_kind();
				return (omg.org.RTC.ExecutionKind)ret;
			});
        }
    }
}
 
namespace ReactiveRTM.OpenRTM
{
    public class ComponentObserverStub : IStub
    {
		private global::OpenRTM.ComponentObserver _target;

		public ComponentObserverStub()
		{
		}

		public ComponentObserverStub(global::OpenRTM.ComponentObserver target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::OpenRTM.ComponentObserver)target;
		}
 
		public static explicit operator org.omg.SDOPackage.SDOService(ReactiveRTM.OpenRTM.ComponentObserverStub child)
		{
			return new org.omg.SDOPackage.SDOServiceStub((org.omg.SDOPackage.SDOService)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.OpenRTM.ComponentObserverStub(org.omg.SDOPackage.SDOServiceStub parent)
		{
			return new ReactiveRTM.OpenRTM.ComponentObserverStub((global::OpenRTM.ComponentObserver)((IStub)parent).GetTarget());
		}

 
        public Task UpdateStatusAsync(global::OpenRTM.StatusKind status_kind,global::System.String hint)
        {
            return Task.Factory.StartNew(()=>{
				_target.update_status(status_kind,hint);
				return;
			});
        }
    }
    public class InPortCdrStub : IStub
    {
		private global::OpenRTM.InPortCdr _target;

		public InPortCdrStub()
		{
		}

		public InPortCdrStub(global::OpenRTM.InPortCdr target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::OpenRTM.InPortCdr)target;
		}

 
        public Task<ReactiveRTM.OpenRTM.PortStatus> PutAsync(global::System.Byte[] data)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.put(data);
				return (OpenRTM.PortStatus)ret;
			});
        }
    }
    public class OutPortCdrStub : IStub
    {
		private global::OpenRTM.OutPortCdr _target;

		public OutPortCdrStub()
		{
		}

		public OutPortCdrStub(global::OpenRTM.OutPortCdr target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::OpenRTM.OutPortCdr)target;
		}

 
        public Task<ReactiveRTM.OpenRTM.PortStatus> GetAsync(global::System.Byte[] data)
        {
            return Task.Factory.StartNew(()=>{
 
			    var tmpdata = data.Select(x=>x).ToArray();
				var ret = _target._get(out tmpdata);
 
			    data = tmpdata.Select(x=>x).ToList();
				return (OpenRTM.PortStatus)ret;
			});
        }
    }
    public class LoggerStub : IStub
    {
		private global::OpenRTM.Logger _target;

		public LoggerStub()
		{
		}

		public LoggerStub(global::OpenRTM.Logger target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::OpenRTM.Logger)target;
		}
 
		public static explicit operator org.omg.SDOPackage.SDOService(ReactiveRTM.OpenRTM.LoggerStub child)
		{
			return new org.omg.SDOPackage.SDOServiceStub((org.omg.SDOPackage.SDOService)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.OpenRTM.LoggerStub(org.omg.SDOPackage.SDOServiceStub parent)
		{
			return new ReactiveRTM.OpenRTM.LoggerStub((global::OpenRTM.Logger)((IStub)parent).GetTarget());
		}

 
        public Task PublishAsync(global::OpenRTM.LogRecord record)
        {
            return Task.Factory.StartNew(()=>{
				_target.publish(record);
				return;
			});
        }
 
        public Task CloseAsync()
        {
            return Task.Factory.StartNew(()=>{
				_target.close();
				return;
			});
        }
    }
}
 
namespace ReactiveRTM.openrtm.aist.go.jp.OpenRTM
{
    public class DataFlowComponentStub : IStub
    {
		private global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent _target;

		public DataFlowComponentStub()
		{
		}

		public DataFlowComponentStub(global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent)target;
		}
 
		public static explicit operator omg.org.RTC.RTObject(ReactiveRTM.openrtm.aist.go.jp.OpenRTM.DataFlowComponentStub child)
		{
			return new omg.org.RTC.RTObjectStub((omg.org.RTC.RTObject)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.openrtm.aist.go.jp.OpenRTM.DataFlowComponentStub(omg.org.RTC.RTObjectStub parent)
		{
			return new ReactiveRTM.openrtm.aist.go.jp.OpenRTM.DataFlowComponentStub((global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent)((IStub)parent).GetTarget());
		}
 
		public static explicit operator omg.org.RTC.LightweightRTObject(ReactiveRTM.openrtm.aist.go.jp.OpenRTM.DataFlowComponentStub child)
		{
			return new omg.org.RTC.LightweightRTObjectStub((omg.org.RTC.LightweightRTObject)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.openrtm.aist.go.jp.OpenRTM.DataFlowComponentStub(omg.org.RTC.LightweightRTObjectStub parent)
		{
			return new ReactiveRTM.openrtm.aist.go.jp.OpenRTM.DataFlowComponentStub((global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent)((IStub)parent).GetTarget());
		}
 
		public static explicit operator omg.org.RTC.ComponentAction(ReactiveRTM.openrtm.aist.go.jp.OpenRTM.DataFlowComponentStub child)
		{
			return new omg.org.RTC.ComponentActionStub((omg.org.RTC.ComponentAction)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.openrtm.aist.go.jp.OpenRTM.DataFlowComponentStub(omg.org.RTC.ComponentActionStub parent)
		{
			return new ReactiveRTM.openrtm.aist.go.jp.OpenRTM.DataFlowComponentStub((global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent)((IStub)parent).GetTarget());
		}
 
		public static explicit operator org.omg.SDOPackage.SDO(ReactiveRTM.openrtm.aist.go.jp.OpenRTM.DataFlowComponentStub child)
		{
			return new org.omg.SDOPackage.SDOStub((org.omg.SDOPackage.SDO)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.openrtm.aist.go.jp.OpenRTM.DataFlowComponentStub(org.omg.SDOPackage.SDOStub parent)
		{
			return new ReactiveRTM.openrtm.aist.go.jp.OpenRTM.DataFlowComponentStub((global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent)((IStub)parent).GetTarget());
		}
 
		public static explicit operator org.omg.SDOPackage.SDOSystemElement(ReactiveRTM.openrtm.aist.go.jp.OpenRTM.DataFlowComponentStub child)
		{
			return new org.omg.SDOPackage.SDOSystemElementStub((org.omg.SDOPackage.SDOSystemElement)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.openrtm.aist.go.jp.OpenRTM.DataFlowComponentStub(org.omg.SDOPackage.SDOSystemElementStub parent)
		{
			return new ReactiveRTM.openrtm.aist.go.jp.OpenRTM.DataFlowComponentStub((global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent)((IStub)parent).GetTarget());
		}
 
		public static explicit operator omg.org.RTC.DataFlowComponent(ReactiveRTM.openrtm.aist.go.jp.OpenRTM.DataFlowComponentStub child)
		{
			return new omg.org.RTC.DataFlowComponentStub((omg.org.RTC.DataFlowComponent)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.openrtm.aist.go.jp.OpenRTM.DataFlowComponentStub(omg.org.RTC.DataFlowComponentStub parent)
		{
			return new ReactiveRTM.openrtm.aist.go.jp.OpenRTM.DataFlowComponentStub((global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent)((IStub)parent).GetTarget());
		}
 
		public static explicit operator omg.org.RTC.DataFlowComponentAction(ReactiveRTM.openrtm.aist.go.jp.OpenRTM.DataFlowComponentStub child)
		{
			return new omg.org.RTC.DataFlowComponentActionStub((omg.org.RTC.DataFlowComponentAction)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.openrtm.aist.go.jp.OpenRTM.DataFlowComponentStub(omg.org.RTC.DataFlowComponentActionStub parent)
		{
			return new ReactiveRTM.openrtm.aist.go.jp.OpenRTM.DataFlowComponentStub((global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent)((IStub)parent).GetTarget());
		}

 
        public Task<ReactiveRTM.omg.org.RTC.ComponentProfile> GetComponentProfileAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_component_profile();
				return new ReactiveRTM.omg.org.RTC.ComponentProfile(ret);
			});
        }
 
        public Task<List<ReactiveRTM.omg.org.RTC.PortServiceStub>> GetPortsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_ports();
				return ret.Select(x=>new ReactiveRTM.omg.org.RTC.PortServiceStub(x)).ToList();
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> InitializeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.initialize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> FinalizeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target._finalize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<System.Boolean> IsAliveAsync(global::omg.org.RTC.ExecutionContext exec_context)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.is_alive(exec_context);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> ExitAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target._exit();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<System.Int32> AttachContextAsync(global::omg.org.RTC.ExecutionContext exec_context)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.attach_context(exec_context);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> DetachContextAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.detach_context(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ExecutionContextStub> GetContextAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_context(exec_handle);
				return new ReactiveRTM.omg.org.RTC.ExecutionContextStub(ret);
			});
        }
 
        public Task<List<ReactiveRTM.omg.org.RTC.ExecutionContextStub>> GetOwnedContextsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_owned_contexts();
				return ret.Select(x=>new ReactiveRTM.omg.org.RTC.ExecutionContextStub(x)).ToList();
			});
        }
 
        public Task<List<ReactiveRTM.omg.org.RTC.ExecutionContextStub>> GetParticipatingContextsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_participating_contexts();
				return ret.Select(x=>new ReactiveRTM.omg.org.RTC.ExecutionContextStub(x)).ToList();
			});
        }
 
        public Task<System.Int32> GetContextHandleAsync(global::omg.org.RTC.ExecutionContext cxt)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_context_handle(cxt);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnInitializeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_initialize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnFinalizeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_finalize();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnStartupAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_startup(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnShutdownAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_shutdown(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnActivatedAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_activated(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnDeactivatedAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_deactivated(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnAbortingAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_aborting(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnErrorAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_error(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnResetAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_reset(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<System.String> GetSdoIdAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_sdo_id();
				return ret;
			});
        }
 
        public Task<System.String> GetSdoTypeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_sdo_type();
				return ret;
			});
        }
 
        public Task<ReactiveRTM.org.omg.SDOPackage.DeviceProfile> GetDeviceProfileAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_device_profile();
				return new ReactiveRTM.org.omg.SDOPackage.DeviceProfile(ret);
			});
        }
 
        public Task<List<ReactiveRTM.org.omg.SDOPackage.ServiceProfile>> GetServiceProfilesAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_service_profiles();
				return ret.Select(x=>new ReactiveRTM.org.omg.SDOPackage.ServiceProfile(x)).ToList();
			});
        }
 
        public Task<ReactiveRTM.org.omg.SDOPackage.ServiceProfile> GetServiceProfileAsync(global::System.String id)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_service_profile(id);
				return new ReactiveRTM.org.omg.SDOPackage.ServiceProfile(ret);
			});
        }
 
        public Task<ReactiveRTM.org.omg.SDOPackage.SDOServiceStub> GetSdoServiceAsync(global::System.String id)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_sdo_service(id);
				return new ReactiveRTM.org.omg.SDOPackage.SDOServiceStub(ret);
			});
        }
 
        public Task<ReactiveRTM.org.omg.SDOPackage.ConfigurationStub> GetConfigurationAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_configuration();
				return new ReactiveRTM.org.omg.SDOPackage.ConfigurationStub(ret);
			});
        }
 
        public Task<ReactiveRTM.org.omg.SDOPackage.MonitoringStub> GetMonitoringAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_monitoring();
				return new ReactiveRTM.org.omg.SDOPackage.MonitoringStub(ret);
			});
        }
 
        public Task<List<ReactiveRTM.org.omg.SDOPackage.OrganizationStub>> GetOrganizationsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_organizations();
				return ret.Select(x=>new ReactiveRTM.org.omg.SDOPackage.OrganizationStub(x)).ToList();
			});
        }
 
        public Task<List<ReactiveRTM.org.omg.SDOPackage.NameValue>> GetStatusListAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_status_list();
				return ret.Select(x=>new ReactiveRTM.org.omg.SDOPackage.NameValue(x)).ToList();
			});
        }
 
        public Task<System.Object> GetStatusAsync(global::System.String nme)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_status(nme);
				return (System.Object)ret;
			});
        }
 
        public Task<List<ReactiveRTM.org.omg.SDOPackage.OrganizationStub>> GetOwnedOrganizationsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_owned_organizations();
				return ret.Select(x=>new ReactiveRTM.org.omg.SDOPackage.OrganizationStub(x)).ToList();
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnExecuteAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_execute(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnStateUpdateAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_state_update(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> OnRateChangedAsync(global::System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.on_rate_changed(exec_handle);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
    }
    public class ExtTrigExecutionContextServiceStub : IStub
    {
		private global::openrtm.aist.go.jp.OpenRTM.ExtTrigExecutionContextService _target;

		public ExtTrigExecutionContextServiceStub()
		{
		}

		public ExtTrigExecutionContextServiceStub(global::openrtm.aist.go.jp.OpenRTM.ExtTrigExecutionContextService target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::openrtm.aist.go.jp.OpenRTM.ExtTrigExecutionContextService)target;
		}
 
		public static explicit operator omg.org.RTC.ExecutionContextService(ReactiveRTM.openrtm.aist.go.jp.OpenRTM.ExtTrigExecutionContextServiceStub child)
		{
			return new omg.org.RTC.ExecutionContextServiceStub((omg.org.RTC.ExecutionContextService)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.openrtm.aist.go.jp.OpenRTM.ExtTrigExecutionContextServiceStub(omg.org.RTC.ExecutionContextServiceStub parent)
		{
			return new ReactiveRTM.openrtm.aist.go.jp.OpenRTM.ExtTrigExecutionContextServiceStub((global::openrtm.aist.go.jp.OpenRTM.ExtTrigExecutionContextService)((IStub)parent).GetTarget());
		}
 
		public static explicit operator omg.org.RTC.ExecutionContext(ReactiveRTM.openrtm.aist.go.jp.OpenRTM.ExtTrigExecutionContextServiceStub child)
		{
			return new omg.org.RTC.ExecutionContextStub((omg.org.RTC.ExecutionContext)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.openrtm.aist.go.jp.OpenRTM.ExtTrigExecutionContextServiceStub(omg.org.RTC.ExecutionContextStub parent)
		{
			return new ReactiveRTM.openrtm.aist.go.jp.OpenRTM.ExtTrigExecutionContextServiceStub((global::openrtm.aist.go.jp.OpenRTM.ExtTrigExecutionContextService)((IStub)parent).GetTarget());
		}
 
		public static explicit operator org.omg.SDOPackage.SDOService(ReactiveRTM.openrtm.aist.go.jp.OpenRTM.ExtTrigExecutionContextServiceStub child)
		{
			return new org.omg.SDOPackage.SDOServiceStub((org.omg.SDOPackage.SDOService)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.openrtm.aist.go.jp.OpenRTM.ExtTrigExecutionContextServiceStub(org.omg.SDOPackage.SDOServiceStub parent)
		{
			return new ReactiveRTM.openrtm.aist.go.jp.OpenRTM.ExtTrigExecutionContextServiceStub((global::openrtm.aist.go.jp.OpenRTM.ExtTrigExecutionContextService)((IStub)parent).GetTarget());
		}

 
        public Task TickAsync()
        {
            return Task.Factory.StartNew(()=>{
				_target.tick();
				return;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ExecutionContextProfile> GetProfileAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_profile();
				return new ReactiveRTM.omg.org.RTC.ExecutionContextProfile(ret);
			});
        }
 
        public Task<System.Boolean> IsRunningAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.is_running();
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> StartAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.start();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> StopAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target._stop();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<System.Double> GetRateAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_rate();
				return ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> SetRateAsync(global::System.Double rate)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.set_rate(rate);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> AddComponentAsync(global::omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.add_component(comp);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> RemoveComponentAsync(global::omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.remove_component(comp);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> ActivateComponentAsync(global::omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.activate_component(comp);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> DeactivateComponentAsync(global::omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.deactivate_component(comp);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> ResetComponentAsync(global::omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.reset_component(comp);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.LifeCycleState> GetComponentStateAsync(global::omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_component_state(comp);
				return (omg.org.RTC.LifeCycleState)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ExecutionKind> GetKindAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_kind();
				return (omg.org.RTC.ExecutionKind)ret;
			});
        }
    }
}
 
namespace ReactiveRTM.org.omg.SDOPackage
{
    public class SDOStub : IStub
    {
		private global::org.omg.SDOPackage.SDO _target;

		public SDOStub()
		{
		}

		public SDOStub(global::org.omg.SDOPackage.SDO target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::org.omg.SDOPackage.SDO)target;
		}
 
		public static explicit operator org.omg.SDOPackage.SDOSystemElement(ReactiveRTM.org.omg.SDOPackage.SDOStub child)
		{
			return new org.omg.SDOPackage.SDOSystemElementStub((org.omg.SDOPackage.SDOSystemElement)((IStub)child).GetTarget());
		}
		public static implicit operator ReactiveRTM.org.omg.SDOPackage.SDOStub(org.omg.SDOPackage.SDOSystemElementStub parent)
		{
			return new ReactiveRTM.org.omg.SDOPackage.SDOStub((global::org.omg.SDOPackage.SDO)((IStub)parent).GetTarget());
		}

 
        public Task<System.String> GetSdoIdAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_sdo_id();
				return ret;
			});
        }
 
        public Task<System.String> GetSdoTypeAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_sdo_type();
				return ret;
			});
        }
 
        public Task<ReactiveRTM.org.omg.SDOPackage.DeviceProfile> GetDeviceProfileAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_device_profile();
				return new ReactiveRTM.org.omg.SDOPackage.DeviceProfile(ret);
			});
        }
 
        public Task<List<ReactiveRTM.org.omg.SDOPackage.ServiceProfile>> GetServiceProfilesAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_service_profiles();
				return ret.Select(x=>new ReactiveRTM.org.omg.SDOPackage.ServiceProfile(x)).ToList();
			});
        }
 
        public Task<ReactiveRTM.org.omg.SDOPackage.ServiceProfile> GetServiceProfileAsync(global::System.String id)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_service_profile(id);
				return new ReactiveRTM.org.omg.SDOPackage.ServiceProfile(ret);
			});
        }
 
        public Task<ReactiveRTM.org.omg.SDOPackage.SDOServiceStub> GetSdoServiceAsync(global::System.String id)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_sdo_service(id);
				return new ReactiveRTM.org.omg.SDOPackage.SDOServiceStub(ret);
			});
        }
 
        public Task<ReactiveRTM.org.omg.SDOPackage.ConfigurationStub> GetConfigurationAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_configuration();
				return new ReactiveRTM.org.omg.SDOPackage.ConfigurationStub(ret);
			});
        }
 
        public Task<ReactiveRTM.org.omg.SDOPackage.MonitoringStub> GetMonitoringAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_monitoring();
				return new ReactiveRTM.org.omg.SDOPackage.MonitoringStub(ret);
			});
        }
 
        public Task<List<ReactiveRTM.org.omg.SDOPackage.OrganizationStub>> GetOrganizationsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_organizations();
				return ret.Select(x=>new ReactiveRTM.org.omg.SDOPackage.OrganizationStub(x)).ToList();
			});
        }
 
        public Task<List<ReactiveRTM.org.omg.SDOPackage.NameValue>> GetStatusListAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_status_list();
				return ret.Select(x=>new ReactiveRTM.org.omg.SDOPackage.NameValue(x)).ToList();
			});
        }
 
        public Task<System.Object> GetStatusAsync(global::System.String nme)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_status(nme);
				return (System.Object)ret;
			});
        }
 
        public Task<List<ReactiveRTM.org.omg.SDOPackage.OrganizationStub>> GetOwnedOrganizationsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_owned_organizations();
				return ret.Select(x=>new ReactiveRTM.org.omg.SDOPackage.OrganizationStub(x)).ToList();
			});
        }
    }
    public class SDOServiceStub : IStub
    {
		private global::org.omg.SDOPackage.SDOService _target;

		public SDOServiceStub()
		{
		}

		public SDOServiceStub(global::org.omg.SDOPackage.SDOService target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::org.omg.SDOPackage.SDOService)target;
		}

    }
    public class SDOSystemElementStub : IStub
    {
		private global::org.omg.SDOPackage.SDOSystemElement _target;

		public SDOSystemElementStub()
		{
		}

		public SDOSystemElementStub(global::org.omg.SDOPackage.SDOSystemElement target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::org.omg.SDOPackage.SDOSystemElement)target;
		}

 
        public Task<List<ReactiveRTM.org.omg.SDOPackage.OrganizationStub>> GetOwnedOrganizationsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_owned_organizations();
				return ret.Select(x=>new ReactiveRTM.org.omg.SDOPackage.OrganizationStub(x)).ToList();
			});
        }
    }
    public class ConfigurationStub : IStub
    {
		private global::org.omg.SDOPackage.Configuration _target;

		public ConfigurationStub()
		{
		}

		public ConfigurationStub(global::org.omg.SDOPackage.Configuration target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::org.omg.SDOPackage.Configuration)target;
		}

 
        public Task<System.Boolean> SetDeviceProfileAsync(global::org.omg.SDOPackage.DeviceProfile dProfile)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.set_device_profile(dProfile);
				return ret;
			});
        }
 
        public Task<System.Boolean> AddServiceProfileAsync(global::org.omg.SDOPackage.ServiceProfile sProfile)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.add_service_profile(sProfile);
				return ret;
			});
        }
 
        public Task<System.Boolean> AddOrganizationAsync(global::org.omg.SDOPackage.Organization organization_object)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.add_organization(organization_object);
				return ret;
			});
        }
 
        public Task<System.Boolean> RemoveServiceProfileAsync(global::System.String id)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.remove_service_profile(id);
				return ret;
			});
        }
 
        public Task<System.Boolean> RemoveOrganizationAsync(global::System.String organization_id)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.remove_organization(organization_id);
				return ret;
			});
        }
 
        public Task<List<ReactiveRTM.org.omg.SDOPackage.Parameter>> GetConfigurationParametersAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_configuration_parameters();
				return ret.Select(x=>new ReactiveRTM.org.omg.SDOPackage.Parameter(x)).ToList();
			});
        }
 
        public Task<List<ReactiveRTM.org.omg.SDOPackage.NameValue>> GetConfigurationParameterValuesAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_configuration_parameter_values();
				return ret.Select(x=>new ReactiveRTM.org.omg.SDOPackage.NameValue(x)).ToList();
			});
        }
 
        public Task<System.Object> GetConfigurationParameterValueAsync(global::System.String name)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_configuration_parameter_value(name);
				return (System.Object)ret;
			});
        }
 
        public Task<System.Boolean> SetConfigurationParameterAsync(global::System.String name,global::System.Object value)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.set_configuration_parameter(name,value);
				return ret;
			});
        }
 
        public Task<List<ReactiveRTM.org.omg.SDOPackage.ConfigurationSet>> GetConfigurationSetsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_configuration_sets();
				return ret.Select(x=>new ReactiveRTM.org.omg.SDOPackage.ConfigurationSet(x)).ToList();
			});
        }
 
        public Task<ReactiveRTM.org.omg.SDOPackage.ConfigurationSet> GetConfigurationSetAsync(global::System.String config_id)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_configuration_set(config_id);
				return new ReactiveRTM.org.omg.SDOPackage.ConfigurationSet(ret);
			});
        }
 
        public Task<System.Boolean> SetConfigurationSetValuesAsync(global::org.omg.SDOPackage.ConfigurationSet configuration_set)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.set_configuration_set_values(configuration_set);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.org.omg.SDOPackage.ConfigurationSet> GetActiveConfigurationSetAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_active_configuration_set();
				return new ReactiveRTM.org.omg.SDOPackage.ConfigurationSet(ret);
			});
        }
 
        public Task<System.Boolean> AddConfigurationSetAsync(global::org.omg.SDOPackage.ConfigurationSet configuration_set)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.add_configuration_set(configuration_set);
				return ret;
			});
        }
 
        public Task<System.Boolean> RemoveConfigurationSetAsync(global::System.String config_id)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.remove_configuration_set(config_id);
				return ret;
			});
        }
 
        public Task<System.Boolean> ActivateConfigurationSetAsync(global::System.String config_id)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.activate_configuration_set(config_id);
				return ret;
			});
        }
    }
    public class MonitoringStub : IStub
    {
		private global::org.omg.SDOPackage.Monitoring _target;

		public MonitoringStub()
		{
		}

		public MonitoringStub(global::org.omg.SDOPackage.Monitoring target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::org.omg.SDOPackage.Monitoring)target;
		}

    }
    public class OrganizationStub : IStub
    {
		private global::org.omg.SDOPackage.Organization _target;

		public OrganizationStub()
		{
		}

		public OrganizationStub(global::org.omg.SDOPackage.Organization target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::org.omg.SDOPackage.Organization)target;
		}

 
        public Task<System.String> GetOrganizationIdAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_organization_id();
				return ret;
			});
        }
 
        public Task<ReactiveRTM.org.omg.SDOPackage.OrganizationProperty> GetOrganizationPropertyAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_organization_property();
				return new ReactiveRTM.org.omg.SDOPackage.OrganizationProperty(ret);
			});
        }
 
        public Task<System.Object> GetOrganizationPropertyValueAsync(global::System.String name)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_organization_property_value(name);
				return (System.Object)ret;
			});
        }
 
        public Task<System.Boolean> AddOrganizationPropertyAsync(global::org.omg.SDOPackage.OrganizationProperty organization_property)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.add_organization_property(organization_property);
				return ret;
			});
        }
 
        public Task<System.Boolean> SetOrganizationPropertyValueAsync(global::System.String name,global::System.Object value)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.set_organization_property_value(name,value);
				return ret;
			});
        }
 
        public Task<System.Boolean> RemoveOrganizationPropertyAsync(global::System.String name)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.remove_organization_property(name);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.org.omg.SDOPackage.SDOSystemElementStub> GetOwnerAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_owner();
				return new ReactiveRTM.org.omg.SDOPackage.SDOSystemElementStub(ret);
			});
        }
 
        public Task<System.Boolean> SetOwnerAsync(global::org.omg.SDOPackage.SDOSystemElement sdo)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.set_owner(sdo);
				return ret;
			});
        }
 
        public Task<List<ReactiveRTM.org.omg.SDOPackage.SDOStub>> GetMembersAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_members();
				return ret.Select(x=>new ReactiveRTM.org.omg.SDOPackage.SDOStub(x)).ToList();
			});
        }
 
        public Task<System.Boolean> SetMembersAsync(global::org.omg.SDOPackage.SDO[] sdos)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.set_members(sdos);
				return ret;
			});
        }
 
        public Task<System.Boolean> AddMembersAsync(global::org.omg.SDOPackage.SDO[] sdo_list)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.add_members(sdo_list);
				return ret;
			});
        }
 
        public Task<System.Boolean> RemoveMemberAsync(global::System.String id)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.remove_member(id);
				return ret;
			});
        }
 
        public Task<ReactiveRTM.org.omg.SDOPackage.DependencyType> GetDependencyAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_dependency();
				return (org.omg.SDOPackage.DependencyType)ret;
			});
        }
 
        public Task<System.Boolean> SetDependencyAsync(global::org.omg.SDOPackage.DependencyType dependency)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.set_dependency(dependency);
				return ret;
			});
        }
    }
}
 
namespace ReactiveRTM.RTC
{
    public class ActArrayStub : IStub
    {
		private global::RTC.ActArray _target;

		public ActArrayStub()
		{
		}

		public ActArrayStub(global::RTC.ActArray target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.ActArray)target;
		}

 
        public Task<ReactiveRTM.RTC.ActArrayGeometry> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.ActArrayGeometry(ret);
			});
        }
 
        public Task GoHomeAsync(global::System.Int16 index)
        {
            return Task.Factory.StartNew(()=>{
				_target.GoHome(index);
				return;
			});
        }
 
        public Task PowerAsync(global::System.Boolean enable)
        {
            return Task.Factory.StartNew(()=>{
				_target.Power(enable);
				return;
			});
        }
 
        public Task BrakesAsync(global::System.Boolean engage)
        {
            return Task.Factory.StartNew(()=>{
				_target.Brakes(engage);
				return;
			});
        }
 
        public Task ConfigSpeedAsync(global::System.Int16 index,global::System.Double speed)
        {
            return Task.Factory.StartNew(()=>{
				_target.ConfigSpeed(index,speed);
				return;
			});
        }
 
        public Task ConfigAccelAsync(global::System.Int16 index,global::System.Double accel)
        {
            return Task.Factory.StartNew(()=>{
				_target.ConfigAccel(index,accel);
				return;
			});
        }
    }
    public class AIOStub : IStub
    {
		private global::RTC.AIO _target;

		public AIOStub()
		{
		}

		public AIOStub(global::RTC.AIO target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.AIO)target;
		}

 
        public Task<System.Int16> NumChannelsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.NumChannels();
				return ret;
			});
        }
 
        public Task SetReferenceLevelAsync(global::System.Int16 index,global::System.Double level)
        {
            return Task.Factory.StartNew(()=>{
				_target.SetReferenceLevel(index,level);
				return;
			});
        }
 
        public Task<System.Double> GetResolutionAsync(global::System.Int16 index)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetResolution(index);
				return ret;
			});
        }
    }
    public class BumperStub : IStub
    {
		private global::RTC.Bumper _target;

		public BumperStub()
		{
		}

		public BumperStub(global::RTC.Bumper target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.Bumper)target;
		}

 
        public Task<ReactiveRTM.RTC.BumperGeometry> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.BumperGeometry(ret);
			});
        }
    }
    public class CameraStub : IStub
    {
		private global::RTC.Camera _target;

		public CameraStub()
		{
		}

		public CameraStub(global::RTC.Camera target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.Camera)target;
		}

 
        public Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.Geometry3D(ret);
			});
        }
 
        public Task<ReactiveRTM.RTC.CameraInfo> GetCameraInfoAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetCameraInfo();
				return new ReactiveRTM.RTC.CameraInfo(ret);
			});
        }
    }
    public class DIOStub : IStub
    {
		private global::RTC.DIO _target;

		public DIOStub()
		{
		}

		public DIOStub(global::RTC.DIO target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.DIO)target;
		}

 
        public Task<System.Int16> NumBitsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.NumBits();
				return ret;
			});
        }
 
        public Task<System.Boolean> GetBitAsync(global::System.Int16 index)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetBit(index);
				return ret;
			});
        }
 
        public Task SetBitAsync(global::System.Int16 index,global::System.Boolean newValue)
        {
            return Task.Factory.StartNew(()=>{
				_target.SetBit(index,newValue);
				return;
			});
        }
    }
    public class FiducialStub : IStub
    {
		private global::RTC.Fiducial _target;

		public FiducialStub()
		{
		}

		public FiducialStub(global::RTC.Fiducial target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.Fiducial)target;
		}

 
        public Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.Geometry3D(ret);
			});
        }
 
        public Task<ReactiveRTM.RTC.FiducialFOV> GetFOVAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetFOV();
				return new ReactiveRTM.RTC.FiducialFOV(ret);
			});
        }
 
        public Task SetFOVAsync(global::RTC.FiducialFOV newFOV)
        {
            return Task.Factory.StartNew(()=>{
				_target.SetFOV(newFOV);
				return;
			});
        }
    }
    public class GPSStub : IStub
    {
		private global::RTC.GPS _target;

		public GPSStub()
		{
		}

		public GPSStub(global::RTC.GPS target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.GPS)target;
		}

 
        public Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.Geometry3D(ret);
			});
        }
    }
    public class GripperStub : IStub
    {
		private global::RTC.Gripper _target;

		public GripperStub()
		{
		}

		public GripperStub(global::RTC.Gripper target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.Gripper)target;
		}

 
        public Task<ReactiveRTM.RTC.GripperGeometry> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.GripperGeometry(ret);
			});
        }
 
        public Task OpenAsync()
        {
            return Task.Factory.StartNew(()=>{
				_target.Open();
				return;
			});
        }
 
        public Task CloseAsync()
        {
            return Task.Factory.StartNew(()=>{
				_target.Close();
				return;
			});
        }
    }
    public class IMUStub : IStub
    {
		private global::RTC.IMU _target;

		public IMUStub()
		{
		}

		public IMUStub(global::RTC.IMU target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.IMU)target;
		}

 
        public Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.Geometry3D(ret);
			});
        }
    }
    public class INSStub : IStub
    {
		private global::RTC.INS _target;

		public INSStub()
		{
		}

		public INSStub(global::RTC.INS target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.INS)target;
		}

 
        public Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.Geometry3D(ret);
			});
        }
    }
    public class LimbStub : IStub
    {
		private global::RTC.Limb _target;

		public LimbStub()
		{
		}

		public LimbStub(global::RTC.Limb target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.Limb)target;
		}

 
        public Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.Geometry3D(ret);
			});
        }
 
        public Task PowerAsync(global::System.Boolean enable)
        {
            return Task.Factory.StartNew(()=>{
				_target.Power(enable);
				return;
			});
        }
 
        public Task BrakesAsync(global::System.Boolean engage)
        {
            return Task.Factory.StartNew(()=>{
				_target.Brakes(engage);
				return;
			});
        }
 
        public Task SetSpeedAsync(global::System.Double speed)
        {
            return Task.Factory.StartNew(()=>{
				_target.SetSpeed(speed);
				return;
			});
        }
    }
    public class OGMapStub : IStub
    {
		private global::RTC.OGMap _target;

		public OGMapStub()
		{
		}

		public OGMapStub(global::RTC.OGMap target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.OGMap)target;
		}

 
        public Task<ReactiveRTM.RTC.OGMapConfig> GetConfigAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetConfig();
				return new ReactiveRTM.RTC.OGMapConfig(ret);
			});
        }
 
        public Task<ReactiveRTM.RTC.OGMapTile> GetTileAsync(global::RTC.OGMapTile tile)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetTile(tile);
				return new ReactiveRTM.RTC.OGMapTile(ret);
			});
        }
    }
    public class MulticameraStub : IStub
    {
		private global::RTC.Multicamera _target;

		public MulticameraStub()
		{
		}

		public MulticameraStub(global::RTC.Multicamera target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.Multicamera)target;
		}

 
        public Task<ReactiveRTM.RTC.MulticameraGeometry> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.MulticameraGeometry(ret);
			});
        }
 
        public Task<List<ReactiveRTM.RTC.CameraInfo>> GetCameraInfosAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetCameraInfos();
				return ret.Select(x=>new ReactiveRTM.RTC.CameraInfo(x)).ToList();
			});
        }
    }
    public class PanTiltStub : IStub
    {
		private global::RTC.PanTilt _target;

		public PanTiltStub()
		{
		}

		public PanTiltStub(global::RTC.PanTilt target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.PanTilt)target;
		}

 
        public Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.Geometry3D(ret);
			});
        }
    }
    public class PathPlanner2DStub : IStub
    {
		private global::RTC.PathPlanner2D _target;

		public PathPlanner2DStub()
		{
		}

		public PathPlanner2DStub(global::RTC.PathPlanner2D target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.PathPlanner2D)target;
		}

 
        public Task SetTaskAsync(global::RTC.Waypoint2D[] coarsePath)
        {
            return Task.Factory.StartNew(()=>{
				_target.SetTask(coarsePath);
				return;
			});
        }
    }
    public class PathPlanner3DStub : IStub
    {
		private global::RTC.PathPlanner3D _target;

		public PathPlanner3DStub()
		{
		}

		public PathPlanner3DStub(global::RTC.PathPlanner3D target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.PathPlanner3D)target;
		}

 
        public Task SetTaskAsync(global::RTC.Waypoint3D[] coarsePath)
        {
            return Task.Factory.StartNew(()=>{
				_target.SetTask(coarsePath);
				return;
			});
        }
    }
    public class PathFollower2DStub : IStub
    {
		private global::RTC.PathFollower2D _target;

		public PathFollower2DStub()
		{
		}

		public PathFollower2DStub(global::RTC.PathFollower2D target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.PathFollower2D)target;
		}

 
        public Task SetPathAsync(global::RTC.Waypoint2D[] path)
        {
            return Task.Factory.StartNew(()=>{
				_target.SetPath(path);
				return;
			});
        }
 
        public Task EnableAsync(global::System.Boolean enable)
        {
            return Task.Factory.StartNew(()=>{
				_target.Enable(enable);
				return;
			});
        }
 
        public Task<System.Int16> GetCurrentWaypointIndexAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetCurrentWaypointIndex();
				return ret;
			});
        }
 
        public Task<ReactiveRTM.RTC.Waypoint2D> GetCurrentWaypointAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetCurrentWaypoint();
				return new ReactiveRTM.RTC.Waypoint2D(ret);
			});
        }
    }
    public class PathFollower3DStub : IStub
    {
		private global::RTC.PathFollower3D _target;

		public PathFollower3DStub()
		{
		}

		public PathFollower3DStub(global::RTC.PathFollower3D target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.PathFollower3D)target;
		}

 
        public Task SetPathAsync(global::RTC.Waypoint3D[] path)
        {
            return Task.Factory.StartNew(()=>{
				_target.SetPath(path);
				return;
			});
        }
 
        public Task EnableAsync(global::System.Boolean enable)
        {
            return Task.Factory.StartNew(()=>{
				_target.Enable(enable);
				return;
			});
        }
 
        public Task<System.Int16> GetCurrentWaypointIndexAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetCurrentWaypointIndex();
				return ret;
			});
        }
 
        public Task<ReactiveRTM.RTC.Waypoint3D> GetCurrentWaypointAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetCurrentWaypoint();
				return new ReactiveRTM.RTC.Waypoint3D(ret);
			});
        }
    }
    public class PointCloudServicesStub : IStub
    {
		private global::RTC.PointCloudServices _target;

		public PointCloudServicesStub()
		{
		}

		public PointCloudServicesStub(global::RTC.PointCloudServices target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.PointCloudServices)target;
		}

 
        public Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.Geometry3D(ret);
			});
        }
    }
    public class Odometry2DStub : IStub
    {
		private global::RTC.Odometry2D _target;

		public Odometry2DStub()
		{
		}

		public Odometry2DStub(global::RTC.Odometry2D target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.Odometry2D)target;
		}

 
        public Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.Geometry3D(ret);
			});
        }
 
        public Task SetOdometryAsync(global::RTC.Pose2D newOdometry)
        {
            return Task.Factory.StartNew(()=>{
				_target.SetOdometry(newOdometry);
				return;
			});
        }
    }
    public class Odometry3DStub : IStub
    {
		private global::RTC.Odometry3D _target;

		public Odometry3DStub()
		{
		}

		public Odometry3DStub(global::RTC.Odometry3D target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.Odometry3D)target;
		}

 
        public Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.Geometry3D(ret);
			});
        }
 
        public Task SetOdometryAsync(global::RTC.Pose3D newOdometry)
        {
            return Task.Factory.StartNew(()=>{
				_target.SetOdometry(newOdometry);
				return;
			});
        }
    }
    public class VelocityControl2DStub : IStub
    {
		private global::RTC.VelocityControl2D _target;

		public VelocityControl2DStub()
		{
		}

		public VelocityControl2DStub(global::RTC.VelocityControl2D target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.VelocityControl2D)target;
		}

 
        public Task<ReactiveRTM.RTC.Geometry2D> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.Geometry2D(ret);
			});
        }
    }
    public class VelocityControl3DStub : IStub
    {
		private global::RTC.VelocityControl3D _target;

		public VelocityControl3DStub()
		{
		}

		public VelocityControl3DStub(global::RTC.VelocityControl3D target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.VelocityControl3D)target;
		}

 
        public Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.Geometry3D(ret);
			});
        }
    }
    public class PoseControl2DStub : IStub
    {
		private global::RTC.PoseControl2D _target;

		public PoseControl2DStub()
		{
		}

		public PoseControl2DStub(global::RTC.PoseControl2D target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.PoseControl2D)target;
		}

 
        public Task<ReactiveRTM.RTC.Geometry2D> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.Geometry2D(ret);
			});
        }
    }
    public class PoseControl3DStub : IStub
    {
		private global::RTC.PoseControl3D _target;

		public PoseControl3DStub()
		{
		}

		public PoseControl3DStub(global::RTC.PoseControl3D target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.PoseControl3D)target;
		}

 
        public Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.Geometry3D(ret);
			});
        }
    }
    public class CarlikeControlStub : IStub
    {
		private global::RTC.CarlikeControl _target;

		public CarlikeControlStub()
		{
		}

		public CarlikeControlStub(global::RTC.CarlikeControl target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.CarlikeControl)target;
		}

 
        public Task<ReactiveRTM.RTC.Geometry2D> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.Geometry2D(ret);
			});
        }
    }
    public class HeadingControl2DStub : IStub
    {
		private global::RTC.HeadingControl2D _target;

		public HeadingControl2DStub()
		{
		}

		public HeadingControl2DStub(global::RTC.HeadingControl2D target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.HeadingControl2D)target;
		}

 
        public Task<ReactiveRTM.RTC.Geometry2D> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.Geometry2D(ret);
			});
        }
    }
    public class HeadingControl3DStub : IStub
    {
		private global::RTC.HeadingControl3D _target;

		public HeadingControl3DStub()
		{
		}

		public HeadingControl3DStub(global::RTC.HeadingControl3D target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.HeadingControl3D)target;
		}

 
        public Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.Geometry3D(ret);
			});
        }
    }
    public class RangerStub : IStub
    {
		private global::RTC.Ranger _target;

		public RangerStub()
		{
		}

		public RangerStub(global::RTC.Ranger target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.Ranger)target;
		}

 
        public Task<ReactiveRTM.RTC.RangerGeometry> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.RangerGeometry(ret);
			});
        }
 
        public Task PowerAsync(global::System.Boolean enable)
        {
            return Task.Factory.StartNew(()=>{
				_target.Power(enable);
				return;
			});
        }
 
        public Task EnableIntensitiesAsync(global::System.Boolean enable)
        {
            return Task.Factory.StartNew(()=>{
				_target.EnableIntensities(enable);
				return;
			});
        }
 
        public Task<ReactiveRTM.RTC.RangerConfig> GetConfigAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetConfig();
				return new ReactiveRTM.RTC.RangerConfig(ret);
			});
        }
 
        public Task SetConfigAsync(global::RTC.RangerConfig newConfig)
        {
            return Task.Factory.StartNew(()=>{
				_target.SetConfig(newConfig);
				return;
			});
        }
    }
    public class RFIDStub : IStub
    {
		private global::RTC.RFID _target;

		public RFIDStub()
		{
		}

		public RFIDStub(global::RTC.RFID target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTC.RFID)target;
		}

 
        public Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.GetGeometry();
				return new ReactiveRTM.RTC.Geometry3D(ret);
			});
        }
 
        public Task WriteAsync(global::System.String GUID,global::System.Byte[] data)
        {
            return Task.Factory.StartNew(()=>{
				_target.Write(GUID,data);
				return;
			});
        }
 
        public Task<List<System.Byte>> ReadAsync(global::System.String GUID)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.Read(GUID);
				return ret.Select(x=>x).ToList();
			});
        }
    }
}
 
namespace ReactiveRTM.RTM
{
    public class ManagerStub : IStub
    {
		private global::RTM.Manager _target;

		public ManagerStub()
		{
		}

		public ManagerStub(global::RTM.Manager target)
		{
			_target = target;
		}

		object IStub.GetTarget()
		{
		    return _target;
		}
		void IStub.SetTarget(object target)
		{
		    _target = (global::RTM.Manager)target;
		}

 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> LoadModuleAsync(global::System.String pathname,global::System.String initfunc)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.load_module(pathname,initfunc);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> UnloadModuleAsync(global::System.String pathname)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.unload_module(pathname);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<List<ReactiveRTM.RTM.ModuleProfile>> GetLoadableModulesAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_loadable_modules();
				return ret.Select(x=>new ReactiveRTM.RTM.ModuleProfile(x)).ToList();
			});
        }
 
        public Task<List<ReactiveRTM.RTM.ModuleProfile>> GetLoadedModulesAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_loaded_modules();
				return ret.Select(x=>new ReactiveRTM.RTM.ModuleProfile(x)).ToList();
			});
        }
 
        public Task<List<ReactiveRTM.RTM.ModuleProfile>> GetFactoryProfilesAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_factory_profiles();
				return ret.Select(x=>new ReactiveRTM.RTM.ModuleProfile(x)).ToList();
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.RTObjectStub> CreateComponentAsync(global::System.String module_name)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.create_component(module_name);
				return new ReactiveRTM.omg.org.RTC.RTObjectStub(ret);
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> DeleteComponentAsync(global::System.String instance_name)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.delete_component(instance_name);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<List<ReactiveRTM.omg.org.RTC.RTObjectStub>> GetComponentsAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_components();
				return ret.Select(x=>new ReactiveRTM.omg.org.RTC.RTObjectStub(x)).ToList();
			});
        }
 
        public Task<List<ReactiveRTM.omg.org.RTC.ComponentProfile>> GetComponentProfilesAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_component_profiles();
				return ret.Select(x=>new ReactiveRTM.omg.org.RTC.ComponentProfile(x)).ToList();
			});
        }
 
        public Task<ReactiveRTM.RTM.ManagerProfile> GetProfileAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_profile();
				return new ReactiveRTM.RTM.ManagerProfile(ret);
			});
        }
 
        public Task<List<ReactiveRTM.org.omg.SDOPackage.NameValue>> GetConfigurationAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_configuration();
				return ret.Select(x=>new ReactiveRTM.org.omg.SDOPackage.NameValue(x)).ToList();
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> SetConfigurationAsync(global::System.String name,global::System.String value)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.set_configuration(name,value);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<System.Boolean> IsMasterAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.is_master();
				return ret;
			});
        }
 
        public Task<List<ReactiveRTM.RTM.ManagerStub>> GetMasterManagersAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_master_managers();
				return ret.Select(x=>new ReactiveRTM.RTM.ManagerStub(x)).ToList();
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> AddMasterManagerAsync(global::RTM.Manager mgr)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.add_master_manager(mgr);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> RemoveMasterManagerAsync(global::RTM.Manager mgr)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.remove_master_manager(mgr);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<List<ReactiveRTM.RTM.ManagerStub>> GetSlaveManagersAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_slave_managers();
				return ret.Select(x=>new ReactiveRTM.RTM.ManagerStub(x)).ToList();
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> AddSlaveManagerAsync(global::RTM.Manager mgr)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.add_slave_manager(mgr);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> RemoveSlaveManagerAsync(global::RTM.Manager mgr)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.remove_slave_manager(mgr);
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> ForkAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.fork();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> ShutdownAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.shutdown();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<ReactiveRTM.omg.org.RTC.ReturnCode_t> RestartAsync()
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.restart();
				return (omg.org.RTC.ReturnCode_t)ret;
			});
        }
 
        public Task<System.Object> GetServiceAsync(global::System.String name)
        {
            return Task.Factory.StartNew(()=>{
				var ret = _target.get_service(name);
				return (System.MarshalByRefObject)ret;
			});
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading.Tasks;
using ReactiveRTM.Corba;
using ReactiveRTM.Extensions;

 
namespace ReactiveRTM.OpenRTM
{

    public class ComponentObserverAdapter : MarshalByRefObject, global::OpenRTM.ComponentObserver
    {
        private ComponentObserver _target;

        public ComponentObserverAdapter(ComponentObserver target)
        {
            _target = target;
        }
        public void update_status(global::OpenRTM.StatusKind status_kind,System.String hint)
        {
            _target.UpdateStatus((ReactiveRTM.OpenRTM.StatusKind)status_kind,hint);
            return;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class InPortCdrAdapter : MarshalByRefObject, global::OpenRTM.InPortCdr
    {
        private InPortCdr _target;

        public InPortCdrAdapter(InPortCdr target)
        {
            _target = target;
        }
        public global::OpenRTM.PortStatus put(global::System.Byte[] data)
        {
            var ret = _target.Put(data.Select(x => (System.Byte)x).ToList());
            return (global::OpenRTM.PortStatus)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class OutPortCdrAdapter : MarshalByRefObject, global::OpenRTM.OutPortCdr
    {
        private OutPortCdr _target;

        public OutPortCdrAdapter(OutPortCdr target)
        {
            _target = target;
        }
        public global::OpenRTM.PortStatus _get(out global::System.Byte[] data)
        {
 
            List<System.Byte> tmpdata;
            var ret = _target.Get(out tmpdata);
 
            data = tmpdata.Select(x=>x).ToArray();
            return (global::OpenRTM.PortStatus)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class LoggerAdapter : MarshalByRefObject, global::OpenRTM.Logger
    {
        private Logger _target;

        public LoggerAdapter(Logger target)
        {
            _target = target;
        }
        public void publish(global::OpenRTM.LogRecord record)
        {
            _target.Publish(new ReactiveRTM.OpenRTM.LogRecord(record));
            return;
        }
        public void close()
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
 
namespace ReactiveRTM.OpenRTM
{

    public class DataFlowComponentAdapter : MarshalByRefObject, global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent
    {
        private DataFlowComponent _target;

        public DataFlowComponentAdapter(DataFlowComponent target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ComponentProfile get_component_profile()
        {
            var ret = _target.GetComponentProfile();
            return ((global::omg.org.RTC.ComponentProfile)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.PortService[] get_ports()
        {
            var ret = _target.GetPorts();
            return ret.Select(x=>((global::omg.org.RTC.PortService)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ReturnCode_t initialize()
        {
            var ret = _target.Initialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t _finalize()
        {
            var ret = _target.Finalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Boolean is_alive(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.IsAlive(new ReactiveRTM.RTC.ExecutionContextStub(exec_context));
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t _exit()
        {
            var ret = _target.Exit();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Int32 attach_context(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.AttachContext(new ReactiveRTM.RTC.ExecutionContextStub(exec_context));
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t detach_context(System.Int32 exec_handle)
        {
            var ret = _target.DetachContext(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ExecutionContext get_context(System.Int32 exec_handle)
        {
            var ret = _target.GetContext(exec_handle);
            return ((global::omg.org.RTC.ExecutionContext)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ExecutionContext[] get_owned_contexts()
        {
            var ret = _target.GetOwnedContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ExecutionContext[] get_participating_contexts()
        {
            var ret = _target.GetParticipatingContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public System.Int32 get_context_handle(global::omg.org.RTC.ExecutionContext cxt)
        {
            var ret = _target.GetContextHandle(new ReactiveRTM.RTC.ExecutionContextStub(cxt));
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_initialize()
        {
            var ret = _target.OnInitialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_finalize()
        {
            var ret = _target.OnFinalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_startup(System.Int32 exec_handle)
        {
            var ret = _target.OnStartup(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_shutdown(System.Int32 exec_handle)
        {
            var ret = _target.OnShutdown(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_activated(System.Int32 exec_handle)
        {
            var ret = _target.OnActivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_deactivated(System.Int32 exec_handle)
        {
            var ret = _target.OnDeactivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_aborting(System.Int32 exec_handle)
        {
            var ret = _target.OnAborting(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_error(System.Int32 exec_handle)
        {
            var ret = _target.OnError(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_reset(System.Int32 exec_handle)
        {
            var ret = _target.OnReset(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.String get_sdo_id()
        {
            var ret = _target.GetSdoId();
            return ret;
        }
        public System.String get_sdo_type()
        {
            var ret = _target.GetSdoType();
            return ret;
        }
        public global::org.omg.SDOPackage.DeviceProfile get_device_profile()
        {
            var ret = _target.GetDeviceProfile();
            return ((global::org.omg.SDOPackage.DeviceProfile)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.ServiceProfile[] get_service_profiles()
        {
            var ret = _target.GetServiceProfiles();
            return ret.Select(x=>((global::org.omg.SDOPackage.ServiceProfile)((IStub)x).GetTarget())).ToArray();
        }
        public global::org.omg.SDOPackage.ServiceProfile get_service_profile(System.String id)
        {
            var ret = _target.GetServiceProfile(id);
            return ((global::org.omg.SDOPackage.ServiceProfile)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.SDOService get_sdo_service(System.String id)
        {
            var ret = _target.GetSdoService(id);
            return ((global::org.omg.SDOPackage.SDOService)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.Configuration get_configuration()
        {
            var ret = _target.GetConfiguration();
            return ((global::org.omg.SDOPackage.Configuration)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.Monitoring get_monitoring()
        {
            var ret = _target.GetMonitoring();
            return ((global::org.omg.SDOPackage.Monitoring)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.Organization[] get_organizations()
        {
            var ret = _target.GetOrganizations();
            return ret.Select(x=>((global::org.omg.SDOPackage.Organization)((IStub)x).GetTarget())).ToArray();
        }
        public global::org.omg.SDOPackage.NameValue[] get_status_list()
        {
            var ret = _target.GetStatusList();
            return Converter.DictionaryToNVList(ret);
        }
        public System.Object get_status(System.String nme)
        {
            var ret = _target.GetStatus(nme);
            return ret;
        }
        public global::org.omg.SDOPackage.Organization[] get_owned_organizations()
        {
            var ret = _target.GetOwnedOrganizations();
            return ret.Select(x=>((global::org.omg.SDOPackage.Organization)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ReturnCode_t on_execute(System.Int32 exec_handle)
        {
            var ret = _target.OnExecute(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_state_update(System.Int32 exec_handle)
        {
            var ret = _target.OnStateUpdate(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_rate_changed(System.Int32 exec_handle)
        {
            var ret = _target.OnRateChanged(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class ExtTrigExecutionContextServiceAdapter : MarshalByRefObject, global::openrtm.aist.go.jp.OpenRTM.ExtTrigExecutionContextService
    {
        private ExtTrigExecutionContextService _target;

        public ExtTrigExecutionContextServiceAdapter(ExtTrigExecutionContextService target)
        {
            _target = target;
        }
        public void tick()
        {
            _target.Tick();
            return;
        }
        public global::omg.org.RTC.ExecutionContextProfile get_profile()
        {
            var ret = _target.GetProfile();
            return ((global::omg.org.RTC.ExecutionContextProfile)((IStub)ret).GetTarget());
        }
        public System.Boolean is_running()
        {
            var ret = _target.IsRunning();
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t start()
        {
            var ret = _target.Start();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t _stop()
        {
            var ret = _target.Stop();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Double get_rate()
        {
            var ret = _target.GetRate();
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t set_rate(System.Double rate)
        {
            var ret = _target.SetRate(rate);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t add_component(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.AddComponent(new ReactiveRTM.RTC.LightweightRTObjectStub(comp));
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t remove_component(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.RemoveComponent(new ReactiveRTM.RTC.LightweightRTObjectStub(comp));
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t activate_component(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.ActivateComponent(new ReactiveRTM.RTC.LightweightRTObjectStub(comp));
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t deactivate_component(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.DeactivateComponent(new ReactiveRTM.RTC.LightweightRTObjectStub(comp));
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t reset_component(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.ResetComponent(new ReactiveRTM.RTC.LightweightRTObjectStub(comp));
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.LifeCycleState get_component_state(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.GetComponentState(new ReactiveRTM.RTC.LightweightRTObjectStub(comp));
            return (global::omg.org.RTC.LifeCycleState)ret;
        }
        public global::omg.org.RTC.ExecutionKind get_kind()
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
 
namespace ReactiveRTM.RTC
{

    public class ExecutionContextAdapter : MarshalByRefObject, global::omg.org.RTC.ExecutionContext
    {
        private ExecutionContext _target;

        public ExecutionContextAdapter(ExecutionContext target)
        {
            _target = target;
        }
        public System.Boolean is_running()
        {
            var ret = _target.IsRunning();
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t start()
        {
            var ret = _target.Start();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t _stop()
        {
            var ret = _target.Stop();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Double get_rate()
        {
            var ret = _target.GetRate();
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t set_rate(System.Double rate)
        {
            var ret = _target.SetRate(rate);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t add_component(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.AddComponent(new ReactiveRTM.RTC.LightweightRTObjectStub(comp));
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t remove_component(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.RemoveComponent(new ReactiveRTM.RTC.LightweightRTObjectStub(comp));
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t activate_component(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.ActivateComponent(new ReactiveRTM.RTC.LightweightRTObjectStub(comp));
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t deactivate_component(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.DeactivateComponent(new ReactiveRTM.RTC.LightweightRTObjectStub(comp));
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t reset_component(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.ResetComponent(new ReactiveRTM.RTC.LightweightRTObjectStub(comp));
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.LifeCycleState get_component_state(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.GetComponentState(new ReactiveRTM.RTC.LightweightRTObjectStub(comp));
            return (global::omg.org.RTC.LifeCycleState)ret;
        }
        public global::omg.org.RTC.ExecutionKind get_kind()
        {
            var ret = _target.GetKind();
            return (global::omg.org.RTC.ExecutionKind)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class ComponentActionAdapter : MarshalByRefObject, global::omg.org.RTC.ComponentAction
    {
        private ComponentAction _target;

        public ComponentActionAdapter(ComponentAction target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ReturnCode_t on_initialize()
        {
            var ret = _target.OnInitialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_finalize()
        {
            var ret = _target.OnFinalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_startup(System.Int32 exec_handle)
        {
            var ret = _target.OnStartup(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_shutdown(System.Int32 exec_handle)
        {
            var ret = _target.OnShutdown(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_activated(System.Int32 exec_handle)
        {
            var ret = _target.OnActivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_deactivated(System.Int32 exec_handle)
        {
            var ret = _target.OnDeactivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_aborting(System.Int32 exec_handle)
        {
            var ret = _target.OnAborting(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_error(System.Int32 exec_handle)
        {
            var ret = _target.OnError(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_reset(System.Int32 exec_handle)
        {
            var ret = _target.OnReset(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class LightweightRTObjectAdapter : MarshalByRefObject, global::omg.org.RTC.LightweightRTObject
    {
        private LightweightRTObject _target;

        public LightweightRTObjectAdapter(LightweightRTObject target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ReturnCode_t initialize()
        {
            var ret = _target.Initialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t _finalize()
        {
            var ret = _target.Finalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Boolean is_alive(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.IsAlive(new ReactiveRTM.RTC.ExecutionContextStub(exec_context));
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t _exit()
        {
            var ret = _target.Exit();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Int32 attach_context(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.AttachContext(new ReactiveRTM.RTC.ExecutionContextStub(exec_context));
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t detach_context(System.Int32 exec_handle)
        {
            var ret = _target.DetachContext(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ExecutionContext get_context(System.Int32 exec_handle)
        {
            var ret = _target.GetContext(exec_handle);
            return ((global::omg.org.RTC.ExecutionContext)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ExecutionContext[] get_owned_contexts()
        {
            var ret = _target.GetOwnedContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ExecutionContext[] get_participating_contexts()
        {
            var ret = _target.GetParticipatingContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public System.Int32 get_context_handle(global::omg.org.RTC.ExecutionContext cxt)
        {
            var ret = _target.GetContextHandle(new ReactiveRTM.RTC.ExecutionContextStub(cxt));
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_initialize()
        {
            var ret = _target.OnInitialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_finalize()
        {
            var ret = _target.OnFinalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_startup(System.Int32 exec_handle)
        {
            var ret = _target.OnStartup(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_shutdown(System.Int32 exec_handle)
        {
            var ret = _target.OnShutdown(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_activated(System.Int32 exec_handle)
        {
            var ret = _target.OnActivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_deactivated(System.Int32 exec_handle)
        {
            var ret = _target.OnDeactivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_aborting(System.Int32 exec_handle)
        {
            var ret = _target.OnAborting(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_error(System.Int32 exec_handle)
        {
            var ret = _target.OnError(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_reset(System.Int32 exec_handle)
        {
            var ret = _target.OnReset(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class DataFlowComponentActionAdapter : MarshalByRefObject, global::omg.org.RTC.DataFlowComponentAction
    {
        private DataFlowComponentAction _target;

        public DataFlowComponentActionAdapter(DataFlowComponentAction target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ReturnCode_t on_execute(System.Int32 exec_handle)
        {
            var ret = _target.OnExecute(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_state_update(System.Int32 exec_handle)
        {
            var ret = _target.OnStateUpdate(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_rate_changed(System.Int32 exec_handle)
        {
            var ret = _target.OnRateChanged(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class DataFlowComponentAdapter : MarshalByRefObject, global::omg.org.RTC.DataFlowComponent
    {
        private DataFlowComponent _target;

        public DataFlowComponentAdapter(DataFlowComponent target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ReturnCode_t initialize()
        {
            var ret = _target.Initialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t _finalize()
        {
            var ret = _target.Finalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Boolean is_alive(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.IsAlive(new ReactiveRTM.RTC.ExecutionContextStub(exec_context));
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t _exit()
        {
            var ret = _target.Exit();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Int32 attach_context(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.AttachContext(new ReactiveRTM.RTC.ExecutionContextStub(exec_context));
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t detach_context(System.Int32 exec_handle)
        {
            var ret = _target.DetachContext(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ExecutionContext get_context(System.Int32 exec_handle)
        {
            var ret = _target.GetContext(exec_handle);
            return ((global::omg.org.RTC.ExecutionContext)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ExecutionContext[] get_owned_contexts()
        {
            var ret = _target.GetOwnedContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ExecutionContext[] get_participating_contexts()
        {
            var ret = _target.GetParticipatingContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public System.Int32 get_context_handle(global::omg.org.RTC.ExecutionContext cxt)
        {
            var ret = _target.GetContextHandle(new ReactiveRTM.RTC.ExecutionContextStub(cxt));
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_initialize()
        {
            var ret = _target.OnInitialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_finalize()
        {
            var ret = _target.OnFinalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_startup(System.Int32 exec_handle)
        {
            var ret = _target.OnStartup(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_shutdown(System.Int32 exec_handle)
        {
            var ret = _target.OnShutdown(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_activated(System.Int32 exec_handle)
        {
            var ret = _target.OnActivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_deactivated(System.Int32 exec_handle)
        {
            var ret = _target.OnDeactivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_aborting(System.Int32 exec_handle)
        {
            var ret = _target.OnAborting(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_error(System.Int32 exec_handle)
        {
            var ret = _target.OnError(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_reset(System.Int32 exec_handle)
        {
            var ret = _target.OnReset(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_execute(System.Int32 exec_handle)
        {
            var ret = _target.OnExecute(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_state_update(System.Int32 exec_handle)
        {
            var ret = _target.OnStateUpdate(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_rate_changed(System.Int32 exec_handle)
        {
            var ret = _target.OnRateChanged(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class FsmAdapter : MarshalByRefObject, global::omg.org.RTC.Fsm
    {
        private Fsm _target;

        public FsmAdapter(Fsm target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ReturnCode_t initialize()
        {
            var ret = _target.Initialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t _finalize()
        {
            var ret = _target.Finalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Boolean is_alive(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.IsAlive(new ReactiveRTM.RTC.ExecutionContextStub(exec_context));
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t _exit()
        {
            var ret = _target.Exit();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Int32 attach_context(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.AttachContext(new ReactiveRTM.RTC.ExecutionContextStub(exec_context));
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t detach_context(System.Int32 exec_handle)
        {
            var ret = _target.DetachContext(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ExecutionContext get_context(System.Int32 exec_handle)
        {
            var ret = _target.GetContext(exec_handle);
            return ((global::omg.org.RTC.ExecutionContext)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ExecutionContext[] get_owned_contexts()
        {
            var ret = _target.GetOwnedContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ExecutionContext[] get_participating_contexts()
        {
            var ret = _target.GetParticipatingContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public System.Int32 get_context_handle(global::omg.org.RTC.ExecutionContext cxt)
        {
            var ret = _target.GetContextHandle(new ReactiveRTM.RTC.ExecutionContextStub(cxt));
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_initialize()
        {
            var ret = _target.OnInitialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_finalize()
        {
            var ret = _target.OnFinalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_startup(System.Int32 exec_handle)
        {
            var ret = _target.OnStartup(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_shutdown(System.Int32 exec_handle)
        {
            var ret = _target.OnShutdown(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_activated(System.Int32 exec_handle)
        {
            var ret = _target.OnActivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_deactivated(System.Int32 exec_handle)
        {
            var ret = _target.OnDeactivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_aborting(System.Int32 exec_handle)
        {
            var ret = _target.OnAborting(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_error(System.Int32 exec_handle)
        {
            var ret = _target.OnError(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_reset(System.Int32 exec_handle)
        {
            var ret = _target.OnReset(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class FsmParticipantActionAdapter : MarshalByRefObject, global::omg.org.RTC.FsmParticipantAction
    {
        private FsmParticipantAction _target;

        public FsmParticipantActionAdapter(FsmParticipantAction target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ReturnCode_t on_action(System.Int32 exec_handle)
        {
            var ret = _target.OnAction(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class FsmParticipantAdapter : MarshalByRefObject, global::omg.org.RTC.FsmParticipant
    {
        private FsmParticipant _target;

        public FsmParticipantAdapter(FsmParticipant target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ReturnCode_t initialize()
        {
            var ret = _target.Initialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t _finalize()
        {
            var ret = _target.Finalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Boolean is_alive(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.IsAlive(new ReactiveRTM.RTC.ExecutionContextStub(exec_context));
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t _exit()
        {
            var ret = _target.Exit();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Int32 attach_context(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.AttachContext(new ReactiveRTM.RTC.ExecutionContextStub(exec_context));
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t detach_context(System.Int32 exec_handle)
        {
            var ret = _target.DetachContext(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ExecutionContext get_context(System.Int32 exec_handle)
        {
            var ret = _target.GetContext(exec_handle);
            return ((global::omg.org.RTC.ExecutionContext)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ExecutionContext[] get_owned_contexts()
        {
            var ret = _target.GetOwnedContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ExecutionContext[] get_participating_contexts()
        {
            var ret = _target.GetParticipatingContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public System.Int32 get_context_handle(global::omg.org.RTC.ExecutionContext cxt)
        {
            var ret = _target.GetContextHandle(new ReactiveRTM.RTC.ExecutionContextStub(cxt));
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_initialize()
        {
            var ret = _target.OnInitialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_finalize()
        {
            var ret = _target.OnFinalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_startup(System.Int32 exec_handle)
        {
            var ret = _target.OnStartup(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_shutdown(System.Int32 exec_handle)
        {
            var ret = _target.OnShutdown(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_activated(System.Int32 exec_handle)
        {
            var ret = _target.OnActivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_deactivated(System.Int32 exec_handle)
        {
            var ret = _target.OnDeactivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_aborting(System.Int32 exec_handle)
        {
            var ret = _target.OnAborting(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_error(System.Int32 exec_handle)
        {
            var ret = _target.OnError(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_reset(System.Int32 exec_handle)
        {
            var ret = _target.OnReset(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_action(System.Int32 exec_handle)
        {
            var ret = _target.OnAction(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class ModeAdapter : MarshalByRefObject, global::omg.org.RTC.Mode
    {
        private Mode _target;

        public ModeAdapter(Mode target)
        {
            _target = target;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class ModeCapableAdapter : MarshalByRefObject, global::omg.org.RTC.ModeCapable
    {
        private ModeCapable _target;

        public ModeCapableAdapter(ModeCapable target)
        {
            _target = target;
        }
        public global::omg.org.RTC.Mode get_default_mode()
        {
            var ret = _target.GetDefaultMode();
            return ((global::omg.org.RTC.Mode)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.Mode get_current_mode()
        {
            var ret = _target.GetCurrentMode();
            return ((global::omg.org.RTC.Mode)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.Mode get_current_mode_in_context(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.GetCurrentModeInContext(new ReactiveRTM.RTC.ExecutionContextStub(exec_context));
            return ((global::omg.org.RTC.Mode)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.Mode get_pending_mode()
        {
            var ret = _target.GetPendingMode();
            return ((global::omg.org.RTC.Mode)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.Mode get_pending_mode_in_context(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.GetPendingModeInContext(new ReactiveRTM.RTC.ExecutionContextStub(exec_context));
            return ((global::omg.org.RTC.Mode)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ReturnCode_t set_mode(global::omg.org.RTC.Mode new_mode,System.Boolean immediate)
        {
            var ret = _target.SetMode(new ReactiveRTM.RTC.ModeStub(new_mode),immediate);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class MultiModeComponentActionAdapter : MarshalByRefObject, global::omg.org.RTC.MultiModeComponentAction
    {
        private MultiModeComponentAction _target;

        public MultiModeComponentActionAdapter(MultiModeComponentAction target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ReturnCode_t on_mode_changed(System.Int32 exec_handle)
        {
            var ret = _target.OnModeChanged(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class MultiModeObjectAdapter : MarshalByRefObject, global::omg.org.RTC.MultiModeObject
    {
        private MultiModeObject _target;

        public MultiModeObjectAdapter(MultiModeObject target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ReturnCode_t initialize()
        {
            var ret = _target.Initialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t _finalize()
        {
            var ret = _target.Finalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Boolean is_alive(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.IsAlive(new ReactiveRTM.RTC.ExecutionContextStub(exec_context));
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t _exit()
        {
            var ret = _target.Exit();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Int32 attach_context(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.AttachContext(new ReactiveRTM.RTC.ExecutionContextStub(exec_context));
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t detach_context(System.Int32 exec_handle)
        {
            var ret = _target.DetachContext(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ExecutionContext get_context(System.Int32 exec_handle)
        {
            var ret = _target.GetContext(exec_handle);
            return ((global::omg.org.RTC.ExecutionContext)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ExecutionContext[] get_owned_contexts()
        {
            var ret = _target.GetOwnedContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ExecutionContext[] get_participating_contexts()
        {
            var ret = _target.GetParticipatingContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public System.Int32 get_context_handle(global::omg.org.RTC.ExecutionContext cxt)
        {
            var ret = _target.GetContextHandle(new ReactiveRTM.RTC.ExecutionContextStub(cxt));
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_initialize()
        {
            var ret = _target.OnInitialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_finalize()
        {
            var ret = _target.OnFinalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_startup(System.Int32 exec_handle)
        {
            var ret = _target.OnStartup(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_shutdown(System.Int32 exec_handle)
        {
            var ret = _target.OnShutdown(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_activated(System.Int32 exec_handle)
        {
            var ret = _target.OnActivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_deactivated(System.Int32 exec_handle)
        {
            var ret = _target.OnDeactivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_aborting(System.Int32 exec_handle)
        {
            var ret = _target.OnAborting(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_error(System.Int32 exec_handle)
        {
            var ret = _target.OnError(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_reset(System.Int32 exec_handle)
        {
            var ret = _target.OnReset(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.Mode get_default_mode()
        {
            var ret = _target.GetDefaultMode();
            return ((global::omg.org.RTC.Mode)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.Mode get_current_mode()
        {
            var ret = _target.GetCurrentMode();
            return ((global::omg.org.RTC.Mode)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.Mode get_current_mode_in_context(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.GetCurrentModeInContext(new ReactiveRTM.RTC.ExecutionContextStub(exec_context));
            return ((global::omg.org.RTC.Mode)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.Mode get_pending_mode()
        {
            var ret = _target.GetPendingMode();
            return ((global::omg.org.RTC.Mode)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.Mode get_pending_mode_in_context(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.GetPendingModeInContext(new ReactiveRTM.RTC.ExecutionContextStub(exec_context));
            return ((global::omg.org.RTC.Mode)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ReturnCode_t set_mode(global::omg.org.RTC.Mode new_mode,System.Boolean immediate)
        {
            var ret = _target.SetMode(new ReactiveRTM.RTC.ModeStub(new_mode),immediate);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_mode_changed(System.Int32 exec_handle)
        {
            var ret = _target.OnModeChanged(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class RTObjectAdapter : MarshalByRefObject, global::omg.org.RTC.RTObject
    {
        private RTObject _target;

        public RTObjectAdapter(RTObject target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ComponentProfile get_component_profile()
        {
            var ret = _target.GetComponentProfile();
            return ((global::omg.org.RTC.ComponentProfile)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.PortService[] get_ports()
        {
            var ret = _target.GetPorts();
            return ret.Select(x=>((global::omg.org.RTC.PortService)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ReturnCode_t initialize()
        {
            var ret = _target.Initialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t _finalize()
        {
            var ret = _target.Finalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Boolean is_alive(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.IsAlive(new ReactiveRTM.RTC.ExecutionContextStub(exec_context));
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t _exit()
        {
            var ret = _target.Exit();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Int32 attach_context(global::omg.org.RTC.ExecutionContext exec_context)
        {
            var ret = _target.AttachContext(new ReactiveRTM.RTC.ExecutionContextStub(exec_context));
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t detach_context(System.Int32 exec_handle)
        {
            var ret = _target.DetachContext(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ExecutionContext get_context(System.Int32 exec_handle)
        {
            var ret = _target.GetContext(exec_handle);
            return ((global::omg.org.RTC.ExecutionContext)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ExecutionContext[] get_owned_contexts()
        {
            var ret = _target.GetOwnedContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ExecutionContext[] get_participating_contexts()
        {
            var ret = _target.GetParticipatingContexts();
            return ret.Select(x=>((global::omg.org.RTC.ExecutionContext)((IStub)x).GetTarget())).ToArray();
        }
        public System.Int32 get_context_handle(global::omg.org.RTC.ExecutionContext cxt)
        {
            var ret = _target.GetContextHandle(new ReactiveRTM.RTC.ExecutionContextStub(cxt));
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_initialize()
        {
            var ret = _target.OnInitialize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_finalize()
        {
            var ret = _target.OnFinalize();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_startup(System.Int32 exec_handle)
        {
            var ret = _target.OnStartup(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_shutdown(System.Int32 exec_handle)
        {
            var ret = _target.OnShutdown(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_activated(System.Int32 exec_handle)
        {
            var ret = _target.OnActivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_deactivated(System.Int32 exec_handle)
        {
            var ret = _target.OnDeactivated(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_aborting(System.Int32 exec_handle)
        {
            var ret = _target.OnAborting(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_error(System.Int32 exec_handle)
        {
            var ret = _target.OnError(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t on_reset(System.Int32 exec_handle)
        {
            var ret = _target.OnReset(exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.String get_sdo_id()
        {
            var ret = _target.GetSdoId();
            return ret;
        }
        public System.String get_sdo_type()
        {
            var ret = _target.GetSdoType();
            return ret;
        }
        public global::org.omg.SDOPackage.DeviceProfile get_device_profile()
        {
            var ret = _target.GetDeviceProfile();
            return ((global::org.omg.SDOPackage.DeviceProfile)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.ServiceProfile[] get_service_profiles()
        {
            var ret = _target.GetServiceProfiles();
            return ret.Select(x=>((global::org.omg.SDOPackage.ServiceProfile)((IStub)x).GetTarget())).ToArray();
        }
        public global::org.omg.SDOPackage.ServiceProfile get_service_profile(System.String id)
        {
            var ret = _target.GetServiceProfile(id);
            return ((global::org.omg.SDOPackage.ServiceProfile)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.SDOService get_sdo_service(System.String id)
        {
            var ret = _target.GetSdoService(id);
            return ((global::org.omg.SDOPackage.SDOService)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.Configuration get_configuration()
        {
            var ret = _target.GetConfiguration();
            return ((global::org.omg.SDOPackage.Configuration)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.Monitoring get_monitoring()
        {
            var ret = _target.GetMonitoring();
            return ((global::org.omg.SDOPackage.Monitoring)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.Organization[] get_organizations()
        {
            var ret = _target.GetOrganizations();
            return ret.Select(x=>((global::org.omg.SDOPackage.Organization)((IStub)x).GetTarget())).ToArray();
        }
        public global::org.omg.SDOPackage.NameValue[] get_status_list()
        {
            var ret = _target.GetStatusList();
            return Converter.DictionaryToNVList(ret);
        }
        public System.Object get_status(System.String nme)
        {
            var ret = _target.GetStatus(nme);
            return ret;
        }
        public global::org.omg.SDOPackage.Organization[] get_owned_organizations()
        {
            var ret = _target.GetOwnedOrganizations();
            return ret.Select(x=>((global::org.omg.SDOPackage.Organization)((IStub)x).GetTarget())).ToArray();
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class PortServiceAdapter : MarshalByRefObject, global::omg.org.RTC.PortService
    {
        private PortService _target;

        public PortServiceAdapter(PortService target)
        {
            _target = target;
        }
        public global::omg.org.RTC.PortProfile get_port_profile()
        {
            var ret = _target.GetPortProfile();
            return ((global::omg.org.RTC.PortProfile)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ConnectorProfile[] get_connector_profiles()
        {
            var ret = _target.GetConnectorProfiles();
            return ret.Select(x=>((global::omg.org.RTC.ConnectorProfile)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ConnectorProfile get_connector_profile(System.String connector_id)
        {
            var ret = _target.GetConnectorProfile(connector_id);
            return ((global::omg.org.RTC.ConnectorProfile)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ReturnCode_t connect(ref global::omg.org.RTC.ConnectorProfile connector_profile)
        {
 
            var tmpconnector_profile = new ReactiveRTM.RTC.ConnectorProfile(connector_profile);
            var ret = _target.Connect(ref tmpconnector_profile);
 
            connector_profile = ((global::omg.org.RTC.ConnectorProfile)((IStub)tmpconnector_profile).GetTarget());
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t disconnect(System.String connector_id)
        {
            var ret = _target.Disconnect(connector_id);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t disconnect_all()
        {
            var ret = _target.DisconnectAll();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t notify_connect(ref global::omg.org.RTC.ConnectorProfile connector_profile)
        {
 
            var tmpconnector_profile = new ReactiveRTM.RTC.ConnectorProfile(connector_profile);
            var ret = _target.NotifyConnect(ref tmpconnector_profile);
 
            connector_profile = ((global::omg.org.RTC.ConnectorProfile)((IStub)tmpconnector_profile).GetTarget());
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t notify_disconnect(System.String connector_id)
        {
            var ret = _target.NotifyDisconnect(connector_id);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class FsmObjectAdapter : MarshalByRefObject, global::omg.org.RTC.FsmObject
    {
        private FsmObject _target;

        public FsmObjectAdapter(FsmObject target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ReturnCode_t send_stimulus(System.String message,System.Int32 exec_handle)
        {
            var ret = _target.SendStimulus(message,exec_handle);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class FsmServiceAdapter : MarshalByRefObject, global::omg.org.RTC.FsmService
    {
        private FsmService _target;

        public FsmServiceAdapter(FsmService target)
        {
            _target = target;
        }
        public global::omg.org.RTC.FsmProfile get_fsm_profile()
        {
            var ret = _target.GetFsmProfile();
            return ((global::omg.org.RTC.FsmProfile)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ReturnCode_t set_fsm_profile(global::omg.org.RTC.FsmProfile fsm_profile)
        {
            var ret = _target.SetFsmProfile(new ReactiveRTM.RTC.FsmProfile(fsm_profile));
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class ExecutionContextServiceAdapter : MarshalByRefObject, global::omg.org.RTC.ExecutionContextService
    {
        private ExecutionContextService _target;

        public ExecutionContextServiceAdapter(ExecutionContextService target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ExecutionContextProfile get_profile()
        {
            var ret = _target.GetProfile();
            return ((global::omg.org.RTC.ExecutionContextProfile)((IStub)ret).GetTarget());
        }
        public System.Boolean is_running()
        {
            var ret = _target.IsRunning();
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t start()
        {
            var ret = _target.Start();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t _stop()
        {
            var ret = _target.Stop();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Double get_rate()
        {
            var ret = _target.GetRate();
            return ret;
        }
        public global::omg.org.RTC.ReturnCode_t set_rate(System.Double rate)
        {
            var ret = _target.SetRate(rate);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t add_component(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.AddComponent(new ReactiveRTM.RTC.LightweightRTObjectStub(comp));
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t remove_component(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.RemoveComponent(new ReactiveRTM.RTC.LightweightRTObjectStub(comp));
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t activate_component(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.ActivateComponent(new ReactiveRTM.RTC.LightweightRTObjectStub(comp));
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t deactivate_component(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.DeactivateComponent(new ReactiveRTM.RTC.LightweightRTObjectStub(comp));
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t reset_component(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.ResetComponent(new ReactiveRTM.RTC.LightweightRTObjectStub(comp));
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.LifeCycleState get_component_state(global::omg.org.RTC.LightweightRTObject comp)
        {
            var ret = _target.GetComponentState(new ReactiveRTM.RTC.LightweightRTObjectStub(comp));
            return (global::omg.org.RTC.LifeCycleState)ret;
        }
        public global::omg.org.RTC.ExecutionKind get_kind()
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
 
namespace ReactiveRTM.RTC
{

    public class ActArrayAdapter : MarshalByRefObject, global::RTC.ActArray
    {
        private ActArray _target;

        public ActArrayAdapter(ActArray target)
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

    public class AIOAdapter : MarshalByRefObject, global::RTC.AIO
    {
        private AIO _target;

        public AIOAdapter(AIO target)
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

    public class BumperAdapter : MarshalByRefObject, global::RTC.Bumper
    {
        private Bumper _target;

        public BumperAdapter(Bumper target)
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

    public class CameraAdapter : MarshalByRefObject, global::RTC.Camera
    {
        private Camera _target;

        public CameraAdapter(Camera target)
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

    public class DIOAdapter : MarshalByRefObject, global::RTC.DIO
    {
        private DIO _target;

        public DIOAdapter(DIO target)
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

    public class FiducialAdapter : MarshalByRefObject, global::RTC.Fiducial
    {
        private Fiducial _target;

        public FiducialAdapter(Fiducial target)
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
            _target.SetFOV(new ReactiveRTM.RTC.FiducialFOV(newFOV));
            return;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class GPSAdapter : MarshalByRefObject, global::RTC.GPS
    {
        private GPS _target;

        public GPSAdapter(GPS target)
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

    public class GripperAdapter : MarshalByRefObject, global::RTC.Gripper
    {
        private Gripper _target;

        public GripperAdapter(Gripper target)
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

    public class IMUAdapter : MarshalByRefObject, global::RTC.IMU
    {
        private IMU _target;

        public IMUAdapter(IMU target)
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

    public class INSAdapter : MarshalByRefObject, global::RTC.INS
    {
        private INS _target;

        public INSAdapter(INS target)
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

    public class LimbAdapter : MarshalByRefObject, global::RTC.Limb
    {
        private Limb _target;

        public LimbAdapter(Limb target)
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

    public class OGMapAdapter : MarshalByRefObject, global::RTC.OGMap
    {
        private OGMap _target;

        public OGMapAdapter(OGMap target)
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
            var ret = _target.GetTile(new ReactiveRTM.RTC.OGMapTile(tile));
            return ((global::RTC.OGMapTile)((IStub)ret).GetTarget());
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class MulticameraAdapter : MarshalByRefObject, global::RTC.Multicamera
    {
        private Multicamera _target;

        public MulticameraAdapter(Multicamera target)
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

    public class PanTiltAdapter : MarshalByRefObject, global::RTC.PanTilt
    {
        private PanTilt _target;

        public PanTiltAdapter(PanTilt target)
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

    public class PathPlanner2DAdapter : MarshalByRefObject, global::RTC.PathPlanner2D
    {
        private PathPlanner2D _target;

        public PathPlanner2DAdapter(PathPlanner2D target)
        {
            _target = target;
        }
        public void SetTask(global::RTC.Waypoint2D[] coarsePath)
        {
            _target.SetTask(coarsePath.Select(x => (ReactiveRTM.RTC.Waypoint2D)new ReactiveRTM.RTC.Waypoint2D(x)).ToList());
            return;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class PathPlanner3DAdapter : MarshalByRefObject, global::RTC.PathPlanner3D
    {
        private PathPlanner3D _target;

        public PathPlanner3DAdapter(PathPlanner3D target)
        {
            _target = target;
        }
        public void SetTask(global::RTC.Waypoint3D[] coarsePath)
        {
            _target.SetTask(coarsePath.Select(x => (ReactiveRTM.RTC.Waypoint3D)new ReactiveRTM.RTC.Waypoint3D(x)).ToList());
            return;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class PathFollower2DAdapter : MarshalByRefObject, global::RTC.PathFollower2D
    {
        private PathFollower2D _target;

        public PathFollower2DAdapter(PathFollower2D target)
        {
            _target = target;
        }
        public void SetPath(global::RTC.Waypoint2D[] path)
        {
            _target.SetPath(path.Select(x => (ReactiveRTM.RTC.Waypoint2D)new ReactiveRTM.RTC.Waypoint2D(x)).ToList());
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

    public class PathFollower3DAdapter : MarshalByRefObject, global::RTC.PathFollower3D
    {
        private PathFollower3D _target;

        public PathFollower3DAdapter(PathFollower3D target)
        {
            _target = target;
        }
        public void SetPath(global::RTC.Waypoint3D[] path)
        {
            _target.SetPath(path.Select(x => (ReactiveRTM.RTC.Waypoint3D)new ReactiveRTM.RTC.Waypoint3D(x)).ToList());
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

    public class PointCloudServicesAdapter : MarshalByRefObject, global::RTC.PointCloudServices
    {
        private PointCloudServices _target;

        public PointCloudServicesAdapter(PointCloudServices target)
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

    public class Odometry2DAdapter : MarshalByRefObject, global::RTC.Odometry2D
    {
        private Odometry2D _target;

        public Odometry2DAdapter(Odometry2D target)
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
            _target.SetOdometry(new ReactiveRTM.RTC.Pose2D(newOdometry));
            return;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class Odometry3DAdapter : MarshalByRefObject, global::RTC.Odometry3D
    {
        private Odometry3D _target;

        public Odometry3DAdapter(Odometry3D target)
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
            _target.SetOdometry(new ReactiveRTM.RTC.Pose3D(newOdometry));
            return;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class VelocityControl2DAdapter : MarshalByRefObject, global::RTC.VelocityControl2D
    {
        private VelocityControl2D _target;

        public VelocityControl2DAdapter(VelocityControl2D target)
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

    public class VelocityControl3DAdapter : MarshalByRefObject, global::RTC.VelocityControl3D
    {
        private VelocityControl3D _target;

        public VelocityControl3DAdapter(VelocityControl3D target)
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

    public class PoseControl2DAdapter : MarshalByRefObject, global::RTC.PoseControl2D
    {
        private PoseControl2D _target;

        public PoseControl2DAdapter(PoseControl2D target)
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

    public class PoseControl3DAdapter : MarshalByRefObject, global::RTC.PoseControl3D
    {
        private PoseControl3D _target;

        public PoseControl3DAdapter(PoseControl3D target)
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

    public class CarlikeControlAdapter : MarshalByRefObject, global::RTC.CarlikeControl
    {
        private CarlikeControl _target;

        public CarlikeControlAdapter(CarlikeControl target)
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

    public class HeadingControl2DAdapter : MarshalByRefObject, global::RTC.HeadingControl2D
    {
        private HeadingControl2D _target;

        public HeadingControl2DAdapter(HeadingControl2D target)
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

    public class HeadingControl3DAdapter : MarshalByRefObject, global::RTC.HeadingControl3D
    {
        private HeadingControl3D _target;

        public HeadingControl3DAdapter(HeadingControl3D target)
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

    public class RangerAdapter : MarshalByRefObject, global::RTC.Ranger
    {
        private Ranger _target;

        public RangerAdapter(Ranger target)
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
            _target.SetConfig(new ReactiveRTM.RTC.RangerConfig(newConfig));
            return;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class RFIDAdapter : MarshalByRefObject, global::RTC.RFID
    {
        private RFID _target;

        public RFIDAdapter(RFID target)
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
            _target.Write(GUID,data.Select(x => (System.Byte)x).ToList());
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

    public class ManagerAdapter : MarshalByRefObject, global::RTM.Manager
    {
        private Manager _target;

        public ManagerAdapter(Manager target)
        {
            _target = target;
        }
        public global::omg.org.RTC.ReturnCode_t load_module(System.String pathname,System.String initfunc)
        {
            var ret = _target.LoadModule(pathname,initfunc);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t unload_module(System.String pathname)
        {
            var ret = _target.UnloadModule(pathname);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::RTM.ModuleProfile[] get_loadable_modules()
        {
            var ret = _target.GetLoadableModules();
            return ret.Select(x=>((global::RTM.ModuleProfile)((IStub)x).GetTarget())).ToArray();
        }
        public global::RTM.ModuleProfile[] get_loaded_modules()
        {
            var ret = _target.GetLoadedModules();
            return ret.Select(x=>((global::RTM.ModuleProfile)((IStub)x).GetTarget())).ToArray();
        }
        public global::RTM.ModuleProfile[] get_factory_profiles()
        {
            var ret = _target.GetFactoryProfiles();
            return ret.Select(x=>((global::RTM.ModuleProfile)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.RTObject create_component(System.String module_name)
        {
            var ret = _target.CreateComponent(module_name);
            return ((global::omg.org.RTC.RTObject)((IStub)ret).GetTarget());
        }
        public global::omg.org.RTC.ReturnCode_t delete_component(System.String instance_name)
        {
            var ret = _target.DeleteComponent(instance_name);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.RTObject[] get_components()
        {
            var ret = _target.GetComponents();
            return ret.Select(x=>((global::omg.org.RTC.RTObject)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ComponentProfile[] get_component_profiles()
        {
            var ret = _target.GetComponentProfiles();
            return ret.Select(x=>((global::omg.org.RTC.ComponentProfile)((IStub)x).GetTarget())).ToArray();
        }
        public global::RTM.ManagerProfile get_profile()
        {
            var ret = _target.GetProfile();
            return ((global::RTM.ManagerProfile)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.NameValue[] get_configuration()
        {
            var ret = _target.GetConfiguration();
            return Converter.DictionaryToNVList(ret);
        }
        public global::omg.org.RTC.ReturnCode_t set_configuration(System.String name,System.String value)
        {
            var ret = _target.SetConfiguration(name,value);
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public System.Boolean is_master()
        {
            var ret = _target.IsMaster();
            return ret;
        }
        public global::RTM.Manager[] get_master_managers()
        {
            var ret = _target.GetMasterManagers();
            return ret.Select(x=>((global::RTM.Manager)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ReturnCode_t add_master_manager(global::RTM.Manager mgr)
        {
            var ret = _target.AddMasterManager(new ReactiveRTM.RTM.ManagerStub(mgr));
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t remove_master_manager(global::RTM.Manager mgr)
        {
            var ret = _target.RemoveMasterManager(new ReactiveRTM.RTM.ManagerStub(mgr));
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::RTM.Manager[] get_slave_managers()
        {
            var ret = _target.GetSlaveManagers();
            return ret.Select(x=>((global::RTM.Manager)((IStub)x).GetTarget())).ToArray();
        }
        public global::omg.org.RTC.ReturnCode_t add_slave_manager(global::RTM.Manager mgr)
        {
            var ret = _target.AddSlaveManager(new ReactiveRTM.RTM.ManagerStub(mgr));
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t remove_slave_manager(global::RTM.Manager mgr)
        {
            var ret = _target.RemoveSlaveManager(new ReactiveRTM.RTM.ManagerStub(mgr));
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t fork()
        {
            var ret = _target.Fork();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t shutdown()
        {
            var ret = _target.Shutdown();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::omg.org.RTC.ReturnCode_t restart()
        {
            var ret = _target.Restart();
            return (global::omg.org.RTC.ReturnCode_t)ret;
        }
        public global::System.MarshalByRefObject get_service(System.String name)
        {
            var ret = _target.GetService(name);
            return (MarshalByRefObject)ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}
 
namespace ReactiveRTM.SDOPackage
{

    public class SDOAdapter : MarshalByRefObject, global::org.omg.SDOPackage.SDO
    {
        private SDO _target;

        public SDOAdapter(SDO target)
        {
            _target = target;
        }
        public System.String get_sdo_id()
        {
            var ret = _target.GetSdoId();
            return ret;
        }
        public System.String get_sdo_type()
        {
            var ret = _target.GetSdoType();
            return ret;
        }
        public global::org.omg.SDOPackage.DeviceProfile get_device_profile()
        {
            var ret = _target.GetDeviceProfile();
            return ((global::org.omg.SDOPackage.DeviceProfile)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.ServiceProfile[] get_service_profiles()
        {
            var ret = _target.GetServiceProfiles();
            return ret.Select(x=>((global::org.omg.SDOPackage.ServiceProfile)((IStub)x).GetTarget())).ToArray();
        }
        public global::org.omg.SDOPackage.ServiceProfile get_service_profile(System.String id)
        {
            var ret = _target.GetServiceProfile(id);
            return ((global::org.omg.SDOPackage.ServiceProfile)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.SDOService get_sdo_service(System.String id)
        {
            var ret = _target.GetSdoService(id);
            return ((global::org.omg.SDOPackage.SDOService)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.Configuration get_configuration()
        {
            var ret = _target.GetConfiguration();
            return ((global::org.omg.SDOPackage.Configuration)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.Monitoring get_monitoring()
        {
            var ret = _target.GetMonitoring();
            return ((global::org.omg.SDOPackage.Monitoring)((IStub)ret).GetTarget());
        }
        public global::org.omg.SDOPackage.Organization[] get_organizations()
        {
            var ret = _target.GetOrganizations();
            return ret.Select(x=>((global::org.omg.SDOPackage.Organization)((IStub)x).GetTarget())).ToArray();
        }
        public global::org.omg.SDOPackage.NameValue[] get_status_list()
        {
            var ret = _target.GetStatusList();
            return Converter.DictionaryToNVList(ret);
        }
        public System.Object get_status(System.String nme)
        {
            var ret = _target.GetStatus(nme);
            return ret;
        }
        public global::org.omg.SDOPackage.Organization[] get_owned_organizations()
        {
            var ret = _target.GetOwnedOrganizations();
            return ret.Select(x=>((global::org.omg.SDOPackage.Organization)((IStub)x).GetTarget())).ToArray();
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class SDOServiceAdapter : MarshalByRefObject, global::org.omg.SDOPackage.SDOService
    {
        private SDOService _target;

        public SDOServiceAdapter(SDOService target)
        {
            _target = target;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class SDOSystemElementAdapter : MarshalByRefObject, global::org.omg.SDOPackage.SDOSystemElement
    {
        private SDOSystemElement _target;

        public SDOSystemElementAdapter(SDOSystemElement target)
        {
            _target = target;
        }
        public global::org.omg.SDOPackage.Organization[] get_owned_organizations()
        {
            var ret = _target.GetOwnedOrganizations();
            return ret.Select(x=>((global::org.omg.SDOPackage.Organization)((IStub)x).GetTarget())).ToArray();
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class ConfigurationAdapter : MarshalByRefObject, global::org.omg.SDOPackage.Configuration
    {
        private Configuration _target;

        public ConfigurationAdapter(Configuration target)
        {
            _target = target;
        }
        public System.Boolean set_device_profile(global::org.omg.SDOPackage.DeviceProfile dProfile)
        {
            var ret = _target.SetDeviceProfile(new ReactiveRTM.SDOPackage.DeviceProfile(dProfile));
            return ret;
        }
        public System.Boolean add_service_profile(global::org.omg.SDOPackage.ServiceProfile sProfile)
        {
            var ret = _target.AddServiceProfile(new ReactiveRTM.SDOPackage.ServiceProfile(sProfile));
            return ret;
        }
        public System.Boolean add_organization(global::org.omg.SDOPackage.Organization organization_object)
        {
            var ret = _target.AddOrganization(new ReactiveRTM.SDOPackage.OrganizationStub(organization_object));
            return ret;
        }
        public System.Boolean remove_service_profile(System.String id)
        {
            var ret = _target.RemoveServiceProfile(id);
            return ret;
        }
        public System.Boolean remove_organization(System.String organization_id)
        {
            var ret = _target.RemoveOrganization(organization_id);
            return ret;
        }
        public global::org.omg.SDOPackage.Parameter[] get_configuration_parameters()
        {
            var ret = _target.GetConfigurationParameters();
            return ret.Select(x=>((global::org.omg.SDOPackage.Parameter)((IStub)x).GetTarget())).ToArray();
        }
        public global::org.omg.SDOPackage.NameValue[] get_configuration_parameter_values()
        {
            var ret = _target.GetConfigurationParameterValues();
            return Converter.DictionaryToNVList(ret);
        }
        public System.Object get_configuration_parameter_value(System.String name)
        {
            var ret = _target.GetConfigurationParameterValue(name);
            return ret;
        }
        public System.Boolean set_configuration_parameter(System.String name,System.Object value)
        {
            var ret = _target.SetConfigurationParameter(name,value);
            return ret;
        }
        public global::org.omg.SDOPackage.ConfigurationSet[] get_configuration_sets()
        {
            var ret = _target.GetConfigurationSets();
            return ret.Select(x=>((global::org.omg.SDOPackage.ConfigurationSet)((IStub)x).GetTarget())).ToArray();
        }
        public global::org.omg.SDOPackage.ConfigurationSet get_configuration_set(System.String config_id)
        {
            var ret = _target.GetConfigurationSet(config_id);
            return ((global::org.omg.SDOPackage.ConfigurationSet)((IStub)ret).GetTarget());
        }
        public System.Boolean set_configuration_set_values(global::org.omg.SDOPackage.ConfigurationSet configuration_set)
        {
            var ret = _target.SetConfigurationSetValues(new ReactiveRTM.SDOPackage.ConfigurationSet(configuration_set));
            return ret;
        }
        public global::org.omg.SDOPackage.ConfigurationSet get_active_configuration_set()
        {
            var ret = _target.GetActiveConfigurationSet();
            return ((global::org.omg.SDOPackage.ConfigurationSet)((IStub)ret).GetTarget());
        }
        public System.Boolean add_configuration_set(global::org.omg.SDOPackage.ConfigurationSet configuration_set)
        {
            var ret = _target.AddConfigurationSet(new ReactiveRTM.SDOPackage.ConfigurationSet(configuration_set));
            return ret;
        }
        public System.Boolean remove_configuration_set(System.String config_id)
        {
            var ret = _target.RemoveConfigurationSet(config_id);
            return ret;
        }
        public System.Boolean activate_configuration_set(System.String config_id)
        {
            var ret = _target.ActivateConfigurationSet(config_id);
            return ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class MonitoringAdapter : MarshalByRefObject, global::org.omg.SDOPackage.Monitoring
    {
        private Monitoring _target;

        public MonitoringAdapter(Monitoring target)
        {
            _target = target;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public class OrganizationAdapter : MarshalByRefObject, global::org.omg.SDOPackage.Organization
    {
        private Organization _target;

        public OrganizationAdapter(Organization target)
        {
            _target = target;
        }
        public System.String get_organization_id()
        {
            var ret = _target.GetOrganizationId();
            return ret;
        }
        public global::org.omg.SDOPackage.OrganizationProperty get_organization_property()
        {
            var ret = _target.GetOrganizationProperty();
            return ((global::org.omg.SDOPackage.OrganizationProperty)((IStub)ret).GetTarget());
        }
        public System.Object get_organization_property_value(System.String name)
        {
            var ret = _target.GetOrganizationPropertyValue(name);
            return ret;
        }
        public System.Boolean add_organization_property(global::org.omg.SDOPackage.OrganizationProperty organization_property)
        {
            var ret = _target.AddOrganizationProperty(new ReactiveRTM.SDOPackage.OrganizationProperty(organization_property));
            return ret;
        }
        public System.Boolean set_organization_property_value(System.String name,System.Object value)
        {
            var ret = _target.SetOrganizationPropertyValue(name,value);
            return ret;
        }
        public System.Boolean remove_organization_property(System.String name)
        {
            var ret = _target.RemoveOrganizationProperty(name);
            return ret;
        }
        public global::org.omg.SDOPackage.SDOSystemElement get_owner()
        {
            var ret = _target.GetOwner();
            return ((global::org.omg.SDOPackage.SDOSystemElement)((IStub)ret).GetTarget());
        }
        public System.Boolean set_owner(global::org.omg.SDOPackage.SDOSystemElement sdo)
        {
            var ret = _target.SetOwner(new ReactiveRTM.SDOPackage.SDOSystemElementStub(sdo));
            return ret;
        }
        public global::org.omg.SDOPackage.SDO[] get_members()
        {
            var ret = _target.GetMembers();
            return ret.Select(x=>((global::org.omg.SDOPackage.SDO)((IStub)x).GetTarget())).ToArray();
        }
        public System.Boolean set_members(global::org.omg.SDOPackage.SDO[] sdos)
        {
            var ret = _target.SetMembers(sdos.Select(x => (ReactiveRTM.SDOPackage.SDO)new ReactiveRTM.SDOPackage.SDOStub(x)).ToList());
            return ret;
        }
        public System.Boolean add_members(global::org.omg.SDOPackage.SDO[] sdo_list)
        {
            var ret = _target.AddMembers(sdo_list.Select(x => (ReactiveRTM.SDOPackage.SDO)new ReactiveRTM.SDOPackage.SDOStub(x)).ToList());
            return ret;
        }
        public System.Boolean remove_member(System.String id)
        {
            var ret = _target.RemoveMember(id);
            return ret;
        }
        public global::org.omg.SDOPackage.DependencyType get_dependency()
        {
            var ret = _target.GetDependency();
            return (global::org.omg.SDOPackage.DependencyType)ret;
        }
        public System.Boolean set_dependency(global::org.omg.SDOPackage.DependencyType dependency)
        {
            var ret = _target.SetDependency((ReactiveRTM.SDOPackage.DependencyType)dependency);
            return ret;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading.Tasks;
using ReactiveRTM.Corba;
using ReactiveRTM.Extensions;

 
namespace ReactiveRTM.CORBA
{
    public class TypeCodeStub : IStub, ReactiveRTM.CORBA.TypeCode
    {
        private global::omg.org.CORBA.TypeCode _target;

        public TypeCodeStub()
        {
        }

        public TypeCodeStub(global::omg.org.CORBA.TypeCode target)
        {
            _target = target;
        }

        object IStub.GetTarget()
        {
            return _target;
        }
        void IStub.SetTarget(object target)
        {
            _target = (global::omg.org.CORBA.TypeCode)target;
        }

 
        public System.Boolean Equal(ReactiveRTM.CORBA.TypeCode tc)
        {
            var ret = _target.equal(((global::omg.org.CORBA.TypeCode)((IStub)tc).GetTarget()));
            return ret;
        }
 
        public System.Boolean Equivalent(ReactiveRTM.CORBA.TypeCode tc)
        {
            var ret = _target.equivalent(((global::omg.org.CORBA.TypeCode)((IStub)tc).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.CORBA.TypeCode GetCompactTypecode()
        {
            var ret = _target.get_compact_typecode();
            return new ReactiveRTM.CORBA.TypeCodeStub(ret);
        }
 
        public ReactiveRTM.CORBA.TCKind Kind()
        {
            var ret = _target.kind();
            return (ReactiveRTM.CORBA.TCKind)ret;
        }
 
        public System.String Id()
        {
            var ret = _target.id();
            return ret;
        }
 
        public System.String Name()
        {
            var ret = _target.name();
            return ret;
        }
 
        public System.Int32 MemberCount()
        {
            var ret = _target.member_count();
            return ret;
        }
 
        public System.String MemberName(System.Int32 index)
        {
            var ret = _target.member_name(index);
            return ret;
        }
 
        public ReactiveRTM.CORBA.TypeCode MemberType(System.Int32 index)
        {
            var ret = _target.member_type(index);
            return new ReactiveRTM.CORBA.TypeCodeStub(ret);
        }
 
        public System.Object MemberLabel(System.Int32 index)
        {
            var ret = _target.member_label(index);
            return ret;
        }
 
        public ReactiveRTM.CORBA.TypeCode DiscriminatorType()
        {
            var ret = _target.discriminator_type();
            return new ReactiveRTM.CORBA.TypeCodeStub(ret);
        }
 
        public System.Int32 DefaultIndex()
        {
            var ret = _target.default_index();
            return ret;
        }
 
        public System.Int32 Length()
        {
            var ret = _target.length();
            return ret;
        }
 
        public ReactiveRTM.CORBA.TypeCode ContentType()
        {
            var ret = _target.content_type();
            return new ReactiveRTM.CORBA.TypeCodeStub(ret);
        }
 
        public System.Int16 MemberVisibility(System.Int32 index)
        {
            var ret = _target.member_visibility(index);
            return ret;
        }
 
        public System.Int16 TypeModifier()
        {
            var ret = _target.type_modifier();
            return ret;
        }
 
        public ReactiveRTM.CORBA.TypeCode ConcreteBaseType()
        {
            var ret = _target.concrete_base_type();
            return new ReactiveRTM.CORBA.TypeCodeStub(ret);
        }
    }
}
 
namespace ReactiveRTM.OpenRTM
{
    public class ComponentObserverStub : IStub, ReactiveRTM.OpenRTM.ComponentObserver
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
 
        public static explicit operator ReactiveRTM.SDOPackage.SDOServiceStub(ReactiveRTM.OpenRTM.ComponentObserverStub child)
        {
            return new ReactiveRTM.SDOPackage.SDOServiceStub((global::org.omg.SDOPackage.SDOService)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.OpenRTM.ComponentObserverStub(ReactiveRTM.SDOPackage.SDOServiceStub parent)
        {
            return new ReactiveRTM.OpenRTM.ComponentObserverStub((global::OpenRTM.ComponentObserver)((IStub)parent).GetTarget());
        }

 
        public void UpdateStatus(ReactiveRTM.OpenRTM.StatusKind statusKind,System.String hint)
        {
            _target.update_status((global::OpenRTM.StatusKind)statusKind,hint);
            return;
        }
    }
    public class InPortCdrStub : IStub, ReactiveRTM.OpenRTM.InPortCdr
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

 
        public ReactiveRTM.OpenRTM.PortStatus Put(List<System.Byte> data)
        {
            var ret = _target.put(data.Select(x=>x).ToArray());
            return (ReactiveRTM.OpenRTM.PortStatus)ret;
        }
    }
    public class OutPortCdrStub : IStub, ReactiveRTM.OpenRTM.OutPortCdr
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

 
        public ReactiveRTM.OpenRTM.PortStatus Get(out List<System.Byte> data)
        {
 
            global::System.Byte[] tmpdata;
            var ret = _target._get(out tmpdata);
 
            data = tmpdata.Select(x => (System.Byte)x).ToList();
            return (ReactiveRTM.OpenRTM.PortStatus)ret;
        }
    }
    public class LoggerStub : IStub, ReactiveRTM.OpenRTM.Logger
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
 
        public static explicit operator ReactiveRTM.SDOPackage.SDOServiceStub(ReactiveRTM.OpenRTM.LoggerStub child)
        {
            return new ReactiveRTM.SDOPackage.SDOServiceStub((global::org.omg.SDOPackage.SDOService)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.OpenRTM.LoggerStub(ReactiveRTM.SDOPackage.SDOServiceStub parent)
        {
            return new ReactiveRTM.OpenRTM.LoggerStub((global::OpenRTM.Logger)((IStub)parent).GetTarget());
        }

 
        public void Publish(ReactiveRTM.OpenRTM.LogRecord record)
        {
            _target.publish(((global::OpenRTM.LogRecord)((IStub)record).GetTarget()));
            return;
        }
 
        public void Close()
        {
            _target.close();
            return;
        }
    }
}
 
namespace ReactiveRTM.OpenRTM
{
    public class DataFlowComponentStub : IStub, ReactiveRTM.OpenRTM.DataFlowComponent
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
 
        public static explicit operator ReactiveRTM.RTC.RTObjectStub(ReactiveRTM.OpenRTM.DataFlowComponentStub child)
        {
            return new ReactiveRTM.RTC.RTObjectStub((global::omg.org.RTC.RTObject)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.OpenRTM.DataFlowComponentStub(ReactiveRTM.RTC.RTObjectStub parent)
        {
            return new ReactiveRTM.OpenRTM.DataFlowComponentStub((global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent)((IStub)parent).GetTarget());
        }
 
        public static explicit operator ReactiveRTM.RTC.LightweightRTObjectStub(ReactiveRTM.OpenRTM.DataFlowComponentStub child)
        {
            return new ReactiveRTM.RTC.LightweightRTObjectStub((global::omg.org.RTC.LightweightRTObject)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.OpenRTM.DataFlowComponentStub(ReactiveRTM.RTC.LightweightRTObjectStub parent)
        {
            return new ReactiveRTM.OpenRTM.DataFlowComponentStub((global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent)((IStub)parent).GetTarget());
        }
 
        public static explicit operator ReactiveRTM.RTC.ComponentActionStub(ReactiveRTM.OpenRTM.DataFlowComponentStub child)
        {
            return new ReactiveRTM.RTC.ComponentActionStub((global::omg.org.RTC.ComponentAction)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.OpenRTM.DataFlowComponentStub(ReactiveRTM.RTC.ComponentActionStub parent)
        {
            return new ReactiveRTM.OpenRTM.DataFlowComponentStub((global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent)((IStub)parent).GetTarget());
        }
 
        public static explicit operator ReactiveRTM.SDOPackage.SDOStub(ReactiveRTM.OpenRTM.DataFlowComponentStub child)
        {
            return new ReactiveRTM.SDOPackage.SDOStub((global::org.omg.SDOPackage.SDO)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.OpenRTM.DataFlowComponentStub(ReactiveRTM.SDOPackage.SDOStub parent)
        {
            return new ReactiveRTM.OpenRTM.DataFlowComponentStub((global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent)((IStub)parent).GetTarget());
        }
 
        public static explicit operator ReactiveRTM.SDOPackage.SDOSystemElementStub(ReactiveRTM.OpenRTM.DataFlowComponentStub child)
        {
            return new ReactiveRTM.SDOPackage.SDOSystemElementStub((global::org.omg.SDOPackage.SDOSystemElement)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.OpenRTM.DataFlowComponentStub(ReactiveRTM.SDOPackage.SDOSystemElementStub parent)
        {
            return new ReactiveRTM.OpenRTM.DataFlowComponentStub((global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent)((IStub)parent).GetTarget());
        }
 
        public static explicit operator ReactiveRTM.RTC.DataFlowComponentStub(ReactiveRTM.OpenRTM.DataFlowComponentStub child)
        {
            return new ReactiveRTM.RTC.DataFlowComponentStub((global::omg.org.RTC.DataFlowComponent)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.OpenRTM.DataFlowComponentStub(ReactiveRTM.RTC.DataFlowComponentStub parent)
        {
            return new ReactiveRTM.OpenRTM.DataFlowComponentStub((global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent)((IStub)parent).GetTarget());
        }
 
        public static explicit operator ReactiveRTM.RTC.DataFlowComponentActionStub(ReactiveRTM.OpenRTM.DataFlowComponentStub child)
        {
            return new ReactiveRTM.RTC.DataFlowComponentActionStub((global::omg.org.RTC.DataFlowComponentAction)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.OpenRTM.DataFlowComponentStub(ReactiveRTM.RTC.DataFlowComponentActionStub parent)
        {
            return new ReactiveRTM.OpenRTM.DataFlowComponentStub((global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent)((IStub)parent).GetTarget());
        }

 
        public ReactiveRTM.RTC.ComponentProfile GetComponentProfile()
        {
            var ret = _target.get_component_profile();
            return new ReactiveRTM.RTC.ComponentProfile(ret);
        }
 
        public List<ReactiveRTM.RTC.PortService> GetPorts()
        {
            var ret = _target.get_ports();
            return ret.Select(x => (ReactiveRTM.RTC.PortService)new ReactiveRTM.RTC.PortServiceStub(x)).ToList();
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Initialize()
        {
            var ret = _target.initialize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Finalize()
        {
            var ret = _target._finalize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public System.Boolean IsAlive(ReactiveRTM.RTC.ExecutionContext execContext)
        {
            var ret = _target.is_alive(((global::omg.org.RTC.ExecutionContext)((IStub)execContext).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Exit()
        {
            var ret = _target._exit();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public System.Int32 AttachContext(ReactiveRTM.RTC.ExecutionContext execContext)
        {
            var ret = _target.attach_context(((global::omg.org.RTC.ExecutionContext)((IStub)execContext).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t DetachContext(System.Int32 execHandle)
        {
            var ret = _target.detach_context(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ExecutionContext GetContext(System.Int32 execHandle)
        {
            var ret = _target.get_context(execHandle);
            return new ReactiveRTM.RTC.ExecutionContextStub(ret);
        }
 
        public List<ReactiveRTM.RTC.ExecutionContext> GetOwnedContexts()
        {
            var ret = _target.get_owned_contexts();
            return ret.Select(x => (ReactiveRTM.RTC.ExecutionContext)new ReactiveRTM.RTC.ExecutionContextStub(x)).ToList();
        }
 
        public List<ReactiveRTM.RTC.ExecutionContext> GetParticipatingContexts()
        {
            var ret = _target.get_participating_contexts();
            return ret.Select(x => (ReactiveRTM.RTC.ExecutionContext)new ReactiveRTM.RTC.ExecutionContextStub(x)).ToList();
        }
 
        public System.Int32 GetContextHandle(ReactiveRTM.RTC.ExecutionContext cxt)
        {
            var ret = _target.get_context_handle(((global::omg.org.RTC.ExecutionContext)((IStub)cxt).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnInitialize()
        {
            var ret = _target.on_initialize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnFinalize()
        {
            var ret = _target.on_finalize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnStartup(System.Int32 execHandle)
        {
            var ret = _target.on_startup(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnShutdown(System.Int32 execHandle)
        {
            var ret = _target.on_shutdown(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnActivated(System.Int32 execHandle)
        {
            var ret = _target.on_activated(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnDeactivated(System.Int32 execHandle)
        {
            var ret = _target.on_deactivated(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnAborting(System.Int32 execHandle)
        {
            var ret = _target.on_aborting(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnError(System.Int32 execHandle)
        {
            var ret = _target.on_error(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnReset(System.Int32 execHandle)
        {
            var ret = _target.on_reset(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public System.String GetSdoId()
        {
            var ret = _target.get_sdo_id();
            return ret;
        }
 
        public System.String GetSdoType()
        {
            var ret = _target.get_sdo_type();
            return ret;
        }
 
        public ReactiveRTM.SDOPackage.DeviceProfile GetDeviceProfile()
        {
            var ret = _target.get_device_profile();
            return new ReactiveRTM.SDOPackage.DeviceProfile(ret);
        }
 
        public List<ReactiveRTM.SDOPackage.ServiceProfile> GetServiceProfiles()
        {
            var ret = _target.get_service_profiles();
            return ret.Select(x => (ReactiveRTM.SDOPackage.ServiceProfile)new ReactiveRTM.SDOPackage.ServiceProfile(x)).ToList();
        }
 
        public ReactiveRTM.SDOPackage.ServiceProfile GetServiceProfile(System.String id)
        {
            var ret = _target.get_service_profile(id);
            return new ReactiveRTM.SDOPackage.ServiceProfile(ret);
        }
 
        public ReactiveRTM.SDOPackage.SDOService GetSdoService(System.String id)
        {
            var ret = _target.get_sdo_service(id);
            return new ReactiveRTM.SDOPackage.SDOServiceStub(ret);
        }
 
        public ReactiveRTM.SDOPackage.Configuration GetConfiguration()
        {
            var ret = _target.get_configuration();
            return new ReactiveRTM.SDOPackage.ConfigurationStub(ret);
        }
 
        public ReactiveRTM.SDOPackage.Monitoring GetMonitoring()
        {
            var ret = _target.get_monitoring();
            return new ReactiveRTM.SDOPackage.MonitoringStub(ret);
        }
 
        public List<ReactiveRTM.SDOPackage.Organization> GetOrganizations()
        {
            var ret = _target.get_organizations();
            return ret.Select(x => (ReactiveRTM.SDOPackage.Organization)new ReactiveRTM.SDOPackage.OrganizationStub(x)).ToList();
        }
 
        public Dictionary<string,object> GetStatusList()
        {
            var ret = _target.get_status_list();
            return Converter.NVListToDictionary(ret);
        }
 
        public System.Object GetStatus(System.String nme)
        {
            var ret = _target.get_status(nme);
            return ret;
        }
 
        public List<ReactiveRTM.SDOPackage.Organization> GetOwnedOrganizations()
        {
            var ret = _target.get_owned_organizations();
            return ret.Select(x => (ReactiveRTM.SDOPackage.Organization)new ReactiveRTM.SDOPackage.OrganizationStub(x)).ToList();
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnExecute(System.Int32 execHandle)
        {
            var ret = _target.on_execute(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnStateUpdate(System.Int32 execHandle)
        {
            var ret = _target.on_state_update(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnRateChanged(System.Int32 execHandle)
        {
            var ret = _target.on_rate_changed(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
    }
    public class ExtTrigExecutionContextServiceStub : IStub, ReactiveRTM.OpenRTM.ExtTrigExecutionContextService
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
 
        public static explicit operator ReactiveRTM.RTC.ExecutionContextServiceStub(ReactiveRTM.OpenRTM.ExtTrigExecutionContextServiceStub child)
        {
            return new ReactiveRTM.RTC.ExecutionContextServiceStub((global::omg.org.RTC.ExecutionContextService)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.OpenRTM.ExtTrigExecutionContextServiceStub(ReactiveRTM.RTC.ExecutionContextServiceStub parent)
        {
            return new ReactiveRTM.OpenRTM.ExtTrigExecutionContextServiceStub((global::openrtm.aist.go.jp.OpenRTM.ExtTrigExecutionContextService)((IStub)parent).GetTarget());
        }
 
        public static explicit operator ReactiveRTM.RTC.ExecutionContextStub(ReactiveRTM.OpenRTM.ExtTrigExecutionContextServiceStub child)
        {
            return new ReactiveRTM.RTC.ExecutionContextStub((global::omg.org.RTC.ExecutionContext)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.OpenRTM.ExtTrigExecutionContextServiceStub(ReactiveRTM.RTC.ExecutionContextStub parent)
        {
            return new ReactiveRTM.OpenRTM.ExtTrigExecutionContextServiceStub((global::openrtm.aist.go.jp.OpenRTM.ExtTrigExecutionContextService)((IStub)parent).GetTarget());
        }
 
        public static explicit operator ReactiveRTM.SDOPackage.SDOServiceStub(ReactiveRTM.OpenRTM.ExtTrigExecutionContextServiceStub child)
        {
            return new ReactiveRTM.SDOPackage.SDOServiceStub((global::org.omg.SDOPackage.SDOService)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.OpenRTM.ExtTrigExecutionContextServiceStub(ReactiveRTM.SDOPackage.SDOServiceStub parent)
        {
            return new ReactiveRTM.OpenRTM.ExtTrigExecutionContextServiceStub((global::openrtm.aist.go.jp.OpenRTM.ExtTrigExecutionContextService)((IStub)parent).GetTarget());
        }

 
        public void Tick()
        {
            _target.tick();
            return;
        }
 
        public ReactiveRTM.RTC.ExecutionContextProfile GetProfile()
        {
            var ret = _target.get_profile();
            return new ReactiveRTM.RTC.ExecutionContextProfile(ret);
        }
 
        public System.Boolean IsRunning()
        {
            var ret = _target.is_running();
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Start()
        {
            var ret = _target.start();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Stop()
        {
            var ret = _target._stop();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public System.Double GetRate()
        {
            var ret = _target.get_rate();
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t SetRate(System.Double rate)
        {
            var ret = _target.set_rate(rate);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t AddComponent(ReactiveRTM.RTC.LightweightRTObject comp)
        {
            var ret = _target.add_component(((global::omg.org.RTC.LightweightRTObject)((IStub)comp).GetTarget()));
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t RemoveComponent(ReactiveRTM.RTC.LightweightRTObject comp)
        {
            var ret = _target.remove_component(((global::omg.org.RTC.LightweightRTObject)((IStub)comp).GetTarget()));
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t ActivateComponent(ReactiveRTM.RTC.LightweightRTObject comp)
        {
            var ret = _target.activate_component(((global::omg.org.RTC.LightweightRTObject)((IStub)comp).GetTarget()));
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t DeactivateComponent(ReactiveRTM.RTC.LightweightRTObject comp)
        {
            var ret = _target.deactivate_component(((global::omg.org.RTC.LightweightRTObject)((IStub)comp).GetTarget()));
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t ResetComponent(ReactiveRTM.RTC.LightweightRTObject comp)
        {
            var ret = _target.reset_component(((global::omg.org.RTC.LightweightRTObject)((IStub)comp).GetTarget()));
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.LifeCycleState GetComponentState(ReactiveRTM.RTC.LightweightRTObject comp)
        {
            var ret = _target.get_component_state(((global::omg.org.RTC.LightweightRTObject)((IStub)comp).GetTarget()));
            return (ReactiveRTM.RTC.LifeCycleState)ret;
        }
 
        public ReactiveRTM.RTC.ExecutionKind GetKind()
        {
            var ret = _target.get_kind();
            return (ReactiveRTM.RTC.ExecutionKind)ret;
        }
    }
}
 
namespace ReactiveRTM.RTC
{
    public class ExecutionContextStub : IStub, ReactiveRTM.RTC.ExecutionContext
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

 
        public System.Boolean IsRunning()
        {
            var ret = _target.is_running();
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Start()
        {
            var ret = _target.start();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Stop()
        {
            var ret = _target._stop();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public System.Double GetRate()
        {
            var ret = _target.get_rate();
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t SetRate(System.Double rate)
        {
            var ret = _target.set_rate(rate);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t AddComponent(ReactiveRTM.RTC.LightweightRTObject comp)
        {
            var ret = _target.add_component(((global::omg.org.RTC.LightweightRTObject)((IStub)comp).GetTarget()));
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t RemoveComponent(ReactiveRTM.RTC.LightweightRTObject comp)
        {
            var ret = _target.remove_component(((global::omg.org.RTC.LightweightRTObject)((IStub)comp).GetTarget()));
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t ActivateComponent(ReactiveRTM.RTC.LightweightRTObject comp)
        {
            var ret = _target.activate_component(((global::omg.org.RTC.LightweightRTObject)((IStub)comp).GetTarget()));
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t DeactivateComponent(ReactiveRTM.RTC.LightweightRTObject comp)
        {
            var ret = _target.deactivate_component(((global::omg.org.RTC.LightweightRTObject)((IStub)comp).GetTarget()));
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t ResetComponent(ReactiveRTM.RTC.LightweightRTObject comp)
        {
            var ret = _target.reset_component(((global::omg.org.RTC.LightweightRTObject)((IStub)comp).GetTarget()));
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.LifeCycleState GetComponentState(ReactiveRTM.RTC.LightweightRTObject comp)
        {
            var ret = _target.get_component_state(((global::omg.org.RTC.LightweightRTObject)((IStub)comp).GetTarget()));
            return (ReactiveRTM.RTC.LifeCycleState)ret;
        }
 
        public ReactiveRTM.RTC.ExecutionKind GetKind()
        {
            var ret = _target.get_kind();
            return (ReactiveRTM.RTC.ExecutionKind)ret;
        }
    }
    public class ComponentActionStub : IStub, ReactiveRTM.RTC.ComponentAction
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

 
        public ReactiveRTM.RTC.ReturnCode_t OnInitialize()
        {
            var ret = _target.on_initialize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnFinalize()
        {
            var ret = _target.on_finalize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnStartup(System.Int32 execHandle)
        {
            var ret = _target.on_startup(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnShutdown(System.Int32 execHandle)
        {
            var ret = _target.on_shutdown(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnActivated(System.Int32 execHandle)
        {
            var ret = _target.on_activated(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnDeactivated(System.Int32 execHandle)
        {
            var ret = _target.on_deactivated(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnAborting(System.Int32 execHandle)
        {
            var ret = _target.on_aborting(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnError(System.Int32 execHandle)
        {
            var ret = _target.on_error(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnReset(System.Int32 execHandle)
        {
            var ret = _target.on_reset(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
    }
    public class LightweightRTObjectStub : IStub, ReactiveRTM.RTC.LightweightRTObject
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
 
        public static explicit operator ReactiveRTM.RTC.ComponentActionStub(ReactiveRTM.RTC.LightweightRTObjectStub child)
        {
            return new ReactiveRTM.RTC.ComponentActionStub((global::omg.org.RTC.ComponentAction)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.RTC.LightweightRTObjectStub(ReactiveRTM.RTC.ComponentActionStub parent)
        {
            return new ReactiveRTM.RTC.LightweightRTObjectStub((global::omg.org.RTC.LightweightRTObject)((IStub)parent).GetTarget());
        }

 
        public ReactiveRTM.RTC.ReturnCode_t Initialize()
        {
            var ret = _target.initialize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Finalize()
        {
            var ret = _target._finalize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public System.Boolean IsAlive(ReactiveRTM.RTC.ExecutionContext execContext)
        {
            var ret = _target.is_alive(((global::omg.org.RTC.ExecutionContext)((IStub)execContext).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Exit()
        {
            var ret = _target._exit();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public System.Int32 AttachContext(ReactiveRTM.RTC.ExecutionContext execContext)
        {
            var ret = _target.attach_context(((global::omg.org.RTC.ExecutionContext)((IStub)execContext).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t DetachContext(System.Int32 execHandle)
        {
            var ret = _target.detach_context(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ExecutionContext GetContext(System.Int32 execHandle)
        {
            var ret = _target.get_context(execHandle);
            return new ReactiveRTM.RTC.ExecutionContextStub(ret);
        }
 
        public List<ReactiveRTM.RTC.ExecutionContext> GetOwnedContexts()
        {
            var ret = _target.get_owned_contexts();
            return ret.Select(x => (ReactiveRTM.RTC.ExecutionContext)new ReactiveRTM.RTC.ExecutionContextStub(x)).ToList();
        }
 
        public List<ReactiveRTM.RTC.ExecutionContext> GetParticipatingContexts()
        {
            var ret = _target.get_participating_contexts();
            return ret.Select(x => (ReactiveRTM.RTC.ExecutionContext)new ReactiveRTM.RTC.ExecutionContextStub(x)).ToList();
        }
 
        public System.Int32 GetContextHandle(ReactiveRTM.RTC.ExecutionContext cxt)
        {
            var ret = _target.get_context_handle(((global::omg.org.RTC.ExecutionContext)((IStub)cxt).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnInitialize()
        {
            var ret = _target.on_initialize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnFinalize()
        {
            var ret = _target.on_finalize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnStartup(System.Int32 execHandle)
        {
            var ret = _target.on_startup(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnShutdown(System.Int32 execHandle)
        {
            var ret = _target.on_shutdown(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnActivated(System.Int32 execHandle)
        {
            var ret = _target.on_activated(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnDeactivated(System.Int32 execHandle)
        {
            var ret = _target.on_deactivated(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnAborting(System.Int32 execHandle)
        {
            var ret = _target.on_aborting(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnError(System.Int32 execHandle)
        {
            var ret = _target.on_error(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnReset(System.Int32 execHandle)
        {
            var ret = _target.on_reset(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
    }
    public class DataFlowComponentActionStub : IStub, ReactiveRTM.RTC.DataFlowComponentAction
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

 
        public ReactiveRTM.RTC.ReturnCode_t OnExecute(System.Int32 execHandle)
        {
            var ret = _target.on_execute(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnStateUpdate(System.Int32 execHandle)
        {
            var ret = _target.on_state_update(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnRateChanged(System.Int32 execHandle)
        {
            var ret = _target.on_rate_changed(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
    }
    public class DataFlowComponentStub : IStub, ReactiveRTM.RTC.DataFlowComponent
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
 
        public static explicit operator ReactiveRTM.RTC.LightweightRTObjectStub(ReactiveRTM.RTC.DataFlowComponentStub child)
        {
            return new ReactiveRTM.RTC.LightweightRTObjectStub((global::omg.org.RTC.LightweightRTObject)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.RTC.DataFlowComponentStub(ReactiveRTM.RTC.LightweightRTObjectStub parent)
        {
            return new ReactiveRTM.RTC.DataFlowComponentStub((global::omg.org.RTC.DataFlowComponent)((IStub)parent).GetTarget());
        }
 
        public static explicit operator ReactiveRTM.RTC.ComponentActionStub(ReactiveRTM.RTC.DataFlowComponentStub child)
        {
            return new ReactiveRTM.RTC.ComponentActionStub((global::omg.org.RTC.ComponentAction)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.RTC.DataFlowComponentStub(ReactiveRTM.RTC.ComponentActionStub parent)
        {
            return new ReactiveRTM.RTC.DataFlowComponentStub((global::omg.org.RTC.DataFlowComponent)((IStub)parent).GetTarget());
        }
 
        public static explicit operator ReactiveRTM.RTC.DataFlowComponentActionStub(ReactiveRTM.RTC.DataFlowComponentStub child)
        {
            return new ReactiveRTM.RTC.DataFlowComponentActionStub((global::omg.org.RTC.DataFlowComponentAction)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.RTC.DataFlowComponentStub(ReactiveRTM.RTC.DataFlowComponentActionStub parent)
        {
            return new ReactiveRTM.RTC.DataFlowComponentStub((global::omg.org.RTC.DataFlowComponent)((IStub)parent).GetTarget());
        }

 
        public ReactiveRTM.RTC.ReturnCode_t Initialize()
        {
            var ret = _target.initialize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Finalize()
        {
            var ret = _target._finalize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public System.Boolean IsAlive(ReactiveRTM.RTC.ExecutionContext execContext)
        {
            var ret = _target.is_alive(((global::omg.org.RTC.ExecutionContext)((IStub)execContext).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Exit()
        {
            var ret = _target._exit();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public System.Int32 AttachContext(ReactiveRTM.RTC.ExecutionContext execContext)
        {
            var ret = _target.attach_context(((global::omg.org.RTC.ExecutionContext)((IStub)execContext).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t DetachContext(System.Int32 execHandle)
        {
            var ret = _target.detach_context(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ExecutionContext GetContext(System.Int32 execHandle)
        {
            var ret = _target.get_context(execHandle);
            return new ReactiveRTM.RTC.ExecutionContextStub(ret);
        }
 
        public List<ReactiveRTM.RTC.ExecutionContext> GetOwnedContexts()
        {
            var ret = _target.get_owned_contexts();
            return ret.Select(x => (ReactiveRTM.RTC.ExecutionContext)new ReactiveRTM.RTC.ExecutionContextStub(x)).ToList();
        }
 
        public List<ReactiveRTM.RTC.ExecutionContext> GetParticipatingContexts()
        {
            var ret = _target.get_participating_contexts();
            return ret.Select(x => (ReactiveRTM.RTC.ExecutionContext)new ReactiveRTM.RTC.ExecutionContextStub(x)).ToList();
        }
 
        public System.Int32 GetContextHandle(ReactiveRTM.RTC.ExecutionContext cxt)
        {
            var ret = _target.get_context_handle(((global::omg.org.RTC.ExecutionContext)((IStub)cxt).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnInitialize()
        {
            var ret = _target.on_initialize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnFinalize()
        {
            var ret = _target.on_finalize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnStartup(System.Int32 execHandle)
        {
            var ret = _target.on_startup(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnShutdown(System.Int32 execHandle)
        {
            var ret = _target.on_shutdown(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnActivated(System.Int32 execHandle)
        {
            var ret = _target.on_activated(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnDeactivated(System.Int32 execHandle)
        {
            var ret = _target.on_deactivated(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnAborting(System.Int32 execHandle)
        {
            var ret = _target.on_aborting(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnError(System.Int32 execHandle)
        {
            var ret = _target.on_error(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnReset(System.Int32 execHandle)
        {
            var ret = _target.on_reset(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnExecute(System.Int32 execHandle)
        {
            var ret = _target.on_execute(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnStateUpdate(System.Int32 execHandle)
        {
            var ret = _target.on_state_update(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnRateChanged(System.Int32 execHandle)
        {
            var ret = _target.on_rate_changed(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
    }
    public class FsmStub : IStub, ReactiveRTM.RTC.Fsm
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
 
        public static explicit operator ReactiveRTM.RTC.LightweightRTObjectStub(ReactiveRTM.RTC.FsmStub child)
        {
            return new ReactiveRTM.RTC.LightweightRTObjectStub((global::omg.org.RTC.LightweightRTObject)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.RTC.FsmStub(ReactiveRTM.RTC.LightweightRTObjectStub parent)
        {
            return new ReactiveRTM.RTC.FsmStub((global::omg.org.RTC.Fsm)((IStub)parent).GetTarget());
        }
 
        public static explicit operator ReactiveRTM.RTC.ComponentActionStub(ReactiveRTM.RTC.FsmStub child)
        {
            return new ReactiveRTM.RTC.ComponentActionStub((global::omg.org.RTC.ComponentAction)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.RTC.FsmStub(ReactiveRTM.RTC.ComponentActionStub parent)
        {
            return new ReactiveRTM.RTC.FsmStub((global::omg.org.RTC.Fsm)((IStub)parent).GetTarget());
        }

 
        public ReactiveRTM.RTC.ReturnCode_t Initialize()
        {
            var ret = _target.initialize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Finalize()
        {
            var ret = _target._finalize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public System.Boolean IsAlive(ReactiveRTM.RTC.ExecutionContext execContext)
        {
            var ret = _target.is_alive(((global::omg.org.RTC.ExecutionContext)((IStub)execContext).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Exit()
        {
            var ret = _target._exit();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public System.Int32 AttachContext(ReactiveRTM.RTC.ExecutionContext execContext)
        {
            var ret = _target.attach_context(((global::omg.org.RTC.ExecutionContext)((IStub)execContext).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t DetachContext(System.Int32 execHandle)
        {
            var ret = _target.detach_context(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ExecutionContext GetContext(System.Int32 execHandle)
        {
            var ret = _target.get_context(execHandle);
            return new ReactiveRTM.RTC.ExecutionContextStub(ret);
        }
 
        public List<ReactiveRTM.RTC.ExecutionContext> GetOwnedContexts()
        {
            var ret = _target.get_owned_contexts();
            return ret.Select(x => (ReactiveRTM.RTC.ExecutionContext)new ReactiveRTM.RTC.ExecutionContextStub(x)).ToList();
        }
 
        public List<ReactiveRTM.RTC.ExecutionContext> GetParticipatingContexts()
        {
            var ret = _target.get_participating_contexts();
            return ret.Select(x => (ReactiveRTM.RTC.ExecutionContext)new ReactiveRTM.RTC.ExecutionContextStub(x)).ToList();
        }
 
        public System.Int32 GetContextHandle(ReactiveRTM.RTC.ExecutionContext cxt)
        {
            var ret = _target.get_context_handle(((global::omg.org.RTC.ExecutionContext)((IStub)cxt).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnInitialize()
        {
            var ret = _target.on_initialize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnFinalize()
        {
            var ret = _target.on_finalize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnStartup(System.Int32 execHandle)
        {
            var ret = _target.on_startup(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnShutdown(System.Int32 execHandle)
        {
            var ret = _target.on_shutdown(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnActivated(System.Int32 execHandle)
        {
            var ret = _target.on_activated(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnDeactivated(System.Int32 execHandle)
        {
            var ret = _target.on_deactivated(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnAborting(System.Int32 execHandle)
        {
            var ret = _target.on_aborting(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnError(System.Int32 execHandle)
        {
            var ret = _target.on_error(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnReset(System.Int32 execHandle)
        {
            var ret = _target.on_reset(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
    }
    public class FsmParticipantActionStub : IStub, ReactiveRTM.RTC.FsmParticipantAction
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

 
        public ReactiveRTM.RTC.ReturnCode_t OnAction(System.Int32 execHandle)
        {
            var ret = _target.on_action(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
    }
    public class FsmParticipantStub : IStub, ReactiveRTM.RTC.FsmParticipant
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
 
        public static explicit operator ReactiveRTM.RTC.LightweightRTObjectStub(ReactiveRTM.RTC.FsmParticipantStub child)
        {
            return new ReactiveRTM.RTC.LightweightRTObjectStub((global::omg.org.RTC.LightweightRTObject)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.RTC.FsmParticipantStub(ReactiveRTM.RTC.LightweightRTObjectStub parent)
        {
            return new ReactiveRTM.RTC.FsmParticipantStub((global::omg.org.RTC.FsmParticipant)((IStub)parent).GetTarget());
        }
 
        public static explicit operator ReactiveRTM.RTC.ComponentActionStub(ReactiveRTM.RTC.FsmParticipantStub child)
        {
            return new ReactiveRTM.RTC.ComponentActionStub((global::omg.org.RTC.ComponentAction)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.RTC.FsmParticipantStub(ReactiveRTM.RTC.ComponentActionStub parent)
        {
            return new ReactiveRTM.RTC.FsmParticipantStub((global::omg.org.RTC.FsmParticipant)((IStub)parent).GetTarget());
        }
 
        public static explicit operator ReactiveRTM.RTC.FsmParticipantActionStub(ReactiveRTM.RTC.FsmParticipantStub child)
        {
            return new ReactiveRTM.RTC.FsmParticipantActionStub((global::omg.org.RTC.FsmParticipantAction)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.RTC.FsmParticipantStub(ReactiveRTM.RTC.FsmParticipantActionStub parent)
        {
            return new ReactiveRTM.RTC.FsmParticipantStub((global::omg.org.RTC.FsmParticipant)((IStub)parent).GetTarget());
        }

 
        public ReactiveRTM.RTC.ReturnCode_t Initialize()
        {
            var ret = _target.initialize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Finalize()
        {
            var ret = _target._finalize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public System.Boolean IsAlive(ReactiveRTM.RTC.ExecutionContext execContext)
        {
            var ret = _target.is_alive(((global::omg.org.RTC.ExecutionContext)((IStub)execContext).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Exit()
        {
            var ret = _target._exit();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public System.Int32 AttachContext(ReactiveRTM.RTC.ExecutionContext execContext)
        {
            var ret = _target.attach_context(((global::omg.org.RTC.ExecutionContext)((IStub)execContext).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t DetachContext(System.Int32 execHandle)
        {
            var ret = _target.detach_context(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ExecutionContext GetContext(System.Int32 execHandle)
        {
            var ret = _target.get_context(execHandle);
            return new ReactiveRTM.RTC.ExecutionContextStub(ret);
        }
 
        public List<ReactiveRTM.RTC.ExecutionContext> GetOwnedContexts()
        {
            var ret = _target.get_owned_contexts();
            return ret.Select(x => (ReactiveRTM.RTC.ExecutionContext)new ReactiveRTM.RTC.ExecutionContextStub(x)).ToList();
        }
 
        public List<ReactiveRTM.RTC.ExecutionContext> GetParticipatingContexts()
        {
            var ret = _target.get_participating_contexts();
            return ret.Select(x => (ReactiveRTM.RTC.ExecutionContext)new ReactiveRTM.RTC.ExecutionContextStub(x)).ToList();
        }
 
        public System.Int32 GetContextHandle(ReactiveRTM.RTC.ExecutionContext cxt)
        {
            var ret = _target.get_context_handle(((global::omg.org.RTC.ExecutionContext)((IStub)cxt).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnInitialize()
        {
            var ret = _target.on_initialize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnFinalize()
        {
            var ret = _target.on_finalize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnStartup(System.Int32 execHandle)
        {
            var ret = _target.on_startup(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnShutdown(System.Int32 execHandle)
        {
            var ret = _target.on_shutdown(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnActivated(System.Int32 execHandle)
        {
            var ret = _target.on_activated(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnDeactivated(System.Int32 execHandle)
        {
            var ret = _target.on_deactivated(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnAborting(System.Int32 execHandle)
        {
            var ret = _target.on_aborting(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnError(System.Int32 execHandle)
        {
            var ret = _target.on_error(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnReset(System.Int32 execHandle)
        {
            var ret = _target.on_reset(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnAction(System.Int32 execHandle)
        {
            var ret = _target.on_action(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
    }
    public class ModeStub : IStub, ReactiveRTM.RTC.Mode
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
    public class ModeCapableStub : IStub, ReactiveRTM.RTC.ModeCapable
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

 
        public ReactiveRTM.RTC.Mode GetDefaultMode()
        {
            var ret = _target.get_default_mode();
            return new ReactiveRTM.RTC.ModeStub(ret);
        }
 
        public ReactiveRTM.RTC.Mode GetCurrentMode()
        {
            var ret = _target.get_current_mode();
            return new ReactiveRTM.RTC.ModeStub(ret);
        }
 
        public ReactiveRTM.RTC.Mode GetCurrentModeInContext(ReactiveRTM.RTC.ExecutionContext execContext)
        {
            var ret = _target.get_current_mode_in_context(((global::omg.org.RTC.ExecutionContext)((IStub)execContext).GetTarget()));
            return new ReactiveRTM.RTC.ModeStub(ret);
        }
 
        public ReactiveRTM.RTC.Mode GetPendingMode()
        {
            var ret = _target.get_pending_mode();
            return new ReactiveRTM.RTC.ModeStub(ret);
        }
 
        public ReactiveRTM.RTC.Mode GetPendingModeInContext(ReactiveRTM.RTC.ExecutionContext execContext)
        {
            var ret = _target.get_pending_mode_in_context(((global::omg.org.RTC.ExecutionContext)((IStub)execContext).GetTarget()));
            return new ReactiveRTM.RTC.ModeStub(ret);
        }
 
        public ReactiveRTM.RTC.ReturnCode_t SetMode(ReactiveRTM.RTC.Mode newMode,System.Boolean immediate)
        {
            var ret = _target.set_mode(((global::omg.org.RTC.Mode)((IStub)newMode).GetTarget()),immediate);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
    }
    public class MultiModeComponentActionStub : IStub, ReactiveRTM.RTC.MultiModeComponentAction
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

 
        public ReactiveRTM.RTC.ReturnCode_t OnModeChanged(System.Int32 execHandle)
        {
            var ret = _target.on_mode_changed(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
    }
    public class MultiModeObjectStub : IStub, ReactiveRTM.RTC.MultiModeObject
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
 
        public static explicit operator ReactiveRTM.RTC.LightweightRTObjectStub(ReactiveRTM.RTC.MultiModeObjectStub child)
        {
            return new ReactiveRTM.RTC.LightweightRTObjectStub((global::omg.org.RTC.LightweightRTObject)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.RTC.MultiModeObjectStub(ReactiveRTM.RTC.LightweightRTObjectStub parent)
        {
            return new ReactiveRTM.RTC.MultiModeObjectStub((global::omg.org.RTC.MultiModeObject)((IStub)parent).GetTarget());
        }
 
        public static explicit operator ReactiveRTM.RTC.ComponentActionStub(ReactiveRTM.RTC.MultiModeObjectStub child)
        {
            return new ReactiveRTM.RTC.ComponentActionStub((global::omg.org.RTC.ComponentAction)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.RTC.MultiModeObjectStub(ReactiveRTM.RTC.ComponentActionStub parent)
        {
            return new ReactiveRTM.RTC.MultiModeObjectStub((global::omg.org.RTC.MultiModeObject)((IStub)parent).GetTarget());
        }
 
        public static explicit operator ReactiveRTM.RTC.ModeCapableStub(ReactiveRTM.RTC.MultiModeObjectStub child)
        {
            return new ReactiveRTM.RTC.ModeCapableStub((global::omg.org.RTC.ModeCapable)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.RTC.MultiModeObjectStub(ReactiveRTM.RTC.ModeCapableStub parent)
        {
            return new ReactiveRTM.RTC.MultiModeObjectStub((global::omg.org.RTC.MultiModeObject)((IStub)parent).GetTarget());
        }
 
        public static explicit operator ReactiveRTM.RTC.MultiModeComponentActionStub(ReactiveRTM.RTC.MultiModeObjectStub child)
        {
            return new ReactiveRTM.RTC.MultiModeComponentActionStub((global::omg.org.RTC.MultiModeComponentAction)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.RTC.MultiModeObjectStub(ReactiveRTM.RTC.MultiModeComponentActionStub parent)
        {
            return new ReactiveRTM.RTC.MultiModeObjectStub((global::omg.org.RTC.MultiModeObject)((IStub)parent).GetTarget());
        }

 
        public ReactiveRTM.RTC.ReturnCode_t Initialize()
        {
            var ret = _target.initialize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Finalize()
        {
            var ret = _target._finalize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public System.Boolean IsAlive(ReactiveRTM.RTC.ExecutionContext execContext)
        {
            var ret = _target.is_alive(((global::omg.org.RTC.ExecutionContext)((IStub)execContext).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Exit()
        {
            var ret = _target._exit();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public System.Int32 AttachContext(ReactiveRTM.RTC.ExecutionContext execContext)
        {
            var ret = _target.attach_context(((global::omg.org.RTC.ExecutionContext)((IStub)execContext).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t DetachContext(System.Int32 execHandle)
        {
            var ret = _target.detach_context(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ExecutionContext GetContext(System.Int32 execHandle)
        {
            var ret = _target.get_context(execHandle);
            return new ReactiveRTM.RTC.ExecutionContextStub(ret);
        }
 
        public List<ReactiveRTM.RTC.ExecutionContext> GetOwnedContexts()
        {
            var ret = _target.get_owned_contexts();
            return ret.Select(x => (ReactiveRTM.RTC.ExecutionContext)new ReactiveRTM.RTC.ExecutionContextStub(x)).ToList();
        }
 
        public List<ReactiveRTM.RTC.ExecutionContext> GetParticipatingContexts()
        {
            var ret = _target.get_participating_contexts();
            return ret.Select(x => (ReactiveRTM.RTC.ExecutionContext)new ReactiveRTM.RTC.ExecutionContextStub(x)).ToList();
        }
 
        public System.Int32 GetContextHandle(ReactiveRTM.RTC.ExecutionContext cxt)
        {
            var ret = _target.get_context_handle(((global::omg.org.RTC.ExecutionContext)((IStub)cxt).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnInitialize()
        {
            var ret = _target.on_initialize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnFinalize()
        {
            var ret = _target.on_finalize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnStartup(System.Int32 execHandle)
        {
            var ret = _target.on_startup(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnShutdown(System.Int32 execHandle)
        {
            var ret = _target.on_shutdown(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnActivated(System.Int32 execHandle)
        {
            var ret = _target.on_activated(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnDeactivated(System.Int32 execHandle)
        {
            var ret = _target.on_deactivated(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnAborting(System.Int32 execHandle)
        {
            var ret = _target.on_aborting(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnError(System.Int32 execHandle)
        {
            var ret = _target.on_error(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnReset(System.Int32 execHandle)
        {
            var ret = _target.on_reset(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.Mode GetDefaultMode()
        {
            var ret = _target.get_default_mode();
            return new ReactiveRTM.RTC.ModeStub(ret);
        }
 
        public ReactiveRTM.RTC.Mode GetCurrentMode()
        {
            var ret = _target.get_current_mode();
            return new ReactiveRTM.RTC.ModeStub(ret);
        }
 
        public ReactiveRTM.RTC.Mode GetCurrentModeInContext(ReactiveRTM.RTC.ExecutionContext execContext)
        {
            var ret = _target.get_current_mode_in_context(((global::omg.org.RTC.ExecutionContext)((IStub)execContext).GetTarget()));
            return new ReactiveRTM.RTC.ModeStub(ret);
        }
 
        public ReactiveRTM.RTC.Mode GetPendingMode()
        {
            var ret = _target.get_pending_mode();
            return new ReactiveRTM.RTC.ModeStub(ret);
        }
 
        public ReactiveRTM.RTC.Mode GetPendingModeInContext(ReactiveRTM.RTC.ExecutionContext execContext)
        {
            var ret = _target.get_pending_mode_in_context(((global::omg.org.RTC.ExecutionContext)((IStub)execContext).GetTarget()));
            return new ReactiveRTM.RTC.ModeStub(ret);
        }
 
        public ReactiveRTM.RTC.ReturnCode_t SetMode(ReactiveRTM.RTC.Mode newMode,System.Boolean immediate)
        {
            var ret = _target.set_mode(((global::omg.org.RTC.Mode)((IStub)newMode).GetTarget()),immediate);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnModeChanged(System.Int32 execHandle)
        {
            var ret = _target.on_mode_changed(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
    }
    public class RTObjectStub : IStub, ReactiveRTM.RTC.RTObject
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
 
        public static explicit operator ReactiveRTM.RTC.LightweightRTObjectStub(ReactiveRTM.RTC.RTObjectStub child)
        {
            return new ReactiveRTM.RTC.LightweightRTObjectStub((global::omg.org.RTC.LightweightRTObject)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.RTC.RTObjectStub(ReactiveRTM.RTC.LightweightRTObjectStub parent)
        {
            return new ReactiveRTM.RTC.RTObjectStub((global::omg.org.RTC.RTObject)((IStub)parent).GetTarget());
        }
 
        public static explicit operator ReactiveRTM.RTC.ComponentActionStub(ReactiveRTM.RTC.RTObjectStub child)
        {
            return new ReactiveRTM.RTC.ComponentActionStub((global::omg.org.RTC.ComponentAction)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.RTC.RTObjectStub(ReactiveRTM.RTC.ComponentActionStub parent)
        {
            return new ReactiveRTM.RTC.RTObjectStub((global::omg.org.RTC.RTObject)((IStub)parent).GetTarget());
        }
 
        public static explicit operator ReactiveRTM.SDOPackage.SDOStub(ReactiveRTM.RTC.RTObjectStub child)
        {
            return new ReactiveRTM.SDOPackage.SDOStub((global::org.omg.SDOPackage.SDO)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.RTC.RTObjectStub(ReactiveRTM.SDOPackage.SDOStub parent)
        {
            return new ReactiveRTM.RTC.RTObjectStub((global::omg.org.RTC.RTObject)((IStub)parent).GetTarget());
        }
 
        public static explicit operator ReactiveRTM.SDOPackage.SDOSystemElementStub(ReactiveRTM.RTC.RTObjectStub child)
        {
            return new ReactiveRTM.SDOPackage.SDOSystemElementStub((global::org.omg.SDOPackage.SDOSystemElement)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.RTC.RTObjectStub(ReactiveRTM.SDOPackage.SDOSystemElementStub parent)
        {
            return new ReactiveRTM.RTC.RTObjectStub((global::omg.org.RTC.RTObject)((IStub)parent).GetTarget());
        }

 
        public ReactiveRTM.RTC.ComponentProfile GetComponentProfile()
        {
            var ret = _target.get_component_profile();
            return new ReactiveRTM.RTC.ComponentProfile(ret);
        }
 
        public List<ReactiveRTM.RTC.PortService> GetPorts()
        {
            var ret = _target.get_ports();
            return ret.Select(x => (ReactiveRTM.RTC.PortService)new ReactiveRTM.RTC.PortServiceStub(x)).ToList();
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Initialize()
        {
            var ret = _target.initialize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Finalize()
        {
            var ret = _target._finalize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public System.Boolean IsAlive(ReactiveRTM.RTC.ExecutionContext execContext)
        {
            var ret = _target.is_alive(((global::omg.org.RTC.ExecutionContext)((IStub)execContext).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Exit()
        {
            var ret = _target._exit();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public System.Int32 AttachContext(ReactiveRTM.RTC.ExecutionContext execContext)
        {
            var ret = _target.attach_context(((global::omg.org.RTC.ExecutionContext)((IStub)execContext).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t DetachContext(System.Int32 execHandle)
        {
            var ret = _target.detach_context(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ExecutionContext GetContext(System.Int32 execHandle)
        {
            var ret = _target.get_context(execHandle);
            return new ReactiveRTM.RTC.ExecutionContextStub(ret);
        }
 
        public List<ReactiveRTM.RTC.ExecutionContext> GetOwnedContexts()
        {
            var ret = _target.get_owned_contexts();
            return ret.Select(x => (ReactiveRTM.RTC.ExecutionContext)new ReactiveRTM.RTC.ExecutionContextStub(x)).ToList();
        }
 
        public List<ReactiveRTM.RTC.ExecutionContext> GetParticipatingContexts()
        {
            var ret = _target.get_participating_contexts();
            return ret.Select(x => (ReactiveRTM.RTC.ExecutionContext)new ReactiveRTM.RTC.ExecutionContextStub(x)).ToList();
        }
 
        public System.Int32 GetContextHandle(ReactiveRTM.RTC.ExecutionContext cxt)
        {
            var ret = _target.get_context_handle(((global::omg.org.RTC.ExecutionContext)((IStub)cxt).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnInitialize()
        {
            var ret = _target.on_initialize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnFinalize()
        {
            var ret = _target.on_finalize();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnStartup(System.Int32 execHandle)
        {
            var ret = _target.on_startup(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnShutdown(System.Int32 execHandle)
        {
            var ret = _target.on_shutdown(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnActivated(System.Int32 execHandle)
        {
            var ret = _target.on_activated(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnDeactivated(System.Int32 execHandle)
        {
            var ret = _target.on_deactivated(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnAborting(System.Int32 execHandle)
        {
            var ret = _target.on_aborting(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnError(System.Int32 execHandle)
        {
            var ret = _target.on_error(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t OnReset(System.Int32 execHandle)
        {
            var ret = _target.on_reset(execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public System.String GetSdoId()
        {
            var ret = _target.get_sdo_id();
            return ret;
        }
 
        public System.String GetSdoType()
        {
            var ret = _target.get_sdo_type();
            return ret;
        }
 
        public ReactiveRTM.SDOPackage.DeviceProfile GetDeviceProfile()
        {
            var ret = _target.get_device_profile();
            return new ReactiveRTM.SDOPackage.DeviceProfile(ret);
        }
 
        public List<ReactiveRTM.SDOPackage.ServiceProfile> GetServiceProfiles()
        {
            var ret = _target.get_service_profiles();
            return ret.Select(x => (ReactiveRTM.SDOPackage.ServiceProfile)new ReactiveRTM.SDOPackage.ServiceProfile(x)).ToList();
        }
 
        public ReactiveRTM.SDOPackage.ServiceProfile GetServiceProfile(System.String id)
        {
            var ret = _target.get_service_profile(id);
            return new ReactiveRTM.SDOPackage.ServiceProfile(ret);
        }
 
        public ReactiveRTM.SDOPackage.SDOService GetSdoService(System.String id)
        {
            var ret = _target.get_sdo_service(id);
            return new ReactiveRTM.SDOPackage.SDOServiceStub(ret);
        }
 
        public ReactiveRTM.SDOPackage.Configuration GetConfiguration()
        {
            var ret = _target.get_configuration();
            return new ReactiveRTM.SDOPackage.ConfigurationStub(ret);
        }
 
        public ReactiveRTM.SDOPackage.Monitoring GetMonitoring()
        {
            var ret = _target.get_monitoring();
            return new ReactiveRTM.SDOPackage.MonitoringStub(ret);
        }
 
        public List<ReactiveRTM.SDOPackage.Organization> GetOrganizations()
        {
            var ret = _target.get_organizations();
            return ret.Select(x => (ReactiveRTM.SDOPackage.Organization)new ReactiveRTM.SDOPackage.OrganizationStub(x)).ToList();
        }
 
        public Dictionary<string,object> GetStatusList()
        {
            var ret = _target.get_status_list();
            return Converter.NVListToDictionary(ret);
        }
 
        public System.Object GetStatus(System.String nme)
        {
            var ret = _target.get_status(nme);
            return ret;
        }
 
        public List<ReactiveRTM.SDOPackage.Organization> GetOwnedOrganizations()
        {
            var ret = _target.get_owned_organizations();
            return ret.Select(x => (ReactiveRTM.SDOPackage.Organization)new ReactiveRTM.SDOPackage.OrganizationStub(x)).ToList();
        }
    }
    public class PortServiceStub : IStub, ReactiveRTM.RTC.PortService
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
 
        public static explicit operator ReactiveRTM.SDOPackage.SDOServiceStub(ReactiveRTM.RTC.PortServiceStub child)
        {
            return new ReactiveRTM.SDOPackage.SDOServiceStub((global::org.omg.SDOPackage.SDOService)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.RTC.PortServiceStub(ReactiveRTM.SDOPackage.SDOServiceStub parent)
        {
            return new ReactiveRTM.RTC.PortServiceStub((global::omg.org.RTC.PortService)((IStub)parent).GetTarget());
        }

 
        public ReactiveRTM.RTC.PortProfile GetPortProfile()
        {
            var ret = _target.get_port_profile();
            return new ReactiveRTM.RTC.PortProfile(ret);
        }
 
        public List<ReactiveRTM.RTC.ConnectorProfile> GetConnectorProfiles()
        {
            var ret = _target.get_connector_profiles();
            return ret.Select(x => (ReactiveRTM.RTC.ConnectorProfile)new ReactiveRTM.RTC.ConnectorProfile(x)).ToList();
        }
 
        public ReactiveRTM.RTC.ConnectorProfile GetConnectorProfile(System.String connectorId)
        {
            var ret = _target.get_connector_profile(connectorId);
            return new ReactiveRTM.RTC.ConnectorProfile(ret);
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Connect(ref ReactiveRTM.RTC.ConnectorProfile connectorProfile)
        {
 
            var tmpconnectorProfile = ((global::omg.org.RTC.ConnectorProfile)((IStub)connectorProfile).GetTarget());
            var ret = _target.connect(ref tmpconnectorProfile);
 
            connectorProfile = new ReactiveRTM.RTC.ConnectorProfile(tmpconnectorProfile);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Disconnect(System.String connectorId)
        {
            var ret = _target.disconnect(connectorId);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t DisconnectAll()
        {
            var ret = _target.disconnect_all();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t NotifyConnect(ref ReactiveRTM.RTC.ConnectorProfile connectorProfile)
        {
 
            var tmpconnectorProfile = ((global::omg.org.RTC.ConnectorProfile)((IStub)connectorProfile).GetTarget());
            var ret = _target.notify_connect(ref tmpconnectorProfile);
 
            connectorProfile = new ReactiveRTM.RTC.ConnectorProfile(tmpconnectorProfile);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t NotifyDisconnect(System.String connectorId)
        {
            var ret = _target.notify_disconnect(connectorId);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
    }
    public class FsmObjectStub : IStub, ReactiveRTM.RTC.FsmObject
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

 
        public ReactiveRTM.RTC.ReturnCode_t SendStimulus(System.String message,System.Int32 execHandle)
        {
            var ret = _target.send_stimulus(message,execHandle);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
    }
    public class FsmServiceStub : IStub, ReactiveRTM.RTC.FsmService
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
 
        public static explicit operator ReactiveRTM.SDOPackage.SDOServiceStub(ReactiveRTM.RTC.FsmServiceStub child)
        {
            return new ReactiveRTM.SDOPackage.SDOServiceStub((global::org.omg.SDOPackage.SDOService)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.RTC.FsmServiceStub(ReactiveRTM.SDOPackage.SDOServiceStub parent)
        {
            return new ReactiveRTM.RTC.FsmServiceStub((global::omg.org.RTC.FsmService)((IStub)parent).GetTarget());
        }

 
        public ReactiveRTM.RTC.FsmProfile GetFsmProfile()
        {
            var ret = _target.get_fsm_profile();
            return new ReactiveRTM.RTC.FsmProfile(ret);
        }
 
        public ReactiveRTM.RTC.ReturnCode_t SetFsmProfile(ReactiveRTM.RTC.FsmProfile fsmProfile)
        {
            var ret = _target.set_fsm_profile(((global::omg.org.RTC.FsmProfile)((IStub)fsmProfile).GetTarget()));
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
    }
    public class ExecutionContextServiceStub : IStub, ReactiveRTM.RTC.ExecutionContextService
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
 
        public static explicit operator ReactiveRTM.RTC.ExecutionContextStub(ReactiveRTM.RTC.ExecutionContextServiceStub child)
        {
            return new ReactiveRTM.RTC.ExecutionContextStub((global::omg.org.RTC.ExecutionContext)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.RTC.ExecutionContextServiceStub(ReactiveRTM.RTC.ExecutionContextStub parent)
        {
            return new ReactiveRTM.RTC.ExecutionContextServiceStub((global::omg.org.RTC.ExecutionContextService)((IStub)parent).GetTarget());
        }
 
        public static explicit operator ReactiveRTM.SDOPackage.SDOServiceStub(ReactiveRTM.RTC.ExecutionContextServiceStub child)
        {
            return new ReactiveRTM.SDOPackage.SDOServiceStub((global::org.omg.SDOPackage.SDOService)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.RTC.ExecutionContextServiceStub(ReactiveRTM.SDOPackage.SDOServiceStub parent)
        {
            return new ReactiveRTM.RTC.ExecutionContextServiceStub((global::omg.org.RTC.ExecutionContextService)((IStub)parent).GetTarget());
        }

 
        public ReactiveRTM.RTC.ExecutionContextProfile GetProfile()
        {
            var ret = _target.get_profile();
            return new ReactiveRTM.RTC.ExecutionContextProfile(ret);
        }
 
        public System.Boolean IsRunning()
        {
            var ret = _target.is_running();
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Start()
        {
            var ret = _target.start();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Stop()
        {
            var ret = _target._stop();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public System.Double GetRate()
        {
            var ret = _target.get_rate();
            return ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t SetRate(System.Double rate)
        {
            var ret = _target.set_rate(rate);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t AddComponent(ReactiveRTM.RTC.LightweightRTObject comp)
        {
            var ret = _target.add_component(((global::omg.org.RTC.LightweightRTObject)((IStub)comp).GetTarget()));
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t RemoveComponent(ReactiveRTM.RTC.LightweightRTObject comp)
        {
            var ret = _target.remove_component(((global::omg.org.RTC.LightweightRTObject)((IStub)comp).GetTarget()));
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t ActivateComponent(ReactiveRTM.RTC.LightweightRTObject comp)
        {
            var ret = _target.activate_component(((global::omg.org.RTC.LightweightRTObject)((IStub)comp).GetTarget()));
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t DeactivateComponent(ReactiveRTM.RTC.LightweightRTObject comp)
        {
            var ret = _target.deactivate_component(((global::omg.org.RTC.LightweightRTObject)((IStub)comp).GetTarget()));
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t ResetComponent(ReactiveRTM.RTC.LightweightRTObject comp)
        {
            var ret = _target.reset_component(((global::omg.org.RTC.LightweightRTObject)((IStub)comp).GetTarget()));
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.LifeCycleState GetComponentState(ReactiveRTM.RTC.LightweightRTObject comp)
        {
            var ret = _target.get_component_state(((global::omg.org.RTC.LightweightRTObject)((IStub)comp).GetTarget()));
            return (ReactiveRTM.RTC.LifeCycleState)ret;
        }
 
        public ReactiveRTM.RTC.ExecutionKind GetKind()
        {
            var ret = _target.get_kind();
            return (ReactiveRTM.RTC.ExecutionKind)ret;
        }
    }
}
 
namespace ReactiveRTM.RTC
{
    public class ActArrayStub : IStub, ReactiveRTM.RTC.ActArray
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

 
        public ReactiveRTM.RTC.ActArrayGeometry GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.ActArrayGeometry(ret);
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
    }
    public class AIOStub : IStub, ReactiveRTM.RTC.AIO
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
    }
    public class BumperStub : IStub, ReactiveRTM.RTC.Bumper
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

 
        public ReactiveRTM.RTC.BumperGeometry GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.BumperGeometry(ret);
        }
    }
    public class CameraStub : IStub, ReactiveRTM.RTC.Camera
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

 
        public ReactiveRTM.RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.Geometry3D(ret);
        }
 
        public ReactiveRTM.RTC.CameraInfo GetCameraInfo()
        {
            var ret = _target.GetCameraInfo();
            return new ReactiveRTM.RTC.CameraInfo(ret);
        }
    }
    public class DIOStub : IStub, ReactiveRTM.RTC.DIO
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
    }
    public class FiducialStub : IStub, ReactiveRTM.RTC.Fiducial
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

 
        public ReactiveRTM.RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.Geometry3D(ret);
        }
 
        public ReactiveRTM.RTC.FiducialFOV GetFOV()
        {
            var ret = _target.GetFOV();
            return new ReactiveRTM.RTC.FiducialFOV(ret);
        }
 
        public void SetFOV(ReactiveRTM.RTC.FiducialFOV newFOV)
        {
            _target.SetFOV(((global::RTC.FiducialFOV)((IStub)newFOV).GetTarget()));
            return;
        }
    }
    public class GPSStub : IStub, ReactiveRTM.RTC.GPS
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

 
        public ReactiveRTM.RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.Geometry3D(ret);
        }
    }
    public class GripperStub : IStub, ReactiveRTM.RTC.Gripper
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

 
        public ReactiveRTM.RTC.GripperGeometry GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.GripperGeometry(ret);
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
    }
    public class IMUStub : IStub, ReactiveRTM.RTC.IMU
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

 
        public ReactiveRTM.RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.Geometry3D(ret);
        }
    }
    public class INSStub : IStub, ReactiveRTM.RTC.INS
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

 
        public ReactiveRTM.RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.Geometry3D(ret);
        }
    }
    public class LimbStub : IStub, ReactiveRTM.RTC.Limb
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

 
        public ReactiveRTM.RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.Geometry3D(ret);
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
    }
    public class OGMapStub : IStub, ReactiveRTM.RTC.OGMap
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

 
        public ReactiveRTM.RTC.OGMapConfig GetConfig()
        {
            var ret = _target.GetConfig();
            return new ReactiveRTM.RTC.OGMapConfig(ret);
        }
 
        public ReactiveRTM.RTC.OGMapTile GetTile(ReactiveRTM.RTC.OGMapTile tile)
        {
            var ret = _target.GetTile(((global::RTC.OGMapTile)((IStub)tile).GetTarget()));
            return new ReactiveRTM.RTC.OGMapTile(ret);
        }
    }
    public class MulticameraStub : IStub, ReactiveRTM.RTC.Multicamera
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

 
        public ReactiveRTM.RTC.MulticameraGeometry GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.MulticameraGeometry(ret);
        }
 
        public List<ReactiveRTM.RTC.CameraInfo> GetCameraInfos()
        {
            var ret = _target.GetCameraInfos();
            return ret.Select(x => (ReactiveRTM.RTC.CameraInfo)new ReactiveRTM.RTC.CameraInfo(x)).ToList();
        }
    }
    public class PanTiltStub : IStub, ReactiveRTM.RTC.PanTilt
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

 
        public ReactiveRTM.RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.Geometry3D(ret);
        }
    }
    public class PathPlanner2DStub : IStub, ReactiveRTM.RTC.PathPlanner2D
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

 
        public void SetTask(List<ReactiveRTM.RTC.Waypoint2D> coarsePath)
        {
            _target.SetTask(coarsePath.Select(x=>((global::RTC.Waypoint2D)((IStub)x).GetTarget())).ToArray());
            return;
        }
    }
    public class PathPlanner3DStub : IStub, ReactiveRTM.RTC.PathPlanner3D
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

 
        public void SetTask(List<ReactiveRTM.RTC.Waypoint3D> coarsePath)
        {
            _target.SetTask(coarsePath.Select(x=>((global::RTC.Waypoint3D)((IStub)x).GetTarget())).ToArray());
            return;
        }
    }
    public class PathFollower2DStub : IStub, ReactiveRTM.RTC.PathFollower2D
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

 
        public void SetPath(List<ReactiveRTM.RTC.Waypoint2D> path)
        {
            _target.SetPath(path.Select(x=>((global::RTC.Waypoint2D)((IStub)x).GetTarget())).ToArray());
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
 
        public ReactiveRTM.RTC.Waypoint2D GetCurrentWaypoint()
        {
            var ret = _target.GetCurrentWaypoint();
            return new ReactiveRTM.RTC.Waypoint2D(ret);
        }
    }
    public class PathFollower3DStub : IStub, ReactiveRTM.RTC.PathFollower3D
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

 
        public void SetPath(List<ReactiveRTM.RTC.Waypoint3D> path)
        {
            _target.SetPath(path.Select(x=>((global::RTC.Waypoint3D)((IStub)x).GetTarget())).ToArray());
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
 
        public ReactiveRTM.RTC.Waypoint3D GetCurrentWaypoint()
        {
            var ret = _target.GetCurrentWaypoint();
            return new ReactiveRTM.RTC.Waypoint3D(ret);
        }
    }
    public class PointCloudServicesStub : IStub, ReactiveRTM.RTC.PointCloudServices
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

 
        public ReactiveRTM.RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.Geometry3D(ret);
        }
    }
    public class Odometry2DStub : IStub, ReactiveRTM.RTC.Odometry2D
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

 
        public ReactiveRTM.RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.Geometry3D(ret);
        }
 
        public void SetOdometry(ReactiveRTM.RTC.Pose2D newOdometry)
        {
            _target.SetOdometry(((global::RTC.Pose2D)((IStub)newOdometry).GetTarget()));
            return;
        }
    }
    public class Odometry3DStub : IStub, ReactiveRTM.RTC.Odometry3D
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

 
        public ReactiveRTM.RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.Geometry3D(ret);
        }
 
        public void SetOdometry(ReactiveRTM.RTC.Pose3D newOdometry)
        {
            _target.SetOdometry(((global::RTC.Pose3D)((IStub)newOdometry).GetTarget()));
            return;
        }
    }
    public class VelocityControl2DStub : IStub, ReactiveRTM.RTC.VelocityControl2D
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

 
        public ReactiveRTM.RTC.Geometry2D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.Geometry2D(ret);
        }
    }
    public class VelocityControl3DStub : IStub, ReactiveRTM.RTC.VelocityControl3D
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

 
        public ReactiveRTM.RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.Geometry3D(ret);
        }
    }
    public class PoseControl2DStub : IStub, ReactiveRTM.RTC.PoseControl2D
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

 
        public ReactiveRTM.RTC.Geometry2D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.Geometry2D(ret);
        }
    }
    public class PoseControl3DStub : IStub, ReactiveRTM.RTC.PoseControl3D
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

 
        public ReactiveRTM.RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.Geometry3D(ret);
        }
    }
    public class CarlikeControlStub : IStub, ReactiveRTM.RTC.CarlikeControl
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

 
        public ReactiveRTM.RTC.Geometry2D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.Geometry2D(ret);
        }
    }
    public class HeadingControl2DStub : IStub, ReactiveRTM.RTC.HeadingControl2D
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

 
        public ReactiveRTM.RTC.Geometry2D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.Geometry2D(ret);
        }
    }
    public class HeadingControl3DStub : IStub, ReactiveRTM.RTC.HeadingControl3D
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

 
        public ReactiveRTM.RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.Geometry3D(ret);
        }
    }
    public class RangerStub : IStub, ReactiveRTM.RTC.Ranger
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

 
        public ReactiveRTM.RTC.RangerGeometry GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.RangerGeometry(ret);
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
 
        public ReactiveRTM.RTC.RangerConfig GetConfig()
        {
            var ret = _target.GetConfig();
            return new ReactiveRTM.RTC.RangerConfig(ret);
        }
 
        public void SetConfig(ReactiveRTM.RTC.RangerConfig newConfig)
        {
            _target.SetConfig(((global::RTC.RangerConfig)((IStub)newConfig).GetTarget()));
            return;
        }
    }
    public class RFIDStub : IStub, ReactiveRTM.RTC.RFID
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

 
        public ReactiveRTM.RTC.Geometry3D GetGeometry()
        {
            var ret = _target.GetGeometry();
            return new ReactiveRTM.RTC.Geometry3D(ret);
        }
 
        public void Write(System.String GUID,List<System.Byte> data)
        {
            _target.Write(GUID,data.Select(x=>x).ToArray());
            return;
        }
 
        public List<System.Byte> Read(System.String GUID)
        {
            var ret = _target.Read(GUID);
            return ret.Select(x => (System.Byte)x).ToList();
        }
    }
}
 
namespace ReactiveRTM.RTM
{
    public class ManagerStub : IStub, ReactiveRTM.RTM.Manager
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

 
        public ReactiveRTM.RTC.ReturnCode_t LoadModule(System.String pathname,System.String initfunc)
        {
            var ret = _target.load_module(pathname,initfunc);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t UnloadModule(System.String pathname)
        {
            var ret = _target.unload_module(pathname);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public List<ReactiveRTM.RTM.ModuleProfile> GetLoadableModules()
        {
            var ret = _target.get_loadable_modules();
            return ret.Select(x => (ReactiveRTM.RTM.ModuleProfile)new ReactiveRTM.RTM.ModuleProfile(x)).ToList();
        }
 
        public List<ReactiveRTM.RTM.ModuleProfile> GetLoadedModules()
        {
            var ret = _target.get_loaded_modules();
            return ret.Select(x => (ReactiveRTM.RTM.ModuleProfile)new ReactiveRTM.RTM.ModuleProfile(x)).ToList();
        }
 
        public List<ReactiveRTM.RTM.ModuleProfile> GetFactoryProfiles()
        {
            var ret = _target.get_factory_profiles();
            return ret.Select(x => (ReactiveRTM.RTM.ModuleProfile)new ReactiveRTM.RTM.ModuleProfile(x)).ToList();
        }
 
        public ReactiveRTM.RTC.RTObject CreateComponent(System.String moduleName)
        {
            var ret = _target.create_component(moduleName);
            return new ReactiveRTM.RTC.RTObjectStub(ret);
        }
 
        public ReactiveRTM.RTC.ReturnCode_t DeleteComponent(System.String instanceName)
        {
            var ret = _target.delete_component(instanceName);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public List<ReactiveRTM.RTC.RTObject> GetComponents()
        {
            var ret = _target.get_components();
            return ret.Select(x => (ReactiveRTM.RTC.RTObject)new ReactiveRTM.RTC.RTObjectStub(x)).ToList();
        }
 
        public List<ReactiveRTM.RTC.ComponentProfile> GetComponentProfiles()
        {
            var ret = _target.get_component_profiles();
            return ret.Select(x => (ReactiveRTM.RTC.ComponentProfile)new ReactiveRTM.RTC.ComponentProfile(x)).ToList();
        }
 
        public ReactiveRTM.RTM.ManagerProfile GetProfile()
        {
            var ret = _target.get_profile();
            return new ReactiveRTM.RTM.ManagerProfile(ret);
        }
 
        public Dictionary<string,object> GetConfiguration()
        {
            var ret = _target.get_configuration();
            return Converter.NVListToDictionary(ret);
        }
 
        public ReactiveRTM.RTC.ReturnCode_t SetConfiguration(System.String name,System.String value)
        {
            var ret = _target.set_configuration(name,value);
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public System.Boolean IsMaster()
        {
            var ret = _target.is_master();
            return ret;
        }
 
        public List<ReactiveRTM.RTM.Manager> GetMasterManagers()
        {
            var ret = _target.get_master_managers();
            return ret.Select(x => (ReactiveRTM.RTM.Manager)new ReactiveRTM.RTM.ManagerStub(x)).ToList();
        }
 
        public ReactiveRTM.RTC.ReturnCode_t AddMasterManager(ReactiveRTM.RTM.Manager mgr)
        {
            var ret = _target.add_master_manager(((global::RTM.Manager)((IStub)mgr).GetTarget()));
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t RemoveMasterManager(ReactiveRTM.RTM.Manager mgr)
        {
            var ret = _target.remove_master_manager(((global::RTM.Manager)((IStub)mgr).GetTarget()));
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public List<ReactiveRTM.RTM.Manager> GetSlaveManagers()
        {
            var ret = _target.get_slave_managers();
            return ret.Select(x => (ReactiveRTM.RTM.Manager)new ReactiveRTM.RTM.ManagerStub(x)).ToList();
        }
 
        public ReactiveRTM.RTC.ReturnCode_t AddSlaveManager(ReactiveRTM.RTM.Manager mgr)
        {
            var ret = _target.add_slave_manager(((global::RTM.Manager)((IStub)mgr).GetTarget()));
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t RemoveSlaveManager(ReactiveRTM.RTM.Manager mgr)
        {
            var ret = _target.remove_slave_manager(((global::RTM.Manager)((IStub)mgr).GetTarget()));
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Fork()
        {
            var ret = _target.fork();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Shutdown()
        {
            var ret = _target.shutdown();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public ReactiveRTM.RTC.ReturnCode_t Restart()
        {
            var ret = _target.restart();
            return (ReactiveRTM.RTC.ReturnCode_t)ret;
        }
 
        public System.Object GetService(System.String name)
        {
            var ret = _target.get_service(name);
            return (object)ret;
        }
    }
}
 
namespace ReactiveRTM.SDOPackage
{
    public class SDOStub : IStub, ReactiveRTM.SDOPackage.SDO
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
 
        public static explicit operator ReactiveRTM.SDOPackage.SDOSystemElementStub(ReactiveRTM.SDOPackage.SDOStub child)
        {
            return new ReactiveRTM.SDOPackage.SDOSystemElementStub((global::org.omg.SDOPackage.SDOSystemElement)((IStub)child).GetTarget());
        }
        public static implicit operator ReactiveRTM.SDOPackage.SDOStub(ReactiveRTM.SDOPackage.SDOSystemElementStub parent)
        {
            return new ReactiveRTM.SDOPackage.SDOStub((global::org.omg.SDOPackage.SDO)((IStub)parent).GetTarget());
        }

 
        public System.String GetSdoId()
        {
            var ret = _target.get_sdo_id();
            return ret;
        }
 
        public System.String GetSdoType()
        {
            var ret = _target.get_sdo_type();
            return ret;
        }
 
        public ReactiveRTM.SDOPackage.DeviceProfile GetDeviceProfile()
        {
            var ret = _target.get_device_profile();
            return new ReactiveRTM.SDOPackage.DeviceProfile(ret);
        }
 
        public List<ReactiveRTM.SDOPackage.ServiceProfile> GetServiceProfiles()
        {
            var ret = _target.get_service_profiles();
            return ret.Select(x => (ReactiveRTM.SDOPackage.ServiceProfile)new ReactiveRTM.SDOPackage.ServiceProfile(x)).ToList();
        }
 
        public ReactiveRTM.SDOPackage.ServiceProfile GetServiceProfile(System.String id)
        {
            var ret = _target.get_service_profile(id);
            return new ReactiveRTM.SDOPackage.ServiceProfile(ret);
        }
 
        public ReactiveRTM.SDOPackage.SDOService GetSdoService(System.String id)
        {
            var ret = _target.get_sdo_service(id);
            return new ReactiveRTM.SDOPackage.SDOServiceStub(ret);
        }
 
        public ReactiveRTM.SDOPackage.Configuration GetConfiguration()
        {
            var ret = _target.get_configuration();
            return new ReactiveRTM.SDOPackage.ConfigurationStub(ret);
        }
 
        public ReactiveRTM.SDOPackage.Monitoring GetMonitoring()
        {
            var ret = _target.get_monitoring();
            return new ReactiveRTM.SDOPackage.MonitoringStub(ret);
        }
 
        public List<ReactiveRTM.SDOPackage.Organization> GetOrganizations()
        {
            var ret = _target.get_organizations();
            return ret.Select(x => (ReactiveRTM.SDOPackage.Organization)new ReactiveRTM.SDOPackage.OrganizationStub(x)).ToList();
        }
 
        public Dictionary<string,object> GetStatusList()
        {
            var ret = _target.get_status_list();
            return Converter.NVListToDictionary(ret);
        }
 
        public System.Object GetStatus(System.String nme)
        {
            var ret = _target.get_status(nme);
            return ret;
        }
 
        public List<ReactiveRTM.SDOPackage.Organization> GetOwnedOrganizations()
        {
            var ret = _target.get_owned_organizations();
            return ret.Select(x => (ReactiveRTM.SDOPackage.Organization)new ReactiveRTM.SDOPackage.OrganizationStub(x)).ToList();
        }
    }
    public class SDOServiceStub : IStub, ReactiveRTM.SDOPackage.SDOService
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
    public class SDOSystemElementStub : IStub, ReactiveRTM.SDOPackage.SDOSystemElement
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

 
        public List<ReactiveRTM.SDOPackage.Organization> GetOwnedOrganizations()
        {
            var ret = _target.get_owned_organizations();
            return ret.Select(x => (ReactiveRTM.SDOPackage.Organization)new ReactiveRTM.SDOPackage.OrganizationStub(x)).ToList();
        }
    }
    public class ConfigurationStub : IStub, ReactiveRTM.SDOPackage.Configuration
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

 
        public System.Boolean SetDeviceProfile(ReactiveRTM.SDOPackage.DeviceProfile dProfile)
        {
            var ret = _target.set_device_profile(((global::org.omg.SDOPackage.DeviceProfile)((IStub)dProfile).GetTarget()));
            return ret;
        }
 
        public System.Boolean AddServiceProfile(ReactiveRTM.SDOPackage.ServiceProfile sProfile)
        {
            var ret = _target.add_service_profile(((global::org.omg.SDOPackage.ServiceProfile)((IStub)sProfile).GetTarget()));
            return ret;
        }
 
        public System.Boolean AddOrganization(ReactiveRTM.SDOPackage.Organization organizationObject)
        {
            var ret = _target.add_organization(((global::org.omg.SDOPackage.Organization)((IStub)organizationObject).GetTarget()));
            return ret;
        }
 
        public System.Boolean RemoveServiceProfile(System.String id)
        {
            var ret = _target.remove_service_profile(id);
            return ret;
        }
 
        public System.Boolean RemoveOrganization(System.String organizationId)
        {
            var ret = _target.remove_organization(organizationId);
            return ret;
        }
 
        public List<ReactiveRTM.SDOPackage.Parameter> GetConfigurationParameters()
        {
            var ret = _target.get_configuration_parameters();
            return ret.Select(x => (ReactiveRTM.SDOPackage.Parameter)new ReactiveRTM.SDOPackage.Parameter(x)).ToList();
        }
 
        public Dictionary<string,object> GetConfigurationParameterValues()
        {
            var ret = _target.get_configuration_parameter_values();
            return Converter.NVListToDictionary(ret);
        }
 
        public System.Object GetConfigurationParameterValue(System.String name)
        {
            var ret = _target.get_configuration_parameter_value(name);
            return ret;
        }
 
        public System.Boolean SetConfigurationParameter(System.String name,System.Object value)
        {
            var ret = _target.set_configuration_parameter(name,value);
            return ret;
        }
 
        public List<ReactiveRTM.SDOPackage.ConfigurationSet> GetConfigurationSets()
        {
            var ret = _target.get_configuration_sets();
            return ret.Select(x => (ReactiveRTM.SDOPackage.ConfigurationSet)new ReactiveRTM.SDOPackage.ConfigurationSet(x)).ToList();
        }
 
        public ReactiveRTM.SDOPackage.ConfigurationSet GetConfigurationSet(System.String configId)
        {
            var ret = _target.get_configuration_set(configId);
            return new ReactiveRTM.SDOPackage.ConfigurationSet(ret);
        }
 
        public System.Boolean SetConfigurationSetValues(ReactiveRTM.SDOPackage.ConfigurationSet configurationSet)
        {
            var ret = _target.set_configuration_set_values(((global::org.omg.SDOPackage.ConfigurationSet)((IStub)configurationSet).GetTarget()));
            return ret;
        }
 
        public ReactiveRTM.SDOPackage.ConfigurationSet GetActiveConfigurationSet()
        {
            var ret = _target.get_active_configuration_set();
            return new ReactiveRTM.SDOPackage.ConfigurationSet(ret);
        }
 
        public System.Boolean AddConfigurationSet(ReactiveRTM.SDOPackage.ConfigurationSet configurationSet)
        {
            var ret = _target.add_configuration_set(((global::org.omg.SDOPackage.ConfigurationSet)((IStub)configurationSet).GetTarget()));
            return ret;
        }
 
        public System.Boolean RemoveConfigurationSet(System.String configId)
        {
            var ret = _target.remove_configuration_set(configId);
            return ret;
        }
 
        public System.Boolean ActivateConfigurationSet(System.String configId)
        {
            var ret = _target.activate_configuration_set(configId);
            return ret;
        }
    }
    public class MonitoringStub : IStub, ReactiveRTM.SDOPackage.Monitoring
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
    public class OrganizationStub : IStub, ReactiveRTM.SDOPackage.Organization
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

 
        public System.String GetOrganizationId()
        {
            var ret = _target.get_organization_id();
            return ret;
        }
 
        public ReactiveRTM.SDOPackage.OrganizationProperty GetOrganizationProperty()
        {
            var ret = _target.get_organization_property();
            return new ReactiveRTM.SDOPackage.OrganizationProperty(ret);
        }
 
        public System.Object GetOrganizationPropertyValue(System.String name)
        {
            var ret = _target.get_organization_property_value(name);
            return ret;
        }
 
        public System.Boolean AddOrganizationProperty(ReactiveRTM.SDOPackage.OrganizationProperty organizationProperty)
        {
            var ret = _target.add_organization_property(((global::org.omg.SDOPackage.OrganizationProperty)((IStub)organizationProperty).GetTarget()));
            return ret;
        }
 
        public System.Boolean SetOrganizationPropertyValue(System.String name,System.Object value)
        {
            var ret = _target.set_organization_property_value(name,value);
            return ret;
        }
 
        public System.Boolean RemoveOrganizationProperty(System.String name)
        {
            var ret = _target.remove_organization_property(name);
            return ret;
        }
 
        public ReactiveRTM.SDOPackage.SDOSystemElement GetOwner()
        {
            var ret = _target.get_owner();
            return new ReactiveRTM.SDOPackage.SDOSystemElementStub(ret);
        }
 
        public System.Boolean SetOwner(ReactiveRTM.SDOPackage.SDOSystemElement sdo)
        {
            var ret = _target.set_owner(((global::org.omg.SDOPackage.SDOSystemElement)((IStub)sdo).GetTarget()));
            return ret;
        }
 
        public List<ReactiveRTM.SDOPackage.SDO> GetMembers()
        {
            var ret = _target.get_members();
            return ret.Select(x => (ReactiveRTM.SDOPackage.SDO)new ReactiveRTM.SDOPackage.SDOStub(x)).ToList();
        }
 
        public System.Boolean SetMembers(List<ReactiveRTM.SDOPackage.SDO> sdos)
        {
            var ret = _target.set_members(sdos.Select(x=>((global::org.omg.SDOPackage.SDO)((IStub)x).GetTarget())).ToArray());
            return ret;
        }
 
        public System.Boolean AddMembers(List<ReactiveRTM.SDOPackage.SDO> sdoList)
        {
            var ret = _target.add_members(sdoList.Select(x=>((global::org.omg.SDOPackage.SDO)((IStub)x).GetTarget())).ToArray());
            return ret;
        }
 
        public System.Boolean RemoveMember(System.String id)
        {
            var ret = _target.remove_member(id);
            return ret;
        }
 
        public ReactiveRTM.SDOPackage.DependencyType GetDependency()
        {
            var ret = _target.get_dependency();
            return (ReactiveRTM.SDOPackage.DependencyType)ret;
        }
 
        public System.Boolean SetDependency(ReactiveRTM.SDOPackage.DependencyType dependency)
        {
            var ret = _target.set_dependency((global::org.omg.SDOPackage.DependencyType)dependency);
            return ret;
        }
    }
}

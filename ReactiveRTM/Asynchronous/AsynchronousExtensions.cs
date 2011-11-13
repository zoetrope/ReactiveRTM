using System.Linq;
using System.Collections.Generic;
using System;
using System.Reactive.Linq;
using System.Reactive.Concurrency;
using ReactiveRTM.Corba;

 
namespace omg.org.RTC
{
     
    public static class ExecutionContextAsyncExtensions
    {
         
        public static IObservable<System.Boolean> is_runningAsync(this ExecutionContext target )
        {
            return Observable.Start(()=>target.is_running());
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> startAsync(this ExecutionContext target )
        {
            return Observable.Start(()=>target.start());
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> _stopAsync(this ExecutionContext target )
        {
            return Observable.Start(()=>target._stop());
        }
         
        public static IObservable<System.Double> get_rateAsync(this ExecutionContext target )
        {
            return Observable.Start(()=>target.get_rate());
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> set_rateAsync(this ExecutionContext target ,System.Double rate)
        {
            return Observable.Start(()=>target.set_rate(rate));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> add_componentAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp)
        {
            return Observable.Start(()=>target.add_component(comp));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> remove_componentAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp)
        {
            return Observable.Start(()=>target.remove_component(comp));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> activate_componentAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp)
        {
            return Observable.Start(()=>target.activate_component(comp));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> deactivate_componentAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp)
        {
            return Observable.Start(()=>target.deactivate_component(comp));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> reset_componentAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp)
        {
            return Observable.Start(()=>target.reset_component(comp));
        }
         
        public static IObservable<omg.org.RTC.LifeCycleState> get_component_stateAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp)
        {
            return Observable.Start(()=>target.get_component_state(comp));
        }
         
        public static IObservable<omg.org.RTC.ExecutionKind> get_kindAsync(this ExecutionContext target )
        {
            return Observable.Start(()=>target.get_kind());
        }
            }
     
    public static class ComponentActionAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_initializeAsync(this ComponentAction target )
        {
            return Observable.Start(()=>target.on_initialize());
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_finalizeAsync(this ComponentAction target )
        {
            return Observable.Start(()=>target.on_finalize());
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_startupAsync(this ComponentAction target ,System.Int32 exec_handle)
        {
            return Observable.Start(()=>target.on_startup(exec_handle));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_shutdownAsync(this ComponentAction target ,System.Int32 exec_handle)
        {
            return Observable.Start(()=>target.on_shutdown(exec_handle));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_activatedAsync(this ComponentAction target ,System.Int32 exec_handle)
        {
            return Observable.Start(()=>target.on_activated(exec_handle));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_deactivatedAsync(this ComponentAction target ,System.Int32 exec_handle)
        {
            return Observable.Start(()=>target.on_deactivated(exec_handle));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_abortingAsync(this ComponentAction target ,System.Int32 exec_handle)
        {
            return Observable.Start(()=>target.on_aborting(exec_handle));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_errorAsync(this ComponentAction target ,System.Int32 exec_handle)
        {
            return Observable.Start(()=>target.on_error(exec_handle));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_resetAsync(this ComponentAction target ,System.Int32 exec_handle)
        {
            return Observable.Start(()=>target.on_reset(exec_handle));
        }
            }
     
    public static class LightweightRTObjectAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ReturnCode_t> initializeAsync(this LightweightRTObject target )
        {
            return Observable.Start(()=>target.initialize());
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> _finalizeAsync(this LightweightRTObject target )
        {
            return Observable.Start(()=>target._finalize());
        }
         
        public static IObservable<System.Boolean> is_aliveAsync(this LightweightRTObject target ,omg.org.RTC.ExecutionContext exec_context)
        {
            return Observable.Start(()=>target.is_alive(exec_context));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> _exitAsync(this LightweightRTObject target )
        {
            return Observable.Start(()=>target._exit());
        }
         
        public static IObservable<System.Int32> attach_contextAsync(this LightweightRTObject target ,omg.org.RTC.ExecutionContext exec_context)
        {
            return Observable.Start(()=>target.attach_context(exec_context));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> detach_contextAsync(this LightweightRTObject target ,System.Int32 exec_handle)
        {
            return Observable.Start(()=>target.detach_context(exec_handle));
        }
         
        public static IObservable<omg.org.RTC.ExecutionContext> get_contextAsync(this LightweightRTObject target ,System.Int32 exec_handle)
        {
            return Observable.Start(()=>target.get_context(exec_handle));
        }
         
        public static IObservable<omg.org.RTC.ExecutionContext[]> get_owned_contextsAsync(this LightweightRTObject target )
        {
            return Observable.Start(()=>target.get_owned_contexts());
        }
         
        public static IObservable<omg.org.RTC.ExecutionContext[]> get_participating_contextsAsync(this LightweightRTObject target )
        {
            return Observable.Start(()=>target.get_participating_contexts());
        }
         
        public static IObservable<System.Int32> get_context_handleAsync(this LightweightRTObject target ,omg.org.RTC.ExecutionContext cxt)
        {
            return Observable.Start(()=>target.get_context_handle(cxt));
        }
            }
     
    public static class DataFlowComponentActionAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_executeAsync(this DataFlowComponentAction target ,System.Int32 exec_handle)
        {
            return Observable.Start(()=>target.on_execute(exec_handle));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_state_updateAsync(this DataFlowComponentAction target ,System.Int32 exec_handle)
        {
            return Observable.Start(()=>target.on_state_update(exec_handle));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_rate_changedAsync(this DataFlowComponentAction target ,System.Int32 exec_handle)
        {
            return Observable.Start(()=>target.on_rate_changed(exec_handle));
        }
            }
     
    public static class FsmParticipantActionAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_actionAsync(this FsmParticipantAction target ,System.Int32 exec_handle)
        {
            return Observable.Start(()=>target.on_action(exec_handle));
        }
            }
     
    public static class ModeCapableAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.Mode> get_default_modeAsync(this ModeCapable target )
        {
            return Observable.Start(()=>target.get_default_mode());
        }
         
        public static IObservable<omg.org.RTC.Mode> get_current_modeAsync(this ModeCapable target )
        {
            return Observable.Start(()=>target.get_current_mode());
        }
         
        public static IObservable<omg.org.RTC.Mode> get_current_mode_in_contextAsync(this ModeCapable target ,omg.org.RTC.ExecutionContext exec_context)
        {
            return Observable.Start(()=>target.get_current_mode_in_context(exec_context));
        }
         
        public static IObservable<omg.org.RTC.Mode> get_pending_modeAsync(this ModeCapable target )
        {
            return Observable.Start(()=>target.get_pending_mode());
        }
         
        public static IObservable<omg.org.RTC.Mode> get_pending_mode_in_contextAsync(this ModeCapable target ,omg.org.RTC.ExecutionContext exec_context)
        {
            return Observable.Start(()=>target.get_pending_mode_in_context(exec_context));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> set_modeAsync(this ModeCapable target ,omg.org.RTC.Mode new_mode,System.Boolean immediate)
        {
            return Observable.Start(()=>target.set_mode(new_mode,immediate));
        }
            }
     
    public static class MultiModeComponentActionAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_mode_changedAsync(this MultiModeComponentAction target ,System.Int32 exec_handle)
        {
            return Observable.Start(()=>target.on_mode_changed(exec_handle));
        }
            }
     
    public static class RTObjectAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ComponentProfile> get_component_profileAsync(this RTObject target )
        {
            return Observable.Start(()=>target.get_component_profile());
        }
         
        public static IObservable<omg.org.RTC.PortService[]> get_portsAsync(this RTObject target )
        {
            return Observable.Start(()=>target.get_ports());
        }
            }
     
    public static class PortServiceAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.PortProfile> get_port_profileAsync(this PortService target )
        {
            return Observable.Start(()=>target.get_port_profile());
        }
         
        public static IObservable<omg.org.RTC.ConnectorProfile[]> get_connector_profilesAsync(this PortService target )
        {
            return Observable.Start(()=>target.get_connector_profiles());
        }
         
        public static IObservable<omg.org.RTC.ConnectorProfile> get_connector_profileAsync(this PortService target ,System.String connector_id)
        {
            return Observable.Start(()=>target.get_connector_profile(connector_id));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> connectAsync(this PortService target ,omg.org.RTC.ConnectorProfile connector_profile)
        {
            return Observable.Start(()=>target.connect(ref connector_profile));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> disconnectAsync(this PortService target ,System.String connector_id)
        {
            return Observable.Start(()=>target.disconnect(connector_id));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> disconnect_allAsync(this PortService target )
        {
            return Observable.Start(()=>target.disconnect_all());
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> notify_connectAsync(this PortService target ,omg.org.RTC.ConnectorProfile connector_profile)
        {
            return Observable.Start(()=>target.notify_connect(ref connector_profile));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> notify_disconnectAsync(this PortService target ,System.String connector_id)
        {
            return Observable.Start(()=>target.notify_disconnect(connector_id));
        }
            }
     
    public static class FsmObjectAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ReturnCode_t> send_stimulusAsync(this FsmObject target ,System.String message,System.Int32 exec_handle)
        {
            return Observable.Start(()=>target.send_stimulus(message,exec_handle));
        }
            }
     
    public static class FsmServiceAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.FsmProfile> get_fsm_profileAsync(this FsmService target )
        {
            return Observable.Start(()=>target.get_fsm_profile());
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> set_fsm_profileAsync(this FsmService target ,omg.org.RTC.FsmProfile fsm_profile)
        {
            return Observable.Start(()=>target.set_fsm_profile(fsm_profile));
        }
            }
     
    public static class ExecutionContextServiceAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ExecutionContextProfile> get_profileAsync(this ExecutionContextService target )
        {
            return Observable.Start(()=>target.get_profile());
        }
            }
    }
 
namespace OpenRTM
{
     
    public static class ComponentObserverAsyncExtensions
    {
         
        public static IObservable<System.Reactive.Unit> update_statusAsync(this ComponentObserver target ,OpenRTM.StatusKind status_kind,System.String hint)
        {
            return Observable.Start(()=>target.update_status(status_kind,hint));
        }
            }
     
    public static class InPortCdrAsyncExtensions
    {
         
        public static IObservable<OpenRTM.PortStatus> putAsync(this InPortCdr target ,System.Byte[] data)
        {
            return Observable.Start(()=>target.put(data));
        }
            }
     
    public static class OutPortCdrAsyncExtensions
    {
         
        public static IObservable<OpenRTM.PortStatus> _getAsync(this OutPortCdr target ,System.Byte[] data)
        {
            return Observable.Start(()=>target._get(out data));
        }
            }
     
    public static class LoggerAsyncExtensions
    {
         
        public static IObservable<System.Reactive.Unit> publishAsync(this Logger target ,OpenRTM.LogRecord record)
        {
            return Observable.Start(()=>target.publish(record));
        }
         
        public static IObservable<System.Reactive.Unit> closeAsync(this Logger target )
        {
            return Observable.Start(()=>target.close());
        }
            }
    }
 
namespace openrtm.aist.go.jp.OpenRTM
{
     
    public static class ExtTrigExecutionContextServiceAsyncExtensions
    {
         
        public static IObservable<System.Reactive.Unit> tickAsync(this ExtTrigExecutionContextService target )
        {
            return Observable.Start(()=>target.tick());
        }
            }
    }
 
namespace org.omg.SDOPackage
{
     
    public static class SDOAsyncExtensions
    {
         
        public static IObservable<System.String> get_sdo_idAsync(this SDO target )
        {
            return Observable.Start(()=>target.get_sdo_id());
        }
         
        public static IObservable<System.String> get_sdo_typeAsync(this SDO target )
        {
            return Observable.Start(()=>target.get_sdo_type());
        }
         
        public static IObservable<org.omg.SDOPackage.DeviceProfile> get_device_profileAsync(this SDO target )
        {
            return Observable.Start(()=>target.get_device_profile());
        }
         
        public static IObservable<org.omg.SDOPackage.ServiceProfile[]> get_service_profilesAsync(this SDO target )
        {
            return Observable.Start(()=>target.get_service_profiles());
        }
         
        public static IObservable<org.omg.SDOPackage.ServiceProfile> get_service_profileAsync(this SDO target ,System.String id)
        {
            return Observable.Start(()=>target.get_service_profile(id));
        }
         
        public static IObservable<org.omg.SDOPackage.SDOService> get_sdo_serviceAsync(this SDO target ,System.String id)
        {
            return Observable.Start(()=>target.get_sdo_service(id));
        }
         
        public static IObservable<org.omg.SDOPackage.Configuration> get_configurationAsync(this SDO target )
        {
            return Observable.Start(()=>target.get_configuration());
        }
         
        public static IObservable<org.omg.SDOPackage.Monitoring> get_monitoringAsync(this SDO target )
        {
            return Observable.Start(()=>target.get_monitoring());
        }
         
        public static IObservable<org.omg.SDOPackage.Organization[]> get_organizationsAsync(this SDO target )
        {
            return Observable.Start(()=>target.get_organizations());
        }
         
        public static IObservable<org.omg.SDOPackage.NameValue[]> get_status_listAsync(this SDO target )
        {
            return Observable.Start(()=>target.get_status_list());
        }
         
        public static IObservable<System.Object> get_statusAsync(this SDO target ,System.String nme)
        {
            return Observable.Start(()=>target.get_status(nme));
        }
            }
     
    public static class SDOSystemElementAsyncExtensions
    {
         
        public static IObservable<org.omg.SDOPackage.Organization[]> get_owned_organizationsAsync(this SDOSystemElement target )
        {
            return Observable.Start(()=>target.get_owned_organizations());
        }
            }
     
    public static class ConfigurationAsyncExtensions
    {
         
        public static IObservable<System.Boolean> set_device_profileAsync(this Configuration target ,org.omg.SDOPackage.DeviceProfile dProfile)
        {
            return Observable.Start(()=>target.set_device_profile(dProfile));
        }
         
        public static IObservable<System.Boolean> add_service_profileAsync(this Configuration target ,org.omg.SDOPackage.ServiceProfile sProfile)
        {
            return Observable.Start(()=>target.add_service_profile(sProfile));
        }
         
        public static IObservable<System.Boolean> add_organizationAsync(this Configuration target ,org.omg.SDOPackage.Organization organization_object)
        {
            return Observable.Start(()=>target.add_organization(organization_object));
        }
         
        public static IObservable<System.Boolean> remove_service_profileAsync(this Configuration target ,System.String id)
        {
            return Observable.Start(()=>target.remove_service_profile(id));
        }
         
        public static IObservable<System.Boolean> remove_organizationAsync(this Configuration target ,System.String organization_id)
        {
            return Observable.Start(()=>target.remove_organization(organization_id));
        }
         
        public static IObservable<org.omg.SDOPackage.Parameter[]> get_configuration_parametersAsync(this Configuration target )
        {
            return Observable.Start(()=>target.get_configuration_parameters());
        }
         
        public static IObservable<org.omg.SDOPackage.NameValue[]> get_configuration_parameter_valuesAsync(this Configuration target )
        {
            return Observable.Start(()=>target.get_configuration_parameter_values());
        }
         
        public static IObservable<System.Object> get_configuration_parameter_valueAsync(this Configuration target ,System.String name)
        {
            return Observable.Start(()=>target.get_configuration_parameter_value(name));
        }
         
        public static IObservable<System.Boolean> set_configuration_parameterAsync(this Configuration target ,System.String name,System.Object value)
        {
            return Observable.Start(()=>target.set_configuration_parameter(name,value));
        }
         
        public static IObservable<org.omg.SDOPackage.ConfigurationSet[]> get_configuration_setsAsync(this Configuration target )
        {
            return Observable.Start(()=>target.get_configuration_sets());
        }
         
        public static IObservable<org.omg.SDOPackage.ConfigurationSet> get_configuration_setAsync(this Configuration target ,System.String config_id)
        {
            return Observable.Start(()=>target.get_configuration_set(config_id));
        }
         
        public static IObservable<System.Boolean> set_configuration_set_valuesAsync(this Configuration target ,org.omg.SDOPackage.ConfigurationSet configuration_set)
        {
            return Observable.Start(()=>target.set_configuration_set_values(configuration_set));
        }
         
        public static IObservable<org.omg.SDOPackage.ConfigurationSet> get_active_configuration_setAsync(this Configuration target )
        {
            return Observable.Start(()=>target.get_active_configuration_set());
        }
         
        public static IObservable<System.Boolean> add_configuration_setAsync(this Configuration target ,org.omg.SDOPackage.ConfigurationSet configuration_set)
        {
            return Observable.Start(()=>target.add_configuration_set(configuration_set));
        }
         
        public static IObservable<System.Boolean> remove_configuration_setAsync(this Configuration target ,System.String config_id)
        {
            return Observable.Start(()=>target.remove_configuration_set(config_id));
        }
         
        public static IObservable<System.Boolean> activate_configuration_setAsync(this Configuration target ,System.String config_id)
        {
            return Observable.Start(()=>target.activate_configuration_set(config_id));
        }
            }
     
    public static class OrganizationAsyncExtensions
    {
         
        public static IObservable<System.String> get_organization_idAsync(this Organization target )
        {
            return Observable.Start(()=>target.get_organization_id());
        }
         
        public static IObservable<org.omg.SDOPackage.OrganizationProperty> get_organization_propertyAsync(this Organization target )
        {
            return Observable.Start(()=>target.get_organization_property());
        }
         
        public static IObservable<System.Object> get_organization_property_valueAsync(this Organization target ,System.String name)
        {
            return Observable.Start(()=>target.get_organization_property_value(name));
        }
         
        public static IObservable<System.Boolean> add_organization_propertyAsync(this Organization target ,org.omg.SDOPackage.OrganizationProperty organization_property)
        {
            return Observable.Start(()=>target.add_organization_property(organization_property));
        }
         
        public static IObservable<System.Boolean> set_organization_property_valueAsync(this Organization target ,System.String name,System.Object value)
        {
            return Observable.Start(()=>target.set_organization_property_value(name,value));
        }
         
        public static IObservable<System.Boolean> remove_organization_propertyAsync(this Organization target ,System.String name)
        {
            return Observable.Start(()=>target.remove_organization_property(name));
        }
         
        public static IObservable<org.omg.SDOPackage.SDOSystemElement> get_ownerAsync(this Organization target )
        {
            return Observable.Start(()=>target.get_owner());
        }
         
        public static IObservable<System.Boolean> set_ownerAsync(this Organization target ,org.omg.SDOPackage.SDOSystemElement sdo)
        {
            return Observable.Start(()=>target.set_owner(sdo));
        }
         
        public static IObservable<org.omg.SDOPackage.SDO[]> get_membersAsync(this Organization target )
        {
            return Observable.Start(()=>target.get_members());
        }
         
        public static IObservable<System.Boolean> set_membersAsync(this Organization target ,org.omg.SDOPackage.SDO[] sdos)
        {
            return Observable.Start(()=>target.set_members(sdos));
        }
         
        public static IObservable<System.Boolean> add_membersAsync(this Organization target ,org.omg.SDOPackage.SDO[] sdo_list)
        {
            return Observable.Start(()=>target.add_members(sdo_list));
        }
         
        public static IObservable<System.Boolean> remove_memberAsync(this Organization target ,System.String id)
        {
            return Observable.Start(()=>target.remove_member(id));
        }
         
        public static IObservable<org.omg.SDOPackage.DependencyType> get_dependencyAsync(this Organization target )
        {
            return Observable.Start(()=>target.get_dependency());
        }
         
        public static IObservable<System.Boolean> set_dependencyAsync(this Organization target ,org.omg.SDOPackage.DependencyType dependency)
        {
            return Observable.Start(()=>target.set_dependency(dependency));
        }
            }
    }
 
namespace RTC
{
     
    public static class ActArrayAsyncExtensions
    {
         
        public static IObservable<RTC.ActArrayGeometry> GetGeometryAsync(this ActArray target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
         
        public static IObservable<System.Reactive.Unit> GoHomeAsync(this ActArray target ,System.Int16 index)
        {
            return Observable.Start(()=>target.GoHome(index));
        }
         
        public static IObservable<System.Reactive.Unit> PowerAsync(this ActArray target ,System.Boolean enable)
        {
            return Observable.Start(()=>target.Power(enable));
        }
         
        public static IObservable<System.Reactive.Unit> BrakesAsync(this ActArray target ,System.Boolean engage)
        {
            return Observable.Start(()=>target.Brakes(engage));
        }
         
        public static IObservable<System.Reactive.Unit> ConfigSpeedAsync(this ActArray target ,System.Int16 index,System.Double speed)
        {
            return Observable.Start(()=>target.ConfigSpeed(index,speed));
        }
         
        public static IObservable<System.Reactive.Unit> ConfigAccelAsync(this ActArray target ,System.Int16 index,System.Double accel)
        {
            return Observable.Start(()=>target.ConfigAccel(index,accel));
        }
            }
     
    public static class AIOAsyncExtensions
    {
         
        public static IObservable<System.Int16> NumChannelsAsync(this AIO target )
        {
            return Observable.Start(()=>target.NumChannels());
        }
         
        public static IObservable<System.Reactive.Unit> SetReferenceLevelAsync(this AIO target ,System.Int16 index,System.Double level)
        {
            return Observable.Start(()=>target.SetReferenceLevel(index,level));
        }
         
        public static IObservable<System.Double> GetResolutionAsync(this AIO target ,System.Int16 index)
        {
            return Observable.Start(()=>target.GetResolution(index));
        }
            }
     
    public static class BumperAsyncExtensions
    {
         
        public static IObservable<RTC.BumperGeometry> GetGeometryAsync(this Bumper target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
            }
     
    public static class CameraAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this Camera target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
         
        public static IObservable<RTC.CameraInfo> GetCameraInfoAsync(this Camera target )
        {
            return Observable.Start(()=>target.GetCameraInfo());
        }
            }
     
    public static class DIOAsyncExtensions
    {
         
        public static IObservable<System.Int16> NumBitsAsync(this DIO target )
        {
            return Observable.Start(()=>target.NumBits());
        }
         
        public static IObservable<System.Boolean> GetBitAsync(this DIO target ,System.Int16 index)
        {
            return Observable.Start(()=>target.GetBit(index));
        }
         
        public static IObservable<System.Reactive.Unit> SetBitAsync(this DIO target ,System.Int16 index,System.Boolean newValue)
        {
            return Observable.Start(()=>target.SetBit(index,newValue));
        }
            }
     
    public static class FiducialAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this Fiducial target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
         
        public static IObservable<RTC.FiducialFOV> GetFOVAsync(this Fiducial target )
        {
            return Observable.Start(()=>target.GetFOV());
        }
         
        public static IObservable<System.Reactive.Unit> SetFOVAsync(this Fiducial target ,RTC.FiducialFOV newFOV)
        {
            return Observable.Start(()=>target.SetFOV(newFOV));
        }
            }
     
    public static class GPSAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this GPS target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
            }
     
    public static class GripperAsyncExtensions
    {
         
        public static IObservable<RTC.GripperGeometry> GetGeometryAsync(this Gripper target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
         
        public static IObservable<System.Reactive.Unit> OpenAsync(this Gripper target )
        {
            return Observable.Start(()=>target.Open());
        }
         
        public static IObservable<System.Reactive.Unit> CloseAsync(this Gripper target )
        {
            return Observable.Start(()=>target.Close());
        }
            }
     
    public static class IMUAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this IMU target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
            }
     
    public static class INSAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this INS target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
            }
     
    public static class LimbAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this Limb target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
         
        public static IObservable<System.Reactive.Unit> PowerAsync(this Limb target ,System.Boolean enable)
        {
            return Observable.Start(()=>target.Power(enable));
        }
         
        public static IObservable<System.Reactive.Unit> BrakesAsync(this Limb target ,System.Boolean engage)
        {
            return Observable.Start(()=>target.Brakes(engage));
        }
         
        public static IObservable<System.Reactive.Unit> SetSpeedAsync(this Limb target ,System.Double speed)
        {
            return Observable.Start(()=>target.SetSpeed(speed));
        }
            }
     
    public static class OGMapAsyncExtensions
    {
         
        public static IObservable<RTC.OGMapConfig> GetConfigAsync(this OGMap target )
        {
            return Observable.Start(()=>target.GetConfig());
        }
         
        public static IObservable<RTC.OGMapTile> GetTileAsync(this OGMap target ,RTC.OGMapTile tile)
        {
            return Observable.Start(()=>target.GetTile(tile));
        }
            }
     
    public static class MulticameraAsyncExtensions
    {
         
        public static IObservable<RTC.MulticameraGeometry> GetGeometryAsync(this Multicamera target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
         
        public static IObservable<RTC.CameraInfo[]> GetCameraInfosAsync(this Multicamera target )
        {
            return Observable.Start(()=>target.GetCameraInfos());
        }
            }
     
    public static class PanTiltAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this PanTilt target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
            }
     
    public static class PathPlanner2DAsyncExtensions
    {
         
        public static IObservable<System.Reactive.Unit> SetTaskAsync(this PathPlanner2D target ,RTC.Waypoint2D[] coarsePath)
        {
            return Observable.Start(()=>target.SetTask(coarsePath));
        }
            }
     
    public static class PathPlanner3DAsyncExtensions
    {
         
        public static IObservable<System.Reactive.Unit> SetTaskAsync(this PathPlanner3D target ,RTC.Waypoint3D[] coarsePath)
        {
            return Observable.Start(()=>target.SetTask(coarsePath));
        }
            }
     
    public static class PathFollower2DAsyncExtensions
    {
         
        public static IObservable<System.Reactive.Unit> SetPathAsync(this PathFollower2D target ,RTC.Waypoint2D[] path)
        {
            return Observable.Start(()=>target.SetPath(path));
        }
         
        public static IObservable<System.Reactive.Unit> EnableAsync(this PathFollower2D target ,System.Boolean enable)
        {
            return Observable.Start(()=>target.Enable(enable));
        }
         
        public static IObservable<System.Int16> GetCurrentWaypointIndexAsync(this PathFollower2D target )
        {
            return Observable.Start(()=>target.GetCurrentWaypointIndex());
        }
         
        public static IObservable<RTC.Waypoint2D> GetCurrentWaypointAsync(this PathFollower2D target )
        {
            return Observable.Start(()=>target.GetCurrentWaypoint());
        }
            }
     
    public static class PathFollower3DAsyncExtensions
    {
         
        public static IObservable<System.Reactive.Unit> SetPathAsync(this PathFollower3D target ,RTC.Waypoint3D[] path)
        {
            return Observable.Start(()=>target.SetPath(path));
        }
         
        public static IObservable<System.Reactive.Unit> EnableAsync(this PathFollower3D target ,System.Boolean enable)
        {
            return Observable.Start(()=>target.Enable(enable));
        }
         
        public static IObservable<System.Int16> GetCurrentWaypointIndexAsync(this PathFollower3D target )
        {
            return Observable.Start(()=>target.GetCurrentWaypointIndex());
        }
         
        public static IObservable<RTC.Waypoint3D> GetCurrentWaypointAsync(this PathFollower3D target )
        {
            return Observable.Start(()=>target.GetCurrentWaypoint());
        }
            }
     
    public static class PointCloudServicesAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this PointCloudServices target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
            }
     
    public static class Odometry2DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this Odometry2D target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
         
        public static IObservable<System.Reactive.Unit> SetOdometryAsync(this Odometry2D target ,RTC.Pose2D newOdometry)
        {
            return Observable.Start(()=>target.SetOdometry(newOdometry));
        }
            }
     
    public static class Odometry3DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this Odometry3D target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
         
        public static IObservable<System.Reactive.Unit> SetOdometryAsync(this Odometry3D target ,RTC.Pose3D newOdometry)
        {
            return Observable.Start(()=>target.SetOdometry(newOdometry));
        }
            }
     
    public static class VelocityControl2DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry2D> GetGeometryAsync(this VelocityControl2D target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
            }
     
    public static class VelocityControl3DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this VelocityControl3D target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
            }
     
    public static class PoseControl2DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry2D> GetGeometryAsync(this PoseControl2D target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
            }
     
    public static class PoseControl3DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this PoseControl3D target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
            }
     
    public static class CarlikeControlAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry2D> GetGeometryAsync(this CarlikeControl target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
            }
     
    public static class HeadingControl2DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry2D> GetGeometryAsync(this HeadingControl2D target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
            }
     
    public static class HeadingControl3DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this HeadingControl3D target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
            }
     
    public static class RangerAsyncExtensions
    {
         
        public static IObservable<RTC.RangerGeometry> GetGeometryAsync(this Ranger target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
         
        public static IObservable<System.Reactive.Unit> PowerAsync(this Ranger target ,System.Boolean enable)
        {
            return Observable.Start(()=>target.Power(enable));
        }
         
        public static IObservable<System.Reactive.Unit> EnableIntensitiesAsync(this Ranger target ,System.Boolean enable)
        {
            return Observable.Start(()=>target.EnableIntensities(enable));
        }
         
        public static IObservable<RTC.RangerConfig> GetConfigAsync(this Ranger target )
        {
            return Observable.Start(()=>target.GetConfig());
        }
         
        public static IObservable<System.Reactive.Unit> SetConfigAsync(this Ranger target ,RTC.RangerConfig newConfig)
        {
            return Observable.Start(()=>target.SetConfig(newConfig));
        }
            }
     
    public static class RFIDAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this RFID target )
        {
            return Observable.Start(()=>target.GetGeometry());
        }
         
        public static IObservable<System.Reactive.Unit> WriteAsync(this RFID target ,System.String GUID,System.Byte[] data)
        {
            return Observable.Start(()=>target.Write(GUID,data));
        }
         
        public static IObservable<System.Byte[]> ReadAsync(this RFID target ,System.String GUID)
        {
            return Observable.Start(()=>target.Read(GUID));
        }
            }
    }
 
namespace RTM
{
     
    public static class ManagerAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ReturnCode_t> load_moduleAsync(this Manager target ,System.String pathname,System.String initfunc)
        {
            return Observable.Start(()=>target.load_module(pathname,initfunc));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> unload_moduleAsync(this Manager target ,System.String pathname)
        {
            return Observable.Start(()=>target.unload_module(pathname));
        }
         
        public static IObservable<RTM.ModuleProfile[]> get_loadable_modulesAsync(this Manager target )
        {
            return Observable.Start(()=>target.get_loadable_modules());
        }
         
        public static IObservable<RTM.ModuleProfile[]> get_loaded_modulesAsync(this Manager target )
        {
            return Observable.Start(()=>target.get_loaded_modules());
        }
         
        public static IObservable<RTM.ModuleProfile[]> get_factory_profilesAsync(this Manager target )
        {
            return Observable.Start(()=>target.get_factory_profiles());
        }
         
        public static IObservable<omg.org.RTC.RTObject> create_componentAsync(this Manager target ,System.String module_name)
        {
            return Observable.Start(()=>target.create_component(module_name));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> delete_componentAsync(this Manager target ,System.String instance_name)
        {
            return Observable.Start(()=>target.delete_component(instance_name));
        }
         
        public static IObservable<omg.org.RTC.RTObject[]> get_componentsAsync(this Manager target )
        {
            return Observable.Start(()=>target.get_components());
        }
         
        public static IObservable<omg.org.RTC.ComponentProfile[]> get_component_profilesAsync(this Manager target )
        {
            return Observable.Start(()=>target.get_component_profiles());
        }
         
        public static IObservable<RTM.ManagerProfile> get_profileAsync(this Manager target )
        {
            return Observable.Start(()=>target.get_profile());
        }
         
        public static IObservable<org.omg.SDOPackage.NameValue[]> get_configurationAsync(this Manager target )
        {
            return Observable.Start(()=>target.get_configuration());
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> set_configurationAsync(this Manager target ,System.String name,System.String value)
        {
            return Observable.Start(()=>target.set_configuration(name,value));
        }
         
        public static IObservable<System.Boolean> is_masterAsync(this Manager target )
        {
            return Observable.Start(()=>target.is_master());
        }
         
        public static IObservable<RTM.Manager[]> get_master_managersAsync(this Manager target )
        {
            return Observable.Start(()=>target.get_master_managers());
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> add_master_managerAsync(this Manager target ,RTM.Manager mgr)
        {
            return Observable.Start(()=>target.add_master_manager(mgr));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> remove_master_managerAsync(this Manager target ,RTM.Manager mgr)
        {
            return Observable.Start(()=>target.remove_master_manager(mgr));
        }
         
        public static IObservable<RTM.Manager[]> get_slave_managersAsync(this Manager target )
        {
            return Observable.Start(()=>target.get_slave_managers());
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> add_slave_managerAsync(this Manager target ,RTM.Manager mgr)
        {
            return Observable.Start(()=>target.add_slave_manager(mgr));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> remove_slave_managerAsync(this Manager target ,RTM.Manager mgr)
        {
            return Observable.Start(()=>target.remove_slave_manager(mgr));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> forkAsync(this Manager target )
        {
            return Observable.Start(()=>target.fork());
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> shutdownAsync(this Manager target )
        {
            return Observable.Start(()=>target.shutdown());
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> restartAsync(this Manager target )
        {
            return Observable.Start(()=>target.restart());
        }
         
        public static IObservable<System.MarshalByRefObject> get_serviceAsync(this Manager target ,System.String name)
        {
            return Observable.Start(()=>target.get_service(name));
        }
            }
    }

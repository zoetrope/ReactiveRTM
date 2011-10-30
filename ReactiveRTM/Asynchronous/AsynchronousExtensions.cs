using System.Linq;
using System.Collections.Generic;
using System;
using System.Reactive.Linq;
using ReactiveRTM.Corba;

 
namespace omg.org.RTC
{
     
    internal static class ExecutionContextAsyncExtensions
    {
         
        public static IObservable<System.Boolean> is_runningAsync(this ExecutionContext target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.is_running())).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> startAsync(this ExecutionContext target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.start())).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> _stopAsync(this ExecutionContext target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target._stop())).Timeout(timeout);
        }
         
        public static IObservable<System.Double> get_rateAsync(this ExecutionContext target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_rate())).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> set_rateAsync(this ExecutionContext target ,System.Double rate, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.set_rate(rate))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> add_componentAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.add_component(comp))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> remove_componentAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.remove_component(comp))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> activate_componentAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.activate_component(comp))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> deactivate_componentAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.deactivate_component(comp))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> reset_componentAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.reset_component(comp))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.LifeCycleState> get_component_stateAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_component_state(comp))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ExecutionKind> get_kindAsync(this ExecutionContext target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_kind())).Timeout(timeout);
        }
            }
     
    internal static class ComponentActionAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_initializeAsync(this ComponentAction target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.on_initialize())).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_finalizeAsync(this ComponentAction target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.on_finalize())).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_startupAsync(this ComponentAction target ,System.Int32 exec_handle, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.on_startup(exec_handle))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_shutdownAsync(this ComponentAction target ,System.Int32 exec_handle, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.on_shutdown(exec_handle))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_activatedAsync(this ComponentAction target ,System.Int32 exec_handle, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.on_activated(exec_handle))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_deactivatedAsync(this ComponentAction target ,System.Int32 exec_handle, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.on_deactivated(exec_handle))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_abortingAsync(this ComponentAction target ,System.Int32 exec_handle, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.on_aborting(exec_handle))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_errorAsync(this ComponentAction target ,System.Int32 exec_handle, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.on_error(exec_handle))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_resetAsync(this ComponentAction target ,System.Int32 exec_handle, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.on_reset(exec_handle))).Timeout(timeout);
        }
            }
     
    internal static class LightweightRTObjectAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ReturnCode_t> initializeAsync(this LightweightRTObject target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.initialize())).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> _finalizeAsync(this LightweightRTObject target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target._finalize())).Timeout(timeout);
        }
         
        public static IObservable<System.Boolean> is_aliveAsync(this LightweightRTObject target ,omg.org.RTC.ExecutionContext exec_context, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.is_alive(exec_context))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> _exitAsync(this LightweightRTObject target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target._exit())).Timeout(timeout);
        }
         
        public static IObservable<System.Int32> attach_contextAsync(this LightweightRTObject target ,omg.org.RTC.ExecutionContext exec_context, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.attach_context(exec_context))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> detach_contextAsync(this LightweightRTObject target ,System.Int32 exec_handle, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.detach_context(exec_handle))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ExecutionContext> get_contextAsync(this LightweightRTObject target ,System.Int32 exec_handle, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_context(exec_handle))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ExecutionContext[]> get_owned_contextsAsync(this LightweightRTObject target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_owned_contexts())).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ExecutionContext[]> get_participating_contextsAsync(this LightweightRTObject target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_participating_contexts())).Timeout(timeout);
        }
         
        public static IObservable<System.Int32> get_context_handleAsync(this LightweightRTObject target ,omg.org.RTC.ExecutionContext cxt, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_context_handle(cxt))).Timeout(timeout);
        }
            }
     
    internal static class DataFlowComponentActionAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_executeAsync(this DataFlowComponentAction target ,System.Int32 exec_handle, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.on_execute(exec_handle))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_state_updateAsync(this DataFlowComponentAction target ,System.Int32 exec_handle, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.on_state_update(exec_handle))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_rate_changedAsync(this DataFlowComponentAction target ,System.Int32 exec_handle, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.on_rate_changed(exec_handle))).Timeout(timeout);
        }
            }
     
    internal static class FsmParticipantActionAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_actionAsync(this FsmParticipantAction target ,System.Int32 exec_handle, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.on_action(exec_handle))).Timeout(timeout);
        }
            }
     
    internal static class ModeCapableAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.Mode> get_default_modeAsync(this ModeCapable target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_default_mode())).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.Mode> get_current_modeAsync(this ModeCapable target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_current_mode())).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.Mode> get_current_mode_in_contextAsync(this ModeCapable target ,omg.org.RTC.ExecutionContext exec_context, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_current_mode_in_context(exec_context))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.Mode> get_pending_modeAsync(this ModeCapable target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_pending_mode())).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.Mode> get_pending_mode_in_contextAsync(this ModeCapable target ,omg.org.RTC.ExecutionContext exec_context, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_pending_mode_in_context(exec_context))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> set_modeAsync(this ModeCapable target ,omg.org.RTC.Mode new_mode,System.Boolean immediate, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.set_mode(new_mode,immediate))).Timeout(timeout);
        }
            }
     
    internal static class MultiModeComponentActionAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_mode_changedAsync(this MultiModeComponentAction target ,System.Int32 exec_handle, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.on_mode_changed(exec_handle))).Timeout(timeout);
        }
            }
     
    internal static class RTObjectAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ComponentProfile> get_component_profileAsync(this RTObject target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_component_profile())).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.PortService[]> get_portsAsync(this RTObject target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_ports())).Timeout(timeout);
        }
            }
     
    internal static class PortServiceAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.PortProfile> get_port_profileAsync(this PortService target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_port_profile())).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ConnectorProfile[]> get_connector_profilesAsync(this PortService target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_connector_profiles())).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ConnectorProfile> get_connector_profileAsync(this PortService target ,System.String connector_id, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_connector_profile(connector_id))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> connectAsync(this PortService target ,omg.org.RTC.ConnectorProfile connector_profile, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.connect(ref connector_profile))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> disconnectAsync(this PortService target ,System.String connector_id, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.disconnect(connector_id))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> disconnect_allAsync(this PortService target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.disconnect_all())).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> notify_connectAsync(this PortService target ,omg.org.RTC.ConnectorProfile connector_profile, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.notify_connect(ref connector_profile))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> notify_disconnectAsync(this PortService target ,System.String connector_id, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.notify_disconnect(connector_id))).Timeout(timeout);
        }
            }
     
    internal static class FsmObjectAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ReturnCode_t> send_stimulusAsync(this FsmObject target ,System.String message,System.Int32 exec_handle, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.send_stimulus(message,exec_handle))).Timeout(timeout);
        }
            }
     
    internal static class FsmServiceAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.FsmProfile> get_fsm_profileAsync(this FsmService target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_fsm_profile())).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> set_fsm_profileAsync(this FsmService target ,omg.org.RTC.FsmProfile fsm_profile, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.set_fsm_profile(fsm_profile))).Timeout(timeout);
        }
            }
     
    internal static class ExecutionContextServiceAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ExecutionContextProfile> get_profileAsync(this ExecutionContextService target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_profile())).Timeout(timeout);
        }
            }
    }
 
namespace OpenRTM
{
     
    internal static class ComponentObserverAsyncExtensions
    {
         
        public static IObservable<System.Reactive.Unit> update_statusAsync(this ComponentObserver target ,OpenRTM.StatusKind status_kind,System.String hint, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.update_status(status_kind,hint))).Timeout(timeout);
        }
            }
     
    internal static class InPortCdrAsyncExtensions
    {
         
        public static IObservable<OpenRTM.PortStatus> putAsync(this InPortCdr target ,System.Byte[] data, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.put(data))).Timeout(timeout);
        }
            }
     
    internal static class OutPortCdrAsyncExtensions
    {
         
        public static IObservable<OpenRTM.PortStatus> _getAsync(this OutPortCdr target ,System.Byte[] data, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target._get(out data))).Timeout(timeout);
        }
            }
     
    internal static class LoggerAsyncExtensions
    {
         
        public static IObservable<System.Reactive.Unit> publishAsync(this Logger target ,OpenRTM.LogRecord record, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.publish(record))).Timeout(timeout);
        }
         
        public static IObservable<System.Reactive.Unit> closeAsync(this Logger target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.close())).Timeout(timeout);
        }
            }
    }
 
namespace openrtm.aist.go.jp.OpenRTM
{
     
    internal static class ExtTrigExecutionContextServiceAsyncExtensions
    {
         
        public static IObservable<System.Reactive.Unit> tickAsync(this ExtTrigExecutionContextService target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.tick())).Timeout(timeout);
        }
            }
    }
 
namespace org.omg.SDOPackage
{
     
    internal static class SDOAsyncExtensions
    {
         
        public static IObservable<System.String> get_sdo_idAsync(this SDO target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_sdo_id())).Timeout(timeout);
        }
         
        public static IObservable<System.String> get_sdo_typeAsync(this SDO target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_sdo_type())).Timeout(timeout);
        }
         
        public static IObservable<org.omg.SDOPackage.DeviceProfile> get_device_profileAsync(this SDO target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_device_profile())).Timeout(timeout);
        }
         
        public static IObservable<org.omg.SDOPackage.ServiceProfile[]> get_service_profilesAsync(this SDO target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_service_profiles())).Timeout(timeout);
        }
         
        public static IObservable<org.omg.SDOPackage.ServiceProfile> get_service_profileAsync(this SDO target ,System.String id, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_service_profile(id))).Timeout(timeout);
        }
         
        public static IObservable<org.omg.SDOPackage.SDOService> get_sdo_serviceAsync(this SDO target ,System.String id, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_sdo_service(id))).Timeout(timeout);
        }
         
        public static IObservable<org.omg.SDOPackage.Configuration> get_configurationAsync(this SDO target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_configuration())).Timeout(timeout);
        }
         
        public static IObservable<org.omg.SDOPackage.Monitoring> get_monitoringAsync(this SDO target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_monitoring())).Timeout(timeout);
        }
         
        public static IObservable<org.omg.SDOPackage.Organization[]> get_organizationsAsync(this SDO target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_organizations())).Timeout(timeout);
        }
         
        public static IObservable<org.omg.SDOPackage.NameValue[]> get_status_listAsync(this SDO target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_status_list())).Timeout(timeout);
        }
         
        public static IObservable<System.Object> get_statusAsync(this SDO target ,System.String nme, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_status(nme))).Timeout(timeout);
        }
            }
     
    internal static class SDOSystemElementAsyncExtensions
    {
         
        public static IObservable<org.omg.SDOPackage.Organization[]> get_owned_organizationsAsync(this SDOSystemElement target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_owned_organizations())).Timeout(timeout);
        }
            }
     
    internal static class ConfigurationAsyncExtensions
    {
         
        public static IObservable<System.Boolean> set_device_profileAsync(this Configuration target ,org.omg.SDOPackage.DeviceProfile dProfile, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.set_device_profile(dProfile))).Timeout(timeout);
        }
         
        public static IObservable<System.Boolean> add_service_profileAsync(this Configuration target ,org.omg.SDOPackage.ServiceProfile sProfile, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.add_service_profile(sProfile))).Timeout(timeout);
        }
         
        public static IObservable<System.Boolean> add_organizationAsync(this Configuration target ,org.omg.SDOPackage.Organization organization_object, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.add_organization(organization_object))).Timeout(timeout);
        }
         
        public static IObservable<System.Boolean> remove_service_profileAsync(this Configuration target ,System.String id, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.remove_service_profile(id))).Timeout(timeout);
        }
         
        public static IObservable<System.Boolean> remove_organizationAsync(this Configuration target ,System.String organization_id, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.remove_organization(organization_id))).Timeout(timeout);
        }
         
        public static IObservable<org.omg.SDOPackage.Parameter[]> get_configuration_parametersAsync(this Configuration target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_configuration_parameters())).Timeout(timeout);
        }
         
        public static IObservable<org.omg.SDOPackage.NameValue[]> get_configuration_parameter_valuesAsync(this Configuration target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_configuration_parameter_values())).Timeout(timeout);
        }
         
        public static IObservable<System.Object> get_configuration_parameter_valueAsync(this Configuration target ,System.String name, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_configuration_parameter_value(name))).Timeout(timeout);
        }
         
        public static IObservable<System.Boolean> set_configuration_parameterAsync(this Configuration target ,System.String name,System.Object value, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.set_configuration_parameter(name,value))).Timeout(timeout);
        }
         
        public static IObservable<org.omg.SDOPackage.ConfigurationSet[]> get_configuration_setsAsync(this Configuration target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_configuration_sets())).Timeout(timeout);
        }
         
        public static IObservable<org.omg.SDOPackage.ConfigurationSet> get_configuration_setAsync(this Configuration target ,System.String config_id, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_configuration_set(config_id))).Timeout(timeout);
        }
         
        public static IObservable<System.Boolean> set_configuration_set_valuesAsync(this Configuration target ,org.omg.SDOPackage.ConfigurationSet configuration_set, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.set_configuration_set_values(configuration_set))).Timeout(timeout);
        }
         
        public static IObservable<org.omg.SDOPackage.ConfigurationSet> get_active_configuration_setAsync(this Configuration target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_active_configuration_set())).Timeout(timeout);
        }
         
        public static IObservable<System.Boolean> add_configuration_setAsync(this Configuration target ,org.omg.SDOPackage.ConfigurationSet configuration_set, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.add_configuration_set(configuration_set))).Timeout(timeout);
        }
         
        public static IObservable<System.Boolean> remove_configuration_setAsync(this Configuration target ,System.String config_id, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.remove_configuration_set(config_id))).Timeout(timeout);
        }
         
        public static IObservable<System.Boolean> activate_configuration_setAsync(this Configuration target ,System.String config_id, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.activate_configuration_set(config_id))).Timeout(timeout);
        }
            }
     
    internal static class OrganizationAsyncExtensions
    {
         
        public static IObservable<System.String> get_organization_idAsync(this Organization target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_organization_id())).Timeout(timeout);
        }
         
        public static IObservable<org.omg.SDOPackage.OrganizationProperty> get_organization_propertyAsync(this Organization target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_organization_property())).Timeout(timeout);
        }
         
        public static IObservable<System.Object> get_organization_property_valueAsync(this Organization target ,System.String name, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_organization_property_value(name))).Timeout(timeout);
        }
         
        public static IObservable<System.Boolean> add_organization_propertyAsync(this Organization target ,org.omg.SDOPackage.OrganizationProperty organization_property, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.add_organization_property(organization_property))).Timeout(timeout);
        }
         
        public static IObservable<System.Boolean> set_organization_property_valueAsync(this Organization target ,System.String name,System.Object value, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.set_organization_property_value(name,value))).Timeout(timeout);
        }
         
        public static IObservable<System.Boolean> remove_organization_propertyAsync(this Organization target ,System.String name, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.remove_organization_property(name))).Timeout(timeout);
        }
         
        public static IObservable<org.omg.SDOPackage.SDOSystemElement> get_ownerAsync(this Organization target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_owner())).Timeout(timeout);
        }
         
        public static IObservable<System.Boolean> set_ownerAsync(this Organization target ,org.omg.SDOPackage.SDOSystemElement sdo, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.set_owner(sdo))).Timeout(timeout);
        }
         
        public static IObservable<org.omg.SDOPackage.SDO[]> get_membersAsync(this Organization target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_members())).Timeout(timeout);
        }
         
        public static IObservable<System.Boolean> set_membersAsync(this Organization target ,org.omg.SDOPackage.SDO[] sdos, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.set_members(sdos))).Timeout(timeout);
        }
         
        public static IObservable<System.Boolean> add_membersAsync(this Organization target ,org.omg.SDOPackage.SDO[] sdo_list, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.add_members(sdo_list))).Timeout(timeout);
        }
         
        public static IObservable<System.Boolean> remove_memberAsync(this Organization target ,System.String id, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.remove_member(id))).Timeout(timeout);
        }
         
        public static IObservable<org.omg.SDOPackage.DependencyType> get_dependencyAsync(this Organization target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_dependency())).Timeout(timeout);
        }
         
        public static IObservable<System.Boolean> set_dependencyAsync(this Organization target ,org.omg.SDOPackage.DependencyType dependency, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.set_dependency(dependency))).Timeout(timeout);
        }
            }
    }
 
namespace RTC
{
     
    internal static class ActArrayAsyncExtensions
    {
         
        public static IObservable<RTC.ActArrayGeometry> GetGeometryAsync(this ActArray target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
         
        public static IObservable<System.Reactive.Unit> GoHomeAsync(this ActArray target ,System.Int16 index, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GoHome(index))).Timeout(timeout);
        }
         
        public static IObservable<System.Reactive.Unit> PowerAsync(this ActArray target ,System.Boolean enable, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.Power(enable))).Timeout(timeout);
        }
         
        public static IObservable<System.Reactive.Unit> BrakesAsync(this ActArray target ,System.Boolean engage, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.Brakes(engage))).Timeout(timeout);
        }
         
        public static IObservable<System.Reactive.Unit> ConfigSpeedAsync(this ActArray target ,System.Int16 index,System.Double speed, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.ConfigSpeed(index,speed))).Timeout(timeout);
        }
         
        public static IObservable<System.Reactive.Unit> ConfigAccelAsync(this ActArray target ,System.Int16 index,System.Double accel, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.ConfigAccel(index,accel))).Timeout(timeout);
        }
            }
     
    internal static class AIOAsyncExtensions
    {
         
        public static IObservable<System.Int16> NumChannelsAsync(this AIO target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.NumChannels())).Timeout(timeout);
        }
         
        public static IObservable<System.Reactive.Unit> SetReferenceLevelAsync(this AIO target ,System.Int16 index,System.Double level, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.SetReferenceLevel(index,level))).Timeout(timeout);
        }
         
        public static IObservable<System.Double> GetResolutionAsync(this AIO target ,System.Int16 index, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetResolution(index))).Timeout(timeout);
        }
            }
     
    internal static class BumperAsyncExtensions
    {
         
        public static IObservable<RTC.BumperGeometry> GetGeometryAsync(this Bumper target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
            }
     
    internal static class CameraAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this Camera target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
         
        public static IObservable<RTC.CameraInfo> GetCameraInfoAsync(this Camera target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetCameraInfo())).Timeout(timeout);
        }
            }
     
    internal static class DIOAsyncExtensions
    {
         
        public static IObservable<System.Int16> NumBitsAsync(this DIO target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.NumBits())).Timeout(timeout);
        }
         
        public static IObservable<System.Boolean> GetBitAsync(this DIO target ,System.Int16 index, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetBit(index))).Timeout(timeout);
        }
         
        public static IObservable<System.Reactive.Unit> SetBitAsync(this DIO target ,System.Int16 index,System.Boolean newValue, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.SetBit(index,newValue))).Timeout(timeout);
        }
            }
     
    internal static class FiducialAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this Fiducial target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
         
        public static IObservable<RTC.FiducialFOV> GetFOVAsync(this Fiducial target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetFOV())).Timeout(timeout);
        }
         
        public static IObservable<System.Reactive.Unit> SetFOVAsync(this Fiducial target ,RTC.FiducialFOV newFOV, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.SetFOV(newFOV))).Timeout(timeout);
        }
            }
     
    internal static class GPSAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this GPS target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
            }
     
    internal static class GripperAsyncExtensions
    {
         
        public static IObservable<RTC.GripperGeometry> GetGeometryAsync(this Gripper target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
         
        public static IObservable<System.Reactive.Unit> OpenAsync(this Gripper target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.Open())).Timeout(timeout);
        }
         
        public static IObservable<System.Reactive.Unit> CloseAsync(this Gripper target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.Close())).Timeout(timeout);
        }
            }
     
    internal static class IMUAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this IMU target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
            }
     
    internal static class INSAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this INS target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
            }
     
    internal static class LimbAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this Limb target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
         
        public static IObservable<System.Reactive.Unit> PowerAsync(this Limb target ,System.Boolean enable, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.Power(enable))).Timeout(timeout);
        }
         
        public static IObservable<System.Reactive.Unit> BrakesAsync(this Limb target ,System.Boolean engage, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.Brakes(engage))).Timeout(timeout);
        }
         
        public static IObservable<System.Reactive.Unit> SetSpeedAsync(this Limb target ,System.Double speed, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.SetSpeed(speed))).Timeout(timeout);
        }
            }
     
    internal static class OGMapAsyncExtensions
    {
         
        public static IObservable<RTC.OGMapConfig> GetConfigAsync(this OGMap target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetConfig())).Timeout(timeout);
        }
         
        public static IObservable<RTC.OGMapTile> GetTileAsync(this OGMap target ,RTC.OGMapTile tile, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetTile(tile))).Timeout(timeout);
        }
            }
     
    internal static class MulticameraAsyncExtensions
    {
         
        public static IObservable<RTC.MulticameraGeometry> GetGeometryAsync(this Multicamera target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
         
        public static IObservable<RTC.CameraInfo[]> GetCameraInfosAsync(this Multicamera target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetCameraInfos())).Timeout(timeout);
        }
            }
     
    internal static class PanTiltAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this PanTilt target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
            }
     
    internal static class PathPlanner2DAsyncExtensions
    {
         
        public static IObservable<System.Reactive.Unit> SetTaskAsync(this PathPlanner2D target ,RTC.Waypoint2D[] coarsePath, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.SetTask(coarsePath))).Timeout(timeout);
        }
            }
     
    internal static class PathPlanner3DAsyncExtensions
    {
         
        public static IObservable<System.Reactive.Unit> SetTaskAsync(this PathPlanner3D target ,RTC.Waypoint3D[] coarsePath, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.SetTask(coarsePath))).Timeout(timeout);
        }
            }
     
    internal static class PathFollower2DAsyncExtensions
    {
         
        public static IObservable<System.Reactive.Unit> SetPathAsync(this PathFollower2D target ,RTC.Waypoint2D[] path, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.SetPath(path))).Timeout(timeout);
        }
         
        public static IObservable<System.Reactive.Unit> EnableAsync(this PathFollower2D target ,System.Boolean enable, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.Enable(enable))).Timeout(timeout);
        }
         
        public static IObservable<System.Int16> GetCurrentWaypointIndexAsync(this PathFollower2D target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetCurrentWaypointIndex())).Timeout(timeout);
        }
         
        public static IObservable<RTC.Waypoint2D> GetCurrentWaypointAsync(this PathFollower2D target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetCurrentWaypoint())).Timeout(timeout);
        }
            }
     
    internal static class PathFollower3DAsyncExtensions
    {
         
        public static IObservable<System.Reactive.Unit> SetPathAsync(this PathFollower3D target ,RTC.Waypoint3D[] path, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.SetPath(path))).Timeout(timeout);
        }
         
        public static IObservable<System.Reactive.Unit> EnableAsync(this PathFollower3D target ,System.Boolean enable, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.Enable(enable))).Timeout(timeout);
        }
         
        public static IObservable<System.Int16> GetCurrentWaypointIndexAsync(this PathFollower3D target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetCurrentWaypointIndex())).Timeout(timeout);
        }
         
        public static IObservable<RTC.Waypoint3D> GetCurrentWaypointAsync(this PathFollower3D target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetCurrentWaypoint())).Timeout(timeout);
        }
            }
     
    internal static class PointCloudServicesAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this PointCloudServices target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
            }
     
    internal static class Odometry2DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this Odometry2D target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
         
        public static IObservable<System.Reactive.Unit> SetOdometryAsync(this Odometry2D target ,RTC.Pose2D newOdometry, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.SetOdometry(newOdometry))).Timeout(timeout);
        }
            }
     
    internal static class Odometry3DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this Odometry3D target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
         
        public static IObservable<System.Reactive.Unit> SetOdometryAsync(this Odometry3D target ,RTC.Pose3D newOdometry, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.SetOdometry(newOdometry))).Timeout(timeout);
        }
            }
     
    internal static class VelocityControl2DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry2D> GetGeometryAsync(this VelocityControl2D target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
            }
     
    internal static class VelocityControl3DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this VelocityControl3D target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
            }
     
    internal static class PoseControl2DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry2D> GetGeometryAsync(this PoseControl2D target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
            }
     
    internal static class PoseControl3DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this PoseControl3D target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
            }
     
    internal static class CarlikeControlAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry2D> GetGeometryAsync(this CarlikeControl target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
            }
     
    internal static class HeadingControl2DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry2D> GetGeometryAsync(this HeadingControl2D target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
            }
     
    internal static class HeadingControl3DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this HeadingControl3D target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
            }
     
    internal static class RangerAsyncExtensions
    {
         
        public static IObservable<RTC.RangerGeometry> GetGeometryAsync(this Ranger target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
         
        public static IObservable<System.Reactive.Unit> PowerAsync(this Ranger target ,System.Boolean enable, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.Power(enable))).Timeout(timeout);
        }
         
        public static IObservable<System.Reactive.Unit> EnableIntensitiesAsync(this Ranger target ,System.Boolean enable, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.EnableIntensities(enable))).Timeout(timeout);
        }
         
        public static IObservable<RTC.RangerConfig> GetConfigAsync(this Ranger target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetConfig())).Timeout(timeout);
        }
         
        public static IObservable<System.Reactive.Unit> SetConfigAsync(this Ranger target ,RTC.RangerConfig newConfig, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.SetConfig(newConfig))).Timeout(timeout);
        }
            }
     
    internal static class RFIDAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this RFID target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.GetGeometry())).Timeout(timeout);
        }
         
        public static IObservable<System.Reactive.Unit> WriteAsync(this RFID target ,System.String GUID,System.Byte[] data, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.Write(GUID,data))).Timeout(timeout);
        }
         
        public static IObservable<System.Byte[]> ReadAsync(this RFID target ,System.String GUID, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.Read(GUID))).Timeout(timeout);
        }
            }
    }
 
namespace RTM
{
     
    internal static class ManagerAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ReturnCode_t> load_moduleAsync(this Manager target ,System.String pathname,System.String initfunc, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.load_module(pathname,initfunc))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> unload_moduleAsync(this Manager target ,System.String pathname, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.unload_module(pathname))).Timeout(timeout);
        }
         
        public static IObservable<RTM.ModuleProfile[]> get_loadable_modulesAsync(this Manager target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_loadable_modules())).Timeout(timeout);
        }
         
        public static IObservable<RTM.ModuleProfile[]> get_loaded_modulesAsync(this Manager target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_loaded_modules())).Timeout(timeout);
        }
         
        public static IObservable<RTM.ModuleProfile[]> get_factory_profilesAsync(this Manager target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_factory_profiles())).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.RTObject> create_componentAsync(this Manager target ,System.String module_name, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.create_component(module_name))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> delete_componentAsync(this Manager target ,System.String instance_name, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.delete_component(instance_name))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.RTObject[]> get_componentsAsync(this Manager target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_components())).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ComponentProfile[]> get_component_profilesAsync(this Manager target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_component_profiles())).Timeout(timeout);
        }
         
        public static IObservable<RTM.ManagerProfile> get_profileAsync(this Manager target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_profile())).Timeout(timeout);
        }
         
        public static IObservable<org.omg.SDOPackage.NameValue[]> get_configurationAsync(this Manager target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_configuration())).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> set_configurationAsync(this Manager target ,System.String name,System.String value, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.set_configuration(name,value))).Timeout(timeout);
        }
         
        public static IObservable<System.Boolean> is_masterAsync(this Manager target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.is_master())).Timeout(timeout);
        }
         
        public static IObservable<RTM.Manager[]> get_master_managersAsync(this Manager target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_master_managers())).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> add_master_managerAsync(this Manager target ,RTM.Manager mgr, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.add_master_manager(mgr))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> remove_master_managerAsync(this Manager target ,RTM.Manager mgr, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.remove_master_manager(mgr))).Timeout(timeout);
        }
         
        public static IObservable<RTM.Manager[]> get_slave_managersAsync(this Manager target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_slave_managers())).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> add_slave_managerAsync(this Manager target ,RTM.Manager mgr, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.add_slave_manager(mgr))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> remove_slave_managerAsync(this Manager target ,RTM.Manager mgr, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.remove_slave_manager(mgr))).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> forkAsync(this Manager target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.fork())).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> shutdownAsync(this Manager target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.shutdown())).Timeout(timeout);
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> restartAsync(this Manager target , TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.restart())).Timeout(timeout);
        }
         
        public static IObservable<System.MarshalByRefObject> get_serviceAsync(this Manager target ,System.String name, TimeSpan timeout)
        {
            return Observable.Defer(Observable.ToAsync(()=>target.get_service(name))).Timeout(timeout);
        }
            }
    }

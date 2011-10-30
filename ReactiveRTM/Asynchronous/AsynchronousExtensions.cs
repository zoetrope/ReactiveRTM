using System.Linq;
using System.Collections.Generic;
using System;
using System.Reactive.Linq;

 
namespace omg.org.RTC
{
     
    internal static class ExecutionContextAsyncExtensions
    {
         
        public static IObservable<System.Boolean> is_runningAsync(this ExecutionContext target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.is_running())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> startAsync(this ExecutionContext target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.start())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> _stopAsync(this ExecutionContext target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target._stop())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Double> get_rateAsync(this ExecutionContext target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_rate())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> set_rateAsync(this ExecutionContext target ,System.Double rate, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.set_rate(rate))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> add_componentAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.add_component(comp))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> remove_componentAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.remove_component(comp))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> activate_componentAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.activate_component(comp))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> deactivate_componentAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.deactivate_component(comp))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> reset_componentAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.reset_component(comp))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.LifeCycleState> get_component_stateAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_component_state(comp))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ExecutionKind> get_kindAsync(this ExecutionContext target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_kind())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class ComponentActionAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_initializeAsync(this ComponentAction target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.on_initialize())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_finalizeAsync(this ComponentAction target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.on_finalize())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_startupAsync(this ComponentAction target ,System.Int32 exec_handle, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.on_startup(exec_handle))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_shutdownAsync(this ComponentAction target ,System.Int32 exec_handle, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.on_shutdown(exec_handle))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_activatedAsync(this ComponentAction target ,System.Int32 exec_handle, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.on_activated(exec_handle))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_deactivatedAsync(this ComponentAction target ,System.Int32 exec_handle, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.on_deactivated(exec_handle))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_abortingAsync(this ComponentAction target ,System.Int32 exec_handle, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.on_aborting(exec_handle))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_errorAsync(this ComponentAction target ,System.Int32 exec_handle, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.on_error(exec_handle))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_resetAsync(this ComponentAction target ,System.Int32 exec_handle, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.on_reset(exec_handle))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class LightweightRTObjectAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ReturnCode_t> initializeAsync(this LightweightRTObject target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.initialize())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> _finalizeAsync(this LightweightRTObject target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target._finalize())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Boolean> is_aliveAsync(this LightweightRTObject target ,omg.org.RTC.ExecutionContext exec_context, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.is_alive(exec_context))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> _exitAsync(this LightweightRTObject target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target._exit())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Int32> attach_contextAsync(this LightweightRTObject target ,omg.org.RTC.ExecutionContext exec_context, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.attach_context(exec_context))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> detach_contextAsync(this LightweightRTObject target ,System.Int32 exec_handle, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.detach_context(exec_handle))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ExecutionContext> get_contextAsync(this LightweightRTObject target ,System.Int32 exec_handle, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_context(exec_handle))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ExecutionContext[]> get_owned_contextsAsync(this LightweightRTObject target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_owned_contexts())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ExecutionContext[]> get_participating_contextsAsync(this LightweightRTObject target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_participating_contexts())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Int32> get_context_handleAsync(this LightweightRTObject target ,omg.org.RTC.ExecutionContext cxt, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_context_handle(cxt))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class DataFlowComponentActionAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_executeAsync(this DataFlowComponentAction target ,System.Int32 exec_handle, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.on_execute(exec_handle))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_state_updateAsync(this DataFlowComponentAction target ,System.Int32 exec_handle, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.on_state_update(exec_handle))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_rate_changedAsync(this DataFlowComponentAction target ,System.Int32 exec_handle, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.on_rate_changed(exec_handle))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class FsmParticipantActionAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_actionAsync(this FsmParticipantAction target ,System.Int32 exec_handle, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.on_action(exec_handle))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class ModeCapableAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.Mode> get_default_modeAsync(this ModeCapable target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_default_mode())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.Mode> get_current_modeAsync(this ModeCapable target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_current_mode())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.Mode> get_current_mode_in_contextAsync(this ModeCapable target ,omg.org.RTC.ExecutionContext exec_context, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_current_mode_in_context(exec_context))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.Mode> get_pending_modeAsync(this ModeCapable target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_pending_mode())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.Mode> get_pending_mode_in_contextAsync(this ModeCapable target ,omg.org.RTC.ExecutionContext exec_context, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_pending_mode_in_context(exec_context))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> set_modeAsync(this ModeCapable target ,omg.org.RTC.Mode new_mode,System.Boolean immediate, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.set_mode(new_mode,immediate))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class MultiModeComponentActionAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ReturnCode_t> on_mode_changedAsync(this MultiModeComponentAction target ,System.Int32 exec_handle, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.on_mode_changed(exec_handle))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class RTObjectAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ComponentProfile> get_component_profileAsync(this RTObject target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_component_profile())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.PortService[]> get_portsAsync(this RTObject target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_ports())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class PortServiceAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.PortProfile> get_port_profileAsync(this PortService target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_port_profile())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ConnectorProfile[]> get_connector_profilesAsync(this PortService target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_connector_profiles())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ConnectorProfile> get_connector_profileAsync(this PortService target ,System.String connector_id, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_connector_profile(connector_id))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> connectAsync(this PortService target ,omg.org.RTC.ConnectorProfile connector_profile, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.connect(ref connector_profile))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> disconnectAsync(this PortService target ,System.String connector_id, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.disconnect(connector_id))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> disconnect_allAsync(this PortService target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.disconnect_all())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> notify_connectAsync(this PortService target ,omg.org.RTC.ConnectorProfile connector_profile, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.notify_connect(ref connector_profile))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> notify_disconnectAsync(this PortService target ,System.String connector_id, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.notify_disconnect(connector_id))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class FsmObjectAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ReturnCode_t> send_stimulusAsync(this FsmObject target ,System.String message,System.Int32 exec_handle, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.send_stimulus(message,exec_handle))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class FsmServiceAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.FsmProfile> get_fsm_profileAsync(this FsmService target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_fsm_profile())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> set_fsm_profileAsync(this FsmService target ,omg.org.RTC.FsmProfile fsm_profile, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.set_fsm_profile(fsm_profile))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class ExecutionContextServiceAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ExecutionContextProfile> get_profileAsync(this ExecutionContextService target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_profile())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
    }
 
namespace OpenRTM
{
     
    internal static class ComponentObserverAsyncExtensions
    {
         
        public static IObservable<System.Reactive.Unit> update_statusAsync(this ComponentObserver target ,OpenRTM.StatusKind status_kind,System.String hint, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.update_status(status_kind,hint))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class InPortCdrAsyncExtensions
    {
         
        public static IObservable<OpenRTM.PortStatus> putAsync(this InPortCdr target ,System.Byte[] data, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.put(data))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class OutPortCdrAsyncExtensions
    {
         
        public static IObservable<OpenRTM.PortStatus> _getAsync(this OutPortCdr target ,System.Byte[] data, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target._get(out data))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class LoggerAsyncExtensions
    {
         
        public static IObservable<System.Reactive.Unit> publishAsync(this Logger target ,OpenRTM.LogRecord record, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.publish(record))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Reactive.Unit> closeAsync(this Logger target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.close())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
    }
 
namespace openrtm.aist.go.jp.OpenRTM
{
     
    internal static class ExtTrigExecutionContextServiceAsyncExtensions
    {
         
        public static IObservable<System.Reactive.Unit> tickAsync(this ExtTrigExecutionContextService target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.tick())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
    }
 
namespace org.omg.SDOPackage
{
     
    internal static class SDOAsyncExtensions
    {
         
        public static IObservable<System.String> get_sdo_idAsync(this SDO target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_sdo_id())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.String> get_sdo_typeAsync(this SDO target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_sdo_type())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<org.omg.SDOPackage.DeviceProfile> get_device_profileAsync(this SDO target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_device_profile())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<org.omg.SDOPackage.ServiceProfile[]> get_service_profilesAsync(this SDO target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_service_profiles())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<org.omg.SDOPackage.ServiceProfile> get_service_profileAsync(this SDO target ,System.String id, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_service_profile(id))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<org.omg.SDOPackage.SDOService> get_sdo_serviceAsync(this SDO target ,System.String id, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_sdo_service(id))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<org.omg.SDOPackage.Configuration> get_configurationAsync(this SDO target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_configuration())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<org.omg.SDOPackage.Monitoring> get_monitoringAsync(this SDO target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_monitoring())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<org.omg.SDOPackage.Organization[]> get_organizationsAsync(this SDO target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_organizations())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<org.omg.SDOPackage.NameValue[]> get_status_listAsync(this SDO target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_status_list())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Object> get_statusAsync(this SDO target ,System.String nme, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_status(nme))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class SDOSystemElementAsyncExtensions
    {
         
        public static IObservable<org.omg.SDOPackage.Organization[]> get_owned_organizationsAsync(this SDOSystemElement target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_owned_organizations())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class ConfigurationAsyncExtensions
    {
         
        public static IObservable<System.Boolean> set_device_profileAsync(this Configuration target ,org.omg.SDOPackage.DeviceProfile dProfile, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.set_device_profile(dProfile))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Boolean> add_service_profileAsync(this Configuration target ,org.omg.SDOPackage.ServiceProfile sProfile, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.add_service_profile(sProfile))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Boolean> add_organizationAsync(this Configuration target ,org.omg.SDOPackage.Organization organization_object, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.add_organization(organization_object))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Boolean> remove_service_profileAsync(this Configuration target ,System.String id, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.remove_service_profile(id))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Boolean> remove_organizationAsync(this Configuration target ,System.String organization_id, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.remove_organization(organization_id))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<org.omg.SDOPackage.Parameter[]> get_configuration_parametersAsync(this Configuration target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_configuration_parameters())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<org.omg.SDOPackage.NameValue[]> get_configuration_parameter_valuesAsync(this Configuration target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_configuration_parameter_values())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Object> get_configuration_parameter_valueAsync(this Configuration target ,System.String name, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_configuration_parameter_value(name))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Boolean> set_configuration_parameterAsync(this Configuration target ,System.String name,System.Object value, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.set_configuration_parameter(name,value))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<org.omg.SDOPackage.ConfigurationSet[]> get_configuration_setsAsync(this Configuration target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_configuration_sets())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<org.omg.SDOPackage.ConfigurationSet> get_configuration_setAsync(this Configuration target ,System.String config_id, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_configuration_set(config_id))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Boolean> set_configuration_set_valuesAsync(this Configuration target ,org.omg.SDOPackage.ConfigurationSet configuration_set, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.set_configuration_set_values(configuration_set))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<org.omg.SDOPackage.ConfigurationSet> get_active_configuration_setAsync(this Configuration target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_active_configuration_set())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Boolean> add_configuration_setAsync(this Configuration target ,org.omg.SDOPackage.ConfigurationSet configuration_set, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.add_configuration_set(configuration_set))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Boolean> remove_configuration_setAsync(this Configuration target ,System.String config_id, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.remove_configuration_set(config_id))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Boolean> activate_configuration_setAsync(this Configuration target ,System.String config_id, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.activate_configuration_set(config_id))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class OrganizationAsyncExtensions
    {
         
        public static IObservable<System.String> get_organization_idAsync(this Organization target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_organization_id())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<org.omg.SDOPackage.OrganizationProperty> get_organization_propertyAsync(this Organization target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_organization_property())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Object> get_organization_property_valueAsync(this Organization target ,System.String name, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_organization_property_value(name))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Boolean> add_organization_propertyAsync(this Organization target ,org.omg.SDOPackage.OrganizationProperty organization_property, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.add_organization_property(organization_property))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Boolean> set_organization_property_valueAsync(this Organization target ,System.String name,System.Object value, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.set_organization_property_value(name,value))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Boolean> remove_organization_propertyAsync(this Organization target ,System.String name, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.remove_organization_property(name))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<org.omg.SDOPackage.SDOSystemElement> get_ownerAsync(this Organization target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_owner())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Boolean> set_ownerAsync(this Organization target ,org.omg.SDOPackage.SDOSystemElement sdo, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.set_owner(sdo))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<org.omg.SDOPackage.SDO[]> get_membersAsync(this Organization target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_members())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Boolean> set_membersAsync(this Organization target ,org.omg.SDOPackage.SDO[] sdos, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.set_members(sdos))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Boolean> add_membersAsync(this Organization target ,org.omg.SDOPackage.SDO[] sdo_list, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.add_members(sdo_list))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Boolean> remove_memberAsync(this Organization target ,System.String id, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.remove_member(id))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<org.omg.SDOPackage.DependencyType> get_dependencyAsync(this Organization target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_dependency())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Boolean> set_dependencyAsync(this Organization target ,org.omg.SDOPackage.DependencyType dependency, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.set_dependency(dependency))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
    }
 
namespace ReactiveRTM
{
     
    internal static class SimpleServiceAsyncExtensions
    {
         
        public static IObservable<System.String[]> invokeAsync(this SimpleService target ,System.String operation,System.String[] args, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.invoke(operation,args))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
    }
 
namespace RTC
{
     
    internal static class ActArrayAsyncExtensions
    {
         
        public static IObservable<RTC.ActArrayGeometry> GetGeometryAsync(this ActArray target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Reactive.Unit> GoHomeAsync(this ActArray target ,System.Int16 index, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GoHome(index))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Reactive.Unit> PowerAsync(this ActArray target ,System.Boolean enable, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.Power(enable))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Reactive.Unit> BrakesAsync(this ActArray target ,System.Boolean engage, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.Brakes(engage))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Reactive.Unit> ConfigSpeedAsync(this ActArray target ,System.Int16 index,System.Double speed, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.ConfigSpeed(index,speed))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Reactive.Unit> ConfigAccelAsync(this ActArray target ,System.Int16 index,System.Double accel, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.ConfigAccel(index,accel))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class AIOAsyncExtensions
    {
         
        public static IObservable<System.Int16> NumChannelsAsync(this AIO target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.NumChannels())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Reactive.Unit> SetReferenceLevelAsync(this AIO target ,System.Int16 index,System.Double level, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.SetReferenceLevel(index,level))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Double> GetResolutionAsync(this AIO target ,System.Int16 index, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetResolution(index))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class BumperAsyncExtensions
    {
         
        public static IObservable<RTC.BumperGeometry> GetGeometryAsync(this Bumper target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class CameraAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this Camera target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<RTC.CameraInfo> GetCameraInfoAsync(this Camera target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetCameraInfo())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class DIOAsyncExtensions
    {
         
        public static IObservable<System.Int16> NumBitsAsync(this DIO target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.NumBits())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Boolean> GetBitAsync(this DIO target ,System.Int16 index, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetBit(index))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Reactive.Unit> SetBitAsync(this DIO target ,System.Int16 index,System.Boolean newValue, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.SetBit(index,newValue))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class FiducialAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this Fiducial target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<RTC.FiducialFOV> GetFOVAsync(this Fiducial target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetFOV())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Reactive.Unit> SetFOVAsync(this Fiducial target ,RTC.FiducialFOV newFOV, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.SetFOV(newFOV))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class GPSAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this GPS target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class GripperAsyncExtensions
    {
         
        public static IObservable<RTC.GripperGeometry> GetGeometryAsync(this Gripper target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Reactive.Unit> OpenAsync(this Gripper target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.Open())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Reactive.Unit> CloseAsync(this Gripper target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.Close())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class IMUAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this IMU target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class INSAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this INS target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class LimbAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this Limb target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Reactive.Unit> PowerAsync(this Limb target ,System.Boolean enable, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.Power(enable))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Reactive.Unit> BrakesAsync(this Limb target ,System.Boolean engage, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.Brakes(engage))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Reactive.Unit> SetSpeedAsync(this Limb target ,System.Double speed, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.SetSpeed(speed))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class OGMapAsyncExtensions
    {
         
        public static IObservable<RTC.OGMapConfig> GetConfigAsync(this OGMap target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetConfig())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<RTC.OGMapTile> GetTileAsync(this OGMap target ,RTC.OGMapTile tile, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetTile(tile))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class MulticameraAsyncExtensions
    {
         
        public static IObservable<RTC.MulticameraGeometry> GetGeometryAsync(this Multicamera target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<RTC.CameraInfo[]> GetCameraInfosAsync(this Multicamera target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetCameraInfos())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class PanTiltAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this PanTilt target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class PathPlanner2DAsyncExtensions
    {
         
        public static IObservable<System.Reactive.Unit> SetTaskAsync(this PathPlanner2D target ,RTC.Waypoint2D[] coarsePath, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.SetTask(coarsePath))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class PathPlanner3DAsyncExtensions
    {
         
        public static IObservable<System.Reactive.Unit> SetTaskAsync(this PathPlanner3D target ,RTC.Waypoint3D[] coarsePath, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.SetTask(coarsePath))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class PathFollower2DAsyncExtensions
    {
         
        public static IObservable<System.Reactive.Unit> SetPathAsync(this PathFollower2D target ,RTC.Waypoint2D[] path, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.SetPath(path))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Reactive.Unit> EnableAsync(this PathFollower2D target ,System.Boolean enable, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.Enable(enable))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Int16> GetCurrentWaypointIndexAsync(this PathFollower2D target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetCurrentWaypointIndex())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<RTC.Waypoint2D> GetCurrentWaypointAsync(this PathFollower2D target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetCurrentWaypoint())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class PathFollower3DAsyncExtensions
    {
         
        public static IObservable<System.Reactive.Unit> SetPathAsync(this PathFollower3D target ,RTC.Waypoint3D[] path, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.SetPath(path))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Reactive.Unit> EnableAsync(this PathFollower3D target ,System.Boolean enable, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.Enable(enable))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Int16> GetCurrentWaypointIndexAsync(this PathFollower3D target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetCurrentWaypointIndex())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<RTC.Waypoint3D> GetCurrentWaypointAsync(this PathFollower3D target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetCurrentWaypoint())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class PointCloudServicesAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this PointCloudServices target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class Odometry2DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this Odometry2D target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Reactive.Unit> SetOdometryAsync(this Odometry2D target ,RTC.Pose2D newOdometry, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.SetOdometry(newOdometry))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class Odometry3DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this Odometry3D target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Reactive.Unit> SetOdometryAsync(this Odometry3D target ,RTC.Pose3D newOdometry, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.SetOdometry(newOdometry))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class VelocityControl2DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry2D> GetGeometryAsync(this VelocityControl2D target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class VelocityControl3DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this VelocityControl3D target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class PoseControl2DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry2D> GetGeometryAsync(this PoseControl2D target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class PoseControl3DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this PoseControl3D target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class CarlikeControlAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry2D> GetGeometryAsync(this CarlikeControl target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class HeadingControl2DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry2D> GetGeometryAsync(this HeadingControl2D target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class HeadingControl3DAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this HeadingControl3D target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class RangerAsyncExtensions
    {
         
        public static IObservable<RTC.RangerGeometry> GetGeometryAsync(this Ranger target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Reactive.Unit> PowerAsync(this Ranger target ,System.Boolean enable, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.Power(enable))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Reactive.Unit> EnableIntensitiesAsync(this Ranger target ,System.Boolean enable, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.EnableIntensities(enable))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<RTC.RangerConfig> GetConfigAsync(this Ranger target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetConfig())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Reactive.Unit> SetConfigAsync(this Ranger target ,RTC.RangerConfig newConfig, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.SetConfig(newConfig))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
     
    internal static class RFIDAsyncExtensions
    {
         
        public static IObservable<RTC.Geometry3D> GetGeometryAsync(this RFID target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.GetGeometry())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Reactive.Unit> WriteAsync(this RFID target ,System.String GUID,System.Byte[] data, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.Write(GUID,data))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Byte[]> ReadAsync(this RFID target ,System.String GUID, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.Read(GUID))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
    }
 
namespace RTM
{
     
    internal static class ManagerAsyncExtensions
    {
         
        public static IObservable<omg.org.RTC.ReturnCode_t> load_moduleAsync(this Manager target ,System.String pathname,System.String initfunc, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.load_module(pathname,initfunc))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> unload_moduleAsync(this Manager target ,System.String pathname, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.unload_module(pathname))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<RTM.ModuleProfile[]> get_loadable_modulesAsync(this Manager target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_loadable_modules())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<RTM.ModuleProfile[]> get_loaded_modulesAsync(this Manager target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_loaded_modules())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<RTM.ModuleProfile[]> get_factory_profilesAsync(this Manager target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_factory_profiles())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.RTObject> create_componentAsync(this Manager target ,System.String module_name, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.create_component(module_name))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> delete_componentAsync(this Manager target ,System.String instance_name, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.delete_component(instance_name))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.RTObject[]> get_componentsAsync(this Manager target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_components())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ComponentProfile[]> get_component_profilesAsync(this Manager target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_component_profiles())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<RTM.ManagerProfile> get_profileAsync(this Manager target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_profile())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<org.omg.SDOPackage.NameValue[]> get_configurationAsync(this Manager target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_configuration())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> set_configurationAsync(this Manager target ,System.String name,System.String value, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.set_configuration(name,value))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.Boolean> is_masterAsync(this Manager target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.is_master())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<RTM.Manager[]> get_master_managersAsync(this Manager target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_master_managers())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> add_master_managerAsync(this Manager target ,RTM.Manager mgr, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.add_master_manager(mgr))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> remove_master_managerAsync(this Manager target ,RTM.Manager mgr, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.remove_master_manager(mgr))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<RTM.Manager[]> get_slave_managersAsync(this Manager target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_slave_managers())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> add_slave_managerAsync(this Manager target ,RTM.Manager mgr, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.add_slave_manager(mgr))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> remove_slave_managerAsync(this Manager target ,RTM.Manager mgr, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.remove_slave_manager(mgr))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> forkAsync(this Manager target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.fork())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> shutdownAsync(this Manager target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.shutdown())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<omg.org.RTC.ReturnCode_t> restartAsync(this Manager target , double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.restart())
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
         
        public static IObservable<System.MarshalByRefObject> get_serviceAsync(this Manager target ,System.String name, double timeoutSeconds=5)
        {
            return Observable.Start(()=>target.get_service(name))
                      .Timeout(TimeSpan.FromSeconds(timeoutSeconds));
        }
            }
    }

using System.Linq;
using System.Collections.Generic;
using System;
using System.Reactive.Linq;
using System.Reactive.Concurrency;
using System.Threading.Tasks;
using ReactiveRTM.Corba;

 
namespace omg.org.RTC
{
     
    public static class ExecutionContextAsyncExtensions
    {
         
        public static Task<System.Boolean> IsRunningAsync(this ExecutionContext target )
        {
            return Task.Factory.StartNew(()=>target.is_running());
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> StartAsync(this ExecutionContext target )
        {
            return Task.Factory.StartNew(()=>target.start());
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> StopAsync(this ExecutionContext target )
        {
            return Task.Factory.StartNew(()=>target._stop());
        }
         
        public static Task<System.Double> GetRateAsync(this ExecutionContext target )
        {
            return Task.Factory.StartNew(()=>target.get_rate());
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> SetRateAsync(this ExecutionContext target ,System.Double rate)
        {
            return Task.Factory.StartNew(()=>target.set_rate(rate));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> AddComponentAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>target.add_component(comp));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> RemoveComponentAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>target.remove_component(comp));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> ActivateComponentAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>target.activate_component(comp));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> DeactivateComponentAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>target.deactivate_component(comp));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> ResetComponentAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>target.reset_component(comp));
        }
         
        public static Task<omg.org.RTC.LifeCycleState> GetComponentStateAsync(this ExecutionContext target ,omg.org.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>target.get_component_state(comp));
        }
         
        public static Task<omg.org.RTC.ExecutionKind> GetKindAsync(this ExecutionContext target )
        {
            return Task.Factory.StartNew(()=>target.get_kind());
        }
            }
     
    public static class ComponentActionAsyncExtensions
    {
         
        public static Task<omg.org.RTC.ReturnCode_t> OnInitializeAsync(this ComponentAction target )
        {
            return Task.Factory.StartNew(()=>target.on_initialize());
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> OnFinalizeAsync(this ComponentAction target )
        {
            return Task.Factory.StartNew(()=>target.on_finalize());
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> OnStartupAsync(this ComponentAction target ,System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>target.on_startup(exec_handle));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> OnShutdownAsync(this ComponentAction target ,System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>target.on_shutdown(exec_handle));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> OnActivatedAsync(this ComponentAction target ,System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>target.on_activated(exec_handle));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> OnDeactivatedAsync(this ComponentAction target ,System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>target.on_deactivated(exec_handle));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> OnAbortingAsync(this ComponentAction target ,System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>target.on_aborting(exec_handle));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> OnErrorAsync(this ComponentAction target ,System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>target.on_error(exec_handle));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> OnResetAsync(this ComponentAction target ,System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>target.on_reset(exec_handle));
        }
            }
     
    public static class LightweightRTObjectAsyncExtensions
    {
         
        public static Task<omg.org.RTC.ReturnCode_t> InitializeAsync(this LightweightRTObject target )
        {
            return Task.Factory.StartNew(()=>target.initialize());
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> FinalizeAsync(this LightweightRTObject target )
        {
            return Task.Factory.StartNew(()=>target._finalize());
        }
         
        public static Task<System.Boolean> IsAliveAsync(this LightweightRTObject target ,omg.org.RTC.ExecutionContext exec_context)
        {
            return Task.Factory.StartNew(()=>target.is_alive(exec_context));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> ExitAsync(this LightweightRTObject target )
        {
            return Task.Factory.StartNew(()=>target._exit());
        }
         
        public static Task<System.Int32> AttachContextAsync(this LightweightRTObject target ,omg.org.RTC.ExecutionContext exec_context)
        {
            return Task.Factory.StartNew(()=>target.attach_context(exec_context));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> DetachContextAsync(this LightweightRTObject target ,System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>target.detach_context(exec_handle));
        }
         
        public static Task<omg.org.RTC.ExecutionContext> GetContextAsync(this LightweightRTObject target ,System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>target.get_context(exec_handle));
        }
         
        public static Task<omg.org.RTC.ExecutionContext[]> GetOwnedContextsAsync(this LightweightRTObject target )
        {
            return Task.Factory.StartNew(()=>target.get_owned_contexts());
        }
         
        public static Task<omg.org.RTC.ExecutionContext[]> GetParticipatingContextsAsync(this LightweightRTObject target )
        {
            return Task.Factory.StartNew(()=>target.get_participating_contexts());
        }
         
        public static Task<System.Int32> GetContextHandleAsync(this LightweightRTObject target ,omg.org.RTC.ExecutionContext cxt)
        {
            return Task.Factory.StartNew(()=>target.get_context_handle(cxt));
        }
            }
     
    public static class DataFlowComponentActionAsyncExtensions
    {
         
        public static Task<omg.org.RTC.ReturnCode_t> OnExecuteAsync(this DataFlowComponentAction target ,System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>target.on_execute(exec_handle));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> OnStateUpdateAsync(this DataFlowComponentAction target ,System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>target.on_state_update(exec_handle));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> OnRateChangedAsync(this DataFlowComponentAction target ,System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>target.on_rate_changed(exec_handle));
        }
            }
     
    public static class FsmParticipantActionAsyncExtensions
    {
         
        public static Task<omg.org.RTC.ReturnCode_t> OnActionAsync(this FsmParticipantAction target ,System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>target.on_action(exec_handle));
        }
            }
     
    public static class ModeCapableAsyncExtensions
    {
         
        public static Task<omg.org.RTC.Mode> GetDefaultModeAsync(this ModeCapable target )
        {
            return Task.Factory.StartNew(()=>target.get_default_mode());
        }
         
        public static Task<omg.org.RTC.Mode> GetCurrentModeAsync(this ModeCapable target )
        {
            return Task.Factory.StartNew(()=>target.get_current_mode());
        }
         
        public static Task<omg.org.RTC.Mode> GetCurrentModeInContextAsync(this ModeCapable target ,omg.org.RTC.ExecutionContext exec_context)
        {
            return Task.Factory.StartNew(()=>target.get_current_mode_in_context(exec_context));
        }
         
        public static Task<omg.org.RTC.Mode> GetPendingModeAsync(this ModeCapable target )
        {
            return Task.Factory.StartNew(()=>target.get_pending_mode());
        }
         
        public static Task<omg.org.RTC.Mode> GetPendingModeInContextAsync(this ModeCapable target ,omg.org.RTC.ExecutionContext exec_context)
        {
            return Task.Factory.StartNew(()=>target.get_pending_mode_in_context(exec_context));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> SetModeAsync(this ModeCapable target ,omg.org.RTC.Mode new_mode,System.Boolean immediate)
        {
            return Task.Factory.StartNew(()=>target.set_mode(new_mode,immediate));
        }
            }
     
    public static class MultiModeComponentActionAsyncExtensions
    {
         
        public static Task<omg.org.RTC.ReturnCode_t> OnModeChangedAsync(this MultiModeComponentAction target ,System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>target.on_mode_changed(exec_handle));
        }
            }
     
    public static class RTObjectAsyncExtensions
    {
         
        public static Task<omg.org.RTC.ComponentProfile> GetComponentProfileAsync(this RTObject target )
        {
            return Task.Factory.StartNew(()=>target.get_component_profile());
        }
         
        public static Task<omg.org.RTC.PortService[]> GetPortsAsync(this RTObject target )
        {
            return Task.Factory.StartNew(()=>target.get_ports());
        }
            }
     
    public static class PortServiceAsyncExtensions
    {
         
        public static Task<omg.org.RTC.PortProfile> GetPortProfileAsync(this PortService target )
        {
            return Task.Factory.StartNew(()=>target.get_port_profile());
        }
         
        public static Task<omg.org.RTC.ConnectorProfile[]> GetConnectorProfilesAsync(this PortService target )
        {
            return Task.Factory.StartNew(()=>target.get_connector_profiles());
        }
         
        public static Task<omg.org.RTC.ConnectorProfile> GetConnectorProfileAsync(this PortService target ,System.String connector_id)
        {
            return Task.Factory.StartNew(()=>target.get_connector_profile(connector_id));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> ConnectAsync(this PortService target ,omg.org.RTC.ConnectorProfile connector_profile)
        {
            return Task.Factory.StartNew(()=>target.connect(ref connector_profile));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> DisconnectAsync(this PortService target ,System.String connector_id)
        {
            return Task.Factory.StartNew(()=>target.disconnect(connector_id));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> DisconnectAllAsync(this PortService target )
        {
            return Task.Factory.StartNew(()=>target.disconnect_all());
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> NotifyConnectAsync(this PortService target ,omg.org.RTC.ConnectorProfile connector_profile)
        {
            return Task.Factory.StartNew(()=>target.notify_connect(ref connector_profile));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> NotifyDisconnectAsync(this PortService target ,System.String connector_id)
        {
            return Task.Factory.StartNew(()=>target.notify_disconnect(connector_id));
        }
            }
     
    public static class FsmObjectAsyncExtensions
    {
         
        public static Task<omg.org.RTC.ReturnCode_t> SendStimulusAsync(this FsmObject target ,System.String message,System.Int32 exec_handle)
        {
            return Task.Factory.StartNew(()=>target.send_stimulus(message,exec_handle));
        }
            }
     
    public static class FsmServiceAsyncExtensions
    {
         
        public static Task<omg.org.RTC.FsmProfile> GetFsmProfileAsync(this FsmService target )
        {
            return Task.Factory.StartNew(()=>target.get_fsm_profile());
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> SetFsmProfileAsync(this FsmService target ,omg.org.RTC.FsmProfile fsm_profile)
        {
            return Task.Factory.StartNew(()=>target.set_fsm_profile(fsm_profile));
        }
            }
     
    public static class ExecutionContextServiceAsyncExtensions
    {
         
        public static Task<omg.org.RTC.ExecutionContextProfile> GetProfileAsync(this ExecutionContextService target )
        {
            return Task.Factory.StartNew(()=>target.get_profile());
        }
            }
    }
 
namespace OpenRTM
{
     
    public static class ComponentObserverAsyncExtensions
    {
         
        public static Task UpdateStatusAsync(this ComponentObserver target ,OpenRTM.StatusKind status_kind,System.String hint)
        {
            return Task.Factory.StartNew(()=>target.update_status(status_kind,hint));
        }
            }
     
    public static class InPortCdrAsyncExtensions
    {
         
        public static Task<OpenRTM.PortStatus> PutAsync(this InPortCdr target ,System.Byte[] data)
        {
            return Task.Factory.StartNew(()=>target.put(data));
        }
            }
     
    public static class OutPortCdrAsyncExtensions
    {
         
        public static Task<OpenRTM.PortStatus> GetAsync(this OutPortCdr target ,System.Byte[] data)
        {
            return Task.Factory.StartNew(()=>target._get(out data));
        }
            }
     
    public static class LoggerAsyncExtensions
    {
         
        public static Task PublishAsync(this Logger target ,OpenRTM.LogRecord record)
        {
            return Task.Factory.StartNew(()=>target.publish(record));
        }
         
        public static Task CloseAsync(this Logger target )
        {
            return Task.Factory.StartNew(()=>target.close());
        }
            }
    }
 
namespace openrtm.aist.go.jp.OpenRTM
{
     
    public static class ExtTrigExecutionContextServiceAsyncExtensions
    {
         
        public static Task TickAsync(this ExtTrigExecutionContextService target )
        {
            return Task.Factory.StartNew(()=>target.tick());
        }
            }
    }
 
namespace org.omg.SDOPackage
{
     
    public static class SDOAsyncExtensions
    {
         
        public static Task<System.String> GetSdoIdAsync(this SDO target )
        {
            return Task.Factory.StartNew(()=>target.get_sdo_id());
        }
         
        public static Task<System.String> GetSdoTypeAsync(this SDO target )
        {
            return Task.Factory.StartNew(()=>target.get_sdo_type());
        }
         
        public static Task<org.omg.SDOPackage.DeviceProfile> GetDeviceProfileAsync(this SDO target )
        {
            return Task.Factory.StartNew(()=>target.get_device_profile());
        }
         
        public static Task<org.omg.SDOPackage.ServiceProfile[]> GetServiceProfilesAsync(this SDO target )
        {
            return Task.Factory.StartNew(()=>target.get_service_profiles());
        }
         
        public static Task<org.omg.SDOPackage.ServiceProfile> GetServiceProfileAsync(this SDO target ,System.String id)
        {
            return Task.Factory.StartNew(()=>target.get_service_profile(id));
        }
         
        public static Task<org.omg.SDOPackage.SDOService> GetSdoServiceAsync(this SDO target ,System.String id)
        {
            return Task.Factory.StartNew(()=>target.get_sdo_service(id));
        }
         
        public static Task<org.omg.SDOPackage.Configuration> GetConfigurationAsync(this SDO target )
        {
            return Task.Factory.StartNew(()=>target.get_configuration());
        }
         
        public static Task<org.omg.SDOPackage.Monitoring> GetMonitoringAsync(this SDO target )
        {
            return Task.Factory.StartNew(()=>target.get_monitoring());
        }
         
        public static Task<org.omg.SDOPackage.Organization[]> GetOrganizationsAsync(this SDO target )
        {
            return Task.Factory.StartNew(()=>target.get_organizations());
        }
         
        public static Task<org.omg.SDOPackage.NameValue[]> GetStatusListAsync(this SDO target )
        {
            return Task.Factory.StartNew(()=>target.get_status_list());
        }
         
        public static Task<System.Object> GetStatusAsync(this SDO target ,System.String nme)
        {
            return Task.Factory.StartNew(()=>target.get_status(nme));
        }
            }
     
    public static class SDOSystemElementAsyncExtensions
    {
         
        public static Task<org.omg.SDOPackage.Organization[]> GetOwnedOrganizationsAsync(this SDOSystemElement target )
        {
            return Task.Factory.StartNew(()=>target.get_owned_organizations());
        }
            }
     
    public static class ConfigurationAsyncExtensions
    {
         
        public static Task<System.Boolean> SetDeviceProfileAsync(this Configuration target ,org.omg.SDOPackage.DeviceProfile dProfile)
        {
            return Task.Factory.StartNew(()=>target.set_device_profile(dProfile));
        }
         
        public static Task<System.Boolean> AddServiceProfileAsync(this Configuration target ,org.omg.SDOPackage.ServiceProfile sProfile)
        {
            return Task.Factory.StartNew(()=>target.add_service_profile(sProfile));
        }
         
        public static Task<System.Boolean> AddOrganizationAsync(this Configuration target ,org.omg.SDOPackage.Organization organization_object)
        {
            return Task.Factory.StartNew(()=>target.add_organization(organization_object));
        }
         
        public static Task<System.Boolean> RemoveServiceProfileAsync(this Configuration target ,System.String id)
        {
            return Task.Factory.StartNew(()=>target.remove_service_profile(id));
        }
         
        public static Task<System.Boolean> RemoveOrganizationAsync(this Configuration target ,System.String organization_id)
        {
            return Task.Factory.StartNew(()=>target.remove_organization(organization_id));
        }
         
        public static Task<org.omg.SDOPackage.Parameter[]> GetConfigurationParametersAsync(this Configuration target )
        {
            return Task.Factory.StartNew(()=>target.get_configuration_parameters());
        }
         
        public static Task<org.omg.SDOPackage.NameValue[]> GetConfigurationParameterValuesAsync(this Configuration target )
        {
            return Task.Factory.StartNew(()=>target.get_configuration_parameter_values());
        }
         
        public static Task<System.Object> GetConfigurationParameterValueAsync(this Configuration target ,System.String name)
        {
            return Task.Factory.StartNew(()=>target.get_configuration_parameter_value(name));
        }
         
        public static Task<System.Boolean> SetConfigurationParameterAsync(this Configuration target ,System.String name,System.Object value)
        {
            return Task.Factory.StartNew(()=>target.set_configuration_parameter(name,value));
        }
         
        public static Task<org.omg.SDOPackage.ConfigurationSet[]> GetConfigurationSetsAsync(this Configuration target )
        {
            return Task.Factory.StartNew(()=>target.get_configuration_sets());
        }
         
        public static Task<org.omg.SDOPackage.ConfigurationSet> GetConfigurationSetAsync(this Configuration target ,System.String config_id)
        {
            return Task.Factory.StartNew(()=>target.get_configuration_set(config_id));
        }
         
        public static Task<System.Boolean> SetConfigurationSetValuesAsync(this Configuration target ,org.omg.SDOPackage.ConfigurationSet configuration_set)
        {
            return Task.Factory.StartNew(()=>target.set_configuration_set_values(configuration_set));
        }
         
        public static Task<org.omg.SDOPackage.ConfigurationSet> GetActiveConfigurationSetAsync(this Configuration target )
        {
            return Task.Factory.StartNew(()=>target.get_active_configuration_set());
        }
         
        public static Task<System.Boolean> AddConfigurationSetAsync(this Configuration target ,org.omg.SDOPackage.ConfigurationSet configuration_set)
        {
            return Task.Factory.StartNew(()=>target.add_configuration_set(configuration_set));
        }
         
        public static Task<System.Boolean> RemoveConfigurationSetAsync(this Configuration target ,System.String config_id)
        {
            return Task.Factory.StartNew(()=>target.remove_configuration_set(config_id));
        }
         
        public static Task<System.Boolean> ActivateConfigurationSetAsync(this Configuration target ,System.String config_id)
        {
            return Task.Factory.StartNew(()=>target.activate_configuration_set(config_id));
        }
            }
     
    public static class OrganizationAsyncExtensions
    {
         
        public static Task<System.String> GetOrganizationIdAsync(this Organization target )
        {
            return Task.Factory.StartNew(()=>target.get_organization_id());
        }
         
        public static Task<org.omg.SDOPackage.OrganizationProperty> GetOrganizationPropertyAsync(this Organization target )
        {
            return Task.Factory.StartNew(()=>target.get_organization_property());
        }
         
        public static Task<System.Object> GetOrganizationPropertyValueAsync(this Organization target ,System.String name)
        {
            return Task.Factory.StartNew(()=>target.get_organization_property_value(name));
        }
         
        public static Task<System.Boolean> AddOrganizationPropertyAsync(this Organization target ,org.omg.SDOPackage.OrganizationProperty organization_property)
        {
            return Task.Factory.StartNew(()=>target.add_organization_property(organization_property));
        }
         
        public static Task<System.Boolean> SetOrganizationPropertyValueAsync(this Organization target ,System.String name,System.Object value)
        {
            return Task.Factory.StartNew(()=>target.set_organization_property_value(name,value));
        }
         
        public static Task<System.Boolean> RemoveOrganizationPropertyAsync(this Organization target ,System.String name)
        {
            return Task.Factory.StartNew(()=>target.remove_organization_property(name));
        }
         
        public static Task<org.omg.SDOPackage.SDOSystemElement> GetOwnerAsync(this Organization target )
        {
            return Task.Factory.StartNew(()=>target.get_owner());
        }
         
        public static Task<System.Boolean> SetOwnerAsync(this Organization target ,org.omg.SDOPackage.SDOSystemElement sdo)
        {
            return Task.Factory.StartNew(()=>target.set_owner(sdo));
        }
         
        public static Task<org.omg.SDOPackage.SDO[]> GetMembersAsync(this Organization target )
        {
            return Task.Factory.StartNew(()=>target.get_members());
        }
         
        public static Task<System.Boolean> SetMembersAsync(this Organization target ,org.omg.SDOPackage.SDO[] sdos)
        {
            return Task.Factory.StartNew(()=>target.set_members(sdos));
        }
         
        public static Task<System.Boolean> AddMembersAsync(this Organization target ,org.omg.SDOPackage.SDO[] sdo_list)
        {
            return Task.Factory.StartNew(()=>target.add_members(sdo_list));
        }
         
        public static Task<System.Boolean> RemoveMemberAsync(this Organization target ,System.String id)
        {
            return Task.Factory.StartNew(()=>target.remove_member(id));
        }
         
        public static Task<org.omg.SDOPackage.DependencyType> GetDependencyAsync(this Organization target )
        {
            return Task.Factory.StartNew(()=>target.get_dependency());
        }
         
        public static Task<System.Boolean> SetDependencyAsync(this Organization target ,org.omg.SDOPackage.DependencyType dependency)
        {
            return Task.Factory.StartNew(()=>target.set_dependency(dependency));
        }
            }
    }
 
namespace RTC
{
     
    public static class ActArrayAsyncExtensions
    {
         
        public static Task<RTC.ActArrayGeometry> GetGeometryAsync(this ActArray target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
         
        public static Task GoHomeAsync(this ActArray target ,System.Int16 index)
        {
            return Task.Factory.StartNew(()=>target.GoHome(index));
        }
         
        public static Task PowerAsync(this ActArray target ,System.Boolean enable)
        {
            return Task.Factory.StartNew(()=>target.Power(enable));
        }
         
        public static Task BrakesAsync(this ActArray target ,System.Boolean engage)
        {
            return Task.Factory.StartNew(()=>target.Brakes(engage));
        }
         
        public static Task ConfigSpeedAsync(this ActArray target ,System.Int16 index,System.Double speed)
        {
            return Task.Factory.StartNew(()=>target.ConfigSpeed(index,speed));
        }
         
        public static Task ConfigAccelAsync(this ActArray target ,System.Int16 index,System.Double accel)
        {
            return Task.Factory.StartNew(()=>target.ConfigAccel(index,accel));
        }
            }
     
    public static class AIOAsyncExtensions
    {
         
        public static Task<System.Int16> NumChannelsAsync(this AIO target )
        {
            return Task.Factory.StartNew(()=>target.NumChannels());
        }
         
        public static Task SetReferenceLevelAsync(this AIO target ,System.Int16 index,System.Double level)
        {
            return Task.Factory.StartNew(()=>target.SetReferenceLevel(index,level));
        }
         
        public static Task<System.Double> GetResolutionAsync(this AIO target ,System.Int16 index)
        {
            return Task.Factory.StartNew(()=>target.GetResolution(index));
        }
            }
     
    public static class BumperAsyncExtensions
    {
         
        public static Task<RTC.BumperGeometry> GetGeometryAsync(this Bumper target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
            }
     
    public static class CameraAsyncExtensions
    {
         
        public static Task<RTC.Geometry3D> GetGeometryAsync(this Camera target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
         
        public static Task<RTC.CameraInfo> GetCameraInfoAsync(this Camera target )
        {
            return Task.Factory.StartNew(()=>target.GetCameraInfo());
        }
            }
     
    public static class DIOAsyncExtensions
    {
         
        public static Task<System.Int16> NumBitsAsync(this DIO target )
        {
            return Task.Factory.StartNew(()=>target.NumBits());
        }
         
        public static Task<System.Boolean> GetBitAsync(this DIO target ,System.Int16 index)
        {
            return Task.Factory.StartNew(()=>target.GetBit(index));
        }
         
        public static Task SetBitAsync(this DIO target ,System.Int16 index,System.Boolean newValue)
        {
            return Task.Factory.StartNew(()=>target.SetBit(index,newValue));
        }
            }
     
    public static class FiducialAsyncExtensions
    {
         
        public static Task<RTC.Geometry3D> GetGeometryAsync(this Fiducial target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
         
        public static Task<RTC.FiducialFOV> GetFOVAsync(this Fiducial target )
        {
            return Task.Factory.StartNew(()=>target.GetFOV());
        }
         
        public static Task SetFOVAsync(this Fiducial target ,RTC.FiducialFOV newFOV)
        {
            return Task.Factory.StartNew(()=>target.SetFOV(newFOV));
        }
            }
     
    public static class GPSAsyncExtensions
    {
         
        public static Task<RTC.Geometry3D> GetGeometryAsync(this GPS target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
            }
     
    public static class GripperAsyncExtensions
    {
         
        public static Task<RTC.GripperGeometry> GetGeometryAsync(this Gripper target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
         
        public static Task OpenAsync(this Gripper target )
        {
            return Task.Factory.StartNew(()=>target.Open());
        }
         
        public static Task CloseAsync(this Gripper target )
        {
            return Task.Factory.StartNew(()=>target.Close());
        }
            }
     
    public static class IMUAsyncExtensions
    {
         
        public static Task<RTC.Geometry3D> GetGeometryAsync(this IMU target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
            }
     
    public static class INSAsyncExtensions
    {
         
        public static Task<RTC.Geometry3D> GetGeometryAsync(this INS target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
            }
     
    public static class LimbAsyncExtensions
    {
         
        public static Task<RTC.Geometry3D> GetGeometryAsync(this Limb target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
         
        public static Task PowerAsync(this Limb target ,System.Boolean enable)
        {
            return Task.Factory.StartNew(()=>target.Power(enable));
        }
         
        public static Task BrakesAsync(this Limb target ,System.Boolean engage)
        {
            return Task.Factory.StartNew(()=>target.Brakes(engage));
        }
         
        public static Task SetSpeedAsync(this Limb target ,System.Double speed)
        {
            return Task.Factory.StartNew(()=>target.SetSpeed(speed));
        }
            }
     
    public static class OGMapAsyncExtensions
    {
         
        public static Task<RTC.OGMapConfig> GetConfigAsync(this OGMap target )
        {
            return Task.Factory.StartNew(()=>target.GetConfig());
        }
         
        public static Task<RTC.OGMapTile> GetTileAsync(this OGMap target ,RTC.OGMapTile tile)
        {
            return Task.Factory.StartNew(()=>target.GetTile(tile));
        }
            }
     
    public static class MulticameraAsyncExtensions
    {
         
        public static Task<RTC.MulticameraGeometry> GetGeometryAsync(this Multicamera target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
         
        public static Task<RTC.CameraInfo[]> GetCameraInfosAsync(this Multicamera target )
        {
            return Task.Factory.StartNew(()=>target.GetCameraInfos());
        }
            }
     
    public static class PanTiltAsyncExtensions
    {
         
        public static Task<RTC.Geometry3D> GetGeometryAsync(this PanTilt target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
            }
     
    public static class PathPlanner2DAsyncExtensions
    {
         
        public static Task SetTaskAsync(this PathPlanner2D target ,RTC.Waypoint2D[] coarsePath)
        {
            return Task.Factory.StartNew(()=>target.SetTask(coarsePath));
        }
            }
     
    public static class PathPlanner3DAsyncExtensions
    {
         
        public static Task SetTaskAsync(this PathPlanner3D target ,RTC.Waypoint3D[] coarsePath)
        {
            return Task.Factory.StartNew(()=>target.SetTask(coarsePath));
        }
            }
     
    public static class PathFollower2DAsyncExtensions
    {
         
        public static Task SetPathAsync(this PathFollower2D target ,RTC.Waypoint2D[] path)
        {
            return Task.Factory.StartNew(()=>target.SetPath(path));
        }
         
        public static Task EnableAsync(this PathFollower2D target ,System.Boolean enable)
        {
            return Task.Factory.StartNew(()=>target.Enable(enable));
        }
         
        public static Task<System.Int16> GetCurrentWaypointIndexAsync(this PathFollower2D target )
        {
            return Task.Factory.StartNew(()=>target.GetCurrentWaypointIndex());
        }
         
        public static Task<RTC.Waypoint2D> GetCurrentWaypointAsync(this PathFollower2D target )
        {
            return Task.Factory.StartNew(()=>target.GetCurrentWaypoint());
        }
            }
     
    public static class PathFollower3DAsyncExtensions
    {
         
        public static Task SetPathAsync(this PathFollower3D target ,RTC.Waypoint3D[] path)
        {
            return Task.Factory.StartNew(()=>target.SetPath(path));
        }
         
        public static Task EnableAsync(this PathFollower3D target ,System.Boolean enable)
        {
            return Task.Factory.StartNew(()=>target.Enable(enable));
        }
         
        public static Task<System.Int16> GetCurrentWaypointIndexAsync(this PathFollower3D target )
        {
            return Task.Factory.StartNew(()=>target.GetCurrentWaypointIndex());
        }
         
        public static Task<RTC.Waypoint3D> GetCurrentWaypointAsync(this PathFollower3D target )
        {
            return Task.Factory.StartNew(()=>target.GetCurrentWaypoint());
        }
            }
     
    public static class PointCloudServicesAsyncExtensions
    {
         
        public static Task<RTC.Geometry3D> GetGeometryAsync(this PointCloudServices target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
            }
     
    public static class Odometry2DAsyncExtensions
    {
         
        public static Task<RTC.Geometry3D> GetGeometryAsync(this Odometry2D target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
         
        public static Task SetOdometryAsync(this Odometry2D target ,RTC.Pose2D newOdometry)
        {
            return Task.Factory.StartNew(()=>target.SetOdometry(newOdometry));
        }
            }
     
    public static class Odometry3DAsyncExtensions
    {
         
        public static Task<RTC.Geometry3D> GetGeometryAsync(this Odometry3D target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
         
        public static Task SetOdometryAsync(this Odometry3D target ,RTC.Pose3D newOdometry)
        {
            return Task.Factory.StartNew(()=>target.SetOdometry(newOdometry));
        }
            }
     
    public static class VelocityControl2DAsyncExtensions
    {
         
        public static Task<RTC.Geometry2D> GetGeometryAsync(this VelocityControl2D target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
            }
     
    public static class VelocityControl3DAsyncExtensions
    {
         
        public static Task<RTC.Geometry3D> GetGeometryAsync(this VelocityControl3D target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
            }
     
    public static class PoseControl2DAsyncExtensions
    {
         
        public static Task<RTC.Geometry2D> GetGeometryAsync(this PoseControl2D target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
            }
     
    public static class PoseControl3DAsyncExtensions
    {
         
        public static Task<RTC.Geometry3D> GetGeometryAsync(this PoseControl3D target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
            }
     
    public static class CarlikeControlAsyncExtensions
    {
         
        public static Task<RTC.Geometry2D> GetGeometryAsync(this CarlikeControl target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
            }
     
    public static class HeadingControl2DAsyncExtensions
    {
         
        public static Task<RTC.Geometry2D> GetGeometryAsync(this HeadingControl2D target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
            }
     
    public static class HeadingControl3DAsyncExtensions
    {
         
        public static Task<RTC.Geometry3D> GetGeometryAsync(this HeadingControl3D target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
            }
     
    public static class RangerAsyncExtensions
    {
         
        public static Task<RTC.RangerGeometry> GetGeometryAsync(this Ranger target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
         
        public static Task PowerAsync(this Ranger target ,System.Boolean enable)
        {
            return Task.Factory.StartNew(()=>target.Power(enable));
        }
         
        public static Task EnableIntensitiesAsync(this Ranger target ,System.Boolean enable)
        {
            return Task.Factory.StartNew(()=>target.EnableIntensities(enable));
        }
         
        public static Task<RTC.RangerConfig> GetConfigAsync(this Ranger target )
        {
            return Task.Factory.StartNew(()=>target.GetConfig());
        }
         
        public static Task SetConfigAsync(this Ranger target ,RTC.RangerConfig newConfig)
        {
            return Task.Factory.StartNew(()=>target.SetConfig(newConfig));
        }
            }
     
    public static class RFIDAsyncExtensions
    {
         
        public static Task<RTC.Geometry3D> GetGeometryAsync(this RFID target )
        {
            return Task.Factory.StartNew(()=>target.GetGeometry());
        }
         
        public static Task WriteAsync(this RFID target ,System.String GUID,System.Byte[] data)
        {
            return Task.Factory.StartNew(()=>target.Write(GUID,data));
        }
         
        public static Task<System.Byte[]> ReadAsync(this RFID target ,System.String GUID)
        {
            return Task.Factory.StartNew(()=>target.Read(GUID));
        }
            }
    }
 
namespace RTM
{
     
    public static class ManagerAsyncExtensions
    {
         
        public static Task<omg.org.RTC.ReturnCode_t> LoadModuleAsync(this Manager target ,System.String pathname,System.String initfunc)
        {
            return Task.Factory.StartNew(()=>target.load_module(pathname,initfunc));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> UnloadModuleAsync(this Manager target ,System.String pathname)
        {
            return Task.Factory.StartNew(()=>target.unload_module(pathname));
        }
         
        public static Task<RTM.ModuleProfile[]> GetLoadableModulesAsync(this Manager target )
        {
            return Task.Factory.StartNew(()=>target.get_loadable_modules());
        }
         
        public static Task<RTM.ModuleProfile[]> GetLoadedModulesAsync(this Manager target )
        {
            return Task.Factory.StartNew(()=>target.get_loaded_modules());
        }
         
        public static Task<RTM.ModuleProfile[]> GetFactoryProfilesAsync(this Manager target )
        {
            return Task.Factory.StartNew(()=>target.get_factory_profiles());
        }
         
        public static Task<omg.org.RTC.RTObject> CreateComponentAsync(this Manager target ,System.String module_name)
        {
            return Task.Factory.StartNew(()=>target.create_component(module_name));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> DeleteComponentAsync(this Manager target ,System.String instance_name)
        {
            return Task.Factory.StartNew(()=>target.delete_component(instance_name));
        }
         
        public static Task<omg.org.RTC.RTObject[]> GetComponentsAsync(this Manager target )
        {
            return Task.Factory.StartNew(()=>target.get_components());
        }
         
        public static Task<omg.org.RTC.ComponentProfile[]> GetComponentProfilesAsync(this Manager target )
        {
            return Task.Factory.StartNew(()=>target.get_component_profiles());
        }
         
        public static Task<RTM.ManagerProfile> GetProfileAsync(this Manager target )
        {
            return Task.Factory.StartNew(()=>target.get_profile());
        }
         
        public static Task<org.omg.SDOPackage.NameValue[]> GetConfigurationAsync(this Manager target )
        {
            return Task.Factory.StartNew(()=>target.get_configuration());
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> SetConfigurationAsync(this Manager target ,System.String name,System.String value)
        {
            return Task.Factory.StartNew(()=>target.set_configuration(name,value));
        }
         
        public static Task<System.Boolean> IsMasterAsync(this Manager target )
        {
            return Task.Factory.StartNew(()=>target.is_master());
        }
         
        public static Task<RTM.Manager[]> GetMasterManagersAsync(this Manager target )
        {
            return Task.Factory.StartNew(()=>target.get_master_managers());
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> AddMasterManagerAsync(this Manager target ,RTM.Manager mgr)
        {
            return Task.Factory.StartNew(()=>target.add_master_manager(mgr));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> RemoveMasterManagerAsync(this Manager target ,RTM.Manager mgr)
        {
            return Task.Factory.StartNew(()=>target.remove_master_manager(mgr));
        }
         
        public static Task<RTM.Manager[]> GetSlaveManagersAsync(this Manager target )
        {
            return Task.Factory.StartNew(()=>target.get_slave_managers());
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> AddSlaveManagerAsync(this Manager target ,RTM.Manager mgr)
        {
            return Task.Factory.StartNew(()=>target.add_slave_manager(mgr));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> RemoveSlaveManagerAsync(this Manager target ,RTM.Manager mgr)
        {
            return Task.Factory.StartNew(()=>target.remove_slave_manager(mgr));
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> ForkAsync(this Manager target )
        {
            return Task.Factory.StartNew(()=>target.fork());
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> ShutdownAsync(this Manager target )
        {
            return Task.Factory.StartNew(()=>target.shutdown());
        }
         
        public static Task<omg.org.RTC.ReturnCode_t> RestartAsync(this Manager target )
        {
            return Task.Factory.StartNew(()=>target.restart());
        }
         
        public static Task<System.MarshalByRefObject> GetServiceAsync(this Manager target ,System.String name)
        {
            return Task.Factory.StartNew(()=>target.get_service(name));
        }
            }
    }

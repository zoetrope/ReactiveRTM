using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading.Tasks;
using ReactiveRTM.Corba;
using ReactiveRTM.Extensions;

 
namespace ReactiveRTM.CORBA
{
    public interface TypeCode 
    {
        System.Boolean Equal(ReactiveRTM.CORBA.TypeCode tc);
        System.Boolean Equivalent(ReactiveRTM.CORBA.TypeCode tc);
        ReactiveRTM.CORBA.TypeCode GetCompactTypecode();
        ReactiveRTM.CORBA.TCKind Kind();
        System.String Id();
        System.String Name();
        System.Int32 MemberCount();
        System.String MemberName(System.Int32 index);
        ReactiveRTM.CORBA.TypeCode MemberType(System.Int32 index);
        System.Object MemberLabel(System.Int32 index);
        ReactiveRTM.CORBA.TypeCode DiscriminatorType();
        System.Int32 DefaultIndex();
        System.Int32 Length();
        ReactiveRTM.CORBA.TypeCode ContentType();
        System.Int16 MemberVisibility(System.Int32 index);
        System.Int16 TypeModifier();
        ReactiveRTM.CORBA.TypeCode ConcreteBaseType();
    }
}
 
namespace ReactiveRTM.OpenRTM
{
    public interface ComponentObserver : ReactiveRTM.SDOPackage.SDOService
    {
        void UpdateStatus(ReactiveRTM.OpenRTM.StatusKind statusKind,System.String hint);
    }
    public interface InPortCdr 
    {
        ReactiveRTM.OpenRTM.PortStatus Put(List<System.Byte> data);
    }
    public interface OutPortCdr 
    {
        ReactiveRTM.OpenRTM.PortStatus Get(out List<System.Byte> data);
    }
    public interface Logger : ReactiveRTM.SDOPackage.SDOService
    {
        void Publish(ReactiveRTM.OpenRTM.LogRecord record);
        void Close();
    }
}
 
namespace ReactiveRTM.OpenRTM
{
    public interface DataFlowComponent : ReactiveRTM.RTC.RTObject,ReactiveRTM.RTC.LightweightRTObject,ReactiveRTM.RTC.ComponentAction,ReactiveRTM.SDOPackage.SDO,ReactiveRTM.SDOPackage.SDOSystemElement,ReactiveRTM.RTC.DataFlowComponent,ReactiveRTM.RTC.DataFlowComponentAction
    {
    }
    public interface ExtTrigExecutionContextService : ReactiveRTM.RTC.ExecutionContextService,ReactiveRTM.RTC.ExecutionContext,ReactiveRTM.SDOPackage.SDOService
    {
        void Tick();
    }
}
 
namespace ReactiveRTM.RTC
{
    public interface ExecutionContext 
    {
        System.Boolean IsRunning();
        ReactiveRTM.RTC.ReturnCode_t Start();
        ReactiveRTM.RTC.ReturnCode_t Stop();
        System.Double GetRate();
        ReactiveRTM.RTC.ReturnCode_t SetRate(System.Double rate);
        ReactiveRTM.RTC.ReturnCode_t AddComponent(ReactiveRTM.RTC.LightweightRTObject comp);
        ReactiveRTM.RTC.ReturnCode_t RemoveComponent(ReactiveRTM.RTC.LightweightRTObject comp);
        ReactiveRTM.RTC.ReturnCode_t ActivateComponent(ReactiveRTM.RTC.LightweightRTObject comp);
        ReactiveRTM.RTC.ReturnCode_t DeactivateComponent(ReactiveRTM.RTC.LightweightRTObject comp);
        ReactiveRTM.RTC.ReturnCode_t ResetComponent(ReactiveRTM.RTC.LightweightRTObject comp);
        ReactiveRTM.RTC.LifeCycleState GetComponentState(ReactiveRTM.RTC.LightweightRTObject comp);
        ReactiveRTM.RTC.ExecutionKind GetKind();
    }
    public interface ComponentAction 
    {
        ReactiveRTM.RTC.ReturnCode_t OnInitialize();
        ReactiveRTM.RTC.ReturnCode_t OnFinalize();
        ReactiveRTM.RTC.ReturnCode_t OnStartup(System.Int32 execHandle);
        ReactiveRTM.RTC.ReturnCode_t OnShutdown(System.Int32 execHandle);
        ReactiveRTM.RTC.ReturnCode_t OnActivated(System.Int32 execHandle);
        ReactiveRTM.RTC.ReturnCode_t OnDeactivated(System.Int32 execHandle);
        ReactiveRTM.RTC.ReturnCode_t OnAborting(System.Int32 execHandle);
        ReactiveRTM.RTC.ReturnCode_t OnError(System.Int32 execHandle);
        ReactiveRTM.RTC.ReturnCode_t OnReset(System.Int32 execHandle);
    }
    public interface LightweightRTObject : ReactiveRTM.RTC.ComponentAction
    {
        ReactiveRTM.RTC.ReturnCode_t Initialize();
        ReactiveRTM.RTC.ReturnCode_t Finalize();
        System.Boolean IsAlive(ReactiveRTM.RTC.ExecutionContext execContext);
        ReactiveRTM.RTC.ReturnCode_t Exit();
        System.Int32 AttachContext(ReactiveRTM.RTC.ExecutionContext execContext);
        ReactiveRTM.RTC.ReturnCode_t DetachContext(System.Int32 execHandle);
        ReactiveRTM.RTC.ExecutionContext GetContext(System.Int32 execHandle);
        List<ReactiveRTM.RTC.ExecutionContext> GetOwnedContexts();
        List<ReactiveRTM.RTC.ExecutionContext> GetParticipatingContexts();
        System.Int32 GetContextHandle(ReactiveRTM.RTC.ExecutionContext cxt);
    }
    public interface DataFlowComponentAction 
    {
        ReactiveRTM.RTC.ReturnCode_t OnExecute(System.Int32 execHandle);
        ReactiveRTM.RTC.ReturnCode_t OnStateUpdate(System.Int32 execHandle);
        ReactiveRTM.RTC.ReturnCode_t OnRateChanged(System.Int32 execHandle);
    }
    public interface DataFlowComponent : ReactiveRTM.RTC.LightweightRTObject,ReactiveRTM.RTC.ComponentAction,ReactiveRTM.RTC.DataFlowComponentAction
    {
    }
    public interface Fsm : ReactiveRTM.RTC.LightweightRTObject,ReactiveRTM.RTC.ComponentAction
    {
    }
    public interface FsmParticipantAction 
    {
        ReactiveRTM.RTC.ReturnCode_t OnAction(System.Int32 execHandle);
    }
    public interface FsmParticipant : ReactiveRTM.RTC.LightweightRTObject,ReactiveRTM.RTC.ComponentAction,ReactiveRTM.RTC.FsmParticipantAction
    {
    }
    public interface Mode 
    {
    }
    public interface ModeCapable 
    {
        ReactiveRTM.RTC.Mode GetDefaultMode();
        ReactiveRTM.RTC.Mode GetCurrentMode();
        ReactiveRTM.RTC.Mode GetCurrentModeInContext(ReactiveRTM.RTC.ExecutionContext execContext);
        ReactiveRTM.RTC.Mode GetPendingMode();
        ReactiveRTM.RTC.Mode GetPendingModeInContext(ReactiveRTM.RTC.ExecutionContext execContext);
        ReactiveRTM.RTC.ReturnCode_t SetMode(ReactiveRTM.RTC.Mode newMode,System.Boolean immediate);
    }
    public interface MultiModeComponentAction 
    {
        ReactiveRTM.RTC.ReturnCode_t OnModeChanged(System.Int32 execHandle);
    }
    public interface MultiModeObject : ReactiveRTM.RTC.LightweightRTObject,ReactiveRTM.RTC.ComponentAction,ReactiveRTM.RTC.ModeCapable,ReactiveRTM.RTC.MultiModeComponentAction
    {
    }
    public interface RTObject : ReactiveRTM.RTC.LightweightRTObject,ReactiveRTM.RTC.ComponentAction,ReactiveRTM.SDOPackage.SDO,ReactiveRTM.SDOPackage.SDOSystemElement
    {
        ReactiveRTM.RTC.ComponentProfile GetComponentProfile();
        List<ReactiveRTM.RTC.PortService> GetPorts();
    }
    public interface PortService : ReactiveRTM.SDOPackage.SDOService
    {
        ReactiveRTM.RTC.PortProfile GetPortProfile();
        List<ReactiveRTM.RTC.ConnectorProfile> GetConnectorProfiles();
        ReactiveRTM.RTC.ConnectorProfile GetConnectorProfile(System.String connectorId);
        ReactiveRTM.RTC.ReturnCode_t Connect(ref ReactiveRTM.RTC.ConnectorProfile connectorProfile);
        ReactiveRTM.RTC.ReturnCode_t Disconnect(System.String connectorId);
        ReactiveRTM.RTC.ReturnCode_t DisconnectAll();
        ReactiveRTM.RTC.ReturnCode_t NotifyConnect(ref ReactiveRTM.RTC.ConnectorProfile connectorProfile);
        ReactiveRTM.RTC.ReturnCode_t NotifyDisconnect(System.String connectorId);
    }
    public interface FsmObject 
    {
        ReactiveRTM.RTC.ReturnCode_t SendStimulus(System.String message,System.Int32 execHandle);
    }
    public interface FsmService : ReactiveRTM.SDOPackage.SDOService
    {
        ReactiveRTM.RTC.FsmProfile GetFsmProfile();
        ReactiveRTM.RTC.ReturnCode_t SetFsmProfile(ReactiveRTM.RTC.FsmProfile fsmProfile);
    }
    public interface ExecutionContextService : ReactiveRTM.RTC.ExecutionContext,ReactiveRTM.SDOPackage.SDOService
    {
        ReactiveRTM.RTC.ExecutionContextProfile GetProfile();
    }
}
 
namespace ReactiveRTM.RTC
{
    public interface ActArray 
    {
        ReactiveRTM.RTC.ActArrayGeometry GetGeometry();
        void GoHome(System.Int16 index);
        void Power(System.Boolean enable);
        void Brakes(System.Boolean engage);
        void ConfigSpeed(System.Int16 index,System.Double speed);
        void ConfigAccel(System.Int16 index,System.Double accel);
    }
    public interface AIO 
    {
        System.Int16 NumChannels();
        void SetReferenceLevel(System.Int16 index,System.Double level);
        System.Double GetResolution(System.Int16 index);
    }
    public interface Bumper 
    {
        ReactiveRTM.RTC.BumperGeometry GetGeometry();
    }
    public interface Camera 
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
        ReactiveRTM.RTC.CameraInfo GetCameraInfo();
    }
    public interface DIO 
    {
        System.Int16 NumBits();
        System.Boolean GetBit(System.Int16 index);
        void SetBit(System.Int16 index,System.Boolean newValue);
    }
    public interface Fiducial 
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
        ReactiveRTM.RTC.FiducialFOV GetFOV();
        void SetFOV(ReactiveRTM.RTC.FiducialFOV newFOV);
    }
    public interface GPS 
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
    }
    public interface Gripper 
    {
        ReactiveRTM.RTC.GripperGeometry GetGeometry();
        void Open();
        void Close();
    }
    public interface IMU 
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
    }
    public interface INS 
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
    }
    public interface Limb 
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
        void Power(System.Boolean enable);
        void Brakes(System.Boolean engage);
        void SetSpeed(System.Double speed);
    }
    public interface OGMap 
    {
        ReactiveRTM.RTC.OGMapConfig GetConfig();
        ReactiveRTM.RTC.OGMapTile GetTile(ReactiveRTM.RTC.OGMapTile tile);
    }
    public interface Multicamera 
    {
        ReactiveRTM.RTC.MulticameraGeometry GetGeometry();
        List<ReactiveRTM.RTC.CameraInfo> GetCameraInfos();
    }
    public interface PanTilt 
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
    }
    public interface PathPlanner2D 
    {
        void SetTask(List<ReactiveRTM.RTC.Waypoint2D> coarsePath);
    }
    public interface PathPlanner3D 
    {
        void SetTask(List<ReactiveRTM.RTC.Waypoint3D> coarsePath);
    }
    public interface PathFollower2D 
    {
        void SetPath(List<ReactiveRTM.RTC.Waypoint2D> path);
        void Enable(System.Boolean enable);
        System.Int16 GetCurrentWaypointIndex();
        ReactiveRTM.RTC.Waypoint2D GetCurrentWaypoint();
    }
    public interface PathFollower3D 
    {
        void SetPath(List<ReactiveRTM.RTC.Waypoint3D> path);
        void Enable(System.Boolean enable);
        System.Int16 GetCurrentWaypointIndex();
        ReactiveRTM.RTC.Waypoint3D GetCurrentWaypoint();
    }
    public interface PointCloudServices 
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
    }
    public interface Odometry2D 
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
        void SetOdometry(ReactiveRTM.RTC.Pose2D newOdometry);
    }
    public interface Odometry3D 
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
        void SetOdometry(ReactiveRTM.RTC.Pose3D newOdometry);
    }
    public interface VelocityControl2D 
    {
        ReactiveRTM.RTC.Geometry2D GetGeometry();
    }
    public interface VelocityControl3D 
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
    }
    public interface PoseControl2D 
    {
        ReactiveRTM.RTC.Geometry2D GetGeometry();
    }
    public interface PoseControl3D 
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
    }
    public interface CarlikeControl 
    {
        ReactiveRTM.RTC.Geometry2D GetGeometry();
    }
    public interface HeadingControl2D 
    {
        ReactiveRTM.RTC.Geometry2D GetGeometry();
    }
    public interface HeadingControl3D 
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
    }
    public interface Ranger 
    {
        ReactiveRTM.RTC.RangerGeometry GetGeometry();
        void Power(System.Boolean enable);
        void EnableIntensities(System.Boolean enable);
        ReactiveRTM.RTC.RangerConfig GetConfig();
        void SetConfig(ReactiveRTM.RTC.RangerConfig newConfig);
    }
    public interface RFID 
    {
        ReactiveRTM.RTC.Geometry3D GetGeometry();
        void Write(System.String GUID,List<System.Byte> data);
        List<System.Byte> Read(System.String GUID);
    }
}
 
namespace ReactiveRTM.RTM
{
    public interface Manager 
    {
        ReactiveRTM.RTC.ReturnCode_t LoadModule(System.String pathname,System.String initfunc);
        ReactiveRTM.RTC.ReturnCode_t UnloadModule(System.String pathname);
        List<ReactiveRTM.RTM.ModuleProfile> GetLoadableModules();
        List<ReactiveRTM.RTM.ModuleProfile> GetLoadedModules();
        List<ReactiveRTM.RTM.ModuleProfile> GetFactoryProfiles();
        ReactiveRTM.RTC.RTObject CreateComponent(System.String moduleName);
        ReactiveRTM.RTC.ReturnCode_t DeleteComponent(System.String instanceName);
        List<ReactiveRTM.RTC.RTObject> GetComponents();
        List<ReactiveRTM.RTC.ComponentProfile> GetComponentProfiles();
        ReactiveRTM.RTM.ManagerProfile GetProfile();
        Dictionary<string,object> GetConfiguration();
        ReactiveRTM.RTC.ReturnCode_t SetConfiguration(System.String name,System.String value);
        System.Boolean IsMaster();
        List<ReactiveRTM.RTM.Manager> GetMasterManagers();
        ReactiveRTM.RTC.ReturnCode_t AddMasterManager(ReactiveRTM.RTM.Manager mgr);
        ReactiveRTM.RTC.ReturnCode_t RemoveMasterManager(ReactiveRTM.RTM.Manager mgr);
        List<ReactiveRTM.RTM.Manager> GetSlaveManagers();
        ReactiveRTM.RTC.ReturnCode_t AddSlaveManager(ReactiveRTM.RTM.Manager mgr);
        ReactiveRTM.RTC.ReturnCode_t RemoveSlaveManager(ReactiveRTM.RTM.Manager mgr);
        ReactiveRTM.RTC.ReturnCode_t Fork();
        ReactiveRTM.RTC.ReturnCode_t Shutdown();
        ReactiveRTM.RTC.ReturnCode_t Restart();
        System.Object GetService(System.String name);
    }
}
 
namespace ReactiveRTM.SDOPackage
{
    public interface SDO : ReactiveRTM.SDOPackage.SDOSystemElement
    {
        System.String GetSdoId();
        System.String GetSdoType();
        ReactiveRTM.SDOPackage.DeviceProfile GetDeviceProfile();
        List<ReactiveRTM.SDOPackage.ServiceProfile> GetServiceProfiles();
        ReactiveRTM.SDOPackage.ServiceProfile GetServiceProfile(System.String id);
        ReactiveRTM.SDOPackage.SDOService GetSdoService(System.String id);
        ReactiveRTM.SDOPackage.Configuration GetConfiguration();
        ReactiveRTM.SDOPackage.Monitoring GetMonitoring();
        List<ReactiveRTM.SDOPackage.Organization> GetOrganizations();
        Dictionary<string,object> GetStatusList();
        System.Object GetStatus(System.String nme);
    }
    public interface SDOService 
    {
    }
    public interface SDOSystemElement 
    {
        List<ReactiveRTM.SDOPackage.Organization> GetOwnedOrganizations();
    }
    public interface Configuration 
    {
        System.Boolean SetDeviceProfile(ReactiveRTM.SDOPackage.DeviceProfile dProfile);
        System.Boolean AddServiceProfile(ReactiveRTM.SDOPackage.ServiceProfile sProfile);
        System.Boolean AddOrganization(ReactiveRTM.SDOPackage.Organization organizationObject);
        System.Boolean RemoveServiceProfile(System.String id);
        System.Boolean RemoveOrganization(System.String organizationId);
        List<ReactiveRTM.SDOPackage.Parameter> GetConfigurationParameters();
        Dictionary<string,object> GetConfigurationParameterValues();
        System.Object GetConfigurationParameterValue(System.String name);
        System.Boolean SetConfigurationParameter(System.String name,System.Object value);
        List<ReactiveRTM.SDOPackage.ConfigurationSet> GetConfigurationSets();
        ReactiveRTM.SDOPackage.ConfigurationSet GetConfigurationSet(System.String configId);
        System.Boolean SetConfigurationSetValues(ReactiveRTM.SDOPackage.ConfigurationSet configurationSet);
        ReactiveRTM.SDOPackage.ConfigurationSet GetActiveConfigurationSet();
        System.Boolean AddConfigurationSet(ReactiveRTM.SDOPackage.ConfigurationSet configurationSet);
        System.Boolean RemoveConfigurationSet(System.String configId);
        System.Boolean ActivateConfigurationSet(System.String configId);
    }
    public interface Monitoring 
    {
    }
    public interface Organization 
    {
        System.String GetOrganizationId();
        ReactiveRTM.SDOPackage.OrganizationProperty GetOrganizationProperty();
        System.Object GetOrganizationPropertyValue(System.String name);
        System.Boolean AddOrganizationProperty(ReactiveRTM.SDOPackage.OrganizationProperty organizationProperty);
        System.Boolean SetOrganizationPropertyValue(System.String name,System.Object value);
        System.Boolean RemoveOrganizationProperty(System.String name);
        ReactiveRTM.SDOPackage.SDOSystemElement GetOwner();
        System.Boolean SetOwner(ReactiveRTM.SDOPackage.SDOSystemElement sdo);
        List<ReactiveRTM.SDOPackage.SDO> GetMembers();
        System.Boolean SetMembers(List<ReactiveRTM.SDOPackage.SDO> sdos);
        System.Boolean AddMembers(List<ReactiveRTM.SDOPackage.SDO> sdoList);
        System.Boolean RemoveMember(System.String id);
        ReactiveRTM.SDOPackage.DependencyType GetDependency();
        System.Boolean SetDependency(ReactiveRTM.SDOPackage.DependencyType dependency);
    }
}

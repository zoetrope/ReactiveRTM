using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading.Tasks;
using ReactiveRTM.Corba;
using ReactiveRTM.Generated;

 
namespace ReactiveRTM.omg.org.CORBA
{
    public interface TypeCode 
    {
        System.Boolean Equal(ReactiveRTM.omg.org.CORBA.TypeCode tc);
        System.Boolean Equivalent(ReactiveRTM.omg.org.CORBA.TypeCode tc);
        ReactiveRTM.omg.org.CORBA.TypeCode GetCompactTypecode();
        ReactiveRTM.omg.org.CORBA.TCKind Kind();
        System.String Id();
        System.String Name();
        System.Int32 MemberCount();
        System.String MemberName(System.Int32 index);
        ReactiveRTM.omg.org.CORBA.TypeCode MemberType(System.Int32 index);
        System.Object MemberLabel(System.Int32 index);
        ReactiveRTM.omg.org.CORBA.TypeCode DiscriminatorType();
        System.Int32 DefaultIndex();
        System.Int32 Length();
        ReactiveRTM.omg.org.CORBA.TypeCode ContentType();
        System.Int16 MemberVisibility(System.Int32 index);
        System.Int16 TypeModifier();
        ReactiveRTM.omg.org.CORBA.TypeCode ConcreteBaseType();
    }
}
 
namespace ReactiveRTM.omg.org.RTC
{
    public interface ExecutionContext 
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
    public interface ComponentAction 
    {
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnInitialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnFinalize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnStartup(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnActivated(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnAborting(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnError(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnReset(System.Int32 execHandle);
    }
    public interface LightweightRTObject : ReactiveRTM.omg.org.RTC.ComponentAction
    {
        ReactiveRTM.omg.org.RTC.ReturnCode_t Initialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Finalize();
        System.Boolean IsAlive(ReactiveRTM.omg.org.RTC.ExecutionContext execContext);
        ReactiveRTM.omg.org.RTC.ReturnCode_t Exit();
        System.Int32 AttachContext(ReactiveRTM.omg.org.RTC.ExecutionContext execContext);
        ReactiveRTM.omg.org.RTC.ReturnCode_t DetachContext(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ExecutionContext GetContext(System.Int32 execHandle);
        List<ReactiveRTM.omg.org.RTC.ExecutionContext> GetOwnedContexts();
        List<ReactiveRTM.omg.org.RTC.ExecutionContext> GetParticipatingContexts();
        System.Int32 GetContextHandle(ReactiveRTM.omg.org.RTC.ExecutionContext cxt);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnInitialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnFinalize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnStartup(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnActivated(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnAborting(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnError(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnReset(System.Int32 execHandle);
    }
    public interface DataFlowComponentAction 
    {
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnExecute(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnStateUpdate(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnRateChanged(System.Int32 execHandle);
    }
    public interface DataFlowComponent : ReactiveRTM.omg.org.RTC.LightweightRTObject,ReactiveRTM.omg.org.RTC.ComponentAction,ReactiveRTM.omg.org.RTC.DataFlowComponentAction
    {
        ReactiveRTM.omg.org.RTC.ReturnCode_t Initialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Finalize();
        System.Boolean IsAlive(ReactiveRTM.omg.org.RTC.ExecutionContext execContext);
        ReactiveRTM.omg.org.RTC.ReturnCode_t Exit();
        System.Int32 AttachContext(ReactiveRTM.omg.org.RTC.ExecutionContext execContext);
        ReactiveRTM.omg.org.RTC.ReturnCode_t DetachContext(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ExecutionContext GetContext(System.Int32 execHandle);
        List<ReactiveRTM.omg.org.RTC.ExecutionContext> GetOwnedContexts();
        List<ReactiveRTM.omg.org.RTC.ExecutionContext> GetParticipatingContexts();
        System.Int32 GetContextHandle(ReactiveRTM.omg.org.RTC.ExecutionContext cxt);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnInitialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnFinalize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnStartup(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnActivated(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnAborting(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnError(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnReset(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnExecute(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnStateUpdate(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnRateChanged(System.Int32 execHandle);
    }
    public interface Fsm : ReactiveRTM.omg.org.RTC.LightweightRTObject,ReactiveRTM.omg.org.RTC.ComponentAction
    {
        ReactiveRTM.omg.org.RTC.ReturnCode_t Initialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Finalize();
        System.Boolean IsAlive(ReactiveRTM.omg.org.RTC.ExecutionContext execContext);
        ReactiveRTM.omg.org.RTC.ReturnCode_t Exit();
        System.Int32 AttachContext(ReactiveRTM.omg.org.RTC.ExecutionContext execContext);
        ReactiveRTM.omg.org.RTC.ReturnCode_t DetachContext(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ExecutionContext GetContext(System.Int32 execHandle);
        List<ReactiveRTM.omg.org.RTC.ExecutionContext> GetOwnedContexts();
        List<ReactiveRTM.omg.org.RTC.ExecutionContext> GetParticipatingContexts();
        System.Int32 GetContextHandle(ReactiveRTM.omg.org.RTC.ExecutionContext cxt);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnInitialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnFinalize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnStartup(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnActivated(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnAborting(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnError(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnReset(System.Int32 execHandle);
    }
    public interface FsmParticipantAction 
    {
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnAction(System.Int32 execHandle);
    }
    public interface FsmParticipant : ReactiveRTM.omg.org.RTC.LightweightRTObject,ReactiveRTM.omg.org.RTC.ComponentAction,ReactiveRTM.omg.org.RTC.FsmParticipantAction
    {
        ReactiveRTM.omg.org.RTC.ReturnCode_t Initialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Finalize();
        System.Boolean IsAlive(ReactiveRTM.omg.org.RTC.ExecutionContext execContext);
        ReactiveRTM.omg.org.RTC.ReturnCode_t Exit();
        System.Int32 AttachContext(ReactiveRTM.omg.org.RTC.ExecutionContext execContext);
        ReactiveRTM.omg.org.RTC.ReturnCode_t DetachContext(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ExecutionContext GetContext(System.Int32 execHandle);
        List<ReactiveRTM.omg.org.RTC.ExecutionContext> GetOwnedContexts();
        List<ReactiveRTM.omg.org.RTC.ExecutionContext> GetParticipatingContexts();
        System.Int32 GetContextHandle(ReactiveRTM.omg.org.RTC.ExecutionContext cxt);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnInitialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnFinalize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnStartup(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnActivated(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnAborting(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnError(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnReset(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnAction(System.Int32 execHandle);
    }
    public interface Mode 
    {
    }
    public interface ModeCapable 
    {
        ReactiveRTM.omg.org.RTC.Mode GetDefaultMode();
        ReactiveRTM.omg.org.RTC.Mode GetCurrentMode();
        ReactiveRTM.omg.org.RTC.Mode GetCurrentModeInContext(ReactiveRTM.omg.org.RTC.ExecutionContext execContext);
        ReactiveRTM.omg.org.RTC.Mode GetPendingMode();
        ReactiveRTM.omg.org.RTC.Mode GetPendingModeInContext(ReactiveRTM.omg.org.RTC.ExecutionContext execContext);
        ReactiveRTM.omg.org.RTC.ReturnCode_t SetMode(ReactiveRTM.omg.org.RTC.Mode newMode,System.Boolean immediate);
    }
    public interface MultiModeComponentAction 
    {
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnModeChanged(System.Int32 execHandle);
    }
    public interface MultiModeObject : ReactiveRTM.omg.org.RTC.LightweightRTObject,ReactiveRTM.omg.org.RTC.ComponentAction,ReactiveRTM.omg.org.RTC.ModeCapable,ReactiveRTM.omg.org.RTC.MultiModeComponentAction
    {
        ReactiveRTM.omg.org.RTC.ReturnCode_t Initialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Finalize();
        System.Boolean IsAlive(ReactiveRTM.omg.org.RTC.ExecutionContext execContext);
        ReactiveRTM.omg.org.RTC.ReturnCode_t Exit();
        System.Int32 AttachContext(ReactiveRTM.omg.org.RTC.ExecutionContext execContext);
        ReactiveRTM.omg.org.RTC.ReturnCode_t DetachContext(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ExecutionContext GetContext(System.Int32 execHandle);
        List<ReactiveRTM.omg.org.RTC.ExecutionContext> GetOwnedContexts();
        List<ReactiveRTM.omg.org.RTC.ExecutionContext> GetParticipatingContexts();
        System.Int32 GetContextHandle(ReactiveRTM.omg.org.RTC.ExecutionContext cxt);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnInitialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnFinalize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnStartup(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnActivated(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnAborting(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnError(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnReset(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.Mode GetDefaultMode();
        ReactiveRTM.omg.org.RTC.Mode GetCurrentMode();
        ReactiveRTM.omg.org.RTC.Mode GetCurrentModeInContext(ReactiveRTM.omg.org.RTC.ExecutionContext execContext);
        ReactiveRTM.omg.org.RTC.Mode GetPendingMode();
        ReactiveRTM.omg.org.RTC.Mode GetPendingModeInContext(ReactiveRTM.omg.org.RTC.ExecutionContext execContext);
        ReactiveRTM.omg.org.RTC.ReturnCode_t SetMode(ReactiveRTM.omg.org.RTC.Mode newMode,System.Boolean immediate);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnModeChanged(System.Int32 execHandle);
    }
    public interface RTObject : ReactiveRTM.omg.org.RTC.LightweightRTObject,ReactiveRTM.omg.org.RTC.ComponentAction,ReactiveRTM.org.omg.SDOPackage.SDO,ReactiveRTM.org.omg.SDOPackage.SDOSystemElement
    {
        ReactiveRTM.omg.org.RTC.ComponentProfile GetComponentProfile();
        List<ReactiveRTM.omg.org.RTC.PortService> GetPorts();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Initialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Finalize();
        System.Boolean IsAlive(ReactiveRTM.omg.org.RTC.ExecutionContext execContext);
        ReactiveRTM.omg.org.RTC.ReturnCode_t Exit();
        System.Int32 AttachContext(ReactiveRTM.omg.org.RTC.ExecutionContext execContext);
        ReactiveRTM.omg.org.RTC.ReturnCode_t DetachContext(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ExecutionContext GetContext(System.Int32 execHandle);
        List<ReactiveRTM.omg.org.RTC.ExecutionContext> GetOwnedContexts();
        List<ReactiveRTM.omg.org.RTC.ExecutionContext> GetParticipatingContexts();
        System.Int32 GetContextHandle(ReactiveRTM.omg.org.RTC.ExecutionContext cxt);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnInitialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnFinalize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnStartup(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnActivated(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnAborting(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnError(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnReset(System.Int32 execHandle);
        System.String GetSdoId();
        System.String GetSdoType();
        ReactiveRTM.org.omg.SDOPackage.DeviceProfile GetDeviceProfile();
        List<ReactiveRTM.org.omg.SDOPackage.ServiceProfile> GetServiceProfiles();
        ReactiveRTM.org.omg.SDOPackage.ServiceProfile GetServiceProfile(System.String id);
        ReactiveRTM.org.omg.SDOPackage.SDOService GetSdoService(System.String id);
        ReactiveRTM.org.omg.SDOPackage.Configuration GetConfiguration();
        ReactiveRTM.org.omg.SDOPackage.Monitoring GetMonitoring();
        List<ReactiveRTM.org.omg.SDOPackage.Organization> GetOrganizations();
        System.Collections.Generic.Dictionary<System.String,System.Object> GetStatusList();
        System.Object GetStatus(System.String nme);
        List<ReactiveRTM.org.omg.SDOPackage.Organization> GetOwnedOrganizations();
    }
    public interface PortService : ReactiveRTM.org.omg.SDOPackage.SDOService
    {
        ReactiveRTM.omg.org.RTC.PortProfile GetPortProfile();
        List<ReactiveRTM.omg.org.RTC.ConnectorProfile> GetConnectorProfiles();
        ReactiveRTM.omg.org.RTC.ConnectorProfile GetConnectorProfile(System.String connectorId);
        ReactiveRTM.omg.org.RTC.ReturnCode_t Connect(ref ReactiveRTM.omg.org.RTC.ConnectorProfile connectorProfile);
        ReactiveRTM.omg.org.RTC.ReturnCode_t Disconnect(System.String connectorId);
        ReactiveRTM.omg.org.RTC.ReturnCode_t DisconnectAll();
        ReactiveRTM.omg.org.RTC.ReturnCode_t NotifyConnect(ref ReactiveRTM.omg.org.RTC.ConnectorProfile connectorProfile);
        ReactiveRTM.omg.org.RTC.ReturnCode_t NotifyDisconnect(System.String connectorId);
    }
    public interface FsmObject 
    {
        ReactiveRTM.omg.org.RTC.ReturnCode_t SendStimulus(System.String message,System.Int32 execHandle);
    }
    public interface FsmService : ReactiveRTM.org.omg.SDOPackage.SDOService
    {
        ReactiveRTM.omg.org.RTC.FsmProfile GetFsmProfile();
        ReactiveRTM.omg.org.RTC.ReturnCode_t SetFsmProfile(ReactiveRTM.omg.org.RTC.FsmProfile fsmProfile);
    }
    public interface ExecutionContextService : ReactiveRTM.omg.org.RTC.ExecutionContext,ReactiveRTM.org.omg.SDOPackage.SDOService
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
}
 
namespace ReactiveRTM.OpenRTM
{
    public interface ComponentObserver : ReactiveRTM.org.omg.SDOPackage.SDOService
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
    public interface Logger : ReactiveRTM.org.omg.SDOPackage.SDOService
    {
        void Publish(ReactiveRTM.OpenRTM.LogRecord record);
        void Close();
    }
}
 
namespace ReactiveRTM.openrtm.aist.go.jp.OpenRTM
{
    public interface DataFlowComponent : ReactiveRTM.omg.org.RTC.RTObject,ReactiveRTM.omg.org.RTC.LightweightRTObject,ReactiveRTM.omg.org.RTC.ComponentAction,ReactiveRTM.org.omg.SDOPackage.SDO,ReactiveRTM.org.omg.SDOPackage.SDOSystemElement,ReactiveRTM.omg.org.RTC.DataFlowComponent,ReactiveRTM.omg.org.RTC.DataFlowComponentAction
    {
        ReactiveRTM.omg.org.RTC.ComponentProfile GetComponentProfile();
        List<ReactiveRTM.omg.org.RTC.PortService> GetPorts();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Initialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Finalize();
        System.Boolean IsAlive(ReactiveRTM.omg.org.RTC.ExecutionContext execContext);
        ReactiveRTM.omg.org.RTC.ReturnCode_t Exit();
        System.Int32 AttachContext(ReactiveRTM.omg.org.RTC.ExecutionContext execContext);
        ReactiveRTM.omg.org.RTC.ReturnCode_t DetachContext(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ExecutionContext GetContext(System.Int32 execHandle);
        List<ReactiveRTM.omg.org.RTC.ExecutionContext> GetOwnedContexts();
        List<ReactiveRTM.omg.org.RTC.ExecutionContext> GetParticipatingContexts();
        System.Int32 GetContextHandle(ReactiveRTM.omg.org.RTC.ExecutionContext cxt);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnInitialize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnFinalize();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnStartup(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnShutdown(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnActivated(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnDeactivated(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnAborting(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnError(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnReset(System.Int32 execHandle);
        System.String GetSdoId();
        System.String GetSdoType();
        ReactiveRTM.org.omg.SDOPackage.DeviceProfile GetDeviceProfile();
        List<ReactiveRTM.org.omg.SDOPackage.ServiceProfile> GetServiceProfiles();
        ReactiveRTM.org.omg.SDOPackage.ServiceProfile GetServiceProfile(System.String id);
        ReactiveRTM.org.omg.SDOPackage.SDOService GetSdoService(System.String id);
        ReactiveRTM.org.omg.SDOPackage.Configuration GetConfiguration();
        ReactiveRTM.org.omg.SDOPackage.Monitoring GetMonitoring();
        List<ReactiveRTM.org.omg.SDOPackage.Organization> GetOrganizations();
        System.Collections.Generic.Dictionary<System.String,System.Object> GetStatusList();
        System.Object GetStatus(System.String nme);
        List<ReactiveRTM.org.omg.SDOPackage.Organization> GetOwnedOrganizations();
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnExecute(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnStateUpdate(System.Int32 execHandle);
        ReactiveRTM.omg.org.RTC.ReturnCode_t OnRateChanged(System.Int32 execHandle);
    }
    public interface ExtTrigExecutionContextService : ReactiveRTM.omg.org.RTC.ExecutionContextService,ReactiveRTM.omg.org.RTC.ExecutionContext,ReactiveRTM.org.omg.SDOPackage.SDOService
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
}
 
namespace ReactiveRTM.org.omg.SDOPackage
{
    public interface SDO : ReactiveRTM.org.omg.SDOPackage.SDOSystemElement
    {
        System.String GetSdoId();
        System.String GetSdoType();
        ReactiveRTM.org.omg.SDOPackage.DeviceProfile GetDeviceProfile();
        List<ReactiveRTM.org.omg.SDOPackage.ServiceProfile> GetServiceProfiles();
        ReactiveRTM.org.omg.SDOPackage.ServiceProfile GetServiceProfile(System.String id);
        ReactiveRTM.org.omg.SDOPackage.SDOService GetSdoService(System.String id);
        ReactiveRTM.org.omg.SDOPackage.Configuration GetConfiguration();
        ReactiveRTM.org.omg.SDOPackage.Monitoring GetMonitoring();
        List<ReactiveRTM.org.omg.SDOPackage.Organization> GetOrganizations();
        System.Collections.Generic.Dictionary<System.String,System.Object> GetStatusList();
        System.Object GetStatus(System.String nme);
        List<ReactiveRTM.org.omg.SDOPackage.Organization> GetOwnedOrganizations();
    }
    public interface SDOService 
    {
    }
    public interface SDOSystemElement 
    {
        List<ReactiveRTM.org.omg.SDOPackage.Organization> GetOwnedOrganizations();
    }
    public interface Configuration 
    {
        System.Boolean SetDeviceProfile(ReactiveRTM.org.omg.SDOPackage.DeviceProfile dProfile);
        System.Boolean AddServiceProfile(ReactiveRTM.org.omg.SDOPackage.ServiceProfile sProfile);
        System.Boolean AddOrganization(ReactiveRTM.org.omg.SDOPackage.Organization organizationObject);
        System.Boolean RemoveServiceProfile(System.String id);
        System.Boolean RemoveOrganization(System.String organizationId);
        List<ReactiveRTM.org.omg.SDOPackage.Parameter> GetConfigurationParameters();
        System.Collections.Generic.Dictionary<System.String,System.Object> GetConfigurationParameterValues();
        System.Object GetConfigurationParameterValue(System.String name);
        System.Boolean SetConfigurationParameter(System.String name,System.Object value);
        List<ReactiveRTM.org.omg.SDOPackage.ConfigurationSet> GetConfigurationSets();
        ReactiveRTM.org.omg.SDOPackage.ConfigurationSet GetConfigurationSet(System.String configId);
        System.Boolean SetConfigurationSetValues(ReactiveRTM.org.omg.SDOPackage.ConfigurationSet configurationSet);
        ReactiveRTM.org.omg.SDOPackage.ConfigurationSet GetActiveConfigurationSet();
        System.Boolean AddConfigurationSet(ReactiveRTM.org.omg.SDOPackage.ConfigurationSet configurationSet);
        System.Boolean RemoveConfigurationSet(System.String configId);
        System.Boolean ActivateConfigurationSet(System.String configId);
    }
    public interface Monitoring 
    {
    }
    public interface Organization 
    {
        System.String GetOrganizationId();
        ReactiveRTM.org.omg.SDOPackage.OrganizationProperty GetOrganizationProperty();
        System.Object GetOrganizationPropertyValue(System.String name);
        System.Boolean AddOrganizationProperty(ReactiveRTM.org.omg.SDOPackage.OrganizationProperty organizationProperty);
        System.Boolean SetOrganizationPropertyValue(System.String name,System.Object value);
        System.Boolean RemoveOrganizationProperty(System.String name);
        ReactiveRTM.org.omg.SDOPackage.SDOSystemElement GetOwner();
        System.Boolean SetOwner(ReactiveRTM.org.omg.SDOPackage.SDOSystemElement sdo);
        List<ReactiveRTM.org.omg.SDOPackage.SDO> GetMembers();
        System.Boolean SetMembers(List<ReactiveRTM.org.omg.SDOPackage.SDO> sdos);
        System.Boolean AddMembers(List<ReactiveRTM.org.omg.SDOPackage.SDO> sdoList);
        System.Boolean RemoveMember(System.String id);
        ReactiveRTM.org.omg.SDOPackage.DependencyType GetDependency();
        System.Boolean SetDependency(ReactiveRTM.org.omg.SDOPackage.DependencyType dependency);
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
        ReactiveRTM.omg.org.RTC.ReturnCode_t LoadModule(System.String pathname,System.String initfunc);
        ReactiveRTM.omg.org.RTC.ReturnCode_t UnloadModule(System.String pathname);
        List<ReactiveRTM.RTM.ModuleProfile> GetLoadableModules();
        List<ReactiveRTM.RTM.ModuleProfile> GetLoadedModules();
        List<ReactiveRTM.RTM.ModuleProfile> GetFactoryProfiles();
        ReactiveRTM.omg.org.RTC.RTObject CreateComponent(System.String moduleName);
        ReactiveRTM.omg.org.RTC.ReturnCode_t DeleteComponent(System.String instanceName);
        List<ReactiveRTM.omg.org.RTC.RTObject> GetComponents();
        List<ReactiveRTM.omg.org.RTC.ComponentProfile> GetComponentProfiles();
        ReactiveRTM.RTM.ManagerProfile GetProfile();
        System.Collections.Generic.Dictionary<System.String,System.Object> GetConfiguration();
        ReactiveRTM.omg.org.RTC.ReturnCode_t SetConfiguration(System.String name,System.String value);
        System.Boolean IsMaster();
        List<ReactiveRTM.RTM.Manager> GetMasterManagers();
        ReactiveRTM.omg.org.RTC.ReturnCode_t AddMasterManager(ReactiveRTM.RTM.Manager mgr);
        ReactiveRTM.omg.org.RTC.ReturnCode_t RemoveMasterManager(ReactiveRTM.RTM.Manager mgr);
        List<ReactiveRTM.RTM.Manager> GetSlaveManagers();
        ReactiveRTM.omg.org.RTC.ReturnCode_t AddSlaveManager(ReactiveRTM.RTM.Manager mgr);
        ReactiveRTM.omg.org.RTC.ReturnCode_t RemoveSlaveManager(ReactiveRTM.RTM.Manager mgr);
        ReactiveRTM.omg.org.RTC.ReturnCode_t Fork();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Shutdown();
        ReactiveRTM.omg.org.RTC.ReturnCode_t Restart();
        System.Object GetService(System.String name);
    }
}

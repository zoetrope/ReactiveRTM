using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading.Tasks;
using ReactiveRTM.Corba;
using ReactiveRTM.Data;
using ReactiveRTM.Generated;

 
namespace ReactiveRTM.OpenRTM
{
    public static class ComponentObserverExtensions
    {
 
        public static Task UpdateStatusAsync(this ComponentObserver target,ReactiveRTM.OpenRTM.StatusKind statusKind,System.String hint)
        {
            return Task.Factory.StartNew(()=>{
                target.UpdateStatus(statusKind,hint);
                return;
            });
        }
    }
    public static class InPortCdrExtensions
    {
 
        public static Task<ReactiveRTM.OpenRTM.PortStatus> PutAsync(this InPortCdr target,List<System.Byte> data)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.Put(data);
                return ret;
            });
        }
    }
    public static class OutPortCdrExtensions
    {
 
        public static Task<Tuple<ReactiveRTM.OpenRTM.PortStatus,List<System.Byte>>> GetAsync(this OutPortCdr target,List<System.Byte> data)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.Get(out data);
                return Tuple.Create(ret,data);
            });
        }
    }
    public static class LoggerExtensions
    {
 
        public static Task PublishAsync(this Logger target,ReactiveRTM.OpenRTM.LogRecord record)
        {
            return Task.Factory.StartNew(()=>{
                target.Publish(record);
                return;
            });
        }
 
        public static Task CloseAsync(this Logger target)
        {
            return Task.Factory.StartNew(()=>{
                target.Close();
                return;
            });
        }
    }
}
 
namespace ReactiveRTM.OpenRTM
{
    public static class DataFlowComponentExtensions
    {
    }
    public static class ExtTrigExecutionContextServiceExtensions
    {
 
        public static Task TickAsync(this ExtTrigExecutionContextService target)
        {
            return Task.Factory.StartNew(()=>{
                target.Tick();
                return;
            });
        }
    }
}
 
namespace ReactiveRTM.RTC
{
    public static class ExecutionContextExtensions
    {
 
        public static Task<System.Boolean> IsRunningAsync(this ExecutionContext target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.IsRunning();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> StartAsync(this ExecutionContext target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.Start();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> StopAsync(this ExecutionContext target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.Stop();
                return ret;
            });
        }
 
        public static Task<System.Double> GetRateAsync(this ExecutionContext target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetRate();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> SetRateAsync(this ExecutionContext target,System.Double rate)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.SetRate(rate);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> AddComponentAsync(this ExecutionContext target,ReactiveRTM.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.AddComponent(comp);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> RemoveComponentAsync(this ExecutionContext target,ReactiveRTM.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.RemoveComponent(comp);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> ActivateComponentAsync(this ExecutionContext target,ReactiveRTM.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.ActivateComponent(comp);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> DeactivateComponentAsync(this ExecutionContext target,ReactiveRTM.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.DeactivateComponent(comp);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> ResetComponentAsync(this ExecutionContext target,ReactiveRTM.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.ResetComponent(comp);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.LifeCycleState> GetComponentStateAsync(this ExecutionContext target,ReactiveRTM.RTC.LightweightRTObject comp)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetComponentState(comp);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ExecutionKind> GetKindAsync(this ExecutionContext target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetKind();
                return ret;
            });
        }
    }
    public static class ComponentActionExtensions
    {
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> OnInitializeAsync(this ComponentAction target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.OnInitialize();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> OnFinalizeAsync(this ComponentAction target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.OnFinalize();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> OnStartupAsync(this ComponentAction target,System.Int32 execHandle)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.OnStartup(execHandle);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> OnShutdownAsync(this ComponentAction target,System.Int32 execHandle)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.OnShutdown(execHandle);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> OnActivatedAsync(this ComponentAction target,System.Int32 execHandle)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.OnActivated(execHandle);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> OnDeactivatedAsync(this ComponentAction target,System.Int32 execHandle)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.OnDeactivated(execHandle);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> OnAbortingAsync(this ComponentAction target,System.Int32 execHandle)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.OnAborting(execHandle);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> OnErrorAsync(this ComponentAction target,System.Int32 execHandle)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.OnError(execHandle);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> OnResetAsync(this ComponentAction target,System.Int32 execHandle)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.OnReset(execHandle);
                return ret;
            });
        }
    }
    public static class LightweightRTObjectExtensions
    {
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> InitializeAsync(this LightweightRTObject target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.Initialize();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> FinalizeAsync(this LightweightRTObject target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.Finalize();
                return ret;
            });
        }
 
        public static Task<System.Boolean> IsAliveAsync(this LightweightRTObject target,ReactiveRTM.RTC.ExecutionContext execContext)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.IsAlive(execContext);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> ExitAsync(this LightweightRTObject target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.Exit();
                return ret;
            });
        }
 
        public static Task<System.Int32> AttachContextAsync(this LightweightRTObject target,ReactiveRTM.RTC.ExecutionContext execContext)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.AttachContext(execContext);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> DetachContextAsync(this LightweightRTObject target,System.Int32 execHandle)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.DetachContext(execHandle);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ExecutionContext> GetContextAsync(this LightweightRTObject target,System.Int32 execHandle)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetContext(execHandle);
                return ret;
            });
        }
 
        public static Task<List<ReactiveRTM.RTC.ExecutionContext>> GetOwnedContextsAsync(this LightweightRTObject target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetOwnedContexts();
                return ret;
            });
        }
 
        public static Task<List<ReactiveRTM.RTC.ExecutionContext>> GetParticipatingContextsAsync(this LightweightRTObject target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetParticipatingContexts();
                return ret;
            });
        }
 
        public static Task<System.Int32> GetContextHandleAsync(this LightweightRTObject target,ReactiveRTM.RTC.ExecutionContext cxt)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetContextHandle(cxt);
                return ret;
            });
        }
    }
    public static class DataFlowComponentActionExtensions
    {
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> OnExecuteAsync(this DataFlowComponentAction target,System.Int32 execHandle)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.OnExecute(execHandle);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> OnStateUpdateAsync(this DataFlowComponentAction target,System.Int32 execHandle)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.OnStateUpdate(execHandle);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> OnRateChangedAsync(this DataFlowComponentAction target,System.Int32 execHandle)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.OnRateChanged(execHandle);
                return ret;
            });
        }
    }
    public static class DataFlowComponentExtensions
    {
    }
    public static class FsmExtensions
    {
    }
    public static class FsmParticipantActionExtensions
    {
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> OnActionAsync(this FsmParticipantAction target,System.Int32 execHandle)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.OnAction(execHandle);
                return ret;
            });
        }
    }
    public static class FsmParticipantExtensions
    {
    }
    public static class ModeExtensions
    {
    }
    public static class ModeCapableExtensions
    {
 
        public static Task<ReactiveRTM.RTC.Mode> GetDefaultModeAsync(this ModeCapable target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetDefaultMode();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.Mode> GetCurrentModeAsync(this ModeCapable target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetCurrentMode();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.Mode> GetCurrentModeInContextAsync(this ModeCapable target,ReactiveRTM.RTC.ExecutionContext execContext)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetCurrentModeInContext(execContext);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.Mode> GetPendingModeAsync(this ModeCapable target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetPendingMode();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.Mode> GetPendingModeInContextAsync(this ModeCapable target,ReactiveRTM.RTC.ExecutionContext execContext)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetPendingModeInContext(execContext);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> SetModeAsync(this ModeCapable target,ReactiveRTM.RTC.Mode newMode,System.Boolean immediate)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.SetMode(newMode,immediate);
                return ret;
            });
        }
    }
    public static class MultiModeComponentActionExtensions
    {
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> OnModeChangedAsync(this MultiModeComponentAction target,System.Int32 execHandle)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.OnModeChanged(execHandle);
                return ret;
            });
        }
    }
    public static class MultiModeObjectExtensions
    {
    }
    public static class RTObjectExtensions
    {
 
        public static Task<ReactiveRTM.RTC.ComponentProfile> GetComponentProfileAsync(this RTObject target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetComponentProfile();
                return ret;
            });
        }
 
        public static Task<List<ReactiveRTM.RTC.PortService>> GetPortsAsync(this RTObject target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetPorts();
                return ret;
            });
        }
    }
    public static class PortServiceExtensions
    {
 
        public static Task<ReactiveRTM.RTC.PortProfile> GetPortProfileAsync(this PortService target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetPortProfile();
                return ret;
            });
        }
 
        public static Task<List<ReactiveRTM.RTC.ConnectorProfile>> GetConnectorProfilesAsync(this PortService target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetConnectorProfiles();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ConnectorProfile> GetConnectorProfileAsync(this PortService target,System.String connectorId)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetConnectorProfile(connectorId);
                return ret;
            });
        }
 
        public static Task<Tuple<ReactiveRTM.RTC.ReturnCode_t,ReactiveRTM.RTC.ConnectorProfile>> ConnectAsync(this PortService target,ReactiveRTM.RTC.ConnectorProfile connectorProfile)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.Connect(ref connectorProfile);
                return Tuple.Create(ret,connectorProfile);
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> DisconnectAsync(this PortService target,System.String connectorId)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.Disconnect(connectorId);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> DisconnectAllAsync(this PortService target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.DisconnectAll();
                return ret;
            });
        }
 
        public static Task<Tuple<ReactiveRTM.RTC.ReturnCode_t,ReactiveRTM.RTC.ConnectorProfile>> NotifyConnectAsync(this PortService target,ReactiveRTM.RTC.ConnectorProfile connectorProfile)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.NotifyConnect(ref connectorProfile);
                return Tuple.Create(ret,connectorProfile);
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> NotifyDisconnectAsync(this PortService target,System.String connectorId)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.NotifyDisconnect(connectorId);
                return ret;
            });
        }
    }
    public static class FsmObjectExtensions
    {
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> SendStimulusAsync(this FsmObject target,System.String message,System.Int32 execHandle)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.SendStimulus(message,execHandle);
                return ret;
            });
        }
    }
    public static class FsmServiceExtensions
    {
 
        public static Task<ReactiveRTM.RTC.FsmProfile> GetFsmProfileAsync(this FsmService target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetFsmProfile();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> SetFsmProfileAsync(this FsmService target,ReactiveRTM.RTC.FsmProfile fsmProfile)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.SetFsmProfile(fsmProfile);
                return ret;
            });
        }
    }
    public static class ExecutionContextServiceExtensions
    {
 
        public static Task<ReactiveRTM.RTC.ExecutionContextProfile> GetProfileAsync(this ExecutionContextService target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetProfile();
                return ret;
            });
        }
    }
}
 
namespace ReactiveRTM.RTC
{
    public static class ActArrayExtensions
    {
 
        public static Task<ReactiveRTM.RTC.ActArrayGeometry> GetGeometryAsync(this ActArray target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
 
        public static Task GoHomeAsync(this ActArray target,System.Int16 index)
        {
            return Task.Factory.StartNew(()=>{
                target.GoHome(index);
                return;
            });
        }
 
        public static Task PowerAsync(this ActArray target,System.Boolean enable)
        {
            return Task.Factory.StartNew(()=>{
                target.Power(enable);
                return;
            });
        }
 
        public static Task BrakesAsync(this ActArray target,System.Boolean engage)
        {
            return Task.Factory.StartNew(()=>{
                target.Brakes(engage);
                return;
            });
        }
 
        public static Task ConfigSpeedAsync(this ActArray target,System.Int16 index,System.Double speed)
        {
            return Task.Factory.StartNew(()=>{
                target.ConfigSpeed(index,speed);
                return;
            });
        }
 
        public static Task ConfigAccelAsync(this ActArray target,System.Int16 index,System.Double accel)
        {
            return Task.Factory.StartNew(()=>{
                target.ConfigAccel(index,accel);
                return;
            });
        }
    }
    public static class AIOExtensions
    {
 
        public static Task<System.Int16> NumChannelsAsync(this AIO target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.NumChannels();
                return ret;
            });
        }
 
        public static Task SetReferenceLevelAsync(this AIO target,System.Int16 index,System.Double level)
        {
            return Task.Factory.StartNew(()=>{
                target.SetReferenceLevel(index,level);
                return;
            });
        }
 
        public static Task<System.Double> GetResolutionAsync(this AIO target,System.Int16 index)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetResolution(index);
                return ret;
            });
        }
    }
    public static class BumperExtensions
    {
 
        public static Task<ReactiveRTM.RTC.BumperGeometry> GetGeometryAsync(this Bumper target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
    }
    public static class CameraExtensions
    {
 
        public static Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync(this Camera target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.CameraInfo> GetCameraInfoAsync(this Camera target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetCameraInfo();
                return ret;
            });
        }
    }
    public static class DIOExtensions
    {
 
        public static Task<System.Int16> NumBitsAsync(this DIO target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.NumBits();
                return ret;
            });
        }
 
        public static Task<System.Boolean> GetBitAsync(this DIO target,System.Int16 index)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetBit(index);
                return ret;
            });
        }
 
        public static Task SetBitAsync(this DIO target,System.Int16 index,System.Boolean newValue)
        {
            return Task.Factory.StartNew(()=>{
                target.SetBit(index,newValue);
                return;
            });
        }
    }
    public static class FiducialExtensions
    {
 
        public static Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync(this Fiducial target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.FiducialFOV> GetFOVAsync(this Fiducial target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetFOV();
                return ret;
            });
        }
 
        public static Task SetFOVAsync(this Fiducial target,ReactiveRTM.RTC.FiducialFOV newFOV)
        {
            return Task.Factory.StartNew(()=>{
                target.SetFOV(newFOV);
                return;
            });
        }
    }
    public static class GPSExtensions
    {
 
        public static Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync(this GPS target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
    }
    public static class GripperExtensions
    {
 
        public static Task<ReactiveRTM.RTC.GripperGeometry> GetGeometryAsync(this Gripper target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
 
        public static Task OpenAsync(this Gripper target)
        {
            return Task.Factory.StartNew(()=>{
                target.Open();
                return;
            });
        }
 
        public static Task CloseAsync(this Gripper target)
        {
            return Task.Factory.StartNew(()=>{
                target.Close();
                return;
            });
        }
    }
    public static class IMUExtensions
    {
 
        public static Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync(this IMU target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
    }
    public static class INSExtensions
    {
 
        public static Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync(this INS target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
    }
    public static class LimbExtensions
    {
 
        public static Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync(this Limb target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
 
        public static Task PowerAsync(this Limb target,System.Boolean enable)
        {
            return Task.Factory.StartNew(()=>{
                target.Power(enable);
                return;
            });
        }
 
        public static Task BrakesAsync(this Limb target,System.Boolean engage)
        {
            return Task.Factory.StartNew(()=>{
                target.Brakes(engage);
                return;
            });
        }
 
        public static Task SetSpeedAsync(this Limb target,System.Double speed)
        {
            return Task.Factory.StartNew(()=>{
                target.SetSpeed(speed);
                return;
            });
        }
    }
    public static class OGMapExtensions
    {
 
        public static Task<ReactiveRTM.RTC.OGMapConfig> GetConfigAsync(this OGMap target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetConfig();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.OGMapTile> GetTileAsync(this OGMap target,ReactiveRTM.RTC.OGMapTile tile)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetTile(tile);
                return ret;
            });
        }
    }
    public static class MulticameraExtensions
    {
 
        public static Task<ReactiveRTM.RTC.MulticameraGeometry> GetGeometryAsync(this Multicamera target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
 
        public static Task<List<ReactiveRTM.RTC.CameraInfo>> GetCameraInfosAsync(this Multicamera target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetCameraInfos();
                return ret;
            });
        }
    }
    public static class PanTiltExtensions
    {
 
        public static Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync(this PanTilt target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
    }
    public static class PathPlanner2DExtensions
    {
 
        public static Task SetTaskAsync(this PathPlanner2D target,List<ReactiveRTM.RTC.Waypoint2D> coarsePath)
        {
            return Task.Factory.StartNew(()=>{
                target.SetTask(coarsePath);
                return;
            });
        }
    }
    public static class PathPlanner3DExtensions
    {
 
        public static Task SetTaskAsync(this PathPlanner3D target,List<ReactiveRTM.RTC.Waypoint3D> coarsePath)
        {
            return Task.Factory.StartNew(()=>{
                target.SetTask(coarsePath);
                return;
            });
        }
    }
    public static class PathFollower2DExtensions
    {
 
        public static Task SetPathAsync(this PathFollower2D target,List<ReactiveRTM.RTC.Waypoint2D> path)
        {
            return Task.Factory.StartNew(()=>{
                target.SetPath(path);
                return;
            });
        }
 
        public static Task EnableAsync(this PathFollower2D target,System.Boolean enable)
        {
            return Task.Factory.StartNew(()=>{
                target.Enable(enable);
                return;
            });
        }
 
        public static Task<System.Int16> GetCurrentWaypointIndexAsync(this PathFollower2D target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetCurrentWaypointIndex();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.Waypoint2D> GetCurrentWaypointAsync(this PathFollower2D target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetCurrentWaypoint();
                return ret;
            });
        }
    }
    public static class PathFollower3DExtensions
    {
 
        public static Task SetPathAsync(this PathFollower3D target,List<ReactiveRTM.RTC.Waypoint3D> path)
        {
            return Task.Factory.StartNew(()=>{
                target.SetPath(path);
                return;
            });
        }
 
        public static Task EnableAsync(this PathFollower3D target,System.Boolean enable)
        {
            return Task.Factory.StartNew(()=>{
                target.Enable(enable);
                return;
            });
        }
 
        public static Task<System.Int16> GetCurrentWaypointIndexAsync(this PathFollower3D target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetCurrentWaypointIndex();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.Waypoint3D> GetCurrentWaypointAsync(this PathFollower3D target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetCurrentWaypoint();
                return ret;
            });
        }
    }
    public static class PointCloudServicesExtensions
    {
 
        public static Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync(this PointCloudServices target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
    }
    public static class Odometry2DExtensions
    {
 
        public static Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync(this Odometry2D target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
 
        public static Task SetOdometryAsync(this Odometry2D target,ReactiveRTM.RTC.Pose2D newOdometry)
        {
            return Task.Factory.StartNew(()=>{
                target.SetOdometry(newOdometry);
                return;
            });
        }
    }
    public static class Odometry3DExtensions
    {
 
        public static Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync(this Odometry3D target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
 
        public static Task SetOdometryAsync(this Odometry3D target,ReactiveRTM.RTC.Pose3D newOdometry)
        {
            return Task.Factory.StartNew(()=>{
                target.SetOdometry(newOdometry);
                return;
            });
        }
    }
    public static class VelocityControl2DExtensions
    {
 
        public static Task<ReactiveRTM.RTC.Geometry2D> GetGeometryAsync(this VelocityControl2D target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
    }
    public static class VelocityControl3DExtensions
    {
 
        public static Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync(this VelocityControl3D target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
    }
    public static class PoseControl2DExtensions
    {
 
        public static Task<ReactiveRTM.RTC.Geometry2D> GetGeometryAsync(this PoseControl2D target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
    }
    public static class PoseControl3DExtensions
    {
 
        public static Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync(this PoseControl3D target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
    }
    public static class CarlikeControlExtensions
    {
 
        public static Task<ReactiveRTM.RTC.Geometry2D> GetGeometryAsync(this CarlikeControl target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
    }
    public static class HeadingControl2DExtensions
    {
 
        public static Task<ReactiveRTM.RTC.Geometry2D> GetGeometryAsync(this HeadingControl2D target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
    }
    public static class HeadingControl3DExtensions
    {
 
        public static Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync(this HeadingControl3D target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
    }
    public static class RangerExtensions
    {
 
        public static Task<ReactiveRTM.RTC.RangerGeometry> GetGeometryAsync(this Ranger target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
 
        public static Task PowerAsync(this Ranger target,System.Boolean enable)
        {
            return Task.Factory.StartNew(()=>{
                target.Power(enable);
                return;
            });
        }
 
        public static Task EnableIntensitiesAsync(this Ranger target,System.Boolean enable)
        {
            return Task.Factory.StartNew(()=>{
                target.EnableIntensities(enable);
                return;
            });
        }
 
        public static Task<ReactiveRTM.RTC.RangerConfig> GetConfigAsync(this Ranger target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetConfig();
                return ret;
            });
        }
 
        public static Task SetConfigAsync(this Ranger target,ReactiveRTM.RTC.RangerConfig newConfig)
        {
            return Task.Factory.StartNew(()=>{
                target.SetConfig(newConfig);
                return;
            });
        }
    }
    public static class RFIDExtensions
    {
 
        public static Task<ReactiveRTM.RTC.Geometry3D> GetGeometryAsync(this RFID target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetGeometry();
                return ret;
            });
        }
 
        public static Task WriteAsync(this RFID target,System.String GUID,List<System.Byte> data)
        {
            return Task.Factory.StartNew(()=>{
                target.Write(GUID,data);
                return;
            });
        }
 
        public static Task<List<System.Byte>> ReadAsync(this RFID target,System.String GUID)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.Read(GUID);
                return ret;
            });
        }
    }
}
 
namespace ReactiveRTM.RTM
{
    public static class ManagerExtensions
    {
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> LoadModuleAsync(this Manager target,System.String pathname,System.String initfunc)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.LoadModule(pathname,initfunc);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> UnloadModuleAsync(this Manager target,System.String pathname)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.UnloadModule(pathname);
                return ret;
            });
        }
 
        public static Task<List<ReactiveRTM.RTM.ModuleProfile>> GetLoadableModulesAsync(this Manager target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetLoadableModules();
                return ret;
            });
        }
 
        public static Task<List<ReactiveRTM.RTM.ModuleProfile>> GetLoadedModulesAsync(this Manager target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetLoadedModules();
                return ret;
            });
        }
 
        public static Task<List<ReactiveRTM.RTM.ModuleProfile>> GetFactoryProfilesAsync(this Manager target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetFactoryProfiles();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.RTObject> CreateComponentAsync(this Manager target,System.String moduleName)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.CreateComponent(moduleName);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> DeleteComponentAsync(this Manager target,System.String instanceName)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.DeleteComponent(instanceName);
                return ret;
            });
        }
 
        public static Task<List<ReactiveRTM.RTC.RTObject>> GetComponentsAsync(this Manager target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetComponents();
                return ret;
            });
        }
 
        public static Task<List<ReactiveRTM.RTC.ComponentProfile>> GetComponentProfilesAsync(this Manager target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetComponentProfiles();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTM.ManagerProfile> GetProfileAsync(this Manager target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetProfile();
                return ret;
            });
        }
 
        public static Task<Dictionary<string,object>> GetConfigurationAsync(this Manager target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetConfiguration();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> SetConfigurationAsync(this Manager target,System.String name,System.String value)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.SetConfiguration(name,value);
                return ret;
            });
        }
 
        public static Task<System.Boolean> IsMasterAsync(this Manager target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.IsMaster();
                return ret;
            });
        }
 
        public static Task<List<ReactiveRTM.RTM.Manager>> GetMasterManagersAsync(this Manager target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetMasterManagers();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> AddMasterManagerAsync(this Manager target,ReactiveRTM.RTM.Manager mgr)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.AddMasterManager(mgr);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> RemoveMasterManagerAsync(this Manager target,ReactiveRTM.RTM.Manager mgr)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.RemoveMasterManager(mgr);
                return ret;
            });
        }
 
        public static Task<List<ReactiveRTM.RTM.Manager>> GetSlaveManagersAsync(this Manager target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetSlaveManagers();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> AddSlaveManagerAsync(this Manager target,ReactiveRTM.RTM.Manager mgr)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.AddSlaveManager(mgr);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> RemoveSlaveManagerAsync(this Manager target,ReactiveRTM.RTM.Manager mgr)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.RemoveSlaveManager(mgr);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> ForkAsync(this Manager target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.Fork();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> ShutdownAsync(this Manager target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.Shutdown();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.RTC.ReturnCode_t> RestartAsync(this Manager target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.Restart();
                return ret;
            });
        }
 
        public static Task<System.Object> GetServiceAsync(this Manager target,System.String name)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetService(name);
                return ret;
            });
        }
    }
}
 
namespace ReactiveRTM.SDOPackage
{
    public static class SDOExtensions
    {
 
        public static Task<System.String> GetSdoIdAsync(this SDO target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetSdoId();
                return ret;
            });
        }
 
        public static Task<System.String> GetSdoTypeAsync(this SDO target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetSdoType();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.SDOPackage.DeviceProfile> GetDeviceProfileAsync(this SDO target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetDeviceProfile();
                return ret;
            });
        }
 
        public static Task<List<ReactiveRTM.SDOPackage.ServiceProfile>> GetServiceProfilesAsync(this SDO target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetServiceProfiles();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.SDOPackage.ServiceProfile> GetServiceProfileAsync(this SDO target,System.String id)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetServiceProfile(id);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.SDOPackage.SDOService> GetSdoServiceAsync(this SDO target,System.String id)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetSdoService(id);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.SDOPackage.Configuration> GetConfigurationAsync(this SDO target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetConfiguration();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.SDOPackage.Monitoring> GetMonitoringAsync(this SDO target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetMonitoring();
                return ret;
            });
        }
 
        public static Task<List<ReactiveRTM.SDOPackage.Organization>> GetOrganizationsAsync(this SDO target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetOrganizations();
                return ret;
            });
        }
 
        public static Task<Dictionary<string,object>> GetStatusListAsync(this SDO target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetStatusList();
                return ret;
            });
        }
 
        public static Task<System.Object> GetStatusAsync(this SDO target,System.String nme)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetStatus(nme);
                return ret;
            });
        }
    }
    public static class SDOServiceExtensions
    {
    }
    public static class SDOSystemElementExtensions
    {
 
        public static Task<List<ReactiveRTM.SDOPackage.Organization>> GetOwnedOrganizationsAsync(this SDOSystemElement target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetOwnedOrganizations();
                return ret;
            });
        }
    }
    public static class ConfigurationExtensions
    {
 
        public static Task<System.Boolean> SetDeviceProfileAsync(this Configuration target,ReactiveRTM.SDOPackage.DeviceProfile dProfile)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.SetDeviceProfile(dProfile);
                return ret;
            });
        }
 
        public static Task<System.Boolean> AddServiceProfileAsync(this Configuration target,ReactiveRTM.SDOPackage.ServiceProfile sProfile)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.AddServiceProfile(sProfile);
                return ret;
            });
        }
 
        public static Task<System.Boolean> AddOrganizationAsync(this Configuration target,ReactiveRTM.SDOPackage.Organization organizationObject)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.AddOrganization(organizationObject);
                return ret;
            });
        }
 
        public static Task<System.Boolean> RemoveServiceProfileAsync(this Configuration target,System.String id)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.RemoveServiceProfile(id);
                return ret;
            });
        }
 
        public static Task<System.Boolean> RemoveOrganizationAsync(this Configuration target,System.String organizationId)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.RemoveOrganization(organizationId);
                return ret;
            });
        }
 
        public static Task<List<ReactiveRTM.SDOPackage.Parameter>> GetConfigurationParametersAsync(this Configuration target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetConfigurationParameters();
                return ret;
            });
        }
 
        public static Task<Dictionary<string,object>> GetConfigurationParameterValuesAsync(this Configuration target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetConfigurationParameterValues();
                return ret;
            });
        }
 
        public static Task<System.Object> GetConfigurationParameterValueAsync(this Configuration target,System.String name)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetConfigurationParameterValue(name);
                return ret;
            });
        }
 
        public static Task<System.Boolean> SetConfigurationParameterAsync(this Configuration target,System.String name,System.Object value)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.SetConfigurationParameter(name,value);
                return ret;
            });
        }
 
        public static Task<List<ReactiveRTM.SDOPackage.ConfigurationSet>> GetConfigurationSetsAsync(this Configuration target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetConfigurationSets();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.SDOPackage.ConfigurationSet> GetConfigurationSetAsync(this Configuration target,System.String configId)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetConfigurationSet(configId);
                return ret;
            });
        }
 
        public static Task<System.Boolean> SetConfigurationSetValuesAsync(this Configuration target,ReactiveRTM.SDOPackage.ConfigurationSet configurationSet)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.SetConfigurationSetValues(configurationSet);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.SDOPackage.ConfigurationSet> GetActiveConfigurationSetAsync(this Configuration target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetActiveConfigurationSet();
                return ret;
            });
        }
 
        public static Task<System.Boolean> AddConfigurationSetAsync(this Configuration target,ReactiveRTM.SDOPackage.ConfigurationSet configurationSet)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.AddConfigurationSet(configurationSet);
                return ret;
            });
        }
 
        public static Task<System.Boolean> RemoveConfigurationSetAsync(this Configuration target,System.String configId)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.RemoveConfigurationSet(configId);
                return ret;
            });
        }
 
        public static Task<System.Boolean> ActivateConfigurationSetAsync(this Configuration target,System.String configId)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.ActivateConfigurationSet(configId);
                return ret;
            });
        }
    }
    public static class MonitoringExtensions
    {
    }
    public static class OrganizationExtensions
    {
 
        public static Task<System.String> GetOrganizationIdAsync(this Organization target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetOrganizationId();
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.SDOPackage.OrganizationProperty> GetOrganizationPropertyAsync(this Organization target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetOrganizationProperty();
                return ret;
            });
        }
 
        public static Task<System.Object> GetOrganizationPropertyValueAsync(this Organization target,System.String name)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetOrganizationPropertyValue(name);
                return ret;
            });
        }
 
        public static Task<System.Boolean> AddOrganizationPropertyAsync(this Organization target,ReactiveRTM.SDOPackage.OrganizationProperty organizationProperty)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.AddOrganizationProperty(organizationProperty);
                return ret;
            });
        }
 
        public static Task<System.Boolean> SetOrganizationPropertyValueAsync(this Organization target,System.String name,System.Object value)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.SetOrganizationPropertyValue(name,value);
                return ret;
            });
        }
 
        public static Task<System.Boolean> RemoveOrganizationPropertyAsync(this Organization target,System.String name)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.RemoveOrganizationProperty(name);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.SDOPackage.SDOSystemElement> GetOwnerAsync(this Organization target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetOwner();
                return ret;
            });
        }
 
        public static Task<System.Boolean> SetOwnerAsync(this Organization target,ReactiveRTM.SDOPackage.SDOSystemElement sdo)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.SetOwner(sdo);
                return ret;
            });
        }
 
        public static Task<List<ReactiveRTM.SDOPackage.SDO>> GetMembersAsync(this Organization target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetMembers();
                return ret;
            });
        }
 
        public static Task<System.Boolean> SetMembersAsync(this Organization target,List<ReactiveRTM.SDOPackage.SDO> sdos)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.SetMembers(sdos);
                return ret;
            });
        }
 
        public static Task<System.Boolean> AddMembersAsync(this Organization target,List<ReactiveRTM.SDOPackage.SDO> sdoList)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.AddMembers(sdoList);
                return ret;
            });
        }
 
        public static Task<System.Boolean> RemoveMemberAsync(this Organization target,System.String id)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.RemoveMember(id);
                return ret;
            });
        }
 
        public static Task<ReactiveRTM.SDOPackage.DependencyType> GetDependencyAsync(this Organization target)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.GetDependency();
                return ret;
            });
        }
 
        public static Task<System.Boolean> SetDependencyAsync(this Organization target,ReactiveRTM.SDOPackage.DependencyType dependency)
        {
            return Task.Factory.StartNew(()=>{
                var ret = target.SetDependency(dependency);
                return ret;
            });
        }
    }
}

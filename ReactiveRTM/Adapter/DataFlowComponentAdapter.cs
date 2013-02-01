using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Text;
using ReactiveRTM.Corba;
using ReactiveRTM.Core;
using ReactiveRTM.openrtm.aist.go.jp.OpenRTM;
using ReactiveRTM.omg.org.RTC;
using ReactiveRTM.org.omg.SDOPackage;
using ReactiveRTM.OpenRTM;

using DataFlowComponent = ReactiveRTM.openrtm.aist.go.jp.OpenRTM.DataFlowComponent;

namespace ReactiveRTM.Adapter
{

    public class DataFlowComponentImpl : DataFlowComponent
    {

        private IComponentActionListener _listener;
        private Configuration _configuration;

        internal DataFlowComponentImpl(IComponentActionListener listener, string name)
        {
            _profile = new ComponentProfile();
            
            _listener = listener;

            _configuration = new ConfigurationImpl(this);
        }
        
        public IScheduler ExecutionContextScheduler {
            get { return _context.ExecutionContextScheduler; }
            set { _context.ExecutionContextScheduler = value; }
        }

        private List<ComponentObserverStub> _observers = new List<ComponentObserverStub>();

        public void AddComponentObserver(ServiceProfile serviceProfile)
        {
            var observer = (ComponentObserverStub)serviceProfile.Service;
            _observers.Add(observer);
        }

        private ExecutionContextServiceImpl _context;


        private ComponentProfile _profile;

        private List<ReactivePortBase> _reactivePorts = new List<ReactivePortBase>();

        public void AddPort(ReactivePortBase reactivePort)
        {
            _reactivePorts.Add(reactivePort);
        }
        public void RemovePort(ReactivePortBase reactivePort)
        {
            _reactivePorts.Remove(reactivePort);
        }

        public TPortType CreatePort<TPortType, TDataType>(string name)
            where TPortType : PortServiceBase<TDataType>, new()
        {
            var port = new TPortType();
            port.Initialize(name);

            port.SetDisposing(() => { RemovePort(port); });

            return port;
        }



        public ReturnCode_t Initialize()
        {
            _context = new ExecutionContextServiceImpl();


            _context.AddComponent(this);

            return ReturnCode_t.RTC_OK;
        }

        public ReturnCode_t Finalize()
        {
            return ReturnCode_t.RTC_OK;
        }

        public bool IsAlive(ExecutionContext execContext)
        {
            return true;
        }

        public ReturnCode_t Exit()
        {
            return ReturnCode_t.RTC_OK;
        }

        public int AttachContext(ExecutionContext execContext)
        {
            throw new NotImplementedException();
        }

        public ReturnCode_t DetachContext(int execHandle)
        {
            throw new NotImplementedException();
        }

        public ExecutionContext GetContext(int execHandle)
        {
            return _context;
        }

        public List<ExecutionContext> GetOwnedContexts()
        {
            return new List<ExecutionContext> { _context };
        }

        public List<ExecutionContext> GetParticipatingContexts()
        {
            return new List<ExecutionContext>();
        }

        public int GetContextHandle(ExecutionContext cxt)
        {
            return 0;
        }
        public ReturnCode_t OnInitialize()
        {
            _observers.ForEach(observer =>
                observer.UpdateStatusAsync(StatusKind.RTC_STATUS, "INACTIVE:0")
                .ToObservable()//TODO:
                .SubscribeOn(ExecutionContextScheduler)
                );
            return _listener.RaiseOnInitialize();
        }



        public ReturnCode_t OnFinalize()
        {
            return _listener.RaiseOnFinalize();
        }

        public ReturnCode_t OnStartup(int execHandle)
        {
            return _listener.RaiseOnStartup(execHandle);
        }

        public ReturnCode_t OnShutdown(int execHandle)
        {
            return _listener.RaiseOnShutdown(execHandle);
        }

        public ReturnCode_t OnActivated(int execHandle)
        {
            _observers.ForEach(observer => observer.UpdateStatusAsync(StatusKind.RTC_STATUS, "ACTIVE:0")
                                               .ToObservable() //TODO:
                                               .SubscribeOn(ExecutionContextScheduler));

            return _listener.RaiseOnActivated(execHandle);
        }

        public ReturnCode_t OnDeactivated(int execHandle)
        {
            _observers.ForEach(observer => observer.UpdateStatusAsync(StatusKind.RTC_STATUS, "INACTIVE:0")
                .ToObservable()//TODO:
                .SubscribeOn(ExecutionContextScheduler));
            return _listener.RaiseOnDeactivated(execHandle);
        }

        public ReturnCode_t OnAborting(int execHandle)
        {
            _observers.ForEach(observer => observer.UpdateStatusAsync(StatusKind.RTC_STATUS, "ERROR:0")
                .ToObservable()//TODO:
                .SubscribeOn(ExecutionContextScheduler));
            return _listener.RaiseOnAborting(execHandle);
        }

        public ReturnCode_t OnError(int execHandle)
        {
            return _listener.RaiseOnError(execHandle);
        }

        public ReturnCode_t OnReset(int execHandle)
        {
            _observers.ForEach(observer => observer.UpdateStatusAsync(StatusKind.RTC_STATUS, "INACTIVE:0")
                .ToObservable()//TODO:
                .SubscribeOn(ExecutionContextScheduler));
            return _listener.RaiseOnReset(execHandle);
        }

        public ReturnCode_t OnExecute(int execHandle)
        {
            return _listener.RaiseOnExecute(execHandle);
        }

        public ReturnCode_t OnStateUpdate(int execHandle)
        {
            return _listener.RaiseOnStateUpdate(execHandle);
        }

        public ReturnCode_t OnRateChanged(int execHandle)
        {
            return _listener.RaiseOnRateChanged(execHandle);
        }

        public ComponentProfile GetComponentProfile()
        {
            _profile.PortProfiles = _reactivePorts.Select(p => p.PortService.GetPortProfile()).ToList();

            return _profile;
        }

        public List<PortService> GetPorts()
        {
            return _reactivePorts.Select(p => p.PortService).ToList();
        }

        public string GetSdoId()
        {
            throw new NotImplementedException();
        }

        public string GetSdoType()
        {
            throw new NotImplementedException();
        }

        public DeviceProfile GetDeviceProfile()
        {
            throw new NotImplementedException();
        }

        public List<ServiceProfile> GetServiceProfiles()
        {
            throw new NotImplementedException();
        }

        public ServiceProfile GetServiceProfile(string id)
        {
            throw new NotImplementedException();
        }

        public SDOService GetSdoService(string id)
        {
            throw new NotImplementedException();
        }

        public Configuration GetConfiguration()
        {
            return _configuration;
        }

        public Monitoring GetMonitoring()
        {
            throw new NotImplementedException();
        }

        public List<Organization> GetOrganizations()
        {
            return new List<Organization>();
        }

        public Dictionary<string, object> GetStatusList()
        {
            throw new NotImplementedException();
        }

        public object GetStatus(string nme)
        {
            throw new NotImplementedException();
        }

        public List<Organization> GetOwnedOrganizations()
        {
            throw new NotImplementedException();
        }

    }

}

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

namespace ReactiveRTM.Adapter
{

    public class DataFlowComponentAdapter : IDataFlowComponent
    {
        public override object InitializeLifetimeService()
        {
            return null;
        }

        private IComponentActionListener _listener;
        private ConfigurationAdapter _configuration;

        internal DataFlowComponentAdapter(IComponentActionListener listener, string name)
        {
            _profile = new ComponentProfile();
            
            _listener = listener;

            _configuration = new ConfigurationAdapter(this);
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

        private ExecutionContextServiceAdapter _context;

        public ReturnCode_t OnInitialize()
        {
            _observers.ForEach(observer => 
                observer.UpdateStatusAsync(StatusKind.RTC_STATUS, "INACTIVE:0")
                .ToObservable()//TODO:
                .SubscribeOn(ExecutionContextScheduler)
                );
            return _listener.RaiseOnInitialize();
        }

        public ReturnCode_t on_finalize()
        {
            return _listener.RaiseOnFinalize();
        }

        public ReturnCode_t on_startup(int exec_handle)
        {
            return _listener.RaiseOnStartup(exec_handle);
        }

        public ReturnCode_t on_shutdown(int exec_handle)
        {
            return _listener.RaiseOnShutdown(exec_handle);
        }

        public ReturnCode_t on_activated(int exec_handle)
        {
            _observers.ForEach(observer => observer.UpdateStatusAsync(StatusKind.RTC_STATUS, "ACTIVE:0")
                                               .ToObservable() //TODO:
                                               .SubscribeOn(ExecutionContextScheduler));
                
            return _listener.RaiseOnActivated(exec_handle);
        }

        public ReturnCode_t on_deactivated(int exec_handle)
        {
            _observers.ForEach(observer => observer.UpdateStatusAsync(StatusKind.RTC_STATUS, "INACTIVE:0")
                .ToObservable()//TODO:
                .SubscribeOn(ExecutionContextScheduler));
            return _listener.RaiseOnDeactivated(exec_handle);
        }

        public ReturnCode_t on_aborting(int exec_handle)
        {
            _observers.ForEach(observer => observer.UpdateStatusAsync(StatusKind.RTC_STATUS, "ERROR:0")
                .ToObservable()//TODO:
                .SubscribeOn(ExecutionContextScheduler));
            return _listener.RaiseOnAborting(exec_handle);
            
        }

        public ReturnCode_t on_error(int exec_handle)
        {
            return _listener.RaiseOnError(exec_handle);
        }

        public ReturnCode_t on_reset(int exec_handle)
        {
            _observers.ForEach(observer => observer.UpdateStatusAsync(StatusKind.RTC_STATUS, "INACTIVE:0")
                .ToObservable()//TODO:
                .SubscribeOn(ExecutionContextScheduler));
            return _listener.RaiseOnReset(exec_handle);
        }

        public ReturnCode_t initialize()
        {
            _context = new ExecutionContextServiceAdapter();
            

            _context.add_component(this);

            return ReturnCode_t.RTC_OK;
        }

        public ReturnCode_t _finalize()
        {
            return ReturnCode_t.RTC_OK;
        }

        public bool is_alive(ExecutionContext exec_context)
        {
            return true;
        }

        public ReturnCode_t _exit()
        {
            return ReturnCode_t.RTC_OK;
        }

        public int attach_context(ExecutionContext exec_context)
        {
            throw new NotImplementedException();
        }

        public ReturnCode_t detach_context(int exec_handle)
        {
            throw new NotImplementedException();
        }

        public ExecutionContext get_context(int exec_handle)
        {
            return _context;
        }

        public ExecutionContext[] get_owned_contexts()
        {
            return new ExecutionContext[] { _context };
        }

        public ExecutionContext[] get_participating_contexts()
        {
            return new ExecutionContext[0];
        }

        public int get_context_handle(ExecutionContext cxt)
        {
            return 0;
        }

        public Organization[] get_owned_organizations()
        {
            return new Organization[0];
        }

        public string get_sdo_id()
        {
            throw new NotImplementedException();
        }

        public string get_sdo_type()
        {
            throw new NotImplementedException();
        }

        public DeviceProfile get_device_profile()
        {
            throw new NotImplementedException();
        }

        public ServiceProfile[] get_service_profiles()
        {
            throw new NotImplementedException();
        }

        public ServiceProfile get_service_profile(string id)
        {
            throw new NotImplementedException();
        }

        public SDOService get_sdo_service(string id)
        {
            throw new NotImplementedException();
        }

        public Configuration get_configuration()
        {
            return _configuration;
        }

        public Monitoring get_monitoring()
        {
            throw new NotImplementedException();
        }

        public Organization[] get_organizations()
        {
            throw new NotImplementedException();
        }

        public NameValue[] get_status_list()
        {
            throw new NotImplementedException();
        }

        public object get_status(string nme)
        {
            throw new NotImplementedException();
        }

        private ComponentProfile _profile;

        public ComponentProfile get_component_profile()
        {
            _profile.port_profiles = _reactivePorts.Select(p => p.PortService.get_port_profile()).ToArray();

            return _profile;
        }

        public PortService[] get_ports()
        {
            return _reactivePorts.Select(p => p.PortService).ToArray();
        }

        public ReturnCode_t on_execute(int exec_handle)
        {
            return _listener.RaiseOnExecute(exec_handle);
        }

        public ReturnCode_t on_state_update(int exec_handle)
        {
            return _listener.RaiseOnStateUpdate(exec_handle);
        }

        public ReturnCode_t on_rate_changed(int exec_handle)
        {
            return _listener.RaiseOnRateChanged(exec_handle);
        }

        private List<ReactivePortBase> _reactivePorts = new List<ReactivePortBase>();

        public void AddPort(ReactivePortBase reactivePort)
        {
            _reactivePorts.Add(reactivePort);
        }
        public void RemovePort(ReactivePortBase reactivePort)
        {
            _reactivePorts.Remove(reactivePort);
        }
    }

}

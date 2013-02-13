using ReactiveRTM.Core;
using ReactiveRTM.Data;
using ReactiveRTM.RTC;
using ReactiveRTM.RTM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveRTM.Servant
{
    class ManagerServant : Manager,IServant, IDisposable
    {
        private ManagerSetting _setting;
        public ManagerServant(ManagerSetting setting)
        {
            _setting = setting;

            if (_setting.IsMaster)
            {

            }
            else
            {
                var mgr = FindManager(_setting.MasterManager);

                AddMasterManager(mgr);
                mgr.AddSlaveManager(this);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        private Manager FindManager(string managerName)
        {
            throw new NotImplementedException();
        }

        public ReturnCode_t LoadModule(string pathname, string initfunc)
        {
            throw new NotImplementedException();
        }

        public ReturnCode_t UnloadModule(string pathname)
        {
            throw new NotImplementedException();
        }

        public List<ModuleProfile> GetLoadableModules()
        {
            throw new NotImplementedException();
        }

        public List<ModuleProfile> GetLoadedModules()
        {
            throw new NotImplementedException();
        }

        public List<ModuleProfile> GetFactoryProfiles()
        {
            throw new NotImplementedException();
        }

        public RTObject CreateComponent(string moduleName)
        {
            throw new NotImplementedException();
        }

        public ReturnCode_t DeleteComponent(string instanceName)
        {
            throw new NotImplementedException();
        }

        public List<RTObject> GetComponents()
        {
            throw new NotImplementedException();
        }

        public List<ComponentProfile> GetComponentProfiles()
        {
            throw new NotImplementedException();
        }

        public ManagerProfile GetProfile()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, object> GetConfiguration()
        {
            throw new NotImplementedException();
        }

        public ReturnCode_t SetConfiguration(string name, string value)
        {
            throw new NotImplementedException();
        }

        public bool IsMaster()
        {
            throw new NotImplementedException();
        }

        public List<Manager> GetMasterManagers()
        {
            throw new NotImplementedException();
        }

        public ReturnCode_t AddMasterManager(Manager mgr)
        {
            throw new NotImplementedException();
        }

        public ReturnCode_t RemoveMasterManager(Manager mgr)
        {
            throw new NotImplementedException();
        }

        public List<Manager> GetSlaveManagers()
        {
            throw new NotImplementedException();
        }

        public ReturnCode_t AddSlaveManager(Manager mgr)
        {
            throw new NotImplementedException();
        }

        public ReturnCode_t RemoveSlaveManager(Manager mgr)
        {
            throw new NotImplementedException();
        }

        public ReturnCode_t Fork()
        {
            throw new NotImplementedException();
        }

        public ReturnCode_t Shutdown()
        {
            throw new NotImplementedException();
        }

        public ReturnCode_t Restart()
        {
            throw new NotImplementedException();
        }

        public object GetService(string name)
        {
            throw new NotImplementedException();
        }
    }
}

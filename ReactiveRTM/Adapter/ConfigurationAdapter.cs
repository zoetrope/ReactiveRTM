using System;
using OpenRTM;
using ReactiveRTM.org.omg.SDOPackage;

namespace ReactiveRTM.Adapter
{
    public class ConfigurationAdapter : IConfiguration
    {
        private DataFlowComponentAdapter _owner;
        private ComponentObserver _observer;

        public ConfigurationAdapter(DataFlowComponentAdapter owner)
        {
            _owner = owner;
        }
                
        public bool SetDeviceProfile(DeviceProfile dProfile)
        {
            throw new NotImplementedException();
        }

        public bool AddServiceProfile(ServiceProfile sProfile)
        {
            if (sProfile.InterfaceType == "IDL:OpenRTM/ComponentObserver:1.0")
            {
                _owner.AddComponentObserver(sProfile);
                return true;
            }

            return false;
        }

        public bool AddOrganization(ReactiveRTM.org.omg.SDOPackage.Organization organization_object)
        {
            throw new NotImplementedException();
        }

        public bool RemoveServiceProfile(string id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveOrganization(string organization_id)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.List<Parameter> GetConfigurationParameters()
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.List<NameValue> GetConfigurationParameterValues()
        {
            throw new NotImplementedException();
        }

        public object GetConfigurationParameterValue(string name)
        {
            throw new NotImplementedException();
        }

        public bool SetConfigurationParameter(string name, ReactiveRTM.System.Object value)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.List<ConfigurationSet> GetConfigurationSets()
        {
            throw new NotImplementedException();
        }

        public ConfigurationSet GetConfigurationSet(string config_id)
        {
            throw new NotImplementedException();
        }

        public bool SetConfigurationSetValues(ConfigurationSet configuration_set)
        {
            throw new NotImplementedException();
        }

        public ConfigurationSet GetActiveConfigurationSet()
        {
            throw new NotImplementedException();
        }

        public bool AddConfigurationSet(ConfigurationSet configuration_set)
        {
            throw new NotImplementedException();
        }

        public bool RemoveConfigurationSet(string config_id)
        {
            throw new NotImplementedException();
        }

        public bool ActivateConfigurationSet(string config_id)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using OpenRTM;
using ReactiveRTM.org.omg.SDOPackage;
using ReactiveRTM.omg.org.RTC;

namespace ReactiveRTM.Adapter
{
    public class ConfigurationImpl : Configuration
    {
        private DataFlowComponent _owner;
        private ComponentObserver _observer;

        public ConfigurationImpl(DataFlowComponent owner)
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

        public bool AddOrganization(Organization organizationObject)
        {
            throw new NotImplementedException();
        }

        public bool RemoveServiceProfile(string id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveOrganization(string organizationId)
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

        public bool SetConfigurationParameter(string name, object value)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.List<ConfigurationSet> GetConfigurationSets()
        {
            throw new NotImplementedException();
        }

        public ConfigurationSet GetConfigurationSet(string configId)
        {
            throw new NotImplementedException();
        }

        public bool SetConfigurationSetValues(ConfigurationSet configurationSet)
        {
            throw new NotImplementedException();
        }

        public ConfigurationSet GetActiveConfigurationSet()
        {
            throw new NotImplementedException();
        }

        public bool AddConfigurationSet(ConfigurationSet configurationSet)
        {
            throw new NotImplementedException();
        }

        public bool RemoveConfigurationSet(string configId)
        {
            throw new NotImplementedException();
        }

        public bool ActivateConfigurationSet(string configId)
        {
            throw new NotImplementedException();
        }
    }
}

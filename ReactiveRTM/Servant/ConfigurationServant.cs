using System;
using OpenRTM;
using ReactiveRTM.SDOPackage;
using ReactiveRTM.RTC;
using System.Collections.Generic;

namespace ReactiveRTM.Servant
{
    public class ConfigurationServant : Configuration, IServant
    {
        private DataFlowComponentServant _owner;
        private ComponentObserver _observer;

        public ConfigurationServant(DataFlowComponentServant owner)
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

        public List<Parameter> GetConfigurationParameters()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, object> GetConfigurationParameterValues()
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

        public List<ConfigurationSet> GetConfigurationSets()
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

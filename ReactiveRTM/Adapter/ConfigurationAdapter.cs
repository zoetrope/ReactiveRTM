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

        public override object InitializeLifetimeService()
        {
            return null;
        }

        public bool set_device_profile(DeviceProfile dProfile)
        {
            throw new NotImplementedException();
        }

        
        public bool add_service_profile(ServiceProfile sProfile)
        {
            if (sProfile.interface_type == "IDL:OpenRTM/ComponentObserver:1.0")
            {
                _owner.AddComponentObserver(sProfile);
                return true;
            }

            return false;
        }

        public bool add_organization(Organization organization_object)
        {
            throw new NotImplementedException();
        }

        public bool remove_service_profile(string id)
        {
            throw new NotImplementedException();
        }

        public bool remove_organization(string organization_id)
        {
            throw new NotImplementedException();
        }

        public Parameter[] get_configuration_parameters()
        {
            throw new NotImplementedException();
        }

        public NameValue[] get_configuration_parameter_values()
        {
            throw new NotImplementedException();
        }

        public object get_configuration_parameter_value(string name)
        {
            throw new NotImplementedException();
        }

        public bool set_configuration_parameter(string name, object value)
        {
            throw new NotImplementedException();
        }

        public ConfigurationSet[] get_configuration_sets()
        {
            return new ConfigurationSet[0];
        }

        public ConfigurationSet get_configuration_set(string config_id)
        {
            throw new NotImplementedException();
        }

        public bool set_configuration_set_values(ConfigurationSet configuration_set)
        {
            throw new NotImplementedException();
        }

        public ConfigurationSet get_active_configuration_set()
        {
            return default(ConfigurationSet);
        }

        public bool add_configuration_set(ConfigurationSet configuration_set)
        {
            throw new NotImplementedException();
        }

        public bool remove_configuration_set(string config_id)
        {
            throw new NotImplementedException();
        }

        public bool activate_configuration_set(string config_id)
        {
            throw new NotImplementedException();
        }
    }
}

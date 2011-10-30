using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using ReactiveRTM.Corba;
using ReactiveRTM.Core;
using ReactiveRTM.Extensions;
using omg.org.RTC;
using org.omg.SDOPackage;

namespace ReactiveRTM.Adapter
{

    public class PortServiceAdapter : MarshalByRefObject, PortService
    {
        private PortProfile _profile;
        private IConnectable _connector;

        public PortServiceAdapter(IConnectable connector, PortProfile prof)
        {
            prof.port_ref = this;
            _connector = connector;
            _profile = prof;
        }

        public override object InitializeLifetimeService()
        {
            return null;
        }

        public PortProfile get_port_profile()
        {
            return _profile;
        }

        public ConnectorProfile[] get_connector_profiles()
        {
            return _profile.connector_profiles;
        }

        public ConnectorProfile get_connector_profile(string connector_id)
        {
            return _profile.connector_profiles
                .Single(prof => prof.connector_id == connector_id);
        }

        public ReturnCode_t connect(ref ConnectorProfile connector_profile)
        {
            if(string.IsNullOrEmpty(connector_profile.connector_id))
            {
                connector_profile.connector_id = Guid.NewGuid().ToString();
            }

            var port = connector_profile.ports.FirstOrDefault();
            if (port != null)
            {
                return port.notify_connect(ref connector_profile);
            }

            return ReturnCode_t.BAD_PARAMETER;
        }

        public ReturnCode_t disconnect(string connector_id)
        {
            throw new NotImplementedException();
        }

        public ReturnCode_t disconnect_all()
        {
            throw new NotImplementedException();
        }

        public ReturnCode_t notify_connect(ref ConnectorProfile connector_profile)
        {
            if(connector_profile.GetInterfaceType()!="corba_cdr")
            {
                throw new NotSupportedException();
            }

            _connector.SetConnectionInfo(ref connector_profile);

            var myIor = CorbaUtility.GetIor(this);

            //var port = connector_profile.ports.Select(CorbaUtility.GetIor).FirstOrDefault(ior => ior == myIor);

            int currentIndex = -1;
            for (int i = 0; i < connector_profile.ports.Length; i++)
            {
                if (CorbaUtility.GetIor(connector_profile.ports[i]) == myIor)
                {
                    currentIndex = i;
                    break;
                }
            }
            if (currentIndex == -1) return ReturnCode_t.BAD_PARAMETER;

            if (currentIndex + 1 < connector_profile.ports.Length)
            {
                connector_profile.ports[currentIndex + 1].notify_connect(ref connector_profile);
            }

            _connector.Connect(ref connector_profile);

            var list  =_profile.connector_profiles.ToList();
            list.Add(connector_profile);
            _profile.connector_profiles = list.ToArray();

            return ReturnCode_t.RTC_OK;
        }
        
        public ReturnCode_t notify_disconnect(string connector_id)
        {
            throw new NotImplementedException();
            
        }
    }

}

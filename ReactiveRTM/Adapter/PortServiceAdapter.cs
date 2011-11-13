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
        private PortProfileHolder _profile;
        private IConnectable _connector;

        public PortServiceAdapter(IConnectable connector, PortProfileHolder prof)
        {
            _connector = connector;
            _profile = prof;
            _profile.PortRef = this;
        }

        public override object InitializeLifetimeService()
        {
            return null;
        }

        public PortProfile get_port_profile()
        {
            return _profile.GetPortProfile();
        }

        public ConnectorProfile[] get_connector_profiles()
        {
            return _profile.GetPortProfile().connector_profiles;
        }

        public ConnectorProfile get_connector_profile(string connector_id)
        {
            return _profile.GetPortProfile().connector_profiles
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
            var prof = new ConnectorProfileHolder(connector_profile);

            if(prof.InterfaceType!="corba_cdr")
            {
                throw new NotSupportedException();
            }

            _connector.SetConnectionInfo(prof);

            var myIor = CorbaUtility.GetIor(this);

            //var port = connector_profile.ports.Select(CorbaUtility.GetIor).FirstOrDefault(ior => ior == myIor);

            int currentIndex = -1;
            for (int i = 0; i < prof.Ports.Count; i++)
            {
                if (CorbaUtility.GetIor(prof.Ports[i]) == myIor)
                {
                    currentIndex = i;
                    break;
                }
            }
            if (currentIndex == -1) return ReturnCode_t.BAD_PARAMETER;

            if (currentIndex + 1 < prof.Ports.Count)
            {
                var p = prof.GetConnectorProfile();
                prof.Ports[currentIndex + 1].notify_connect(ref p);
                prof = new ConnectorProfileHolder(p);
            }

            _connector.Connect(prof);

            _profile.ConnectorProfiles.Add(new ConnectorProfileHolder(prof.GetConnectorProfile()));

            return ReturnCode_t.RTC_OK;
        }
        
        public ReturnCode_t notify_disconnect(string connector_id)
        {
            throw new NotImplementedException();
            
        }
    }

}

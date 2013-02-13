using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using ReactiveRTM.Corba;
using ReactiveRTM.Core;
using ReactiveRTM.Extensions;
using ReactiveRTM.RTC;
using ReactiveRTM.Data;

namespace ReactiveRTM.Servant
{

    public class PortServiceServant : PortService, IServant
    {
        private PortProfile _profile;
        private IConnectable _connector;

        public PortServiceServant(IConnectable connector, PortProfile prof)
        {
            _connector = connector;
            _profile = prof;
            _profile.PortRef = this;
        }

        public PortProfile GetPortProfile()
        {
            return _profile;
        }

        public List<ConnectorProfile> GetConnectorProfiles()
        {
            return _profile.ConnectorProfiles;
        }

        public ConnectorProfile GetConnectorProfile(string connectorId)
        {
            return _profile.ConnectorProfiles
                .Single(prof => prof.ConnectorId == connectorId);
        }

        public ReturnCode_t Connect(ref ConnectorProfile connectorProfile)
        {
            if (string.IsNullOrEmpty(connectorProfile.ConnectorId))
            {
                connectorProfile.ConnectorId = Guid.NewGuid().ToString();
            }

            var port = connectorProfile.Ports.FirstOrDefault();
            if (port != null)
            {
                return port.NotifyConnect(ref connectorProfile);
            }

            return ReturnCode_t.BAD_PARAMETER;
        }

        public ReturnCode_t Disconnect(string connectorId)
        {
            throw new NotImplementedException();
        }

        public ReturnCode_t DisconnectAll()
        {
            throw new NotImplementedException();
        }

        public ReturnCode_t NotifyConnect(ref ConnectorProfile connectorProfile)
        {

            if (connectorProfile.GetInterfaceType() != "corba_cdr")
            {
                throw new NotSupportedException();
            }

            _connector.SetConnectionInfo(connectorProfile);

            var myIor = CorbaUtility.GetIor(this);

            //var port = connector_profile.ports.Select(CorbaUtility.GetIor).FirstOrDefault(ior => ior == myIor);

            int currentIndex = -1;
            for (int i = 0; i < connectorProfile.Ports.Count; i++)
            {
                if (CorbaUtility.GetIor(connectorProfile.Ports[i]) == myIor)
                {
                    currentIndex = i;
                    break;
                }
            }
            if (currentIndex == -1) return ReturnCode_t.BAD_PARAMETER;

            if (currentIndex + 1 < connectorProfile.Ports.Count)
            {
                connectorProfile.Ports[currentIndex + 1].NotifyConnect(ref connectorProfile);
            }

            _connector.Connect(connectorProfile);

            _profile.ConnectorProfiles.Add(connectorProfile);

            return ReturnCode_t.RTC_OK;
        }

        public ReturnCode_t NotifyDisconnect(string connectorId)
        {
            throw new NotImplementedException();
        }
    }

}

using System;
using ReactiveRTM.Core;
using ReactiveRTM.Extensions;
using ReactiveRTM.omg.org.RTC;
using System.Collections.Generic;
using ReactiveRTM.OpenRTM;

namespace ReactiveRTM.Mock
{
    public class OutPortServiceMock : PortServiceMock
    {
        private InPortCdr _inPortCdr;
        public OutPortServiceMock(PortProfile prof)
            : base(prof)
        {
        }

        public InPortCdr GetInPortCdr()
        {
            return _inPortCdr;
        }

        public override ReturnCode_t Connect(ref ConnectorProfile connectorProfile)
        {
            var ior = connectorProfile.GetInPortIor();


            
            var orb = global::omg.org.CORBA.OrbServices.GetSingleton();

            _inPortCdr = (InPortCdr)orb.string_to_object(ior);

            return ReturnCode_t.RTC_OK;
        }
    }

    public class InPortServiceMock : PortServiceMock
    {
        private InPortCdr _inPortCdrMock;
        public InPortServiceMock(PortProfile prof, InPortCdr mock)
            :base(prof)
        {
            _inPortCdrMock = mock;
        }

        public override ReturnCode_t Connect(ref ConnectorProfile connectorProfile)
        {
            var orb = global::omg.org.CORBA.OrbServices.GetSingleton();

            connectorProfile.SetInPortIor(orb.object_to_string(_inPortCdrMock));

            return ReturnCode_t.RTC_OK;
        }
    }

    public abstract class PortServiceMock : PortService
    {
        private PortProfile _profile;

        public PortServiceMock(PortProfile prof)
        {
            _profile = prof;
        }
        

        public PortProfile GetPortProfile()
        {
            return _profile;
        }

        public List<ConnectorProfile> GetConnectorProfiles()
        {
            throw new NotImplementedException();
        }

        public ConnectorProfile GetConnectorProfile(string connectorId)
        {
            throw new NotImplementedException();
        }

        public abstract ReturnCode_t Connect(ref ConnectorProfile connectorProfile);

        public ReturnCode_t Disconnect(string connectorId)
        {
            return ReturnCode_t.RTC_OK;
        }

        public ReturnCode_t DisconnectAll()
        {
            throw new NotImplementedException();
        }

        public ReturnCode_t NotifyConnect(ref ConnectorProfile connectorProfile)
        {
            throw new NotImplementedException();
        }

        public ReturnCode_t NotifyDisconnect(string connectorId)
        {
            throw new NotImplementedException();
        }
    }

}

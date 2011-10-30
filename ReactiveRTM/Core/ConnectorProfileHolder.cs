using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using omg.org.RTC;

namespace ReactiveRTM.Core
{
    internal class ConnectorProfileHolder
    {
        private ConnectorProfile _profile;

        public string Name
        {
            get { return _profile.name; }
            set { _profile.name = value; }
        }
        public string ConnectorID
        {
            get { return _profile.connector_id; }
            set { _profile.connector_id = value; }
        }
        public List<PortService> Ports
        {
            get { return _profile.ports.ToList(); }
            set { _profile.ports = value.ToArray(); }
        }
    }
}

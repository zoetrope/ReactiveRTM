using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReactiveRTM.Extensions;
using omg.org.RTC;
using org.omg.SDOPackage;

namespace ReactiveRTM.Core
{
    public class ComponentProfileHolder
    {
        private ComponentProfile _profile;

        public ComponentProfileHolder()
        {
            _profile.port_profiles = new PortProfile[0];
            _profile.properties = new NameValue[0];
        }

        public ComponentProfileHolder(ComponentProfile prof)
        {
            _profile = prof;
            
        }

        public string Category {
            get { return _profile.category; }
            set { _profile.category = value; }
        }
        public string Description
        {
            get { return _profile.description; }
            set { _profile.description = value; }
        }
        public string InstanceName
        {
            get { return _profile.instance_name; }
            set { _profile.instance_name = value; }
        }
        public RTObject Parent
        {
            get { return _profile.parent; }
            set { _profile.parent = value; }
        }
        public string TypeName
        {
            get { return _profile.type_name; }
            set { _profile.type_name = value; }
        }
        public string Vendor
        {
            get { return _profile.vendor; }
            set { _profile.vendor= value; }
        }
        public string Version
        {
            get { return _profile.version; }
            set { _profile.version = value; }
        }
        public List<PortProfileHolder> PortProfiles
        {
            get { return _profile.port_profiles.Select(x=>new PortProfileHolder(x)).ToList(); }
        }
        
    }
}

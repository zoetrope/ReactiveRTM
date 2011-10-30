using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using Codeplex.Data;
using OpenRTM;
using RTC;
using ReactiveRTM.Corba;
using ReactiveRTM.Core;
using ReactiveRTM.Extensions;
using omg.org.RTC;
using org.omg.SDOPackage;

namespace ReactiveRTM.Core
{
    public class ReactiveOutPort<TDataType> : ReactivePortBase
    {
        private InPortCdr _proxy;
        private CdrSerializer<TDataType> _serializer;

        public ReactiveOutPort(string name)
            : base(name)
        {
            var prof = new PortProfile(name, new PortInterfaceProfile[0], null, new ConnectorProfile[0],null, new NameValue[0]);

            var factory = new CdrSerializerFactory();
            _serializer = factory.GetSerializer<TDataType>();

            PortProfileExtensions.AddDataFlowType(ref prof, "push");
            PortProfileExtensions.AddSubscriptionType(ref prof, "flush");
            PortProfileExtensions.AddInterfaceType(ref prof, "corba_cdr");

            NameValueExtensions.AddStringValue(ref prof.properties, "port.port_type", "DataOutPort"); 
            NameValueExtensions.AddStringValue(ref prof.properties, "dataport.data_type", CorbaUtility.GetRepositoryID(typeof(TDataType)));

            Initialize(prof);

        }

        public IDisposable Subscribe(IObserver<TDataType> observer)
        {
            throw new NotImplementedException();
        }


        public PortStatus Write(TDataType data)
        {
            var stream = new MemoryStream();
            _serializer.Serialize(data, stream);
            return _proxy.put(stream.ToArray());
        }

        public IObservable<PortStatus> WriteAsync(TDataType data)
        {
            return Observable.Defer(() => Observable.Start(() => Write(data)));
            
        }


        #region Overrides of ReactivePortBase

        public override ReturnCode_t SetConnectionInfo(ref ConnectorProfile connectorProfile)
        {
            return ReturnCode_t.RTC_OK;
        }

        public override ReturnCode_t Connect(ref ConnectorProfile connectorProfile)
        {
            var ior = connectorProfile.GetInPortIor();
            _proxy = CorbaUtility.ToObject<InPortCdr>(ior);
            return ReturnCode_t.RTC_OK;
        }

        public override ReturnCode_t Disconnect(ref ConnectorProfile connectorProfile)
        {
            return ReturnCode_t.RTC_OK;
        }

        #endregion
    }

    public class ReactiveOutPort : ReactiveOutPort<TimedWString>
    {
        ReactiveOutPort(string name)
            :base(name)
        {
        }
        
        public void Write(object data)
        {
            var json = DynamicJson.Serialize(data);

            TimedWString ts = new TimedWString();
            ts.data = json;

            base.Write(ts);
        }
        
        public void WriteAsync(object data)
        {
            var json = DynamicJson.Serialize(data);

            TimedWString ts = new TimedWString();
            ts.data = json;

            base.WriteAsync(ts);
        }
    }
}

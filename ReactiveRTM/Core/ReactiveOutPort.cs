﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive;
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
    public class ReactiveOutPort<TDataType> : ReactivePortBase, IObserver<TDataType>
    {
        private List<IObserver<TDataType>> _observers = new List<IObserver<TDataType>>();
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


        public PortStatus Write(TDataType data)
        {

            _observers.ForEach(observer => observer.OnNext(data));

            return PortStatus.PORT_OK;
        }

        public IObservable<PortStatus> WriteAsync(TDataType data)
        {
            return Observable.Defer(() => Observable.Start(() => Write(data)));
            
        }

        public void Connect(IObserver<TDataType> observer)
        {
            _observers.Add(observer);
        }

        #region Overrides of ReactivePortBase

        public override ReturnCode_t SetConnectionInfo(ref ConnectorProfile connectorProfile)
        {
            return ReturnCode_t.RTC_OK;
        }

        public override ReturnCode_t Connect(ref ConnectorProfile connectorProfile)
        {
            var ior = connectorProfile.GetInPortIor();
            var proxy = CorbaUtility.ToObject<InPortCdr>(ior);

            var observer = Observer.Create((TDataType data) =>
            {
                var stream = new MemoryStream();
                _serializer.Serialize(data, stream);
                proxy.put(stream.ToArray());
            });

            _observers.Add(observer);

            return ReturnCode_t.RTC_OK;
        }

        public override ReturnCode_t Disconnect(ref ConnectorProfile connectorProfile)
        {
            return ReturnCode_t.RTC_OK;
        }

        #endregion

        public void OnNext(TDataType value)
        {
            WriteAsync(value);
        }

        public void OnError(Exception error)
        {
            
        }

        public void OnCompleted()
        {
            
        }
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

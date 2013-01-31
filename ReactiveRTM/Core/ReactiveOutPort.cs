using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using Codeplex.Data;
using ReactiveRTM.Corba;
using ReactiveRTM.Core;
using ReactiveRTM.Extensions;
using ReactiveRTM.OpenRTM;
using ReactiveRTM.RTC;
using ReactiveRTM.omg.org.RTC;

namespace ReactiveRTM.Core
{
    public class ReactiveOutPort<TDataType> : ReactivePortBase, IObserver<TDataType>
    {
        private List<IObserver<TDataType>> _observers = new List<IObserver<TDataType>>();
        private CdrSerializer<TDataType> _serializer;

        public ReactiveOutPort(string name)
            : base(name)
        {
            var prof = new PortProfileHolder() { Name = name };

            var factory = new CdrSerializerFactory();
            _serializer = factory.GetSerializer<TDataType>();

            prof.DataflowType = "push";
            prof.SubscriptionType = "flush";
            prof.InterfaceType = "corba_cdr";

            prof.PortType = PortType.DataOutPort;
            prof.DataType = CorbaUtility.GetRepositoryId(typeof(TDataType));
                

            Initialize(prof);

        }


        public PortStatus Write(TDataType data)
        {

            _observers.ForEach(observer => observer.OnNext(data));

            return PortStatus.PORT_OK;
        }

        public IObservable<PortStatus> WriteAsync(TDataType data)
        {
            //return Observable.Defer(() => Observable.Start(() => Write(data)));
            return Observable.Start(() => Write(data));
            
        }

        public void Connect(IObserver<TDataType> observer)
        {
            _observers.Add(observer);
        }

        #region Overrides of ReactivePortBase

        public override ReturnCode_t SetConnectionInfo(ConnectorProfile connectorProfile)
        {
            return ReturnCode_t.RTC_OK;
        }

        public override ReturnCode_t Connect(ConnectorProfile connectorProfile)
        {
            var ior = connectorProfile.InPortIor;
            var proxy = CorbaUtility.ToObject<InPortCdr>(ior);

            var observer = Observer.Create((TDataType data) =>
            {
                var stream = new MemoryStream();
                _serializer.Serialize(data, stream);
                proxy.Put(stream.ToArray());
            });

            _observers.Add(observer);

            return ReturnCode_t.RTC_OK;
        }

        public override ReturnCode_t Disconnect(ConnectorProfile connectorProfile)
        {
            return ReturnCode_t.RTC_OK;
        }

        #endregion

        public void OnNext(TDataType value)
        {
            Write(value);
        }

        public void OnError(Exception error)
        {
            
        }

        public void OnCompleted()
        {
            
        }
    }

    public class DynamicOutPort : ReactiveOutPort<TimedWString>
    {
        DynamicOutPort(string name)
            :base(name)
        {
        }
        
        public void Write(object data)
        {
            var json = DynamicJson.Serialize(data);

            TimedWString ts = new TimedWString();
            ts.Data = json;

            base.Write(ts);
        }
        
        public void WriteAsync(object data)
        {
            var json = DynamicJson.Serialize(data);

            TimedWString ts = new TimedWString();
            ts.Data = json;

            base.WriteAsync(ts);
        }
    }
}

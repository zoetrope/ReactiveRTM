using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using ReactiveRTM.Adapter;
using ReactiveRTM.Corba;
using ReactiveRTM.Extensions;
using ReactiveRTM.RTC;
using ReactiveRTM.omg.org.RTC;
using ReactiveRTM.OpenRTM;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace ReactiveRTM.Core
{
    public class ReactiveInPort<TDataType> : ReactivePortBase, IObservable<TDataType>
    {
        private Subject<TDataType> _source;
        private CdrSerializer<TDataType> _serializer;
        private InPortCdrImpl _adapter;

        public ReactiveInPort(string name)
            : base(name)
        {

            var factory = new CdrSerializerFactory();
            _serializer = factory.GetSerializer<TDataType>();

            _adapter = new InPortCdrImpl();

            _source = new Subject<TDataType>();

            _adapter.DataReceivedAsObservable()
                .Select(x => _serializer.Deserialize(new MemoryStream(x.ToArray())))
                .Subscribe(x => _source.OnNext(x));

            var prof = new PortProfile() { Name = name };

            prof.SetDataflowType ("push");
            prof.SetSubscriptionType("flush");
            prof.SetInterfaceType("corba_cdr");

            prof.SetPortType(PortType.DataInPort);
            prof.SetDataType(CorbaUtility.GetRepositoryId(typeof(TDataType)));

            Initialize(prof);
        }
        public IDisposable Subscribe(IObserver<TDataType> observer)
        {
            return _source.Subscribe(observer);
        }


        public void Connect(IObservable<TDataType> observable)
        {
            observable.Subscribe(x => _source.OnNext(x));
        }


        #region Overrides of ReactivePortBase 

        public override ReturnCode_t SetConnectionInfo(ConnectorProfile connectorProfile)
        {
            connectorProfile.SetInPortIor(CorbaUtility.GetIor(_adapter));
            return ReturnCode_t.RTC_OK;
        }

        public override ReturnCode_t Connect(ConnectorProfile connectorProfile)
        {
            return ReturnCode_t.RTC_OK;
        }

        public override ReturnCode_t Disconnect(ConnectorProfile connectorProfile)
        {
            return ReturnCode_t.RTC_OK;
        }

        #endregion
    }

    public class DynamicInPort : ReactiveInPort<TimedWString>
    {
        private Subject<TimedWString> _source;
        private CdrSerializer<TimedWString> _serializer;

        public DynamicInPort(string name)
            : base(name)
        {
            var factory = new CdrSerializerFactory();
            _serializer = factory.GetSerializer<TimedWString>();

            _source = new Subject<TimedWString>();

            var cdr = new InPortCdrImpl();

            cdr.DataReceivedAsObservable()
                .Subscribe(x => _source.OnNext(Parse(x)));

            var ior = CorbaUtility.GetIor(cdr);


        }

        private TimedWString Parse(IEnumerable<byte> data)
        {
            return _serializer.Deserialize(new MemoryStream(data.ToArray()));
        }


        public IDisposable Subscribe(IObserver<dynamic> observer)
        {
            return _source.Select(x => JObject.Parse(x.Data)).Subscribe(observer);
        }
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Push(object data)
        {
            var json = JObject.FromObject(data).ToString();
            var ts = new TimedWString();
            ts.Data = json;

            _source.OnNext(ts);
        }

    }
    /*
    public class ClassicInPort<TDataType> : ReactiveInPort<TDataType>
    {
    }
    */
}

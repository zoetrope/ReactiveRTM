using System;
using System.ComponentModel;
using System.IO;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using Codeplex.Data;
using ReactiveRTM.Adapter;
using ReactiveRTM.Corba;
using ReactiveRTM.Extensions;
using ReactiveRTM.RTC;

namespace ReactiveRTM.Core
{
    public class ReactiveInPort<TDataType> : ReactivePortBase, IObservable<TDataType>
    {
        private Subject<TDataType> _source;
        private CdrSerializer<TDataType> _serializer;
        private InPortCdrAdapter _adapter;

        public ReactiveInPort(string name)
            : base(name)
        {

            var factory = new CdrSerializerFactory();
            _serializer = factory.GetSerializer<TDataType>();

            _adapter = new InPortCdrAdapter();

            _source = new Subject<TDataType>();

            _adapter.DataReceivedAsObservable()
                .Select(x => _serializer.Deserialize(new MemoryStream(x)))
                .Subscribe(x => _source.OnNext(x));

            var prof = new PortProfileHolder() { Name = name };

            prof.DataflowType = "push";
            prof.SubscriptionType= "flush";
            prof.InterfaceType= "corba_cdr";

            prof.PortType = PortType.DataInPort;
            prof.DataType = CorbaUtility.GetRepositoryId(typeof(TDataType));

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

        public override ReturnCode_t SetConnectionInfo(ConnectorProfileHolder connectorProfile)
        {
            connectorProfile.InPortIor = CorbaUtility.GetIor(_adapter);
            return ReturnCode_t.RTC_OK;
        }

        public override ReturnCode_t Connect(ConnectorProfileHolder connectorProfile)
        {
            return ReturnCode_t.RTC_OK;
        }

        public override ReturnCode_t Disconnect(ConnectorProfileHolder connectorProfile)
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

            var cdr = new InPortCdrAdapter();

            cdr.DataReceivedAsObservable()
                .Subscribe(x => _source.OnNext(Parse(x)));

            var ior = CorbaUtility.GetIor(cdr);


        }

        private TimedWString Parse(byte[] data)
        {
            return _serializer.Deserialize(new MemoryStream(data));
        }


        public IDisposable Subscribe(IObserver<dynamic> observer)
        {
            return _source.Select(x => DynamicJson.Parse(x.data)).Subscribe(observer);
        }
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Push(object data)
        {
            var json = DynamicJson.Serialize(data);
            var ts = new TimedWString();
            ts.data = json;

            _source.OnNext(ts);
        }

    }

}

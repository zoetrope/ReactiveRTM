using ReactiveRTM.Core;
using ReactiveRTM.OpenRTM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveRTM.Corba
{
    class NamingServiceContainer : IDisposable
    {
        private NamingSetting _setting;
        private List<NamingServiceWrapper> _namingServices;
        private IDisposable _timerDispose;

        public bool IsEnabled { get; set; }

        public NamingServiceContainer(NamingSetting setting)
        {
            _setting = setting;

            if (_setting.Enable.Value)
            {
                IsEnabled = true;
            }

            _namingServices = _setting.NamingServers.Select(x => new NamingServiceWrapper(x)).ToList();

            if (_setting.Update.Enable.Value)
            {
                _timerDispose = Observable.Timer(TimeSpan.FromSeconds(_setting.Update.Interval.Value))
                    .Subscribe(x => Update());
            }

        }

        private void Update()
        {

        }

        public void RegisterComponent(ReactiveComponentBase comp)
        {
            if (IsEnabled)
            {
                _namingServices.ForEach(ns => ns.Register(comp.Name + ".rtc", (MarshalByRefObject)comp.Component));
            }
        }


        public void Dispose()
        {
            _timerDispose.Dispose();

            _namingServices.ForEach(x => x.Dispose());
        }

        internal DataFlowComponent GetComponent(string name)
        {
            var comp = _namingServices.Select(x => x.GetObject<global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent>(name).Result);
            return new DataFlowComponentStub(comp.FirstOrDefault());

        }
    }

    class NamingServiceWrapper : IDisposable
    {
        private INamingServiceClient _client;
        public bool IsAlive { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }

        public NamingServiceWrapper(string host)
        {
            Host = host;
            IsAlive = false;

            Reconnect();
        }

        private async Task Reconnect()
        {
            if (!IsAlive)
            {
                try
                {
                    await Task.Factory.StartNew(() =>
                    {
                        //TODO: typeに応じてインスタンスを作り分ける
                        _client = new NamingServiceClient(Host, Port);
                    });
                    IsAlive = true;
                }
                catch (Exception ex)
                {
                    IsAlive = false;
                }
            }
        }

        public async void Register(string name, MarshalByRefObject obj)
        {
            await Reconnect();
            if (IsAlive)
            {
                try
                {
                    _client.RegisterObject(name, (MarshalByRefObject)obj);
                }
                catch
                {
                    IsAlive = false;
                }
            }
        }

        public async Task Unregister(string name)
        {
            await Reconnect();
            if (IsAlive)
            {
                try
                {
                    _client.UnregisterObject(name);
                }
                catch
                {
                    IsAlive = false;
                }
            }
        }

        public async Task<TObjectType> GetObject<TObjectType>(string name) where TObjectType : class
        {
            await Reconnect();
            if (IsAlive)
            {
                try
                {
                    return _client.GetObject<TObjectType>(name);
                }
                catch
                {
                    IsAlive = false;
                }
            }
            return null;
        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }

}

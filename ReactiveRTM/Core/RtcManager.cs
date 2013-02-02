using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using ReactiveRTM.Adapter;
using ReactiveRTM.Corba;
using ReactiveRTM.Core;
using ReactiveRTM.openrtm.aist.go.jp.OpenRTM;
using NDesk.Options;
using System.IO;
using YamlDotNet.RepresentationModel.Serialization;

namespace ReactiveRTM.Core
{
    public class RtcManager : IDisposable
    {
        private NamingServiceClient _client;
        private RtcSetting _setting;

        public RtcSetting RtcSetting
        {
            get { return _setting; }
        }

        public RtcManager()
        {
            
        }

        public RtcManager(IEnumerable<string> args)
            : this()
        {
            ParseOption(args);
            CorbaUtility.Initialize(_setting.Corba);
        }

        public RtcManager(string host, int port)
            : this()
        {
            _client = new NamingServiceClient(host, port);
        }

        private void ParseOption(IEnumerable<string> args)
        {
            string settingFileName = null;
            bool help = false;
            int verbose = 0;
            bool version=false;

            var p = new OptionSet() {
                { "f|file=",      v => settingFileName = v },
                { "v|version",  v => version = true },
                { "h|?|help",   v => help = v != null },
            };
            var extra = p.Parse(args);

            ParseSetting(settingFileName);
        }

        private void ParseSetting(string fileName)
        {
            var settingFile = fileName;
            if (string.IsNullOrEmpty(settingFile) || !File.Exists(settingFile))
            {
                settingFile = _defaultSettingFileNames.Where(f => File.Exists(f)).FirstOrDefault();
            }

            if (!string.IsNullOrEmpty(settingFile))
            {
                try
                {
                    using (var input = new StreamReader(settingFile, Encoding.UTF8))
                    {
                        var yamlSerializer = new YamlSerializer<RtcSetting>();
                        _setting = yamlSerializer.Deserialize(input);
                    }
                }
                catch (FileNotFoundException)
                {
                }
            }
            else
            {
                CreateDefaultSetting();
            }

        }

        private void CreateDefaultSetting()
        {
            throw new NotImplementedException();
        }

        private List<string> _defaultSettingFileNames = new List<string> { "rtc.yaml" };

        public void RegisterComponent(ReactiveComponentBase comp)
        {
            _client.RegisterObject(comp.Name + ".rtc", (MarshalByRefObject)comp.Component);
        }

        public void Run()
        {
            Thread.Sleep(Timeout.Infinite);
        }

        public void Dispose()
        {
            CorbaUtility.Destroy();
        }

        public IObservableComponent GetComponent(string name)
        {
            var comp = _client.GetObject<global::omg.org.RTC.RTObject>(name);
            var stub = new DataFlowComponentStub((global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent)comp);
            return new ObservableComponent(stub);
        }
    }
}

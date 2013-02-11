using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using ReactiveRTM.Adapter;
using ReactiveRTM.Corba;
using ReactiveRTM.Core;
using ReactiveRTM.OpenRTM;
using NDesk.Options;
using System.IO;
using YamlDotNet.RepresentationModel.Serialization;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;
using System.ComponentModel.Composition.Registration;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Primitives;
using Common.Logging;
using YamlDotNet.Core;

namespace ReactiveRTM.Core
{

#if LANG_JP
    /// <summary>
    /// RTコンポーネントの生成・ライフサイクル管理、各種サービスの提供
    /// </summary>
#else
    /// <summary>
    /// 
    /// </summary>
#endif
    /// <example>
    /// <code>
    /// using(var manager = new Manager(args))
    /// {
    ///     manager.CreateComponent("");
    ///     
    ///     manager.Wait();
    /// }
    /// </code>
    /// </example>
    public class RtcManager : IDisposable
    {
        private ILog _logger = LogManager.GetCurrentClassLogger();
        private NamingServiceClient _client;
        private RtcSetting _setting;

        public RtcSetting RtcSetting
        {
            get { return _setting; }
        }

        
#if LANG_JP
        /// <summary>
        /// オプションを指定して<see cref="RtcManager"/>のインスタンスを生成
        /// </summary>
        /// <param name="args">
        /// オプションの指定
        /// <list type="bullet">
        /// <item>
        /// -f filename : 
        /// </item>
        /// </list>
        /// </param>
#else
#endif
        public RtcManager(IEnumerable<string> args)
        {
            Initialize(args);
        }

        public RtcManager()
            : this(new string[]{})
        {

        }

        private void Initialize(IEnumerable<string> args)
        {
            try
            {
                var settingFile = ParseOption(args);
                ParseSetting(settingFile);

                CorbaUtility.Initialize(_setting.Corba);

                if (_setting.Naming.Enable.Value)
                {
                    _client = new NamingServiceClient();
                }

                LoadComponent();
            }
            catch (FileNotFoundException ex)
            {
                _logger.Error("設定ファイルが見つからない");
                throw;
            }
            catch (SyntaxErrorException ex)
            {
                _logger.Error("設定ファイルのフォーマットがおかしい");
                throw;
            }
            finally
            {
                Dispose();
            }
        }
        
#if LANG_JP
        /// <summary>
        /// 名前を指定してコンポーネントを生成
        /// </summary>
        /// <param name="name">コンポーネントのフルネーム</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">存在しない名前の</exception>
        /// <exception cref="InvalidCastException">指定した名前の型が<see cref="ReactiveComponent" />ではない</exception>
#else
#endif
        public ReactiveComponent CreateComponent(string name)
        {
            var def = new ImportDefinition(i => i.ContractName.Equals(name),
                name, ImportCardinality.ZeroOrMore, false, false);
            var exports = _container.GetExports(def);
            if (exports.Count() == 0)
            {
                _logger.Error("");
                throw new ArgumentException("", "name");
            }
            var comp = exports.Single().Value as ReactiveComponent;
            if (comp == null)
            {
                _logger.Error("");
                throw new InvalidCastException("");
            }
            return comp;
        }

#if LANG_JP
        /// <summary>
        /// 型を指定してコンポーネントを生成
        /// </summary>
        /// <typeparam name="TComponent"></typeparam>
        /// <returns></returns>
#else
#endif
        public TComponent CreateComponent<TComponent>()
        {
            try
            {
                return _container.GetExportedValue<TComponent>();

            }
            catch (CompositionContractMismatchException ex)
            {
                _logger.Error("", ex);
                throw;
            }
        }

        private CompositionContainer _container;

        public void LoadComponent()
        {
            
            var builder = new RegistrationBuilder();
            builder.ForTypesDerivedFrom<ReactiveComponent>()
                   .Export()
                   .SetCreationPolicy(CreationPolicy.NonShared);

            var catalog = new AggregateCatalog();
            foreach (var setting in _setting.Catalogs)
            {
                switch (setting.Catalog)
                {
                    case "AssemblyCatalog":
                        foreach (var arg in setting.Args)
                        {
                            catalog.Catalogs.Add(new AssemblyCatalog(Assembly.LoadFrom(arg),builder));
                        }
                        break;
                    case "DirectoryCatalog":
                        foreach (var arg in setting.Args)
                        {
                            catalog.Catalogs.Add(new DirectoryCatalog(arg, builder));
                        }
                        break;
                    case "TypeCatalog":
                        var types = setting.Args.Select(t => Type.GetType(t));
                        catalog.Catalogs.Add(new TypeCatalog(types, builder));
                        break;
                    default:
                        throw new Exception("");
                }
            }

            var defaultAssemblies = new List<Assembly>{
                Assembly.GetCallingAssembly(),
                Assembly.GetExecutingAssembly(),
                Assembly.GetEntryAssembly()
            };
            defaultAssemblies
                .Where(asm => asm != null)
                .Distinct()
                .ToList()
                .ForEach(asm => catalog.Catalogs.Add(new AssemblyCatalog(asm)));
            
            _container = new CompositionContainer(catalog);

        }


        private string ParseOption(IEnumerable<string> args)
        {
            string settingFileName = null;
            bool help = false;
            bool version=false;

            var p = new OptionSet() {
                { "f|file=",      v => settingFileName = v },
                { "v|version",  v => version = true },
                { "h|?|help",   v => help = v != null },
            };
            var extra = p.Parse(args);

            return settingFileName;
            
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
                using (var input = new StreamReader(settingFile, Encoding.UTF8))
                {
                    var yamlSerializer = new YamlSerializer<RtcSetting>();
                    _setting = yamlSerializer.Deserialize(input);
                }
            }
            else
            {
                CreateDefaultSetting();
            }

        }

        private void CreateDefaultSetting()
        {
            _setting = new RtcSetting();

        }

        private List<string> _defaultSettingFileNames = new List<string> { "rtc.yaml" };

        public void RegisterComponent(ReactiveComponentBase comp)
        {
            _client.RegisterObject(comp.Name + ".rtc", (MarshalByRefObject)comp.Component);
        }

        private ManualResetEvent _event = new ManualResetEvent(false);

        public void Run()
        {
            _event.WaitOne();
        }

        public void Dispose()
        {
            CorbaUtility.Destroy();
            _event.Set();
        }

        public IObservableComponent GetComponent(string name)
        {
            var comp = _client.GetObject<global::omg.org.RTC.RTObject>(name);
            var stub = new DataFlowComponentStub((global::openrtm.aist.go.jp.OpenRTM.DataFlowComponent)comp);
            return new ObservableComponent(stub);
        }
    }
}

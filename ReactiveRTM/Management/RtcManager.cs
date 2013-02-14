using Common.Logging;
using NDesk.Options;
using ReactiveRTM.Component;
using ReactiveRTM.Corba;
using ReactiveRTM.OpenRTM;
using ReactiveRTM.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using YamlDotNet.Core;

namespace ReactiveRTM.Management
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


        private ModuleFactory<ReactiveComponent> _componentFactory;
        private RtcSetting _setting;
        private NamingServiceContainer _namingContainer;


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
            : this(new string[] { })
        {

        }

        private void Initialize(IEnumerable<string> args)
        {
            try
            {
                var opt = RunOption.Parse(args);
                
                _setting = RtcSetting.Load(opt.SettingFileName);

                CorbaUtility.Initialize(_setting.Corba);
                _namingContainer = new NamingServiceContainer(_setting.Naming);

                _componentFactory = new ModuleFactory<ReactiveComponent>(_setting.Catalogs);
                _componentFactory.LoadCatalog();
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
            return _componentFactory.Create(name);
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
            return _componentFactory.Create<TComponent>();
        }



        public void RegisterComponent(ReactiveComponentBase comp)
        {
            _namingContainer.RegisterComponent(comp);
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
            var comp = _namingContainer.GetComponent(name);
            return new ObservableComponent(comp);
        }
    }


}
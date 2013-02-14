using Common.Logging;
using ReactiveRTM.Component;
using ReactiveRTM.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.ComponentModel.Composition.Registration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveRTM.Management
{
    class ModuleManager
    {
        public ModuleManager(List<CatalogSetting> settings)
        {
            var componentFactory = new ModuleFactory<ReactiveComponent>(settings);
        }

        //NamingService
        //SdoService(Logger,ComponentObserver)
        //ExecutionContext
        //Port?



    }

    public class ModuleFactory<TObject> where TObject : class
    {
        private ILog _logger = LogManager.GetCurrentClassLogger();
        private CompositionContainer _container;
        private List<CatalogSetting> _catalogSettings;

        public ModuleFactory(List<CatalogSetting> settings)
        {
            _catalogSettings = settings;
        }

        public void LoadCatalog()
        {

            var builder = new RegistrationBuilder();
            builder.ForTypesDerivedFrom<TObject>()
                   .Export()
                   .SetCreationPolicy(CreationPolicy.NonShared);

            _container = CreateCatalog(builder);
        }

        private CompositionContainer CreateCatalog(RegistrationBuilder builder)
        {
            var catalog = new AggregateCatalog();
            foreach (var setting in _catalogSettings)
            {
                switch (setting.Catalog)
                {
                    case "AssemblyCatalog":
                        foreach (var arg in setting.Args)
                        {
                            catalog.Catalogs.Add(new AssemblyCatalog(Assembly.LoadFrom(arg), builder));
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

            return new CompositionContainer(catalog);
        }

        public TObject Create(string name)
        {
            var def = new ImportDefinition(i => i.ContractName.Equals(name),
                name, ImportCardinality.ZeroOrMore, false, false);
            var exports = _container.GetExports(def);
            if (exports.Count() == 0)
            {
                _logger.Error("");
                throw new ArgumentException("", "name");
            }
            var comp = exports.Single().Value as TObject;
            if (comp == null)
            {
                _logger.Error("");
                throw new InvalidCastException("");
            }
            return comp;
        }

        public TConcreteObject Create<TConcreteObject>()
        {
            try
            {
                return _container.GetExportedValue<TConcreteObject>();

            }
            catch (CompositionContractMismatchException ex)
            {
                _logger.Error("", ex);
                throw;
            }
        }
    }
}

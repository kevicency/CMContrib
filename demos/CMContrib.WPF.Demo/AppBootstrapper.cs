using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Reflection;
using Caliburn.Micro.Contrib.Demo.Views.Samples;

namespace Caliburn.Micro.Contrib.Demo
{
    public class AppBootstrapper : Bootstrapper<IShell>
    {
        CompositionContainer container;

        /// <summary>
        /// By default, we are configured to use MEF
        /// </summary>
        protected override void Configure()
        {
            // CMContrib Config stuff
            FrameworkExtensions.Message.Attach.AllowExtraSyntax(MessageSyntaxes.SpecialValueProperty | MessageSyntaxes.XamlBinding);
            FrameworkExtensions.ActionMessage.EnableFilters();
            FrameworkExtensions.ViewLocator.EnableContextFallback();
            Localizer.CustomResourceManager = Properties.Demo.ResourceManager;

            // Return a generic sample view if the sample doesn't provide a custom view
            var baseLocate = ViewLocator.LocateTypeForModelType;
            ViewLocator.LocateTypeForModelType = (type, dependencyObject, context) =>
            {
                var baseView = baseLocate(type, dependencyObject, context);
                if (baseView == null && type.GetInterfaces().Contains(typeof (ISample)))
                {
                    return typeof (GenericSampleView);
                }
                return baseView;
            };
            // Namespace mapping for custom dialog view
            ViewLocator.AddSubNamespaceMapping("Dialogs", "Demo.Views");
            // or alternatively
            // ViewLocator.AddNamespaceMapping("Caliburn.Micro.Contrib.Dialogs", "Caliburn.Micro.Contrib.Demo.Views");

            var catalog = new AggregateCatalog(
                AssemblySource.Instance.Select(x => new AssemblyCatalog(x)).OfType<ComposablePartCatalog>()
                );

            container = new CompositionContainer(catalog);

            var batch = new CompositionBatch();

            batch.AddExportedValue<IWindowManager>(new WindowManager());
            batch.AddExportedValue<IEventAggregator>(new EventAggregator());
            batch.AddExportedValue(container);
            batch.AddExportedValue(catalog);

            container.Compose(batch);

            LogManager.GetLog = t => new ConsoleLog(t);
        }

        protected override IEnumerable<Assembly> SelectAssemblies()
        {
            return base.SelectAssemblies().Concat(new Assembly[] { typeof(ResultExtensions).Assembly });
        }

        protected override object GetInstance(Type serviceType, string key)
        {
            string contract = string.IsNullOrEmpty(key) ? AttributedModelServices.GetContractName(serviceType) : key;
            var exports = container.GetExportedValues<object>(contract);

            if (exports.Count() > 0)
                return exports.First();

            throw new Exception(string.Format("Could not locate any instances of contract {0}.", contract));
        }

        protected override IEnumerable<object> GetAllInstances(Type serviceType)
        {
            return container.GetExportedValues<object>(AttributedModelServices.GetContractName(serviceType));
        }

        protected override void BuildUp(object instance)
        {
            container.SatisfyImportsOnce(instance);
        }
    }
}


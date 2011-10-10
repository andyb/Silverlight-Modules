using System;
using System.Collections.Generic;
using System.Windows;
using Microsoft.Practices.Composite.Modularity;
using Microsoft.Practices.Composite.UnityExtensions;
using Microsoft.Practices.Unity;
using System.Windows.Controls;
using slModules.Infrastructure;


namespace slModules
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override IModuleCatalog GetModuleCatalog()
        {
            string query = App.Current.Host.Source.Query;
            var level1 = new ModuleInfo(ModuleNames.level1, string.Format("{0}.Level1Module, {0}, Version=1.0.0.0", ModuleNames.level1)) { InitializationMode = InitializationMode.OnDemand, Ref = ModuleNames.level1 + ".xap" };
            var level2 = new ModuleInfo(ModuleNames.level2, string.Format("{0}.Level2Module, {0}, Version=1.0.0.0",ModuleNames.level2)) { InitializationMode = InitializationMode.OnDemand, Ref = ModuleNames.level2 + ".xap" };
            var level3 = new ModuleInfo(ModuleNames.level3, string.Format("{0}.Level3Module, {0}, Version=1.0.0.0", ModuleNames.level3)) { InitializationMode = InitializationMode.OnDemand, Ref = ModuleNames.level3 + ".xap" };
            var level4 = new ModuleInfo(ModuleNames.level4, string.Format("{0}.Level4Module, {0}, Version=1.0.0.0", ModuleNames.level4)) { InitializationMode = InitializationMode.OnDemand, Ref = ModuleNames.level4 + ".xap" };
            
            ModuleCatalog cat = new ModuleCatalog();
            cat.AddModule(level1);
            cat.AddModule(level2);
            cat.AddModule(level3);
            cat.AddModule(level4);
            return cat;

        }

        protected override DependencyObject CreateShell()
        {
            Shell shell = Container.Resolve<Shell>();
            Application.Current.RootVisual = shell;

            var regionManager = new RegionManager();

            regionManager[RegionNames.MainRegion] = shell.LayoutRoot;

            this.Container.RegisterInstance(typeof(RegionManager), regionManager);

            return shell;
        }
    }

}

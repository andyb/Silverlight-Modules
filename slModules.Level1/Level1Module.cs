using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Practices.Composite.Modularity;
using slModules.Infrastructure;

namespace slModules.Level1
{
    public class Level1Module : IModule
    {
        private readonly RegionManager regionManager;
        private readonly IModuleManager moduleManager;

        public Level1Module(RegionManager regionManager, IModuleManager moduleManager)
        {
            this.regionManager = regionManager;
            this.moduleManager = moduleManager;
        }

        public void Initialize()
        {
            MainPage view = new MainPage();
            this.regionManager[RegionNames.MainRegion].Children.Add(view);
        }
    }    
}

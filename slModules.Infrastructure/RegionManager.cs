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
using System.Collections.Generic;

namespace slModules.Infrastructure
{

    /// <summary>
    /// This manages regions within the application
    /// </summary>
    public class RegionManager
    {
        private static RegionManager instance = new RegionManager();
        private Dictionary<string, Grid> regions = new Dictionary<string, Grid>();

        public static RegionManager Instance
        {
            get { return instance; }
        }

        public Grid this[string name]
        {
            get { return this.regions[name]; }
            set { this.regions[name] = value; }
        }

    }
}

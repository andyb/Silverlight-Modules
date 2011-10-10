using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Practices.Composite.Modularity;
using slModules.Infrastructure;

namespace slModules
{
    public partial class Shell : UserControl
    {
        public Shell()
        {
            InitializeComponent();
        }

        public Shell(IModuleManager moduleManager)
            : this()
        {
            this.moduleManager = moduleManager;
        }

        private readonly IModuleManager moduleManager;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoadModule(ModuleNames.level1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LoadModule(ModuleNames.level2);
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            LoadModule(ModuleNames.level3);
        }


        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            LoadModule(ModuleNames.level4);
        }


        private void LoadModule(string moduleName)
        {
            foreach (var control in this.LayoutRoot.Children)
            {
                control.Visibility = Visibility.Collapsed;
            }

            UserControl showControl = this.LayoutRoot.FindName(moduleName) as UserControl;
            if (showControl != null)
            {
                showControl.Visibility = Visibility.Visible;
            }
            else
            {
                this.moduleManager.LoadModule(moduleName);
            }
        }

    }
}

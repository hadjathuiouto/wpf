using Autofac;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TutoWpf.Data;
using TutoWpf.Start;
using TutoWpf.ViewModel;

namespace TutoWpf
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //MainWindow window = new MainWindow(new MainViewModel(new DailyService()));
            Bootstrapper bootstrap = new Bootstrapper();
            var container = bootstrap.Boostrap();
            MainWindow window = container.Resolve<MainWindow>();
            window.Show();
        }
    }
}

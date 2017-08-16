using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ESAPIX.Bootstrapper;
using ESAPIX15._1Template.Views;

namespace ESAPIX15._1Template
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var bs = new AppBootstrapper<MainView>();
            bs.Run();
        }
    }
}

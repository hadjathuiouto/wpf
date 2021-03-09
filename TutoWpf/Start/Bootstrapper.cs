using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoWpf.Data;
using TutoWpf.ViewModel;


namespace TutoWpf.Start
{
    public class Bootstrapper
    {
        
       public IContainer Boostrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<DailyService>().As<IDailyService>();
            return builder.Build();
        }
        
    }
}

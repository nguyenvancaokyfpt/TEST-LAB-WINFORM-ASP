using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TestLabManagerAppWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            // initialize the database
            MyService.Initialize();
            MyMapper.Initialize();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var loginWindow = MyService.serviceProvider.GetService<WindowLogin>();
            loginWindow.Show();
        }
    }
}

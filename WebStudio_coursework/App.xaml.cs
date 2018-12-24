using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WebStudio_coursework
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            var dialog = new LoginWindow(new CurrentUser());
            dialog.ShowDialog();
            //if (dialog.ShowDialog() == true)
            //{
            //    MainWindow m = new MainWindow();
            //    m.ShowDialog();
            //}
        }
    }
}

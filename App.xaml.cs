using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BibleBrowser
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void BibleBrowserStartup(object sender, StartupEventArgs e)
        {
            Window mainWindow = new BibleBrowserMain();
            mainWindow.Show();
        }
    }
}

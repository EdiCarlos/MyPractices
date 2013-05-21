using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace ApplicationSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MessageBox.Show("Application Started");
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            MessageBox.Show("Exit", "Closing current applicaiton");
        }

        private void Application_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("Application Activated");
        }

        private void Application_Deactivated(object sender, EventArgs e)
        {
            MessageBox.Show("Application Deactivated");
        }
    }
}

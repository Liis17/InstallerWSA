using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace InstallerWSFA
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static string? Pathfile = ""; // путь до файла при старте
        void App_Startup(object sender, StartupEventArgs e)
        {
            Pathfile = e.Args?.FirstOrDefault();
        }

    }
}

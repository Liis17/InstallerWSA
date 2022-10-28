using InstallerWSA;

using Microsoft.Win32;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InstallerWSFA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string path = Environment.ProcessPath;
        public static string pathadb;
        public static string filename;
        public static TextBox tbsymbol;
        public MainWindow()
        {
            InitializeComponent();
            tbsymbol = symbol;
            if (Exists.YourPirateShip() == true) //проверка что adb еще тут
            {
                if (isHaveProcess("vmwp") == true) //VmmemWSA //проверка что эта хуета запущена
                {
                    if (App.Pathfile == null)
                    {
                        FileSelector.OpenData();
                    }
                    else if (App.Pathfile != null)
                    {
                        filename = $"{tbsymbol.Text}{App.Pathfile}{tbsymbol.Text}";
                        Receiving.ReceivingPath();
                    }

                }
                else
                {
                    MessageBox.Show("WSA не запущен", "Упс");
                }
            }
            else
            {
                MessageBox.Show("А куда делся adb который был в папке с этой программой?\nВерни пж на место pls", "Бл*тъб");
            }
            

        }
        public bool isHaveProcess(string pName)
        {
            Process[] pList = Process.GetProcesses();
            foreach (Process myProcess in pList)
            {
                if (myProcess.ProcessName == pName)
                    return true;
            }
            return false;
        } // проверка что эта хуета запущена х2

        private void symbol_Loaded(object sender, RoutedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        } //если эта штука будет отрисованна то программа закрывается
    }
}

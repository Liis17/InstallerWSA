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
        public string path = Environment.ProcessPath;
        public string pathadb;
        string filename = "";
        public MainWindow()
        {
            InitializeComponent();
            OpenData();
        }

        private void OpenData()
        {
            OpenFileDialog Filedialog = new OpenFileDialog();
            Filedialog.InitialDirectory = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            Filedialog.Filter = "APK |*.apk";
            Filedialog.Title = "Select .apk";
            Filedialog.FilterIndex = 1;
            try
            {
                if (Filedialog.ShowDialog() == true)
                {
                    filename = $"{symbol.Text}{Filedialog.FileName}{symbol.Text}";
                    ReceivingPath();
                }
            }
            catch
            {
                MessageBox.Show("Файл не выбран!","Не выбран файл");
            }
        }
        public void ReceivingPath()
        {
            List<string> list = new List<string>();
            string[] a = path.Split("\\");
            foreach (var item in a)
            {
                list.Add(item + "\\");
            }
            list.RemoveAt(list.Count - 1);
            path = "";
            foreach (var item in list)
            {
                path += item;
            }
            pathadb = path + "ADB\\adb.exe";
            path += "ADB\\aboba.cmd";
            CreateFile();
        }
        public void CreateFile()
        {
            
            string param = $"{pathadb} connect 127.0.0.1:58526\n{pathadb} -s 127.0.0.1:58526 install {filename}\nbreak 5";
            File.WriteAllText(path, param);
            StartFile();
        }

        public void StartFile()
        {
            Process.Start(path);
            Thread.Sleep(30000);
            File.Delete(path);
            Close();
        }

       
    }
}

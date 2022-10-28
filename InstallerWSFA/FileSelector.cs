using InstallerWSFA;

using Microsoft.Win32;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InstallerWSA
{
    class FileSelector
    {
        public static void OpenData()
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
                    MainWindow.filename = $"{MainWindow.tbsymbol.Text}{Filedialog.FileName}{MainWindow.tbsymbol.Text}";
                    Receiving.ReceivingPath();
                }
            }
            catch
            {
                MessageBox.Show("Файл не выбран!", "Не выбран файл");
                Process.GetCurrentProcess().Kill();
            }
        }
    }
}

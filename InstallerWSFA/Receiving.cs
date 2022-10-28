using InstallerWSFA;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallerWSA
{
    class Receiving
    {
        public static void ReceivingPath()
        {
            List<string> list = new List<string>();
            string[] a = MainWindow.path.Split("\\");
            foreach (var item in a)
            {
                list.Add(item + "\\");
            }
            list.RemoveAt(list.Count - 1);
            MainWindow.path = "";
            foreach (var item in list)
            {
                MainWindow.path += item;
            }
            MainWindow.pathadb = $"{MainWindow.tbsymbol.Text}{MainWindow.path}ADB\\adb.exe{MainWindow.tbsymbol.Text}";
            MainWindow.path += "ADB\\aboba.cmd";
            Create.CreateFile();
        }
    }
}

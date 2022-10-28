using InstallerWSFA;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InstallerWSA
{
    class Install
    {
        public static void StartFile()
        {
            Process.Start(MainWindow.path);
            Thread.Sleep(30000);
            File.Delete(MainWindow.path);
            Process.GetCurrentProcess().Kill();
        }
    }
}

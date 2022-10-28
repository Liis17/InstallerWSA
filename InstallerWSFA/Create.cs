using InstallerWSFA;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallerWSA
{
    class Create
    {
        public static void CreateFile()
        {
            string param = $"{MainWindow.pathadb} connect 127.0.0.1:58526\n{MainWindow.pathadb} -s 127.0.0.1:58526 install {MainWindow.filename}\nbreak 5";
            File.WriteAllText(MainWindow.path, param);
            Install.StartFile();
        }
    }
}

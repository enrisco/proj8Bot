using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration.Install;

namespace _8Bot_Configuration.Controller
{
    public class Services
    {
        public static void InstallService(string exeFilename)
        {
            string[] commandLineOptions = new string[1] { "/LogFile=install.log" };

            AssemblyInstaller installer = new AssemblyInstaller(exeFilename, commandLineOptions)
            {
                UseNewContext = true
            };
            installer.Install(null);
            installer.Commit(null);
        }

        public static void UninstallService(string exeFilename)
        {
            string[] commandLineOptions = new string[1] { "/LogFile=uninstall.log" };

            AssemblyInstaller installer = new AssemblyInstaller(exeFilename, commandLineOptions)
            {
                UseNewContext = true
            };
            installer.Uninstall(null);

        }
    }
}

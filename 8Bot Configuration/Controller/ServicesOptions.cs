using System;
using System.Threading;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Reflection;
using System.Diagnostics;
using System.Configuration.Install;
using System.Collections.Generic;
using System.Collections;

namespace _8Bot_Configuration.Controller
{
    class ServicesOptions
    {
        public static void InstallService(string exeFilename)
        {
            string[] commandLineOptions = new string[1] { "/LogFile=install.log" };

            AssemblyInstaller installer = new AssemblyInstaller(exeFilename, null)
            {
                UseNewContext = true
            };
            installer.Install(null);
            installer.Commit(null);
        }

        public static void UninstallService(string exeFilename)
        {
            string[] commandLineOptions = new string[1] { "/LogFile=uninstall.log" };

            AssemblyInstaller uninstaller = new AssemblyInstaller(exeFilename, null)
            {
                UseNewContext = true
            };
            /*installer.Install(null);
            installer.Commit(null);*/

            uninstaller.Uninstall(null);
            //uninstaller.Commit(null);
        }
    }

}



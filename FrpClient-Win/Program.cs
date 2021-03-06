﻿using System;
using System.ServiceProcess;
using System.Windows.Forms;

namespace FrpClient_Win 
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if(args.Length > 0 && args[0] == "service") {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[] { new autorunService() };
                ServiceBase.Run(ServicesToRun);
            } else {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}

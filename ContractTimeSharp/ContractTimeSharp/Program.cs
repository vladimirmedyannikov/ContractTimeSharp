﻿using ContractTime.Model;
using ContractTimeSharp.Forms;
using ContractTimeSharp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ContractTimeSharp
{
    static class Program
    {
        private static User user;
        public static User User { get { return user; } set { user = value; } }

        private static ParametersApp param;
        public static ParametersApp ParamApp
        {
            get { return param; }
            set { param = value; }
        }
            /// <summary>
            /// Главная точка входа для приложения.
            /// </summary>
        /*    [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainApplication());
        }*/
    }
}

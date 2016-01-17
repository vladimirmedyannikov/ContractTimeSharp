using ContractTime.Model;
using ContractTimeSharp.Forms;
using ContractTimeSharp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContractTimeSharp
{
    class MainApplication
    {
        static User user;
        public static User User { get { return user; } set { user = value; } }

        private static ParametersApp param;
        public static ParametersApp ParamApp {
            get { return param; }
            set { param = value; }
        }

        public MainApplication()
        {
            
        }

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new AuthForm().ShowDialog();
            if (User != null) Application.Run(new DialogGridForm());
        }
    }
}

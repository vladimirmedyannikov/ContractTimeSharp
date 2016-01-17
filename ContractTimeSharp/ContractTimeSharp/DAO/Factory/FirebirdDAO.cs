using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;

namespace ContractTimeSharp.DAO.Factory
{
    class FirebirdDAO : DAOFactory
    {
        public override FbConnection getConnection()
        {
            FbConnectionStringBuilder fbSb = new FbConnectionStringBuilder();
            //fbSb.Charset = "WIN1251";
            fbSb.UserID = Properties.Settings.Default.login;
            fbSb.Password = Properties.Settings.Default.password;
            //fbSb.Port = 3050;
            fbSb.DataSource = Properties.Settings.Default.host;
            fbSb.Database = Properties.Settings.Default.dbname;
            //fbSb.ServerType = 0;
            //fbSb.ConnectionTimeout = 30;
            //MessageBox.Show(fbSb.ToString());
            FbConnection fb = new FbConnection(fbSb.ToString());
            return fb;
        }

        public override DepartmentDAO getDepartmentDAO()
        {
            throw new NotImplementedException();
        }

        public override FirmDAO getFirmDAO()
        {
            throw new NotImplementedException();
        }

        public override InvestProjectDAO getInvestProjectDAO()
        {
            throw new NotImplementedException();
        }

        public override UserDAO getUserDAO()
        {
            throw new NotImplementedException();
        }
    }
}

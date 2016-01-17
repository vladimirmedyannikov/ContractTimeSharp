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
            fbSb.UserID = "SYSDBA";
            fbSb.Password = "masterkey";
            //fbSb.Port = 3050;
            fbSb.DataSource = "192.168.0.105";
            fbSb.Database = "contracttime";
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

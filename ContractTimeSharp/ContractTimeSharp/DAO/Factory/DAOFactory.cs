using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ContractTimeSharp.DAO.Factory
{
    abstract class DAOFactory
    {
        public abstract DepartmentDAO getDepartmentDAO();
        public abstract FirmDAO getFirmDAO();
        public abstract InvestProjectDAO getInvestProjectDAO();
        public abstract UserDAO getUserDAO();

        public abstract FbConnection getConnection();

        public static DAOFactory getDAOFactory()
        {
            return new FirebirdDAO();
        }
    }
}

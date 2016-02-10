using ContractTime.Model;
using ContractTimeSharp.DAO.Factory;
using ContractTimeSharp.Model;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ContractTimeSharp.DAO
{
    class LogDAO : DAO<LogEntry>
    {
        private DAOFactory daoFactory = new FirebirdDAO();

        public void delete(LogEntry e)
        {
            throw new NotImplementedException();
        }

        public List<LogEntry> getAll()
        {
            FbConnection connection = null;
            FbCommand statment = null;
            String sql = "Select u.id_user, l_name, f_name, p_name, id_log, date_log, type_log, operation from log_info l " +
                " left join user_info u on u.id_user = l.id_user order by id_log";
            List<LogEntry> logList = new List<LogEntry>();
            try
            {
                connection = daoFactory.getConnection();
                statment = new FbCommand(sql, connection);
                FbDataAdapter da = new FbDataAdapter(statment);
                DataSet result = new DataSet();
                da.Fill(result);
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    LogEntry log = new LogEntry();
                    log.IdLog = Convert.ToInt32(row["id_log"].ToString());

                    DateTime dateLog;
                    DateTime.TryParse(row["date_log"].ToString(), out dateLog);
                    log.DateLog = dateLog;

                    log.TypeLog = Convert.ToInt32(row["type_log"].ToString());
                    log.Sql = row["operation"].ToString();

                    User user = new User();
                    user.Id = Convert.ToInt32(row["id_user"].ToString());
                    user.FirstName = row["f_name"].ToString();
                    user.SecondName = row["l_name"].ToString();
                    user.ThirdName = row["p_name"].ToString();
                    log.User = user;

                    logList.Add(log);
                }
            }
            catch (Exception e)
            {
                throw new DAOException("Log info getAll ", e);
            }
            finally
            {
                try
                {
                    if (connection != null) connection.Close();
                }
                catch (System.Data.DataException e)
                {

                }
            }
            return logList;
        }

        public LogEntry getById(int id)
        {
            throw new NotImplementedException();
        }

        public LogEntry insert(LogEntry e)
        {
            throw new NotImplementedException();
        }

        public void update(LogEntry e)
        {
            throw new NotImplementedException();
        }
    }
}

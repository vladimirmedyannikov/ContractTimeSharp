using ContractTime.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContractTimeSharp.Model
{
    class LogEntry
    {
        private int idLog;
        private DateTime dateLog;
        private int typeLog;
        private User user;
        private string sql;

        public int IdLog
        {
            get { return idLog; }
            set { idLog = value; }
        }

        public DateTime DateLog
        {
            get { return dateLog; }
            set { dateLog = value; }
        }

        public int TypeLog
        {
            get { return typeLog; }
            set { typeLog = value; }
        }

        public User User
        {
            get { return user; }
            set { user = value; }
        }

        public string Sql
        {
            get { return sql; }
            set { sql = value; }
        }

        public string TypeStr
        {
            get { return (typeLog == 1) ? "Вход" : "Выход"; }
        }
    }
}

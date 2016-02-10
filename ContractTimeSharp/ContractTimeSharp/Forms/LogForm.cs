using ContractTimeSharp.DAO;
using ContractTimeSharp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContractTimeSharp.Forms
{
    public partial class LogForm : Form
    {
        private LogDAO dao = new LogDAO();
        private List<LogEntry> listLog = new List<LogEntry>();
        public LogForm()
        {
            InitializeComponent();
            initializeColumn();
            initializeData();
        }

        public void initializeData()
        {
            listLog = dao.getAll();
            gridLog.DataSource = listLog;
        }

        public void initializeColumn()
        {
            gridLog.AutoGenerateColumns = false;

            DataGridViewColumn colummIdLog = new DataGridViewTextBoxColumn();
            colummIdLog.DataPropertyName = "IdLog";
            colummIdLog.HeaderText = "Номер";

            DataGridViewColumn columnDate = new DataGridViewTextBoxColumn();
            columnDate.DataPropertyName = "DateLog";
            columnDate.HeaderText = "Дата";

            DataGridViewColumn columnType = new DataGridViewTextBoxColumn();
            columnType.DataPropertyName = "TypeStr";
            columnType.HeaderText = "Тип";

            DataGridViewColumn columnUser = new DataGridViewTextBoxColumn();
            columnUser.DataPropertyName = "User";
            columnUser.HeaderText = "Пользователь";

            gridLog.Columns.AddRange(new DataGridViewColumn[] { colummIdLog, columnDate, columnType, columnUser });
        }

        private void LogForm_Load(object sender, EventArgs e)
        {

        }
    }
}

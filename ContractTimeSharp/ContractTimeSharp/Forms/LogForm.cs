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
            gridLog.CellPainting += GridLog_CellPainting;
        }

        private void GridLog_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.Paint(e.ClipBounds, DataGridViewPaintParts.All);
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                if (gridLog.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Contains("Вход"))
                {
                    e.Graphics.FillRectangle(Brushes.Green, e.CellBounds);
                    e.Graphics.DrawString(gridLog.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), new Font(FontFamily.GenericSerif, 10), new SolidBrush(Color.Black), e.CellBounds);
                    e.Handled = true;
                }
                else
                {
                    e.Graphics.FillRectangle(Brushes.Red, e.CellBounds);
                    e.Graphics.DrawString(gridLog.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), new Font(FontFamily.GenericSerif, 10), new SolidBrush(Color.Black), e.CellBounds);
                    e.Handled = true;
                }
            }
            
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
            columnType.Width = 50;
            columnType.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

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

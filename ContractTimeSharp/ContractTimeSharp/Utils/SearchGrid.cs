using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContractTimeSharp.Utils
{
    public partial class SearchGrid : Form
    {
        private int columnSearchIndex;
        private DataGridView grid;
        private List<string> listColumn = new List<string>();

        public SearchGrid()
        {
            InitializeComponent();
        }

        public SearchGrid(DataGridView grid):this()
        {
            this.grid = grid;

            foreach (DataGridViewColumn column in grid.Columns)
            {
                listColumn.Add(column.HeaderText.ToString());
            }
            cbColumn.DataSource = listColumn;
        }

        private void SearchGrid_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool find = false;
            if (columnSearchIndex != cbColumn.SelectedIndex) {
                columnSearchIndex = cbColumn.SelectedIndex;
                if (grid.RowCount > 0) grid.CurrentCell = grid.Rows[0].Cells[1];
            }
            
            for (int i = grid.SelectedRows[0].Index + 1 ; i < grid.RowCount; i++)
            {
                DataGridViewRow row = grid.Rows[i];
                if (row.Cells[columnSearchIndex].Value.ToString().ToLower().Contains(tbSearch.Text.ToLower()))
                {
                    row.Selected = true;
                    grid.CurrentCell = row.Cells[1];
                    find = true;
                    break;
                }
            }
            if (!find)
            {
                grid.Rows[0].Selected = true;
                grid.CurrentCell = grid.Rows[0].Cells[1];
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using ContractTime.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractTimeSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.Add(new Firm(1,"Firm1"));
            bindingSource.Add(new Firm(2, "Firm2"));
            bindingSource.Add(new Firm(3, "Firm3"));
            bindingSource.Add(new Firm(4, "Firm4"));
            //dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bindingSource;
            

            /*DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "NameFirm";
            column.Name = "NameFirm";
            dataGridView1.Columns.Add(column);*/

            /*column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "NameFirm";
            column.Name = "NameFirm";
            dataGridView1.Columns.Add(column);*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

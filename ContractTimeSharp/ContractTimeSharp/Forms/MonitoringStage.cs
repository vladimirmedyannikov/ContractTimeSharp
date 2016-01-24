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
    public partial class MonitoringStage : Form
    {
        public MonitoringStage()
        {
            InitializeComponent();
        }

        private void butnShow_Click(object sender, EventArgs e)
        {
            initializeData();
        }

        public void initializeData()
        {
            StageProjectDAO dao = new StageProjectDAO();
            BindingSource source = new BindingSource();
            List<StageProject> listStage = dao.getByDate(dateTimePicker1.Value);
            source.DataSource = listStage;
            dataStage.DataSource = source;
        }
    }
}

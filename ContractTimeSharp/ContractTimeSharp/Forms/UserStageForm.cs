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
    public partial class UserStageForm : Form
    {
        public UserStageForm()
        {
            InitializeComponent();
            initializateDataGrid();
        }

        private void initializateDataGrid()
        {
            BindingSource sourceNotComplete = new BindingSource();
            List<StageProject> stageList = new StageProjectDAO().getByUser(MainApplication.User);
            sourceNotComplete.DataSource = stageList.Where(x => x.StatusStage == 0).ToList();
            gridNotComplete.DataSource = sourceNotComplete;

            BindingSource sourceComplete = new BindingSource();
            sourceComplete.DataSource = stageList.Where(x => x.StatusStage == 1).ToList();
            gridComplete.DataSource = sourceComplete;

        }
    }
}

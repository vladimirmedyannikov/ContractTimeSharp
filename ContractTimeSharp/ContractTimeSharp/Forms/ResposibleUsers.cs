using ContractTime.Model;
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
    public partial class ResposibleUsers : Form
    {
        public ResposibleUsers()
        {
            InitializeComponent();
            initializateData();
        }

        private void initializateData()
        {
            UserDAO dao = new UserDAO();
            List<User> listAll = dao.getUsersResponsible(Utils.AdvanceUtil.stageStatus.ALL);
            BindingSource sourceAll = new BindingSource();
            sourceAll.DataSource = listAll;
            gridAll.DataSource = sourceAll;

            List<User> listPlan = dao.getUsersResponsible(Utils.AdvanceUtil.stageStatus.PLAN);
            BindingSource sourcePlan = new BindingSource();
            sourcePlan.DataSource = listPlan;
            gridNotComplete.DataSource = sourcePlan;

            List<User> listFact = dao.getUsersResponsible(Utils.AdvanceUtil.stageStatus.FACT);
            BindingSource sourceFact = new BindingSource();
            sourceFact.DataSource = listFact;
            gridComplete.DataSource = sourceFact;

            //listStage.Select(user => user.User).ToList(); 
        }


    private void showDialog(DataGridView grid)
    {
        DialogStageProject dialog = new DialogStageProject();
        StageProject stage;
        if (grid.CurrentRow.DataBoundItem != null && grid.CurrentRow.DataBoundItem.GetType() == typeof(StageProject))
        {
            stage = (StageProject)grid.CurrentRow.DataBoundItem;
            dialog.setStageProject(stage);
            dialog.setUserMode(true);
            dialog.ShowDialog();
        }
    }

        private void gridNotComplete_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showDialog(gridNotComplete);
        }

        private void gridComplete_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showDialog(gridComplete);
        }

        private void gridAll_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showDialog(gridAll);
        }
    }
}

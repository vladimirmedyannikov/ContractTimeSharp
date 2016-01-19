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
            gridNotComplete.DataSource = null;
            gridComplete.DataSource = null;
            gridPrepare(gridComplete);
            gridPrepare(gridNotComplete);
            BindingSource sourceNotComplete = new BindingSource();
            List<StageProject> stageList = new StageProjectDAO().getByUser(MainApplication.User);
            sourceNotComplete.DataSource = stageList.Where(x => x.StatusStage == 0).ToList();
            gridNotComplete.DataSource = sourceNotComplete;
            
            BindingSource sourceComplete = new BindingSource();
            sourceComplete.DataSource = stageList.Where(x => x.StatusStage == 1).ToList();
            gridComplete.DataSource = sourceComplete;
        }

        private void gridPrepare(DataGridView grid)
        {
            grid.AutoGenerateColumns = false;
            grid.ColumnCount = 6;
            grid.Columns[0].DataPropertyName = "Project";
            grid.Columns[0].HeaderText = "Проект";
            grid.Columns[1].DataPropertyName = "NameStage";
            grid.Columns[1].HeaderText = "Этап";
            grid.Columns[2].DataPropertyName = "DateBeginPlan";
            grid.Columns[2].HeaderText = "Начало(план)";
            grid.Columns[3].DataPropertyName = "DateEndPlan";
            grid.Columns[3].HeaderText = "Завершение(план)";
            grid.Columns[4].DataPropertyName = "DateBeginUser";
            grid.Columns[4].HeaderText = "Начало(ответств.)";
            grid.Columns[5].DataPropertyName = "DateEndUser";
            grid.Columns[5].HeaderText = "Завершение(ответств.)";
        }
        private void gridNotComplete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridNotComplete_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showDialog(gridNotComplete);
            initializateDataGrid();
        }

        private void gridComplete_DoubleClick(object sender, EventArgs e)
        {
            showDialog(gridComplete);
            initializateDataGrid();
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
    }
}

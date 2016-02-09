using ContractTime.Model;
using ContractTimeSharp.DAO;
using ContractTimeSharp.Model;
using ContractTimeSharp.Utils;
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
            initializeColumn(gridNotComplete);
            initializeColumn(gridAll);
            initializeColumn(gridComplete);
            initializeColumn(gridDefault);
            initializateData();
        }

        private void initializeColumn(DataGridView grid)
        {
            DataGridViewColumn columnName = new DataGridViewTextBoxColumn();
            columnName.DataPropertyName = "FullName";
            columnName.HeaderText = "ФИО";

            DataGridViewColumn columnDepartment = new DataGridViewTextBoxColumn();
            columnDepartment.DataPropertyName = "Department";
            columnDepartment.HeaderText = "Подраздеоелние";

            DataGridViewColumn columnApp = new DataGridViewTextBoxColumn();
            columnApp.DataPropertyName = "Appointment";
            columnApp.HeaderText = "Должность";

            DataGridViewColumn columnEmail = new DataGridViewTextBoxColumn();
            columnEmail.DataPropertyName = "Email";
            columnEmail.HeaderText = "Email";

            DataGridViewColumn columnLogin = new DataGridViewTextBoxColumn();
            columnLogin.DataPropertyName = "Login";
            columnLogin.HeaderText = "Login";

            DataGridViewColumn columnType = new DataGridViewTextBoxColumn();
            columnType.DataPropertyName = "TypeUserStr";
            columnType.HeaderText = "Тип УЗ";


            grid.AutoGenerateColumns = false;
            grid.Columns.AddRange(new DataGridViewColumn[] { columnName, columnApp, columnDepartment, columnEmail, columnLogin, columnType });
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

            List<User> listDefault = dao.getUsersResponsible(Utils.AdvanceUtil.stageStatus.DEFAULT);
            BindingSource sourceDefault = new BindingSource();
            sourceDefault.DataSource = listDefault;
            gridDefault.DataSource = sourceDefault;

            //listStage.Select(user => user.User).ToList(); 
        }


    private void showDialog(DataGridView grid)
    {
        DialogStageProject dialog = new DialogStageProject();
        if (grid.CurrentRow.DataBoundItem != null && grid.CurrentRow.DataBoundItem.GetType() == typeof(User))
        {
                User user = (User)((BindingSource)grid.DataSource).Current;
                UserStageForm form = new UserStageForm(user);
                form.ShowDialog();
            }
    }

        private void gridNotComplete_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void gridComplete_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void gridAll_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void gridNotComplete_DoubleClick(object sender, EventArgs e)
        {
            showDialog(gridNotComplete);
        }

        private void gridComplete_DoubleClick(object sender, EventArgs e)
        {
            showDialog(gridComplete);
        }

        private void gridAll_DoubleClick(object sender, EventArgs e)
        {
            showDialog(gridAll);
        }

        private void gridNotComplete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
            {
                SearchGrid form = new SearchGrid(gridNotComplete);
                form.ShowDialog();
            }
        }

        private void gridComplete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
            {
                SearchGrid form = new SearchGrid(gridComplete);
                form.ShowDialog();
            }
        }

        private void gridAll_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
            {
                SearchGrid form = new SearchGrid(gridAll);
                form.ShowDialog();
            }
        }

        private void gridDefault_DoubleClick(object sender, EventArgs e)
        {
            showDialog(gridDefault);
        }
    }
}

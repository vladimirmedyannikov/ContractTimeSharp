using ContractTimeSharp.DAO;
using ContractTimeSharp.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContractTimeSharp.Forms
{
    public partial class ChangeInnerIndexStage : Form
    {
        private List<StageProject> listStage = new List<StageProject>();

        public ChangeInnerIndexStage()
        {
            InitializeComponent();
            initializeColumns();
        }

        public ChangeInnerIndexStage(List<StageProject> stage) : this()
        {
            listStage = new List<StageProject>(stage);
            initializeData();
        }

        private void initializeData()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = listStage;
            dataGridStage.DataSource = bindingSource;
            
        }

        private void initializeColumns()
        {
            dataGridStage.AutoGenerateColumns = false;

            DataGridViewColumn columnNameStage = new DataGridViewTextBoxColumn();
            columnNameStage.DataPropertyName = "NameStage";
            columnNameStage.HeaderText = "Этап";

            DataGridViewColumn columnUser = new DataGridViewTextBoxColumn();
            columnUser.DataPropertyName = "User";
            columnUser.HeaderText = "Ответственный";

            DataGridViewColumn columnDateBeginPlan = new DataGridViewTextBoxColumn();
            columnDateBeginPlan.DataPropertyName = "DateBeginPlan";
            columnDateBeginPlan.HeaderText = "Дата начала (план)";

            DataGridViewColumn columnDateEndPlan = new DataGridViewTextBoxColumn();
            columnDateEndPlan.DataPropertyName = "DateEndPlan";
            columnDateEndPlan.HeaderText = "Дата завершения (план)";

            DataGridViewColumn columnDateBeginProg = new DataGridViewTextBoxColumn();
            columnDateBeginProg.DataPropertyName = "DateBeginProg";
            columnDateBeginProg.HeaderText = "Дата начала (прогноз)";

            DataGridViewColumn columnDateEndProg = new DataGridViewTextBoxColumn();
            columnDateEndProg.DataPropertyName = "DateEndProg";
            columnDateEndProg.HeaderText = "Дата завершеия (прогноз)";

            DataGridViewColumn columnDateBeginUser = new DataGridViewTextBoxColumn();
            columnDateBeginUser.DataPropertyName = "DateBeginUser";
            columnDateBeginUser.HeaderText = "Дата начала (пользоват.)";

            DataGridViewColumn columnDateEndUser = new DataGridViewTextBoxColumn();
            columnDateEndUser.DataPropertyName = "DateEndUser";
            columnDateEndUser.HeaderText = "Дата завершения (пользоват.)";

            DataGridViewColumn columnIndex = new DataGridViewTextBoxColumn();
            columnDateEndUser.DataPropertyName = "InnerIndex";
            columnDateEndUser.HeaderText = "Позиция";


            dataGridStage.Columns.AddRange(new DataGridViewColumn[] { columnNameStage, columnUser, columnDateBeginPlan, columnDateEndPlan, columnDateBeginProg ,
                columnDateEndProg , columnDateBeginUser, columnDateEndUser, columnIndex });
        }

        private void ChangeInnerIndexStage_Load(object sender, EventArgs e)
        {
            
        }

        private StageProject getStageProject()
        {
            StageProject stage = null;
            if (dataGridStage.CurrentRow.DataBoundItem != null && dataGridStage.CurrentRow.DataBoundItem.GetType() == typeof(StageProject))
            {
                stage = (StageProject)dataGridStage.CurrentRow.DataBoundItem;
            }
            return stage;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            StageProject stage = getStageProject();

            foreach(StageProject s in listStage)
            {
                if ((s.InnerIndex - stage.InnerIndex) == -1)
                {
                    s.InnerIndex++;
                    stage.InnerIndex--;
                }
            }
            listStage.Sort(
                delegate(StageProject p1, StageProject p2)
                {
                    if (p1.InnerIndex > p2.InnerIndex) return 1;
                    else if (p1.InnerIndex < p2.InnerIndex) return -1;
                    else return 0;
                }
                );
            dataGridStage.CurrentCell = dataGridStage.Rows[stage.InnerIndex].Cells[0];
            dataGridStage.Rows[stage.InnerIndex].Selected = true;
            dataGridStage.Update();
            dataGridStage.Refresh();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            StageProject stage = getStageProject();

            foreach (StageProject s in listStage)
            {
                if ((s.InnerIndex - stage.InnerIndex) == 1)
                {
                    s.InnerIndex--;
                    stage.InnerIndex++;
                    break;
                }
            }
            listStage.Sort(
                delegate (StageProject p1, StageProject p2)
                {
                    if (p1.InnerIndex > p2.InnerIndex) return 1;
                    else if (p1.InnerIndex < p2.InnerIndex) return -1;
                    else return 0;
                }
                );
            dataGridStage.CurrentCell = dataGridStage.Rows[stage.InnerIndex].Cells[0];
            dataGridStage.Rows[stage.InnerIndex].Selected = true;
            dataGridStage.Update();
            dataGridStage.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Вы действительно хотите сохранить порядок ?","Сохранение",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                StageProjectDAO dao = new StageProjectDAO();
                dao.saveInnerIndex(listStage);
                this.Close();
            }
        }
    }
}

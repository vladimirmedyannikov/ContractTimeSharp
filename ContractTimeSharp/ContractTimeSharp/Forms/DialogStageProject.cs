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
    partial class DialogStageProject : Form
    {
        private StageProject stageProject;
        public StageProject StageProejct { set { stageProject = value; } get { return stageProject; } }
        public AdvanceUtil.paramStagInsert paramInsert;
        public int idProject { get; set; }
        public bool userMode { get; set; }

        public DialogStageProject()
        {
            InitializeComponent();
            InitializationDataBox();
        }

        private void InitializationPermission()
        {
            if (userMode)
            {
                textBoxNameStage.Enabled = false;
                comboBoxUser.Enabled = false;
                dateBegin.Enabled = false;
                dateEnd.Enabled = false;
                dateBeginProg.Enabled = false;
                dateEndProg.Enabled = false;
                dateBeginProg.Visible = false;
                dateEndProg.Visible = false;
                labeldbp.Visible = false;
                labeldep.Visible = false;
            }
        }

        public void InitializationDataBox()
        {
            UserDAO daoUser = new UserDAO();
            comboBoxUser.Items.AddRange(daoUser.getUserComboBox().ToArray());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void setStageProject(StageProject stage)
        {
            setStageProject(stage, AdvanceUtil.paramStagInsert.NOSUB);
        }
        public void setStageProject(StageProject stage, AdvanceUtil.paramStagInsert param)
        {
            stageProject = stage;
            paramInsert = param;
            if (stage != null)
            {
                if (param == AdvanceUtil.paramStagInsert.NOSUB)
                {
                    textBoxNameStage.Text = stage.NameStage;
                    comboBoxUser.SelectedItem = new KeyValuePair(stage.User.Id.ToString(), stage.User.FullName);
                    dateBegin.Value = stage.DateBeginPlan;
                    dateEnd.Value = stage.DateEndPlan;

                    dateBeginUser.Checked = true;
                    dateEndUser.Checked = true;

                    dateBeginUser.Value = stage.DateBeginUser < dateBeginUser.MinDate ?  stage.DateBeginPlan : stage.DateBeginUser;
                    dateEndUser.Value = stage.DateEndUser < dateEndUser.MinDate ? stage.DateEndPlan : stage.DateEndUser;

                    dateBeginProg.Value = stage.DateBeginProg< dateBeginProg.MinDate ? stage.DateBeginPlan : stage.DateBeginProg;
                    dateEndProg.Value = stage.DateEndProg < dateEndProg.MinDate ? stage.DateEndPlan : stage.DateEndProg;
                    textBoxAbout.Text = stage.CommentUser;
                    comboBoxStatus.SelectedIndex = stage.StatusStage == 0 ? 0 : 1;
                }
                else
                {

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                if (stageProject == null)
                {
                    stageProject = new StageProject();
                }
                stageProject.NameStage = textBoxNameStage.Text;
                UserDAO daoUser = new UserDAO();
                stageProject.User = daoUser.getById(Convert.ToInt32(((KeyValuePair)comboBoxUser.SelectedItem).Key));
                stageProject.DateBeginPlan = dateBegin.Value;
                stageProject.DateEndPlan = dateEnd.Value;

                if (dateBeginUser.Checked)
                {
                    stageProject.DateBeginUser = dateBeginUser.Value;
                }
                if (dateEndUser.Checked)
                {
                    stageProject.DateEndUser = dateEndUser.Value;
                }

                stageProject.CommentUser = textBoxAbout.Text;
                stageProject.IdProject = idProject;
                stageProject.StatusStage = comboBoxStatus.SelectedIndex;

                if (paramInsert == AdvanceUtil.paramStagInsert.SUB)
                {
                    stageProject.IdParentStage = stageProject.IdStage;
                }
                StageProjectDAO dao = new StageProjectDAO();
                
                if (stageProject.IdStage != 0 && paramInsert != AdvanceUtil.paramStagInsert.SUB)
                {
                    dao.update(stageProject);
                }
                else
                {
                    dao.insert(stageProject);
                }
                this.Close();
            }
        }

        internal void setUserMode(bool mode)
        {
            userMode = mode;
        }

        public bool isValid()
        {
            bool valid = true;
            MessageBox alert = null;
            String error = "";
            if (textBoxNameStage.Text == null || textBoxNameStage.Text.Length <= 2)
            {
                error += "Введите название длиной более 2х символов\n";
                valid = false;
            }
            if (comboBoxUser.SelectedIndex == -1)
            {
                error += "Выберите ответственного сотрудника за проект\n";
                valid = false;
            }
            if (dateEnd.Value.CompareTo(dateBegin.Value) < 0)
            {
                error += "Дата окончания не должна быть меньше даты начала\n";
                valid = false;
            }

            if (dateEndUser.Value.CompareTo(dateBeginUser.Value) < 0)
            {
                error += "Дата окончания(ответств.) не должна быть меньше даты начала\n";
                valid = false;
            }

            if (userMode)
            {
                if (textBoxAbout.Text.Trim().Length < 5 && comboBoxStatus.SelectedIndex == 0)
                {
                    error += "Необходимо ввести комментарий\n";
                    valid = false;
                }
                if (!dateBeginUser.Checked && !dateEndUser.Checked)
                {
                    error += "Необходимо ввести минимум одну дату\n";
                    valid = false;
                }

            }

            if (!valid)
            {
                MessageBox.Show("Ошибки:\n" + error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return valid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void DialogStageProject_Load(object sender, EventArgs e)
        {
            InitializationPermission();
        }
    }
}

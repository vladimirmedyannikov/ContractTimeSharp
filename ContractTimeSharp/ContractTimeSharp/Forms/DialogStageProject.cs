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

        public DialogStageProject()
        {
            InitializeComponent();
            InitializationDataBox();
        }

        public void InitializationDataBox()
        {
            UserDAO daoUser = new UserDAO();
            comboBoxUser.Items.AddRange(daoUser.getUserComboBox().ToArray());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
                    dateBeginUser.Value = stage.DateBeginUser;
                    dateEndUser.Value = stage.DateEndUser;
                    dateBeginProg.Value = stage.DateBeginProg;
                    dateEndProg.Value = stage.DateEndProg;
                    textBoxAbout.Text = stage.CommentUser;
                }
                else
                {

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

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
            if (!valid)
            {
                MessageBox.Show("Ошибки:\n" + error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return valid;
        }
    }
}

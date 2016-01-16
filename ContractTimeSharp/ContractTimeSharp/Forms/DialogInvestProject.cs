using ContractTime.Model;
using ContractTimeSharp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ContractTimeSharp.Utils;

namespace ContractTimeSharp.Forms
{
    partial class DialogInvestProject : Form
    {
        private InvestProject project { get; set; }
        public InvestProject Project
        {
            get { return project; }
            set
            {
                project = value;
            }
        }

        public DialogInvestProject()
        {
            InitializeComponent();
            InitializationDataBox();
        }

        public void InitializationDataBox()
        {
            UserDAO daoUser = new UserDAO();
            DepartmentDAO daoDepartment = new DepartmentDAO();
            comboBoxUser.Items.AddRange(daoUser.getUserComboBox().ToArray());
            comboBoxDepartment.Items.AddRange(daoDepartment.getComboBox().ToArray());
        }

        private void saveButton(object sender, EventArgs e)
        {
            if (isValid())
            {
                if (Project == null)
                {
                    Project = new InvestProject();
                }
                Project.nameProject = textBoxNameStage.Text;
                Project.numberProject = textBoxNumberProject.Text;
                Project.dateBegin = dateBeginPlan.Value;
                Project.dateEnd = dateEndPlan.Value;
                Project.dateBeginProg = dateBeginProg.Value;
                Project.dateEndProg = dateEndProg.Value;
                UserDAO daoUser = new UserDAO();
                DepartmentDAO daoDepartment = new DepartmentDAO();
                InvestProjectDAO projectDAO = new InvestProjectDAO();
                Project.user = daoUser.getById(Convert.ToInt32(((KeyValuePair)comboBoxUser.SelectedItem).Key));
                Project.department = daoDepartment.getById(Convert.ToInt32(((KeyValuePair)comboBoxDepartment.SelectedItem).Key));
                
                if (Project.idProject != 0)
                {
                    projectDAO.update(Project);
                }
                else
                {
                    projectDAO.insert(Project);
                }
            }
        }

        public void setProject(InvestProject editProject)
        {
            Project = editProject;
            if (Project != null)
            {
                textBoxNameStage.Text = Project.nameProject;
                textBoxNumberProject.Text = Project.numberProject;
                dateBeginPlan.Value = Project.dateBegin;
                dateEndPlan.Value = Project.dateEnd;
                dateBeginProg.Value = Project.dateBeginProg;
                dateEndProg.Value = Project.dateEndProg;
                textBoxAbout.Text = Project.aboutProject;
                comboBoxDepartment.SelectedItem = new KeyValuePair(Project.department.idDepartment.ToString(), Project.department.nameDepartment);
                comboBoxUser.SelectedItem = new KeyValuePair(Project.user.Id.ToString(), Project.user.FullName);

            }
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
            if (textBoxNumberProject.Text == null || textBoxNumberProject.Text.Length == 0)
            {
                error += "Введите номер проекта\n";
                valid = false;
            }
            if (comboBoxUser.SelectedIndex == -1)
            {
                error += "Выберите ответственного сотрудника за проект\n";
                valid = false;
            }
            if (comboBoxDepartment.SelectedIndex == -1)
            {
                error += "Выберите подразделение\n";
                valid = false;
            }
            if (dateEndPlan.Value.CompareTo(dateBeginPlan.Value) < 0)
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

        private void cancelButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

    }
}

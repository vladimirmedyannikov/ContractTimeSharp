using ContractTime.Model;
using ContractTimeSharp.DAO;
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
    public partial class DirectoryUserForm : Form
    {
        private UserDAO dao = new UserDAO();
        private BindingSource bindingSource = new BindingSource();
        private List<User> userList = new List<User>();

        public DirectoryUserForm()
        {
            InitializeComponent();
        }

        private void DirectoryUserForm_Load(object sender, EventArgs e)
        {
            initializationData();
            InitializationDataBox();
        }

        public void initializationData()
        {
            userList = dao.getAll();
            bindingSource.DataSource = userList;
            gridUsers.DataSource = bindingSource;
            bindingSource.CurrentItemChanged += BindingSource_CurrentItemChanged;
        }

        public void InitializationDataBox()
        {
            DepartmentDAO daoDepartment = new DepartmentDAO();
            cbDepartment.Items.AddRange(daoDepartment.getComboBox().ToArray());
        }

        private void BindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            User user = (User)((BindingSource)gridUsers.DataSource).Current;

            initializatePanelEdit(user);
        }

        private void gridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void initializatePanelEdit(User user)
        {
            tbFirstName.Text = user.FirstName;
            tbSecondName.Text = user.SecondName;
            tbThirdName.Text = user.ThirdName;
            tbAppointment.Text = user.Appointment;
            tbEmail.Text = user.Email;
            tbLogin.Text = user.Login;
            if (user.TypeUser == (int)AdvanceUtil.typeUser.USER)
            {
                rbUser.Checked = true;
            }
            else if (user.TypeUser == (int)AdvanceUtil.typeUser.ADMIN) { rbAdmin.Checked = true; }
            cbDepartment.SelectedItem = new KeyValuePair(user.Department.idDepartment.ToString(), user.Department.nameDepartment);


        }

        private void gridUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isValid())
            {

            }
        }

        public bool isValid()
        {
            bool valid = true;
            MessageBox alert = null;
            String error = "";
            if (tbFirstName.Text == null || tbFirstName.Text.Length <= 2)
            {
                error += "Имя должно быть более 2х символов\n";
                valid = false;
            }
            if (tbSecondName.Text == null || tbSecondName.Text.Length <= 2)
            {
                error += "Фамилия должна быть более 2х символов\n";
                valid = false;
            }
            if (tbThirdName.Text == null || tbThirdName.Text.Length <= 2)
            {
                error += "Отчество должна быть более 2х символов\n";
                valid = false;
            }
            if (tbAppointment.Text == null || tbAppointment.Text.Length <= 2)
            {
                error += "Должность должна быть более 2х символов\n";
                valid = false;
            }
            if (tbLogin.Text == null || tbLogin.Text.Length <= 2)
            {
                error += "Логин должен быть более 2х символов\n";
                valid = false;
            }
            if (tbPassword.Text == null || tbPassword.Text.Length <= 5)
            {
                error += "Логин должен быть более 5х символов\n";
                valid = false;
            }
            if (cbDepartment.SelectedIndex == -1)
            {
                error += "Выберите подразделение сотрудника за проект\n";
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

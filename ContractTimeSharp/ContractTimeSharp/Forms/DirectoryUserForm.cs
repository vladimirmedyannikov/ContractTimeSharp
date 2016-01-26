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
    }
}

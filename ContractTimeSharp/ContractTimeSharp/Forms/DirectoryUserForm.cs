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
        }

        public void initializationData()
        {
            userList = dao.getAll();
            bindingSource.DataSource = userList;
            gridUsers.DataSource = bindingSource;
        }
    }
}

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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти ?", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            UserDAO userDao = new UserDAO();
            User user = userDao.auth(textLogin.Text, textPassword.Text);
            if (user != null)
            {
                //new DialogGridForm().Show();
                MainApplication.User = user;
                this.Close();
            }
            else
            {
                MessageBox.Show("Логин или пароль неверны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AuthForm_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnOk.PerformClick();
            }
        }
    }
}

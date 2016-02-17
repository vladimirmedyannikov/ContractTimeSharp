using ContractTime.Model;
using ContractTimeSharp.DAO;
using ContractTimeSharp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace ContractTimeSharp.Forms
{
    public partial class DirectoryUserForm : Form
    {
        private int bookMark { get; set; }
        private int scrollIndex { get; set; }
        private UserDAO dao = new UserDAO();
        private BindingSource bindingSource = new BindingSource();
        private List<User> userList = new List<User>();
        private bool addUser = false;
        ToolTip buttonToolTip = new ToolTip();

        public DirectoryUserForm()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip() { AutoPopDelay = 0, InitialDelay = 0, ReshowDelay = 0, ShowAlways = true, };
            cbDepartment.DrawMode = DrawMode.OwnerDrawFixed;
            cbDepartment.DrawItem += (s, e) =>
            {
                e.DrawBackground();
                string text = cbDepartment.GetItemText(cbDepartment.Items[e.Index]);
                using (SolidBrush br = new SolidBrush(e.ForeColor))
                    e.Graphics.DrawString(text, e.Font, br, e.Bounds);
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected && cbDepartment.DroppedDown)
                    toolTip.Show(text, cbDepartment, e.Bounds.Right, e.Bounds.Bottom + 4);
                e.DrawFocusRectangle();
            };
            cbDepartment.DropDownClosed += (s, e) =>
                toolTip.Hide(cbDepartment);
        }
 
        //ToolTip buttonToolTip = new ToolTip();

        private void DirectoryUserForm_Load(object sender, EventArgs e)
        {
            initializeColumn();
            initializationData();
            InitializationDataBox();

        }

        private void initializeColumn()
        {
            gridUsers.AutoGenerateColumns = false;
            DataGridViewColumn columnName = new DataGridViewTextBoxColumn();
            columnName.DataPropertyName = "FullName";
            columnName.HeaderText = "ФИО";

            DataGridViewColumn columnDepartment= new DataGridViewTextBoxColumn();
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


            gridUsers.AutoGenerateColumns = false;
            gridUsers.Columns.AddRange(new DataGridViewColumn[] { columnName, columnApp, columnDepartment, columnEmail, columnLogin, columnType });
        }

        public void initializationData()
        {
            panelParam.Hide();
            userList = dao.getAll();
            bindingSource.DataSource = userList;
            gridUsers.DataSource = bindingSource;
            bindingSource.CurrentItemChanged += BindingSource_CurrentItemChanged;

            if ((scrollIndex >= 0) && (gridUsers.Rows.Count > 0))
            {
                gridUsers.FirstDisplayedScrollingRowIndex = scrollIndex;
            }
            if (bookMark != 0)
            {
                gridUsers.Rows[bookMark].Selected = true;
                bindingSource.Position = bookMark;
            }
        }

        public void InitializationDataBox()
        {
            DepartmentDAO daoDepartment = new DepartmentDAO();
            cbDepartment.Items.AddRange(daoDepartment.getComboBox().ToArray());
        }

        private void BindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (!addUser)
            {
                User user = (User)((BindingSource)gridUsers.DataSource).Current;
                initializatePanelEdit(user);
            }
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
            tbPassword.Text = user.Password;
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
                generateBookMark();
                if (addUser)
                {
                    User user = new User();
                    user.FirstName = tbFirstName.Text;
                    user.SecondName = tbSecondName.Text;
                    user.ThirdName = tbThirdName.Text;
                    user.Appointment = tbAppointment.Text;
                    DepartmentDAO daoDepartment = new DepartmentDAO();
                    user.Department = daoDepartment.getById(Convert.ToInt32(((KeyValuePair)(cbDepartment.SelectedItem)).Key));
                    user.Login = tbLogin.Text;
                    user.Password = tbPassword.Text;
                    user.HashPass = Encoding.ASCII.GetString(new SHA1CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(tbPassword.Text)));
                    user.TypeUser = (rbUser.Checked) ? (int)AdvanceUtil.typeUser.USER : (int)AdvanceUtil.typeUser.ADMIN;
                    user.Email = tbEmail.Text;
                    user = dao.insert(user);
                    if (user.Id == 0)
                    {
                        MessageBox.Show("Пользователь не добавлен");
                    }
                    int index = userList.FindIndex(x => x.FullName == user.FullName);
                    if (index >= 0) gridUsers.CurrentCell = gridUsers.Rows[index].Cells[0];
                    panelParam.Hide();
                    
                }
                else
                {
                    User user = new User();
                    user = (User)((BindingSource)gridUsers.DataSource).Current;
                    user.FirstName = tbFirstName.Text;
                    user.SecondName = tbSecondName.Text;
                    user.ThirdName = tbThirdName.Text;
                    user.Appointment = tbAppointment.Text;
                    DepartmentDAO daoDepartment = new DepartmentDAO();
                    user.Department = daoDepartment.getById(Convert.ToInt32(((KeyValuePair)(cbDepartment.SelectedItem)).Key));
                    user.Login = tbLogin.Text;
                    user.Password = tbPassword.Text;
                    user.HashPass = Encoding.ASCII.GetString(new SHA1CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(tbPassword.Text)));
                    user.TypeUser = (rbUser.Checked) ? (int)AdvanceUtil.typeUser.USER : (int)AdvanceUtil.typeUser.ADMIN;
                    user.Email = tbEmail.Text;
                    dao.update(user);
                }
                initializationData();
            }
        }

        public bool isValid()
        {
            bool valid = true;
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
            if (!AdvanceUtil.IsValidEmail(tbEmail.Text))
            {
                error += "Почтовый адрес должен быть формата email@domen.com\n";
                valid = false;
            }

            if (!valid)
            {
                MessageBox.Show("Ошибки:\n" + error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return valid;
        }

        private void mnuUserAdd_Click(object sender, EventArgs e)
        {
            addUser = true;
            tbAppointment.Text = "";
            tbEmail.Text = "";
            tbFirstName.Text = "";
            tbLogin.Text = "";
            tbPassword.Text = "";
            tbSecondName.Text = "";
            tbThirdName.Text = "";
            cbDepartment.SelectedIndex = -1;
            panelParam.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            panelParam.Hide();
        }

        private void mnuUserEdit_Click(object sender, EventArgs e)
        {
            addUser = false;
            User user = (User)((BindingSource)gridUsers.DataSource).Current;
            initializatePanelEdit(user);
            panelParam.Show();
        }

        private void generateBookMark()
        {
            bookMark = gridUsers.CurrentRow.Index;
            scrollIndex = gridUsers.FirstDisplayedScrollingRowIndex;
        }

        private void gridUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
            {
                SearchGrid form = new SearchGrid(gridUsers);
                form.ShowDialog();
            }
        }

        private void mnuUserDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,"Вы действительно хотите удалить пользователя ?","Удаление",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                User user = (User)bindingSource.Current;
                dao.delete(user);
                initializationData();
            }
        }

        private void cbDepartment_MouseHover(object sender, EventArgs e)
        {
            buttonToolTip.ToolTipTitle = "Value";
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.IsBalloon = true;
            buttonToolTip.ShowAlways = true;
            buttonToolTip.AutoPopDelay = 5000;
            buttonToolTip.InitialDelay = 1000;
            buttonToolTip.ReshowDelay = 0;

            buttonToolTip.SetToolTip(cbDepartment, cbDepartment.SelectedText);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelParam.Hide();
        }

        private void mnuExcel_Click(object sender, EventArgs e)
        {
            ReportGenerate.PrintExcelGrid(gridUsers);
        }
    }
}

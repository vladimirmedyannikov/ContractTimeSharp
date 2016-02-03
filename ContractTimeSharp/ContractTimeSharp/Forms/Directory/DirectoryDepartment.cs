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

namespace ContractTimeSharp.Forms.Directory
{
    public partial class DirectoryDepartment : Form
    {
        private int bookMark { get; set; }
        private int scrollIndex { get; set; }
        private List<Department> departmentList = new List<Department>();
        private DepartmentDAO dao = new DepartmentDAO();
        private bool addDept;
        private BindingSource bindingSource = new BindingSource();

        public DirectoryDepartment()
        {
            InitializeComponent();
            InitializeColumn();
            initializationData();
            InitializationDataBox();
        }

        public void InitializeColumn()
        {
            DataGridViewColumn columnName = new DataGridViewTextBoxColumn();
            columnName.DataPropertyName = "nameDepartment";
            columnName.HeaderText = "Название подразделения";

            DataGridViewColumn columnFirm = new DataGridViewTextBoxColumn();
            columnFirm.DataPropertyName = "firmDepartment";
            columnFirm.HeaderText = "Организация";

            DataGridViewColumn columnParent = new DataGridViewTextBoxColumn();
            columnParent.DataPropertyName = "parentDepartment";
            columnParent.HeaderText = "Родитель";

            gridDepartment.AutoGenerateColumns = false;
            gridDepartment.Columns.AddRange(new DataGridViewColumn[] { columnName, columnFirm,columnParent});

        }

        public void initializationData()
        {
            panelParam.Hide();
            departmentList = dao.getAll();
            bindingSource.DataSource = departmentList;
            gridDepartment.DataSource = bindingSource;
            bindingSource.CurrentItemChanged += BindingSource_CurrentItemChanged;

            if ((scrollIndex >= 0) && (gridDepartment.Rows.Count > 0))
            {
                gridDepartment.FirstDisplayedScrollingRowIndex = scrollIndex;
            }
            if (bookMark != 0)
            {
                gridDepartment.Rows[bookMark].Selected = true;
                bindingSource.Position = bookMark;
            }
        }

        private void InitializePanelEdit(Department department)
        {
            tbNameDept.Text = department.nameDepartment;
            cbFirm.SelectedItem = new KeyValuePair(department.firmDepartment.IdFirm.ToString(), department.firmDepartment.NameFirm);
            if (department.parentDepartment.idDepartment != 0)
            {
                cbDepartment.SelectedItem = new KeyValuePair(department.parentDepartment.idDepartment.ToString(), department.parentDepartment.nameDepartment);
            }
        }

        private void BindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            
        }

        public void InitializationDataBox()
        {
            FirmDAO daoFirm = new FirmDAO();
            cbFirm.Items.AddRange(daoFirm.getComboBox().ToArray());
            cbDepartment.Enabled = false;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cbFirm_SelectedIndexChanged(object sender, EventArgs e)
        {
            DepartmentDAO daoDepartment = new DepartmentDAO();
            if (cbFirm.SelectedIndex >= 0)
            {
                cbDepartment.Items.Clear();
                cbDepartment.Items.AddRange(daoDepartment.getComboBox(Convert.ToInt32(((KeyValuePair)cbFirm.SelectedItem).Key)).ToArray());
                cbDepartment.Enabled = true;
            }
        }

        private void mnuDeptEdit_Click(object sender, EventArgs e)
        {
            Department department = (Department)((BindingSource)(gridDepartment.DataSource)).Current;
            InitializePanelEdit(department);
            addDept = false;
            panelParam.Show();
        }

        private void mnuDeptAdd_Click(object sender, EventArgs e)
        {
            tbNameDept.Text = "";
            cbFirm.SelectedIndex = -1;
            cbDepartment.SelectedIndex = -1;
            cbDepartment.Enabled = false;
            addDept = true;
            panelParam.Show();
        }

        private void cbFirm_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void generateBookMark()
        {
            bookMark = gridDepartment.CurrentRow.Index;
            scrollIndex = gridDepartment.FirstDisplayedScrollingRowIndex;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            generateBookMark();
            Department department = null;
            if (isValid())
            {
                if (!addDept)
                {
                    department = (Department)((BindingSource)gridDepartment.DataSource).Current;
                }
                else
                {
                    department = new Department();
                }
                department.nameDepartment = tbNameDept.Text;
                FirmDAO daoFirm = new FirmDAO();
                department.firmDepartment = daoFirm.getById(Convert.ToInt32(((KeyValuePair)cbFirm.SelectedItem).Key));
                if (cbDepartment.SelectedIndex >= 0) department.parentDepartment = dao.getById(Convert.ToInt32(((KeyValuePair)cbDepartment.SelectedItem).Key));

                if (department.idDepartment != 0)
                {
                    dao.update(department);
                }
                else
                {
                    department = dao.insert(department);
                }
                initializationData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            panelParam.Hide();
        }

        public bool isValid()
        {
            bool valid = true;
            String error = "";
            if (tbNameDept.Text == null || tbNameDept.Text.Length <= 2)
            {
                error += "Название должно быть более 2х символов\n";
                valid = false;
            }
            if (cbFirm.SelectedIndex < 0)
            {
                error += "Необходимо выбрать организацию\n";
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

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
            initializationData();
            InitializationDataBox();
        }

        public void initializationData()
        {
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            Department department = null;
            if (!addDept) {
                department = (Department)((BindingSource)gridDepartment.DataSource).Current;
            }
            else
            {
                department = new Department();
            }

        }
    }
}

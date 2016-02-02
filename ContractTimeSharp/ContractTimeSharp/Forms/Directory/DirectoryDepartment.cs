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
            cbDepartment.Items.AddRange(daoDepartment.getComboBox(Convert.ToInt32(((KeyValuePair)cbFirm.SelectedItem).Key)).ToArray());
            cbDepartment.Enabled = true;
        }
    }
}

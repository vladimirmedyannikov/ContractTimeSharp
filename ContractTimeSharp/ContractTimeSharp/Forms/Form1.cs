﻿using ContractTime.Model;
using ContractTimeSharp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace ContractTimeSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.Add(new Firm(1,"Firm1"));
            bindingSource.Add(new Firm(2, "Firm2"));
            bindingSource.Add(new Firm(3, "Firm3"));
            bindingSource.Add(new Firm(4, "Firm4"));
            /*dataGridView1.AutoGenerateColumns = false;
            
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "user";
            column.Name = "NameFirm";
            dataGridView1.Columns.Add(column);*/

            /*column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "NameFirm";
            column.Name = "NameFirm";
            dataGridView1.Columns.Add(column);*/

            InvestProjectDAO dao = new InvestProjectDAO();
            InvestProject investProject = new InvestProject();
            investProject.nameProject = "New project";
            investProject.numberProject = "kikj osj 22 12";
            User user = new User();
            user.Id = 1;
            investProject.user = user;
            Department department = new Department();
            department.idDepartment = 3;
            investProject.department = department;
            investProject.dateBegin = DateTime.Now;
            investProject.dateEnd = DateTime.Now.AddDays(5);
            investProject.aboutProject = "About project";
            bindingSource.Clear();

            //dao.insert(investProject);
            bindingSource.DataSource = dao.getAll();
            dataGridView1.DataSource = bindingSource;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.DataMember);
            InvestProject ip = (InvestProject)dataGridView1.CurrentRow.DataBoundItem;
            MessageBox.Show(ip.nameProject);
        }
    }
}

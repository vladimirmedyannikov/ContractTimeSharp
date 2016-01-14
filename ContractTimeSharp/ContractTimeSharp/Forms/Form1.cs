using Aga.Controls.Tree;
using Aga.Controls.Tree.NodeControls;
using ContractTime.Model;
using ContractTimeSharp.DAO;
using ContractTimeSharp.Model;
using ContractTimeSharp.NodeTree;
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
            treeViewAdv1.UseColumns = true;

            TreeColumn columnName = new TreeColumn("Этап", 120);
            TreeColumn columnNameStage = new TreeColumn("Название", 150);
            TreeColumn columnUser = new TreeColumn("Ответственный", 160);
            TreeColumn columnDateBegin = new TreeColumn("Начало (план)", 60);
            TreeColumn columnDateEnd = new TreeColumn("Завершение (план)", 60);
            TreeColumn columnDateBeginUser = new TreeColumn("Начало (пользв.)", 60);
            TreeColumn columnDateEndUser = new TreeColumn("Завершение (пользв.)", 60);
            TreeColumn columnStatus = new TreeColumn("Статус", 10);
            TreeColumn columnDateBeginProg = new TreeColumn("Начало (прогноз)", 60);
            TreeColumn columnDateEndProg = new TreeColumn("Завершение (прогноз)", 60);
            TreeColumn columnComment = new TreeColumn("Комментарий", 200);


            //treeViewAdv1.Columns.Add(columnName);
            treeViewAdv1.Columns.Add(columnNameStage);
            treeViewAdv1.Columns.Add(columnUser);
            treeViewAdv1.Columns.Add(columnDateBegin);
            treeViewAdv1.Columns.Add(columnDateEnd);
            treeViewAdv1.Columns.Add(columnDateBeginUser);
            treeViewAdv1.Columns.Add(columnDateEndUser);
            treeViewAdv1.Columns.Add(columnStatus);
            treeViewAdv1.Columns.Add(columnDateBeginProg);
            treeViewAdv1.Columns.Add(columnDateEndProg);
            treeViewAdv1.Columns.Add(columnComment);
            

            NodeTextBox nodeTextName = new NodeTextBox();
            nodeTextName.DataPropertyName = "NameStage";
            nodeTextName.ParentColumn = columnNameStage;
            nodeTextName.IncrementalSearchEnabled = true;
            treeViewAdv1.NodeControls.Add(nodeTextName);

            NodeTextBox nodeTextUser = new NodeTextBox();
            nodeTextUser.DataPropertyName = "User";
            nodeTextUser.ParentColumn = columnUser;
            nodeTextUser.IncrementalSearchEnabled = true;
            treeViewAdv1.NodeControls.Add(nodeTextUser);

            NodeTextBox nodeTextDateBegin = new NodeTextBox();
            nodeTextDateBegin.DataPropertyName = "DateBegin";
            nodeTextDateBegin.ParentColumn = columnDateBegin;
            nodeTextDateBegin.IncrementalSearchEnabled = true;
            treeViewAdv1.NodeControls.Add(nodeTextDateBegin);

            NodeTextBox nodeTextDateEnd = new NodeTextBox();
            nodeTextDateEnd.DataPropertyName = "DateEnd";
            nodeTextDateEnd.ParentColumn = columnDateEnd;
            nodeTextDateEnd.IncrementalSearchEnabled = true;
            treeViewAdv1.NodeControls.Add(nodeTextDateEnd);

            NodeTextBox nodeTextDateBeginUser = new NodeTextBox();
            nodeTextDateBeginUser.DataPropertyName = "DateBeginUser";
            nodeTextDateBeginUser.ParentColumn = columnDateBeginUser;
            nodeTextDateBeginUser.IncrementalSearchEnabled = true;
            treeViewAdv1.NodeControls.Add(nodeTextDateBeginUser);

            NodeTextBox nodeTextDateEndUser = new NodeTextBox();
            nodeTextDateEndUser.DataPropertyName = "DateEndUser";
            nodeTextDateEndUser.ParentColumn = columnDateEndUser;
            nodeTextDateEndUser.IncrementalSearchEnabled = true;
            treeViewAdv1.NodeControls.Add(nodeTextDateEndUser);

            NodeTextBox nodeTextStatus = new NodeTextBox();
            nodeTextStatus.DataPropertyName = "Status";
            nodeTextStatus.ParentColumn = columnStatus ;
            nodeTextStatus.IncrementalSearchEnabled = true;
            treeViewAdv1.NodeControls.Add(nodeTextStatus);

            NodeTextBox nodeTextDateBeginProg = new NodeTextBox();
            nodeTextDateBeginProg.DataPropertyName = "DateBeginProg";
            nodeTextDateBeginProg.ParentColumn = columnDateBeginProg;
            nodeTextDateBeginProg.IncrementalSearchEnabled = true;
            treeViewAdv1.NodeControls.Add(nodeTextDateBeginProg);

            NodeTextBox nodeTextDateEndProg= new NodeTextBox();
            nodeTextDateEndProg.DataPropertyName = "DateEndProg";
            nodeTextDateEndProg.ParentColumn = columnDateEndProg;
            nodeTextDateEndProg.IncrementalSearchEnabled = true;
            treeViewAdv1.NodeControls.Add(nodeTextDateEndProg);

            NodeTextBox nodeTextCommentUser = new NodeTextBox();
            nodeTextCommentUser.DataPropertyName = "CommentUser";
            nodeTextCommentUser.ParentColumn = columnComment;
            nodeTextCommentUser.IncrementalSearchEnabled = true;
            treeViewAdv1.NodeControls.Add(nodeTextCommentUser);
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
            bindingSource.CurrentItemChanged += BindingSource_CurrentItemChanged;
            bindingSource.CurrentChanged += BindingSource_CurrentChanged;
            bindingSource.PositionChanged += BindingSource_PositionChanged;
            dataGridView1.DataMemberChanged += DataGridView1_DataMemberChanged;

        }

        private void DataGridView1_DataMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            
        }

        private void BindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("next");
            
        }

        private void BindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem != null)
            {
                InvestProject ip = (InvestProject)((BindingSource)sender).Current;
                StageProjectDAO dao = new StageProjectDAO();
                List<StageProject> listProject = dao.getByProject(ip.idProject);
                List<StageProject> listSubStage = dao.getSubStageProject(ip.idProject);
                TreeModel model = new TreeModel();
                treeViewAdv1.Model = model;
                treeViewAdv1.BeginUpdate();
                foreach (StageProject stage in listProject)
                {
                    Node node = new StageProjectNode(stage.NameStage,stage.CommentUser,stage.DateBeginPlan.ToString(), stage.DateEndPlan.ToString(), stage.DateBeginProg.ToString(), stage.DateEndProg.ToString(), stage.DateBeginUser.ToString(), stage.DateEndUser.ToString(), stage.User.FullName, stage.StatusStage.ToString(), stage);
                    foreach (StageProject child in stage.SubStage){
                        Node childNode = new StageProjectNode(child.NameStage, child.CommentUser, child.DateBeginPlan.ToString(), child.DateEndPlan.ToString(), child.DateBeginProg.ToString(), child.DateEndProg.ToString(), child.DateBeginUser.ToString(), child.DateEndUser.ToString(), child.User.FullName, child.StatusStage.ToString(),child);
                        node.Nodes.Add(childNode);
                    }
                    model.Nodes.Add(node);                   
                }
                treeViewAdv1.EndUpdate();
            }
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

        private void olvDataTree_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeViewAdv1_Click(object sender, EventArgs e)
        {

        }

        private void treeViewAdv1_DoubleClick(object sender, EventArgs e)
        {
           // Node node = (Node)treeViewAdv1.Model;
            TreeModel model = (TreeModel)treeViewAdv1.Model;
            
            MessageBox.Show(((StageProjectNode)model.Nodes[treeViewAdv1.SelectedNode.Index]).stage.User.SecondName);
        }
    }
}

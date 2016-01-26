using Aga.Controls.Tree;
using Aga.Controls.Tree.NodeControls;
using ContractTime.Model;
using ContractTimeSharp.DAO;
using ContractTimeSharp.Forms;
using ContractTimeSharp.Model;
using ContractTimeSharp.NodeTree;
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
    public partial class MonitoringStage : Form
    {
        public MonitoringStage()
        {
            InitializeComponent();
        }

        private void butnShow_Click(object sender, EventArgs e)
        {
            initializeData();
            updateProjectTreeView();
        }


        private void InitializeColumnStageProject()
        {
            #region Инициализация столбцов Этапов
            treeProject.UseColumns = true;

            TreeColumn columnName = new TreeColumn("Этап", 120);
            TreeColumn columnNameStage = new TreeColumn("Название", 150);
            TreeColumn columnUser = new TreeColumn("Ответственный", 160);
            TreeColumn columnDateBegin = new TreeColumn("Начало (план)", 60);
            TreeColumn columnDateEnd = new TreeColumn("Завершение (план)", 60);
            TreeColumn columnDateBeginUser = new TreeColumn("Начало (пользв.)", 60);

            TreeColumn columnDateEndUser = new TreeColumn("Завершение (пользв.)", 60);
            TreeColumn columnStatus = new TreeColumn("Статус", 60);
            TreeColumn columnDateBeginProg = new TreeColumn("Начало (прогноз)", 60);
            TreeColumn columnDateEndProg = new TreeColumn("Завершение (прогноз)", 60);
            TreeColumn columnComment = new TreeColumn("Комментарий", 200);

            //treeProject.Columns.Add(columnName);
            treeProject.Columns.Add(columnNameStage);
            treeProject.Columns.Add(columnUser);
            treeProject.Columns.Add(columnDateBegin);
            treeProject.Columns.Add(columnDateEnd);
            treeProject.Columns.Add(columnDateBeginUser);
            treeProject.Columns.Add(columnDateEndUser);
            treeProject.Columns.Add(columnStatus);
            treeProject.Columns.Add(columnDateBeginProg);
            treeProject.Columns.Add(columnDateEndProg);
            treeProject.Columns.Add(columnComment);

            NodeCheckBox nodeCheck = new NodeCheckBox();
            nodeCheck.ParentColumn = columnNameStage;
            //nodeCheck.ThreeState = true;
            nodeCheck.VirtualMode = false;
            nodeCheck.EditEnabled = true;
            //nodeCheck.IsEditEnabledValueNeeded += IsEditEnabledValueNeeded;
            treeProject.NodeControls.Add(nodeCheck);

            NodeTextBox nodeTextName = new NodeTextBox();
            nodeTextName.DataPropertyName = "NameStage";
            nodeTextName.ParentColumn = columnNameStage;
            nodeTextName.IncrementalSearchEnabled = true;
            treeProject.NodeControls.Add(nodeTextName);

            NodeTextBox nodeTextUser = new NodeTextBox();
            nodeTextUser.DataPropertyName = "User";
            nodeTextUser.ParentColumn = columnUser;
            nodeTextUser.IncrementalSearchEnabled = true;
            treeProject.NodeControls.Add(nodeTextUser);

            NodeTextBox nodeTextDateBegin = new NodeTextBox();
            nodeTextDateBegin.DataPropertyName = "DateBegin";
            nodeTextDateBegin.ParentColumn = columnDateBegin;
            nodeTextDateBegin.IncrementalSearchEnabled = true;
            treeProject.NodeControls.Add(nodeTextDateBegin);

            NodeTextBox nodeTextDateEnd = new NodeTextBox();
            nodeTextDateEnd.DataPropertyName = "DateEnd";
            nodeTextDateEnd.ParentColumn = columnDateEnd;
            nodeTextDateEnd.IncrementalSearchEnabled = true;
            treeProject.NodeControls.Add(nodeTextDateEnd);

            NodeTextBox nodeTextDateBeginUser = new NodeTextBox();
            nodeTextDateBeginUser.DataPropertyName = "DateBeginUser";
            nodeTextDateBeginUser.ParentColumn = columnDateBeginUser;
            nodeTextDateBeginUser.IncrementalSearchEnabled = true;
            treeProject.NodeControls.Add(nodeTextDateBeginUser);

            NodeTextBox nodeTextDateEndUser = new NodeTextBox();
            nodeTextDateEndUser.DataPropertyName = "DateEndUser";
            nodeTextDateEndUser.ParentColumn = columnDateEndUser;
            nodeTextDateEndUser.IncrementalSearchEnabled = false;


            treeProject.NodeControls.Add(nodeTextDateEndUser);

            NodeTextBox nodeTextStatus = new NodeTextBox();
            nodeTextStatus.DataPropertyName = "Status";
            nodeTextStatus.ParentColumn = columnStatus;
            nodeTextStatus.IncrementalSearchEnabled = true;
            treeProject.NodeControls.Add(nodeTextStatus);

            NodeTextBox nodeTextDateBeginProg = new NodeTextBox();
            nodeTextDateBeginProg.DataPropertyName = "DateBeginProg";
            nodeTextDateBeginProg.ParentColumn = columnDateBeginProg;
            nodeTextDateBeginProg.IncrementalSearchEnabled = true;
            treeProject.NodeControls.Add(nodeTextDateBeginProg);

            NodeTextBox nodeTextDateEndProg = new NodeTextBox();
            nodeTextDateEndProg.DataPropertyName = "DateEndProg";
            nodeTextDateEndProg.ParentColumn = columnDateEndProg;
            nodeTextDateEndProg.IncrementalSearchEnabled = true;
            treeProject.NodeControls.Add(nodeTextDateEndProg);

            NodeTextBox nodeTextCommentUser = new NodeTextBox();
            nodeTextCommentUser.DataPropertyName = "CommentUser";
            nodeTextCommentUser.ParentColumn = columnComment;
            nodeTextCommentUser.IncrementalSearchEnabled = true;
            treeProject.NodeControls.Add(nodeTextCommentUser);
            #endregion
        }

        public void initializeData()
        {
            StageProjectDAO dao = new StageProjectDAO();
            BindingSource source = new BindingSource();
            List<StageProject> listStage = dao.getByDate(dateTimePicker1.Value);
            source.DataSource = listStage;
            dataStage.DataSource = source;
        }

        public void updateStageProject()
        {
            TreeModel model = new TreeModel();
            treeProject.Model = model;
            
            treeProject.BeginUpdate();
            InvestProjectDAO daoProject = new InvestProjectDAO();
            StageProjectDAO dao = new StageProjectDAO();
            List<InvestProject> listProject = daoProject.getAll();
            List<StageProject> listStage = null;
            List<StageProject> listSubStage = null;
            foreach (InvestProject project in listProject)
            {
                listStage = dao.getByProject(project.idProject);
                listSubStage = dao.getSubStageProject(project.idProject);
                Node nodeProject = new StageProjectNode(project.nameProject, "", project.dateBegin.ToShortDateString(), project.dateEnd.ToShortDateString(), project.dateBeginProg.ToShortDateString(), project.dateEndProg.ToShortDateString(), "", "", "","", null);
                foreach (StageProject stage in listStage)
                {
                    Node node = new StageProjectNode(stage.NameStage, stage.CommentUser, stage.DateBeginPlan.ToShortDateString(), stage.DateEndPlan.ToShortDateString(), stage.DateBeginProg.ToShortDateString(), stage.DateEndProg.ToShortDateString(), stage.DateBeginUser.ToShortDateString(), stage.DateEndUser.ToShortDateString(), stage.User.FullName, stage.StatusStage.ToString(), stage);
                    nodeProject.Nodes.Add(node);
                    foreach (StageProject child in stage.SubStage)
                    {
                        Node childNode = new StageProjectNode(child.NameStage, child.CommentUser, child.DateBeginPlan.ToShortDateString(), child.DateEndPlan.ToShortDateString(), child.DateBeginProg.ToShortDateString(), child.DateEndProg.ToShortDateString(), child.DateBeginUser.ToShortDateString(), child.DateEndUser.ToShortDateString(), child.User.FullName, child.StatusStage.ToString(), child);
                        node.Nodes.Add(childNode);
                    }
                    model.Nodes.Add(nodeProject);
                }
            }

            treeProject.EndUpdate();
        }

        public void updateProjectTreeView()
        {
            TreeNode root = new TreeNode();

            treeViewProject.Nodes.Clear();
            InvestProjectDAO daoProject = new InvestProjectDAO();
            StageProjectDAO dao = new StageProjectDAO();
            List<InvestProject> listProject = daoProject.getAll();
            List<StageProject> listStage = null;
            List<StageProject> listSubStage = null;
            foreach (InvestProject project in listProject)
            {
                listStage = dao.getByProject(project.idProject);
                listSubStage = dao.getSubStageProject(project.idProject);
                TreeNode nodeProject = new TreeNode(String.Format("Проект: {0} || Дата начала {1} || Дата завершения {2} || Дана начала(прогноз) {3} || Дата завершения(прогноз) {4}",project.nameProject, project.dateBegin.ToShortDateString(), project.dateEnd.ToShortDateString(), project.dateBeginProg.ToShortDateString(), project.dateEndProg.ToShortDateString()));
                nodeProject.Tag = project;
                foreach (StageProject stage in listStage)
                {
                    TreeNode node = new TreeNode(String.Format("Этап: {0} || Дата начала {1} || Дата завершения {2} || Дана начала(прогноз) {3} || Дата завершения(прогноз) {4} || Ответственный {5} || Дата начала(ответств) {6} || Дата завершения(ответств) {7}", 
                        stage.NameStage, stage.DateBeginPlan.ToShortDateString(), stage.DateEndPlan.ToShortDateString(), stage.DateBeginProg.ToShortDateString(), stage.DateEndProg.ToShortDateString(),
                        stage.User.FullName, stage.DateBeginUser.ToShortDateString(), stage.DateEndUser.ToShortDateString()));
                    node.Tag = stage;
                    nodeProject.Nodes.Add(node);
                    foreach (StageProject child in stage.SubStage)
                    {
                        TreeNode childNode = new TreeNode(String.Format("Этап: {0} || Дата начала {1} || Дата завершения {2} || Дана начала(прогноз) {3} || Дата завершения(прогноз) {4} || Ответственный {5} || Дата начала(ответств) {6} || Дата завершения(ответств) {7}",
                            child.NameStage, child.DateBeginPlan.ToShortDateString(), child.DateEndPlan.ToShortDateString(), child.DateBeginProg.ToShortDateString(), child.DateEndProg.ToShortDateString(),
                            child.User.FullName, child.DateBeginUser.ToShortDateString(), child.DateEndUser.ToShortDateString()));
                        childNode.Tag = child;
                        node.Nodes.Add(childNode);
                    }
                }
                treeViewProject.Nodes.Add(nodeProject);
            }

            treeProject.EndUpdate();
        }

        private void sendMessage_Click(object sender, EventArgs e)
        {
            List<TreeNode> nodeList = new List<TreeNode>();
            foreach (TreeNode node in treeViewProject.Nodes)
            {
                nodeList.AddRange(getParent(node));
            }

            List<StageProject> listStage = nodeList.Select(s => (StageProject)s.Tag).ToList();
            List<User> listUser = listStage.Select(u => u.User).GroupBy(user=>user.Id).Select(group => group.First()).ToList();
            foreach (User user in listUser)
            {
                List<StageProject> listSend = listStage.Where(u => u.User.Id == user.Id).ToList();
                StringBuilder message = new StringBuilder();
                message.Append("<H1>Добрый день<br>У Вас имеются задачи для заполения в системе: </H1><br><ul>");
                foreach (StageProject stage in listSend)
                {
                    message.AppendFormat("<li>Проект: {0}, Этап: {1}, Плановая дата начала: {2}, Плановая дата завершения: {3} </li>",stage.Project.nameProject, stage.NameStage, stage.DateBeginPlan.ToShortDateString(), stage.DateEndPlan.ToShortDateString());
                }
                message.Append("</li>");
                AdvanceUtil.SendMessage(user.Email, message.ToString());
            }
        }

        private List<TreeNode> getParent(TreeNode node)
        {
            List<TreeNode> list = new List<TreeNode>();
            if (node.Nodes.Count > 0)
            {
                foreach(TreeNode subNode in node.Nodes)
                {
                    if (subNode.Checked && subNode.Tag != null)
                        list.Add(subNode);
                    list.AddRange(getParent(subNode));
                }
                return list;
            }
            else
                return new List<TreeNode>();
        }
    }
}

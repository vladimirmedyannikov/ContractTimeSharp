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
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using ContractTimeSharp.Forms.Directory;

namespace ContractTimeSharp
{
    public partial class DialogGridForm : Form
    {
        private int bookMark;
        private int scrollIndex;
        public int BookMarkInvestProject
        {
            get { return bookMark; }
            set
            {
                bookMark = value;
            }
        }
        public int ScrollIndex
        {
            get { return scrollIndex; }
            set
            {
                scrollIndex = value;
            }
        }
        public DialogGridForm()
        {
            InitializeComponent();
            InitializeColumnStageProject();
            InitializeColumnInvestProject();
            initializationInvestProject();
        }

        private void InitializeColumnInvestProject()
        {
            #region Инициализация столбцов Проекта
            dataGridInvestProject.AutoGenerateColumns = false;

            DataGridViewColumn columnNameProject = new DataGridViewTextBoxColumn();
            columnNameProject.HeaderText = "Название проекта";
            columnNameProject.DataPropertyName = "nameProject";

            DataGridViewColumn columnNumberProject = new DataGridViewTextBoxColumn();
            columnNumberProject.HeaderText = "Номер проекта";
            columnNumberProject.DataPropertyName = "numberProject";

            DataGridViewColumn columnDepartment = new DataGridViewTextBoxColumn();
            columnDepartment.HeaderText = "Подразделение";
            columnDepartment.DataPropertyName = "department";

            DataGridViewColumn columnUserProject = new DataGridViewTextBoxColumn();
            columnUserProject.HeaderText = "Ответственный";
            columnUserProject.DataPropertyName = "user";

            DataGridViewColumn columnDateBeginProject = new DataGridViewTextBoxColumn();
            columnDateBeginProject.HeaderText = "Дата начала (план)";
            columnDateBeginProject.DataPropertyName = "dateBegin";

            DataGridViewColumn columnDateEndProject = new DataGridViewTextBoxColumn();
            columnDateEndProject.HeaderText = "Дата завершения (план)";
            columnDateEndProject.DataPropertyName = "dateEnd";

            DataGridViewColumn columnDateBeginProgProject = new DataGridViewTextBoxColumn();
            columnDateBeginProgProject.HeaderText = "Дата начала (прогноз)";
            columnDateBeginProgProject.DataPropertyName = "dateBeginProg";

            DataGridViewColumn columnDateEndProgProject = new DataGridViewTextBoxColumn();
            columnDateEndProgProject.HeaderText = "Дата завершения (прогноз)";
            columnDateEndProgProject.DataPropertyName = "dateEndProg";

            DataGridViewColumn columnAboutProject = new DataGridViewTextBoxColumn();
            columnAboutProject.HeaderText = "Комментарий";
            columnAboutProject.DataPropertyName = "aboutProject";

            dataGridInvestProject.Columns.AddRange(new DataGridViewColumn[] { columnNameProject, columnNumberProject, columnDepartment, columnUserProject, columnDateBeginProject,
                columnDateEndProject, columnDateBeginProgProject, columnDateEndProgProject, columnAboutProject });
            #endregion
        }

        private void InitializeColumnStageProject()
        {
            #region Инициализация столбцов Этапов
            treeViewAdv1.UseColumns = true;

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
            nodeTextDateEndUser.IncrementalSearchEnabled = false;


            treeViewAdv1.NodeControls.Add(nodeTextDateEndUser);

            NodeTextBox nodeTextStatus = new NodeTextBox();
            nodeTextStatus.DataPropertyName = "Status";
            nodeTextStatus.ParentColumn = columnStatus;
            nodeTextStatus.IncrementalSearchEnabled = true;
            treeViewAdv1.NodeControls.Add(nodeTextStatus);

            NodeTextBox nodeTextDateBeginProg = new NodeTextBox();
            nodeTextDateBeginProg.DataPropertyName = "DateBeginProg";
            nodeTextDateBeginProg.ParentColumn = columnDateBeginProg;
            nodeTextDateBeginProg.IncrementalSearchEnabled = true;
            treeViewAdv1.NodeControls.Add(nodeTextDateBeginProg);

            NodeTextBox nodeTextDateEndProg = new NodeTextBox();
            nodeTextDateEndProg.DataPropertyName = "DateEndProg";
            nodeTextDateEndProg.ParentColumn = columnDateEndProg;
            nodeTextDateEndProg.IncrementalSearchEnabled = true;
            treeViewAdv1.NodeControls.Add(nodeTextDateEndProg);

            NodeTextBox nodeTextCommentUser = new NodeTextBox();
            nodeTextCommentUser.DataPropertyName = "CommentUser";
            nodeTextCommentUser.ParentColumn = columnComment;
            nodeTextCommentUser.IncrementalSearchEnabled = true;
            treeViewAdv1.NodeControls.Add(nodeTextCommentUser);
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        public void initializationInvestProject()
        {
            BindingSource bindingSource = new BindingSource();
            InvestProjectDAO dao = new InvestProjectDAO();
            bindingSource.Clear();
            bindingSource.DataSource = dao.getAll();
            dataGridInvestProject.DataSource = bindingSource;
            bindingSource.CurrentItemChanged += BindingSource_CurrentItemChanged;
            
            if ((ScrollIndex >=0) && (dataGridInvestProject.Rows.Count > 0))
            {
                dataGridInvestProject.FirstDisplayedScrollingRowIndex = ScrollIndex;
            }
            if (BookMarkInvestProject != 0)
            {
                dataGridInvestProject.Rows[BookMarkInvestProject].Selected = true;
                bindingSource.Position = BookMarkInvestProject;
            }
            else
            {
                if (bindingSource.Count > 0)
                {
                    bindingSource.MoveNext();
                    bindingSource.MoveFirst();
                }
                if (bindingSource.Count == 1)
                {
                    updateStageProject();
                }
                //dataGridInvestProject.Rows[1].Selected = true;
            }
        }


        private void BindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            updateStageProject();
        }

        public void updateStageProject()
        {
            if (dataGridInvestProject.CurrentRow.DataBoundItem != null)
            {
                InvestProject ip = (InvestProject)((BindingSource)dataGridInvestProject.DataSource).Current;
                StageProjectDAO dao = new StageProjectDAO();
                List<StageProject> listProject = dao.getByProject(ip.idProject);
                //List<StageProject> listSubStage = dao.getSubStageProject(ip.idProject);
                TreeModel model = new TreeModel();
                treeViewAdv1.BeginUpdate();
                foreach (StageProject stage in listProject)
                {
                    Node node = new StageProjectNode(stage.NameStage, stage.CommentUser, stage.DateBeginPlan.ToShortDateString(), stage.DateEndPlan.ToShortDateString(), stage.DateBeginProg.ToShortDateString(), stage.DateEndProg.ToShortDateString(), stage.DateBeginUser.ToShortDateString(), stage.DateEndUser.ToShortDateString(), stage.User.FullName, stage.StatusStage.ToString(), stage);
                    foreach (StageProject child in stage.SubStage)
                    {
                        Node childNode = new StageProjectNode(child.NameStage, child.CommentUser, child.DateBeginPlan.ToShortDateString(), child.DateEndPlan.ToShortDateString(), child.DateBeginProg.ToShortDateString(), child.DateEndProg.ToShortDateString(), child.DateBeginUser.ToShortDateString(), child.DateEndUser.ToShortDateString(), child.User.FullName, child.StatusStage.ToString(), child);
                        node.Nodes.Add(childNode);
                    }
                    model.Nodes.Add(node);
                }
                treeViewAdv1.Model = model;
                treeViewAdv1.EndUpdate();
            }
        }

        private void treeViewAdv1_DoubleClick(object sender, EventArgs e)
        {
            TreeModel model = (TreeModel)treeViewAdv1.Model;
            if (model != null && model.Nodes.Count > 0) mnuEditStage.PerformClick();
        }

        private void insertInvestProjectMenu(object sender, EventArgs e)
        {
            DialogInvestProject d = new DialogInvestProject();
            d.ShowDialog();
            initializationInvestProject();
        }

        private void editInvestProjectMenu(object sender, EventArgs e)
        {
            showDialogInvestProject();
        }

        private void deleteInvestProjectMenu(object sender, EventArgs e)
        {
            InvestProject ip = (InvestProject)dataGridInvestProject.CurrentRow.DataBoundItem;
            if (MessageBox.Show("Вы действительно хотите удалить проект и все связанные с ним данные ?", "Удаление",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                InvestProjectDAO dao = new InvestProjectDAO();
                dao.delete(ip);
                initializationInvestProject();
            }
        }

        public void showDialogInvestProject()
        {
            generateBookMark();
            DialogInvestProject dialog = new DialogInvestProject();
            try
            {
                if (dataGridInvestProject.CurrentRow.DataBoundItem != null && dataGridInvestProject.CurrentRow.DataBoundItem.GetType() == typeof(InvestProject))
                {
                    InvestProject ip = (InvestProject)dataGridInvestProject.CurrentRow.DataBoundItem;
                    dialog.setProject(ip);
                }
            }
            catch (Exception error)
            {
                //TODO;
                //throw new Exception();
            }
            dialog.ShowDialog();
            initializationInvestProject();
        }

        private void menuStageProject_Opening(object sender, CancelEventArgs e)
        {
            TreeModel model = (TreeModel)treeViewAdv1.Model;
            int index = -1;
            try {
                if (treeViewAdv1.SelectedNode != null & treeViewAdv1.SelectedNode.Parent.Index >= 0)
                {
                    index = treeViewAdv1.SelectedNode.Parent.Index;
                    mnuAddSubStage.Enabled = false;
                }
                else
                {
                    index = treeViewAdv1.SelectedNode.Index;
                    mnuAddSubStage.Enabled = true;
                }
                if (model != null)
                {
                    mnuDeleteStage.Enabled = true;
                    mnuEditStage.Enabled = true;
                    if (treeViewAdv1.SelectedNode != null)
                    {
                        StageProject stage = ((StageProjectNode)model.Nodes[index]).stage;
                    }
                }
                else
                {
                    mnuDeleteStage.Enabled = false;
                    mnuAddSubStage.Enabled = false;
                    mnuEditStage.Enabled = false;
                }
            }
            catch(Exception error)
            {
                //TODO
                mnuDeleteStage.Enabled = false;
                mnuAddSubStage.Enabled = false;
                mnuEditStage.Enabled = false;
            }
        }

        private void mnuAddStage_Click(object sender, EventArgs e)
        {
            showDialogStage();
        }

        public void showDialogStage()
        {
            generateBookMark();
            DialogStageProject dialog = new DialogStageProject();
            if (dataGridInvestProject.CurrentRow.DataBoundItem != null && dataGridInvestProject.CurrentRow.DataBoundItem.GetType() == typeof(InvestProject))
            {
                InvestProject ip = (InvestProject)dataGridInvestProject.CurrentRow.DataBoundItem;
                dialog.idProject = ip.idProject;
            }
            dialog.ShowDialog();
            initializationInvestProject();
            updateStageProject();
            

        }

        private void mnuEditStage_Click(object sender, EventArgs e)
        {
            generateBookMark();
            DialogStageProject dialog = new DialogStageProject();
            TreeModel model = (TreeModel)treeViewAdv1.Model;
            if (model != null && treeViewAdv1.SelectedNode != null)
            {
                StageProject stage;
                if (treeViewAdv1.SelectedNode.Parent.Index >= 0)
                {
                    stage = ((StageProjectNode)model.Nodes[treeViewAdv1.SelectedNode.Parent.Index].Nodes[treeViewAdv1.SelectedNode.Index]).stage;
                }
                else
                {
                    stage = ((StageProjectNode)model.Nodes[treeViewAdv1.SelectedNode.Index]).stage;
                }
                dialog.setStageProject(stage);
                if (dataGridInvestProject.CurrentRow.DataBoundItem != null && dataGridInvestProject.CurrentRow.DataBoundItem.GetType() == typeof(InvestProject))
                {
                    InvestProject ip = (InvestProject)dataGridInvestProject.CurrentRow.DataBoundItem;
                    dialog.idProject = ip.idProject;
                }

                dialog.ShowDialog();
                initializationInvestProject();
                updateStageProject();
                

            }
        }

        private void mnuAddSubStage_Click(object sender, EventArgs e)
        {
            generateBookMark();
            DialogStageProject dialog = new DialogStageProject();
            TreeModel model = (TreeModel)treeViewAdv1.Model;
            if (model != null)
            {
                StageProject stage = ((StageProjectNode)model.Nodes[treeViewAdv1.SelectedNode.Index]).stage;
                dialog.setStageProject(stage, AdvanceUtil.paramStagInsert.SUB);
                dialog.idProject = stage.IdProject;
            }
            dialog.ShowDialog();
            initializationInvestProject();
            updateStageProject();
        }

        private void generateBookMark()
        {
            BookMarkInvestProject = dataGridInvestProject.CurrentRow.Index;
            ScrollIndex = dataGridInvestProject.FirstDisplayedScrollingRowIndex;
        }

        private void treeViewAdv1_Click(object sender, EventArgs e)
        {

        }

        private void treeViewAdv1_RowDraw(object sender, TreeViewRowDrawEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void menuMyTask_Click(object sender, EventArgs e)
        {
            UserStageForm form = new UserStageForm();
            form.ShowDialog();
            initializationInvestProject();
        }

        private void mnuDeleteStage_Click(object sender, EventArgs e)
        {
            StageProject stage;
            stage = getCurrentStage();
            if (stage != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить проект и все связанные с ним данные ?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    StageProjectDAO dao = new StageProjectDAO();
                    dao.delete(stage);
                    updateStageProject();
                }
            }
        }

        private StageProject getCurrentStage()
        {
            StageProject stage = null;
            TreeModel model = (TreeModel)treeViewAdv1.Model;
            if (model != null && treeViewAdv1.SelectedNode != null)
            {
                if (treeViewAdv1.SelectedNode.Parent.Index >= 0)
                {
                    stage = ((StageProjectNode)model.Nodes[treeViewAdv1.SelectedNode.Parent.Index].Nodes[treeViewAdv1.SelectedNode.Index]).stage;
                }
                else
                {
                    stage = ((StageProjectNode)model.Nodes[treeViewAdv1.SelectedNode.Index]).stage;
                }
            }
            return stage;
        }

        private InvestProject getCurrentProject()
        {
            InvestProject ip = null;
            if (dataGridInvestProject.CurrentRow.DataBoundItem != null && dataGridInvestProject.CurrentRow.DataBoundItem.GetType() == typeof(InvestProject))
            {
                ip = (InvestProject)dataGridInvestProject.CurrentRow.DataBoundItem;
            }
            return ip;
        }

        private void treeViewAdv1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    mnuDeleteStage.PerformClick();
                    break;
            }

        }

        private void menuInvestProject_Opening(object sender, CancelEventArgs e)
        {

        }

        private void mnuInvestPrint_Click(object sender, EventArgs e)
        {
            InvestProject project = getCurrentProject();
            ReportGenerate.
            PrintExcelProject(project);
        }

        

        private void dataGridInvestProject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mnuUser_Click(object sender, EventArgs e)
        {
            DirectoryUserForm userDirectory = new DirectoryUserForm();
            userDirectory.Show();
        }

        private void mnuResposibleUsers_Click(object sender, EventArgs e)
        {
            ResposibleUsers usersForm = new ResposibleUsers();
            usersForm.ShowDialog();
        }



        private void mnuDateMonitoring_Click(object sender, EventArgs e)
        {
            MonitoringStage form = new MonitoringStage();
            form.ShowDialog();
        }

        private void mnuDepartment_Click(object sender, EventArgs e)
        {
            DirectoryDepartment form = new DirectoryDepartment();
            form.ShowDialog();
        }

        private void mnuPrintAll_Click(object sender, EventArgs e)
        {
            ReportGenerate.PrintExcelProjects();
        }

        private void dataGridInvestProject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
            {
                SearchGrid form = new SearchGrid(dataGridInvestProject);
                form.ShowDialog();
            }

        }

        private List<StageProject> getCurrentStageList()
        {
            List<StageProject> stageList = new List<StageProject>();
            TreeModel model = (TreeModel)treeViewAdv1.Model;
            if (model != null && treeViewAdv1.SelectedNode != null)
            {
                if (treeViewAdv1.SelectedNode.Parent.Index >= 0)
                {
                    foreach (StageProjectNode node in model.Nodes[treeViewAdv1.SelectedNode.Parent.Index].Nodes)
                    {
                        stageList.Add(node.stage);
                    }
                    //stage = ((StageProjectNode)model.Nodes[treeViewAdv1.SelectedNode.Parent.Index].Nodes[treeViewAdv1.SelectedNode.Index]).stage;
                }
                else
                {
                    foreach (StageProjectNode node in model.Nodes)
                    {
                        stageList.Add(node.stage);
                    }
                    //stage = ((StageProjectNode)model.Nodes[treeViewAdv1.SelectedNode.Index]).stage;
                }
            }
            return stageList;
        }

        private void mnuChangeIndex_Click(object sender, EventArgs e)
        {
            generateBookMark();
            ChangeInnerIndexStage form = new ChangeInnerIndexStage(getCurrentStageList());
            form.ShowDialog();
            initializationInvestProject();
        }

        private void mnuLog_Click(object sender, EventArgs e)
        {
            LogForm form = new LogForm();
            form.ShowDialog();
        }

        private void DialogGridForm_Load(object sender, EventArgs e)
        {

        }
    }
}

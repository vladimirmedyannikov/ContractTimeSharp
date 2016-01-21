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

namespace ContractTimeSharp
{
    public partial class DialogGridForm : Form
    {
        public DialogGridForm()
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

            initializationInvestProject();
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
            bindingSource.MoveFirst();
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
                List<StageProject> listSubStage = dao.getSubStageProject(ip.idProject);
                TreeModel model = new TreeModel();
                treeViewAdv1.Model = model;
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
            DialogStageProject dialog = new DialogStageProject();
            if (dataGridInvestProject.CurrentRow.DataBoundItem != null && dataGridInvestProject.CurrentRow.DataBoundItem.GetType() == typeof(InvestProject))
            {
                InvestProject ip = (InvestProject)dataGridInvestProject.CurrentRow.DataBoundItem;
                dialog.idProject = ip.idProject;
            }
            dialog.ShowDialog();
            updateStageProject();
        }

        private void mnuEditStage_Click(object sender, EventArgs e)
        {
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
                updateStageProject();
            }
        }

        private void mnuAddSubStage_Click(object sender, EventArgs e)
        {
            DialogStageProject dialog = new DialogStageProject();
            TreeModel model = (TreeModel)treeViewAdv1.Model;
            if (model != null)
            {
                StageProject stage = ((StageProjectNode)model.Nodes[treeViewAdv1.SelectedNode.Index]).stage;
                dialog.setStageProject(stage, AdvanceUtil.paramStagInsert.SUB);
                dialog.idProject = stage.IdProject;
            }
            dialog.ShowDialog();
            updateStageProject();
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
            Excel.Application xlApp = new Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Не удалось создать Excel документ");
                return;
            }
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.Item[1];

            xlWorkSheet.Cells[4, 2] = "# СОВА";
            xlWorkSheet.Cells[4, 3] = "Производство";
            xlWorkSheet.Cells[4, 4] = "Мероприятие";
            xlWorkSheet.Cells[4, 5] = "Этап";
            xlWorkSheet.Cells[4, 6] = "Ответственный";
            xlWorkSheet.Cells[4, 7] = "Начало(план)";
            xlWorkSheet.Cells[4, 8] = "Окончание(план)";
            xlWorkSheet.Cells[4, 9] = "Начало(план/факт)";
            xlWorkSheet.Cells[4, 10] = "Окончание(план/факт)";
            xlWorkSheet.Cells[4, 11] = "Статус";
            xlWorkSheet.Cells[4, 12] = "Начало(прогноз)";
            xlWorkSheet.Cells[4, 13] = "Окончание(прогноз)";
            xlWorkSheet.Cells[4, 14] = "Комментарий";
            xlWorkSheet.Range[xlWorkSheet.Cells[4, 2], xlWorkSheet.Cells[4, 14]].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            xlWorkSheet.Range[xlWorkSheet.Cells[4, 2], xlWorkSheet.Cells[4, 14]].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);

            InvestProject project = getCurrentProject();

            int index = 5;
            foreach(StageProject s in project.getProjectList())
            {
                xlWorkSheet.Cells[index, 2] = project.numberProject;
                xlWorkSheet.Cells[index, 3] = project.department.nameDepartment;
                xlWorkSheet.Cells[index, 4] = project.nameProject;
                xlWorkSheet.Cells[index, 5] = s.NameStage;
                xlWorkSheet.Cells[index, 6] = s.User.FullName;
                xlWorkSheet.Cells[index, 7] = s.DateBeginPlan;
                xlWorkSheet.Cells[index, 8] = s.DateEndPlan;
                xlWorkSheet.Cells[index, 9] = s.DateBeginUser;
                xlWorkSheet.Cells[index, 10] = s.DateEndUser;
                xlWorkSheet.Cells[index, 11] = s.StatusStage.ToString();
                xlWorkSheet.Cells[index, 12] = s.DateBeginProg;
                xlWorkSheet.Cells[index, 13] = s.DateEndProg;
                xlWorkSheet.Cells[index, 14] = s.CommentUser;
                if (s.SubStage != null && s.SubStage.Count > 0) 
                {
                    xlWorkSheet.Range[xlWorkSheet.Cells[index, 2], xlWorkSheet.Cells[index, 14]].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                    
                    foreach (StageProject sub in s.SubStage)
                    {
                        index++;
                        xlWorkSheet.Cells[index, 2] = project.numberProject;
                        xlWorkSheet.Cells[index, 3] = project.department.nameDepartment;
                        xlWorkSheet.Cells[index, 4] = project.nameProject;
                        xlWorkSheet.Cells[index, 5] = sub.NameStage;
                        xlWorkSheet.Cells[index, 6] = sub.User.FullName;
                        xlWorkSheet.Cells[index, 7] = sub.DateBeginPlan;
                        xlWorkSheet.Cells[index, 8] = sub.DateEndPlan;
                        xlWorkSheet.Cells[index, 9] = sub.DateBeginUser;
                        xlWorkSheet.Cells[index, 10] = sub.DateEndUser;
                        xlWorkSheet.Cells[index, 11] = sub.StatusStage.ToString();
                        xlWorkSheet.Cells[index, 12] = sub.DateBeginProg;
                        xlWorkSheet.Cells[index, 13] = sub.DateEndProg;
                        xlWorkSheet.Cells[index, 14] = sub.CommentUser;
                        Excel.Range range =  xlWorkSheet.Rows[index] as Excel.Range;
                        range.OutlineLevel = 1;
                        range.Group(System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);

                    }
                    
                    //Excel.Range range = xlWorkSheet.Range[xlWorkSheet.Cells[index - s.SubStage.Count-1, 2], xlWorkSheet.Cells[index- s.SubStage.Count-1, 14]];
                    //Excel.Range range = xlWorkSheet.Rows["1:10", null] as Excel.Range;

                    //range.Group(0,0,0,0);
                }
                index++;

            }

            xlApp.Visible = true;

            //xlWorkBook.SaveAs("d:\\csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

    }
}

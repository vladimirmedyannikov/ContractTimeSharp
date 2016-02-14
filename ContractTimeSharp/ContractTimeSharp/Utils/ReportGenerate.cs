using ContractTime.Model;
using ContractTimeSharp.DAO;
using ContractTimeSharp.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace ContractTimeSharp.Utils
{
    public static class ReportGenerate
    {

        public static void PrintExcelProjects()
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
            xlWorkSheet.Cells[4, 9] = "Начало(прогноз/факт)";
            xlWorkSheet.Cells[4, 10] = "Окончание(прогноз/факт)";
            xlWorkSheet.Cells[4, 11] = "Статус";
            xlWorkSheet.Cells[4, 12] = "Начало(прогноз)";
            xlWorkSheet.Cells[4, 13] = "Окончание(прогноз)";
            xlWorkSheet.Cells[4, 14] = "Комментарий";

            ((Excel.Range)(xlWorkSheet.Columns[2])).EntireColumn.ColumnWidth = 10;
            ((Excel.Range)(xlWorkSheet.Columns[3])).EntireColumn.ColumnWidth = 20;
            ((Excel.Range)(xlWorkSheet.Columns[4])).EntireColumn.ColumnWidth = 26;
            ((Excel.Range)(xlWorkSheet.Columns[5])).EntireColumn.ColumnWidth = 22;
            ((Excel.Range)(xlWorkSheet.Columns[6])).EntireColumn.ColumnWidth = 16;
            ((Excel.Range)(xlWorkSheet.Columns[7])).EntireColumn.ColumnWidth = 11.5D;
            ((Excel.Range)(xlWorkSheet.Columns[8])).EntireColumn.ColumnWidth = 14.5;
            ((Excel.Range)(xlWorkSheet.Columns[9])).EntireColumn.ColumnWidth = 11.5;
            ((Excel.Range)(xlWorkSheet.Columns[10])).EntireColumn.ColumnWidth = 14.5;
            ((Excel.Range)(xlWorkSheet.Columns[11])).EntireColumn.ColumnWidth = 12.5;
            ((Excel.Range)(xlWorkSheet.Columns[12])).EntireColumn.ColumnWidth = 14;
            ((Excel.Range)(xlWorkSheet.Columns[13])).EntireColumn.ColumnWidth = 14;
            ((Excel.Range)(xlWorkSheet.Columns[14])).EntireColumn.ColumnWidth = 20;

            xlWorkSheet.Range[xlWorkSheet.Cells[4, 2], xlWorkSheet.Cells[4, 14]].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            xlWorkSheet.Range[xlWorkSheet.Cells[4, 2], xlWorkSheet.Cells[4, 14]].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
            xlWorkSheet.Range[xlWorkSheet.Cells[4, 2], xlWorkSheet.Cells[4, 14]].Font.Bold = true;


            int index = 5;
            InvestProjectDAO dao = new InvestProjectDAO();
            List<InvestProject> list =  dao.getAll();
            foreach (Object objectProject in list){
                InvestProject project = null;
                if (objectProject.GetType() == typeof(InvestProject))
                {
                    project = (InvestProject)objectProject;
                }
                else
                {
                    continue;
                }

                xlWorkSheet.Cells[index, 2] = project.numberProject;
                xlWorkSheet.Cells[index, 3] = project.department.nameDepartment;
                xlWorkSheet.Cells[index, 4] = project.nameProject;
                xlWorkSheet.Cells[index, 12] = project.dateBeginProg;
                xlWorkSheet.Cells[index, 13] = project.dateEndProg;
                xlWorkSheet.Cells[index, 7] = project.dateBegin;
                xlWorkSheet.Cells[index, 8] = project.dateEnd;
                xlWorkSheet.Range[xlWorkSheet.Cells[index, 2], xlWorkSheet.Cells[index, 14]].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
                index++;
                foreach (StageProject s in project.getProjectList())
                {
                    xlWorkSheet.Cells[index, 2] = project.numberProject;
                    xlWorkSheet.Cells[index, 3] = project.department.nameDepartment;
                    xlWorkSheet.Cells[index, 4] = project.nameProject;
                    xlWorkSheet.Cells[index, 5] = s.NameStage;
                    xlWorkSheet.Cells[index, 6] = s.User.FullName;
                    xlWorkSheet.Cells[index, 7] = s.DateBeginPlan;
                    xlWorkSheet.Cells[index, 8] = s.DateEndPlan;
                    xlWorkSheet.Cells[index, 9] = (s.DateBeginUser.CompareTo(new DateTime(1, 1, 1)) == 0) ? "" : s.DateBeginUser.ToShortDateString();
                    xlWorkSheet.Cells[index, 10] = (s.DateEndUser.CompareTo(new DateTime(1, 1, 1)) == 0) ? "" : s.DateEndUser.ToShortDateString();
                    xlWorkSheet.Cells[index, 11] = s.StatusStageStr;
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
                            xlWorkSheet.Cells[index, 9] = (sub.DateBeginUser.CompareTo(new DateTime(1, 1, 1)) == 0) ? "" : sub.DateBeginUser.ToShortDateString();
                            xlWorkSheet.Cells[index, 10] = (sub.DateEndUser.CompareTo(new DateTime(1, 1, 1)) == 0) ? "" : sub.DateEndUser.ToShortDateString();
                            xlWorkSheet.Cells[index, 11] = sub.StatusStageStr;
                            xlWorkSheet.Cells[index, 12] = sub.DateBeginProg;
                            xlWorkSheet.Cells[index, 13] = sub.DateEndProg;
                            xlWorkSheet.Cells[index, 14] = sub.CommentUser;
                            Excel.Range range = xlWorkSheet.Rows[index] as Excel.Range;
                            range.OutlineLevel = 1;
                            range.Group(System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);

                        }
                        //Excel.Range range = xlWorkSheet.Range[xlWorkSheet.Cells[index - s.SubStage.Count-1, 2], xlWorkSheet.Cells[index- s.SubStage.Count-1, 14]];
                        //Excel.Range range = xlWorkSheet.Rows["1:10", null] as Excel.Range;
                        //range.Group(0,0,0,0);
                    }
                    index++;

                }

                index--;
                xlWorkSheet.Range[xlWorkSheet.Cells[4, 2], xlWorkSheet.Cells[index, 14]].Font.Size = 8;
                xlWorkSheet.Range[xlWorkSheet.Cells[4, 2], xlWorkSheet.Cells[index, 14]].WrapText = true;
                xlWorkSheet.Range[xlWorkSheet.Cells[6, 9], xlWorkSheet.Cells[index, 11]].Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.FromArgb(252, 228, 214));
                xlWorkSheet.Range[xlWorkSheet.Cells[6, 12], xlWorkSheet.Cells[index, 13]].Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.FromArgb(218, 238, 243));
                //xlWorkSheet.Range[xlWorkSheet.Cells[4, 2], xlWorkSheet.Cells[index, 14]].AutoFit();
                index++;

            }
            xlApp.Visible = true;

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        public static void PrintExcelProject(Object objectProject)
        {
            InvestProject project = null;
            if (objectProject.GetType() == typeof(InvestProject))
            {
                project = (InvestProject)objectProject;
            }
            else return;

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
            xlWorkSheet.Cells[4, 9] = "Начало(прогноз/факт)";
            xlWorkSheet.Cells[4, 10] = "Окончание(прогноз/факт)";
            xlWorkSheet.Cells[4, 11] = "Статус";
            xlWorkSheet.Cells[4, 12] = "Начало(прогноз)";
            xlWorkSheet.Cells[4, 13] = "Окончание(прогноз)";
            xlWorkSheet.Cells[4, 14] = "Комментарий";

            ((Excel.Range)(xlWorkSheet.Columns[2])).EntireColumn.ColumnWidth = 10;
            ((Excel.Range)(xlWorkSheet.Columns[3])).EntireColumn.ColumnWidth = 20;
            ((Excel.Range)(xlWorkSheet.Columns[4])).EntireColumn.ColumnWidth = 26;
            ((Excel.Range)(xlWorkSheet.Columns[5])).EntireColumn.ColumnWidth = 22;
            ((Excel.Range)(xlWorkSheet.Columns[6])).EntireColumn.ColumnWidth = 16;
            ((Excel.Range)(xlWorkSheet.Columns[7])).EntireColumn.ColumnWidth = 11.5D;
            ((Excel.Range)(xlWorkSheet.Columns[8])).EntireColumn.ColumnWidth = 14.5;
            ((Excel.Range)(xlWorkSheet.Columns[9])).EntireColumn.ColumnWidth = 11.5;
            ((Excel.Range)(xlWorkSheet.Columns[10])).EntireColumn.ColumnWidth = 14.5;
            ((Excel.Range)(xlWorkSheet.Columns[11])).EntireColumn.ColumnWidth = 12.5;
            ((Excel.Range)(xlWorkSheet.Columns[12])).EntireColumn.ColumnWidth = 14;
            ((Excel.Range)(xlWorkSheet.Columns[13])).EntireColumn.ColumnWidth = 14;
            ((Excel.Range)(xlWorkSheet.Columns[14])).EntireColumn.ColumnWidth = 20;

            xlWorkSheet.Range[xlWorkSheet.Cells[4, 2], xlWorkSheet.Cells[4, 14]].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            xlWorkSheet.Range[xlWorkSheet.Cells[4, 2], xlWorkSheet.Cells[4, 14]].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
            xlWorkSheet.Range[xlWorkSheet.Cells[4, 2], xlWorkSheet.Cells[4, 14]].Font.Bold = true;


            int index = 5;
            xlWorkSheet.Cells[index, 2] = project.numberProject;
            xlWorkSheet.Cells[index, 3] = project.department.nameDepartment;
            xlWorkSheet.Cells[index, 4] = project.nameProject;
            xlWorkSheet.Cells[index, 12] = project.dateBeginProg;
            xlWorkSheet.Cells[index, 13] = project.dateEndProg;
            xlWorkSheet.Cells[index, 7] = project.dateBegin;
            xlWorkSheet.Cells[index, 8] = project.dateEnd;
            
            index++;
            foreach (StageProject s in project.getProjectList())
            {
                xlWorkSheet.Cells[index, 2] = project.numberProject;
                xlWorkSheet.Cells[index, 3] = project.department.nameDepartment;
                xlWorkSheet.Cells[index, 4] = project.nameProject;
                xlWorkSheet.Cells[index, 5] = s.NameStage;
                xlWorkSheet.Cells[index, 6] = s.User.FullName;
                xlWorkSheet.Cells[index, 7] = s.DateBeginPlan;
                xlWorkSheet.Cells[index, 8] = s.DateEndPlan;
                xlWorkSheet.Cells[index, 9] = (s.DateBeginUser.CompareTo(new DateTime(1, 1, 1)) == 0) ? "" : s.DateBeginUser.ToShortDateString();
                xlWorkSheet.Cells[index, 10] = (s.DateEndUser.CompareTo(new DateTime(1, 1, 1)) == 0) ? "" : s.DateEndUser.ToShortDateString();
                xlWorkSheet.Cells[index, 11] = s.StatusStageStr;
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
                        xlWorkSheet.Cells[index, 9] = (sub.DateBeginUser.CompareTo(new DateTime(1, 1, 1)) == 0) ? "" : sub.DateBeginUser.ToShortDateString();
                        xlWorkSheet.Cells[index, 10] = (sub.DateEndUser.CompareTo(new DateTime(1,1,1)) == 0) ? "" : sub.DateEndUser.ToShortDateString();
                        xlWorkSheet.Cells[index, 11] = sub.StatusStageStr;
                        xlWorkSheet.Cells[index, 12] = sub.DateBeginProg;
                        xlWorkSheet.Cells[index, 13] = sub.DateEndProg;
                        xlWorkSheet.Cells[index, 14] = sub.CommentUser;
                        Excel.Range range = xlWorkSheet.Rows[index] as Excel.Range;
                        range.OutlineLevel = 1;
                        range.Group(System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);

                    }
                    //Excel.Range range = xlWorkSheet.Range[xlWorkSheet.Cells[index - s.SubStage.Count-1, 2], xlWorkSheet.Cells[index- s.SubStage.Count-1, 14]];
                    //Excel.Range range = xlWorkSheet.Rows["1:10", null] as Excel.Range;
                    //range.Group(0,0,0,0);
                }
                index++;

            }

            index--;
            xlWorkSheet.Range[xlWorkSheet.Cells[4, 2], xlWorkSheet.Cells[index, 14]].Font.Size = 8;
            xlWorkSheet.Range[xlWorkSheet.Cells[4, 2], xlWorkSheet.Cells[index, 14]].WrapText = true;
            xlWorkSheet.Range[xlWorkSheet.Cells[6, 9], xlWorkSheet.Cells[index, 11]].Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.FromArgb(252, 228, 214));
            xlWorkSheet.Range[xlWorkSheet.Cells[6, 12], xlWorkSheet.Cells[index, 13]].Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.FromArgb(218, 238, 243));
            //xlWorkSheet.Range[xlWorkSheet.Cells[4, 2], xlWorkSheet.Cells[index, 14]].AutoFit();

            xlApp.Visible = true;

            //xlWorkBook.SaveAs("d:\\csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlWorkBook.Close(true, misValue, misValue);
            //xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        private static void releaseObject(object obj)
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;

namespace ProductionSchedule
{
    public partial class frmExportSchedule : Form
    {
        public frmExportSchedule()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);


            try
            {

                DateTime dtStartDate = dtExportSchedStartDate.Value;
                System.TimeSpan tsWeek = new TimeSpan(6, 23, 59, 59);
                DateTime dtEndDate = dtStartDate.Add(tsWeek);

                DAL.DAL db = new DAL.DAL();
                System.Data.DataTable dtWeeksData = new System.Data.DataTable();
                dtWeeksData = db.GetWeeklyJobsForExport(dtStartDate.ToString("MMMM dd, yyyy HH:mm:ss"), dtEndDate.ToString("MMMM dd, yyyy HH:mm:ss"));

                do //If there is no data for a full wee then end of schedule
                {
                    AddWorksheetToExcel(ref workbook, dtWeeksData, dtStartDate);

                    dtStartDate = dtStartDate.Add(new TimeSpan(7, 0, 0, 0));
                    dtEndDate = dtStartDate.Add(tsWeek);
                    dtWeeksData = db.GetWeeklyJobsForExport(dtStartDate.ToString("MMMM dd, yyyy HH:mm:ss"), dtEndDate.ToString("MMMM dd, yyyy HH:mm:ss"));
                }
                while (dtWeeksData.Rows.Count > 0);



                excel.DisplayAlerts = false;
                workbook.Sheets["Sheet1"].Delete();
                excel.DisplayAlerts = true;
                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }

        }

        private void AddWorksheetToExcel(ref Microsoft.Office.Interop.Excel._Workbook workbook, System.Data.DataTable dtWeeksData, DateTime dtStartDate)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Worksheet currentWS = workbook.ActiveSheet;
                Microsoft.Office.Interop.Excel._Worksheet worksheet;
                worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.Worksheets.Add(After: workbook.Sheets[workbook.Sheets.Count]);

                worksheet.Name = dtStartDate.Date.ToShortDateString().Replace("/", "-").Replace("\\", "-");

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                for (int i = 0; i < dtWeeksData.Rows.Count; i++)
                {
                    for (int j = 0; j < dtWeeksData.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dtWeeksData.Columns[j].ColumnName;
                            worksheet.Cells[cellRowIndex, cellColumnIndex].
                            worksheet.Cells[cellRowIndex + 1, cellColumnIndex] = dtWeeksData.Rows[i][j].ToString();
                        }
                        else
                        {
                            try
                            {
                                worksheet.Cells[cellRowIndex + 1, cellColumnIndex] = dtWeeksData.Rows[i][j].ToString();
                            }
                            catch
                            {
                                worksheet.Cells[cellRowIndex + 1, cellColumnIndex] = "";
                            }
                        }
                        cellColumnIndex++;
                    }
                    //Range line = (Range)worksheet.Rows[cellRowIndex+1];
                    //line.Insert();
                    worksheet.Rows.Insert(cellRowIndex + 1, 1);
                    if (cellRowIndex == 1)
                    {
                        Microsoft.Office.Interop.Excel.Range rng = worksheet.Cells[1, 1] as Range;
                        rng.EntireRow.Font.Bold = true;
                        rng.EntireRow.Interior.Color = Color.Yellow;

                    }
                    //worksheet.InsertRow(3);
                    cellColumnIndex = 1;
                    cellRowIndex++;

                }
                worksheet.Columns.AutoFit();
                worksheet.Rows.AutoFit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AddWorksheetToExcel: " + ex.Message);
            }

        }
    }
}

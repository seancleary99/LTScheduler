using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Classes;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;
using System.Configuration;
using System.Data;

namespace ProductionSchedule
{
    public partial class frmJobs : Form
    {
        private Job selectedJob;
        private JobPlot selectedJobPlot;
        private BindingSource jobBindingSource1 = new BindingSource();
        private BindingSource jobPlotSource = new BindingSource();
         
        public string SelectedJobId { get { return selectedJob.JobId.ToString(); } }
        public int SelectedPlotId { get { return GetSelectedPlotID(); } }

        public frmJobs()
        {
            InitializeComponent();
        }

        private void frmJobs_Load(object sender, EventArgs e)
        {
            PopulateDropDowns();
            PopulateExportStartDate();

            RefreshJobs();
            
        }

        private void PopulateExportStartDate()
        {
            DateTime currentDT = DateTime.Now;
            TimeSpan ts = new TimeSpan(09, 00, 0);
            currentDT = currentDT.Date + ts;
            dtExportSchedStartDate.Value = GetMondayOfWeek(currentDT);

        }

        private void RefreshJobs()
        {
            dgJobs.DataSource = jobBindingSource1;

            jobBindingSource1.DataSource = GetAllJobs();

            //dgJobPlots.DataSource = jobPlotSource;
            //jobPlotSource.DataSource = GetAllJobPlots();
            PopulateJobPlots();

        }

        public void PopulateJobPlots() {
            dgJobPlots.DataSource = jobPlotSource;
            jobPlotSource.DataSource = GetAllJobPlots();

            if (selectedJob != null)
            {
                RefreshJobPlotDetails();
            }
        }

        private List<Job> GetAllJobs()        
        {
            DAL.DAL db = new DAL.DAL();
            List<Job> lstJobs = db.GetAllJobs();
            return lstJobs;
        }

        private List<JobPlot> GetAllJobPlots()
        {
            List<JobPlot> lstJobPlots = new List<JobPlot>();
            if (selectedJob != null)
            {
                DAL.DAL db = new DAL.DAL();
                lstJobPlots = db.GetAllJobPlotsForJob(selectedJob.JobId);
            }
            return lstJobPlots;

        }
    
        private void PopulateDropDowns()
        {
            DAL.DAL db = new DAL.DAL();
            List<Contractor> lstContractors = db.GetAllContractors();
            cbContractor.SelectedIndex = -1;
            cbContractor.DataSource = lstContractors;
            cbContractor.DisplayMember = "ContractorName";
            cbContractor.ValueMember = "ID";
        }

        private void LoadJob(int jobId)
        {
            selectedJob = new Job(jobId);
            lblJobIdVal.Text = selectedJob.JobId.ToString();
            tbLine.Text = selectedJob.Line;
            cbContractor.SelectedValue = selectedJob.ContractorID;
            tbJobName.Text = selectedJob.JobName;
            tbSiteName.Text = selectedJob.SiteName;
            tbSiteContact.Text = selectedJob.SiteContact;
            chkSiteComplete.Checked = bool.Parse(selectedJob.SiteComplete);
            tbProductionTime.Text = GetProductionTimeForJob(jobId);

        }

        private string GetProductionTimeForJob(int jobId)
        {
            float prodTime = new float();
            List<JobPlot> jPlots = GetAllJobPlots();

            foreach (JobPlot jp in jPlots)
            {

                Plot p = new Plot(jp.PlotId);
                prodTime = prodTime + p.PlotBenchTotal + p.PlotLineTotal;
            }

            return prodTime.ToString();
        }


        private void btnAddNewJob_Click(object sender, EventArgs e)
        {
            ClearJobForm();
        }

        private void ClearJobForm()
        {
            lblJobIdVal.Text = "";
            tbLine.Text = "";
            cbContractor.SelectedIndex = -1;
            cbContractor.Text = "Select Contractor";
            tbJobName.Text = "";
            tbSiteName.Text = "";
            tbSiteContact.Text = "";
            chkSiteComplete.Checked = false;
            selectedJob = null;
        }

        private void btnSaveJob_Click(object sender, EventArgs e)
        {
            int currJobID = 0;
            int.TryParse(lblJobIdVal.Text, out currJobID);
            selectedJob = new Job(currJobID, tbJobName.Text, tbLine.Text, (int)cbContractor.SelectedValue, tbSiteName.Text, tbSiteContact.Text, chkSiteComplete.Checked, dtProductionDate.Value, dtProdCompleteDate.Value, dtOnSite.Value, dtCompletionDate.Value, null);
            if (selectedJob.Save())
            {
                jobBindingSource1.DataSource = GetAllJobs();
                dgJobs.Refresh();
            }
       
        }

        private void dgJobs_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgJobs.Rows[e.RowIndex].Cells[0].Value.ToString());
            selectedJob = new Job(id);

            lblJobIdVal.Text = id.ToString();
            tbLine.Text = selectedJob.Line;
            tbJobName.Text = selectedJob.JobName;
            tbSiteContact.Text = selectedJob.SiteContact;
            tbSiteName.Text = selectedJob.SiteName;
            dtCompletionDate.Value = selectedJob.CompletionDate;
            dtProductionDate.Value = selectedJob.ProductionDate;
            DateTime tempDT;
            DateTime.TryParse(selectedJob.ProductionCompleteDate.ToString(), out tempDT);
            if (tempDT > (new DateTime(1,1,1)))
            {
                dtProdCompleteDate.Value = tempDT;
            }
            else
            {
                dtProdCompleteDate.Value = dtProdCompleteDate.MinDate;
            }
            dtOnSite.Value = selectedJob.OnSiteDate;
            chkSiteComplete.Checked = bool.Parse(selectedJob.SiteComplete);
            cbContractor.SelectedValue = selectedJob.ContractorID;
            tbProductionTime.Text = GetProductionTimeForJob(id);

            jobPlotSource.DataSource = GetAllJobPlots();


        }

        private void RefreshJobPlotDetails()
        {
            //int id = Convert.ToInt32(dgJobs.Rows[e.RowIndex].Cells[0].Value.ToString());
            //int id = Convert.ToInt32(dgJobs.SelectedRows[0].Cells[0].Value.ToString());
           // selectedJob = new Job(id);

            lblJobIdVal.Text = selectedJob.JobId.ToString();
            tbLine.Text = selectedJob.Line;
            tbJobName.Text = selectedJob.JobName;
            tbSiteContact.Text = selectedJob.SiteContact;
            tbSiteName.Text = selectedJob.SiteName;
            dtCompletionDate.Value = selectedJob.CompletionDate;
            dtProductionDate.Value = selectedJob.ProductionDate;
            DateTime tempDT;
            DateTime.TryParse(selectedJob.ProductionCompleteDate.ToString(), out tempDT);
            if (tempDT > (new DateTime(1, 1, 1)))
            {
                dtProdCompleteDate.Value = tempDT;
            }
            else
            {
                dtProdCompleteDate.Value = dtProdCompleteDate.MinDate;
            }
            dtOnSite.Value = selectedJob.OnSiteDate;
            chkSiteComplete.Checked = bool.Parse(selectedJob.SiteComplete);
            cbContractor.SelectedValue = selectedJob.ContractorID;
            tbProductionTime.Text = GetProductionTimeForJob(selectedJob.JobId);

           

        }

        private void btnAddPlot_Click(object sender, EventArgs e)
        {
            if (lblJobIdVal.Text == "")
            {
                MessageBox.Show("You must select a Job before adding Plots!", "Warning!", MessageBoxButtons.OK);
            }
            else {
                frmAddJobPlot addPlotForm = new frmAddJobPlot(this);
                addPlotForm.ShowDialog();
            }
        }

        private void chkSiteComplete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSiteComplete.Checked)
            {
                dtCompletionDate.Visible = true;
                dtCompletionDate.Enabled = true;
                dtCompletionDate.Value = System.DateTime.Today;
            }
            else
            {
                dtCompletionDate.Visible = false;
                dtCompletionDate.Enabled = false;
            }

        }

        private void AddWorksheetToExcel(ref Microsoft.Office.Interop.Excel._Workbook workbook, System.Data.DataTable dtWeeksData, DateTime dtStartDate)
        {
            try {
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
            catch (Exception ex){
                MessageBox.Show("AddWorksheetToExcel: " + ex.Message);
            }

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

        private DateTime GetMondayOfWeek(DateTime dateToParse)
        {

            int delta = DayOfWeek.Monday - dateToParse.DayOfWeek;
            if (delta > 0)
                delta -= 7;
            DateTime monday = dateToParse.AddDays(delta);
            return monday;
        }

        private void btnRecalc_Click(object sender, EventArgs e)
        {
            int totWeekHours = int.Parse(ConfigurationManager.AppSettings["WorkingHours"].ToString());
            DAL.DAL db = new DAL.DAL();
            DateTime? fromDate = null;

            if (selectedJob != null)
            {
                DialogResult result = MessageBox.Show("Do you want to recalculate the schedule from the beginning of the week for the selected job? If you click no, the schedule will be recalculated from the beginning of this week.", "Information", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:
                        fromDate = (DateTime?)GetMondayOfWeek(selectedJob.ProductionDate);
                        break;
                    case DialogResult.No:
                        //MessageBox.Show("Schedule will be recaulculated from the beginning of this week.")
                        break;
                    case DialogResult.Cancel:
                        MessageBox.Show("The schedule has not been updated");
                        return;
                }

            }

            if (db.RecalculateSchedule(totWeekHours, fromDate))
            {
                RefreshJobs();
                MessageBox.Show("Schedule Updated", "Update Complete", MessageBoxButtons.OK);
                RefreshJobs();                
            }
            else
            {
                MessageBox.Show("Schedule Not Updated", "Error", MessageBoxButtons.OK);
            }

        }

        private void btnEditPlot_Click(object sender, EventArgs e)
        {
            if (dgJobPlots.SelectedRows.Count == 0)
            {
                MessageBox.Show("You must select a Plot before editing!", "Warning!", MessageBoxButtons.OK);
            }
            else {
                GetSelectedPlotID();
                frmPlot editPlotForm = new frmPlot(this);
                editPlotForm.Top = 50;
                editPlotForm.WindowState = FormWindowState.Normal;
                editPlotForm.Width = this.Width - 100;
                editPlotForm.ShowDialog();
            }
        }

        private int GetSelectedPlotID()
        {
            int plotId = dgJobPlots.SelectedRows[0].Index;//.DataGridView.Columns["PlotId"].;
            DataGridViewRow dgr = dgJobPlots.Rows[plotId];
            return ((JobPlot)dgr.DataBoundItem).PlotId;
           // ((DAL.Classes.JobPlot)dgr.DataBoundItem).PlotId 8   int

        }

        private void btnRemovePlot_Click(object sender, EventArgs e)
        {
            if (dgJobPlots.SelectedRows.Count == 0)
            {
                MessageBox.Show("You must select a Plot to remove!", "Warning!", MessageBoxButtons.OK);
            }
            else {
                
                int plotId = dgJobPlots.SelectedRows[0].Index;//.DataGridView.Columns["PlotId"].;
                DataGridViewRow dgr = dgJobPlots.Rows[plotId];
                int jpId = (((JobPlot)dgr.DataBoundItem)).JobPlotId;
                JobPlot jpToDelete = new JobPlot(jpId);
                if (jpToDelete.Delete())
                {
                    PopulateJobPlots();
                }
            }
        }
    }
}

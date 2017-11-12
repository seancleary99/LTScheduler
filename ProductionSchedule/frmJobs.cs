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

namespace ProductionSchedule
{
    public partial class frmJobs : Form
    {
        private Job selectedJob;
        private JobPlot selectedJobPlot;
        private BindingSource jobBindingSource1 = new BindingSource();
        private BindingSource jobPlotSource = new BindingSource();
         
        public string SelectedJobId { get { return selectedJob.JobId.ToString(); } }
        public frmJobs()
        {
            InitializeComponent();
        }

        private void frmJobs_Load(object sender, EventArgs e)
        {
            PopulateDropDowns();

            dgJobs.DataSource = jobBindingSource1;

            jobBindingSource1.DataSource = GetAllJobs();

            //dgJobPlots.DataSource = jobPlotSource;
            //jobPlotSource.DataSource = GetAllJobPlots();
            PopulateJobPlots();

            //LoadJob(1);
            
        }

        public void PopulateJobPlots() {
            dgJobPlots.DataSource = jobPlotSource;
            jobPlotSource.DataSource = GetAllJobPlots();
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
            chkSiteComplete.Checked = selectedJob.SiteComplete;

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
            selectedJob = new Job(currJobID, tbJobName.Text, tbLine.Text, (int)cbContractor.SelectedValue, tbSiteName.Text, tbSiteContact.Text, chkSiteComplete.Checked, dtProductionDate.Value.Date, dtOnSite.Value.Date, dtCompletionDate.Value.Date, null);
            selectedJob.Save();
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
            dtOnSite.Value = selectedJob.OnSiteDate;
            chkSiteComplete.Checked = selectedJob.SiteComplete;
            cbContractor.SelectedValue = selectedJob.ContractorID;

            jobPlotSource.DataSource = GetAllJobPlots();


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
    }
}

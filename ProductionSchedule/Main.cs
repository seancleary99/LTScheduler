using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionSchedule
{
    public partial class Main : Form
    {
        Form currentForm = null;
        public Main()
        {
            InitializeComponent();
        }

        private void erectorsToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            CloseOpenForms();
            frmErectors erectorForm = new frmErectors();
            erectorForm.Left = 0;
            erectorForm.Top = 0;
            Rectangle recNew = new Rectangle();
            recNew = this.ClientRectangle;
            recNew.Height -= 4;
            recNew.Width -= 4;
            erectorForm.Size = recNew.Size;

            erectorForm.FormBorderStyle = FormBorderStyle.None;
            erectorForm.MdiParent = this;
            
            erectorForm.Show();
            //erectorForm.BringToFront();
        }

        private void houseTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            frmHouseTypes houseTypeForm = new frmHouseTypes();

            houseTypeForm.Left = 0;
            houseTypeForm.Top = 0;
            Rectangle recNew = new Rectangle();
            recNew = this.ClientRectangle;
            recNew.Height -= 4;
            recNew.Width -= 4;
            houseTypeForm.Size = recNew.Size;

            houseTypeForm.FormBorderStyle = FormBorderStyle.None;
            houseTypeForm.MdiParent = this;
            houseTypeForm.Show();
        }

        private void craneHireToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CloseOpenForms();
            frmCranes craneForm = new frmCranes();

            craneForm.Left = 0;
            craneForm.Top = 0;
            Rectangle recNew = new Rectangle();
            recNew = this.ClientRectangle;
            recNew.Height -= 4;
            recNew.Width -= 4;
            craneForm.Size = recNew.Size;

            craneForm.FormBorderStyle = FormBorderStyle.None;
            craneForm.MdiParent = this;
            craneForm.Show();
        }

        private void jobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            frmJobs jobsForm = new frmJobs();
            jobsForm.Left = 0;
            jobsForm.Top = 0;
            Rectangle recNew = new Rectangle();
            recNew = this.ClientRectangle;
            recNew.Height -= 4;
            recNew.Width -= 4;
            jobsForm.Size = recNew.Size;
            jobsForm.FormBorderStyle = FormBorderStyle.None;
            jobsForm.MdiParent = this;
            jobsForm.Show();


        }

        private void CloseOpenForms()
        {
            foreach (Form f in this.MdiChildren) {
                if (f.Name != "Main")
                    f.Close();
            }
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Name != "Main")
            //        f.Close();
            //}
        }

        private void contractorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            frmContractors contForm = new frmContractors();

            contForm.Left = 0;
            contForm.Top = 0;
            Rectangle recNew = new Rectangle();
            recNew = this.ClientRectangle;
            recNew.Height -= 4;
            recNew.Width -= 4;
            contForm.Size = recNew.Size;

            contForm.FormBorderStyle = FormBorderStyle.None;
            contForm.MdiParent = this;
            contForm.Show();
            contForm.Focus();
        }

        private void plotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            frmPlot plotForm = new frmPlot();

            plotForm.Left = 0;
            plotForm.Top = 0;
            Rectangle recNew = new Rectangle();
            recNew = this.ClientRectangle;
            recNew.Height -= 4;
            recNew.Width -= 4;
            plotForm.Size = recNew.Size;


            plotForm.FormBorderStyle = FormBorderStyle.None;
            plotForm.MdiParent = this;
            plotForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.GetJobPlotsReportForDates' table. You can move, or remove it, as needed.
            this.GetJobPlotsReportForDatesTableAdapter.Fill(this.DataSet2.GetJobPlotsReportForDates, dtFrom.Value, dtTo.Value);
            // TODO: This line of code loads data into the 'DataSet2.GetJobPlotsReport' table. You can move, or remove it, as needed.
            this.GetJobPlotsReportTableAdapter.Fill(this.DataSet2.GetJobPlotsReport);
            // TODO: This line of code loads data into the 'DataSet2.Jobs' table. You can move, or remove it, as needed.
            this.JobsTableAdapter.Fill(this.DataSet2.Jobs);

            
            this.reportViewer1.RefreshReport();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            this.GetJobPlotsReportForDatesTableAdapter.Fill(this.DataSet2.GetJobPlotsReportForDates, dtFrom.Value, dtTo.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}

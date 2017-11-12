using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DAL.Classes;
using System.Data;

namespace ProductionSchedule
{
    public partial class frmAddJobPlot : Form
    {
        private frmJobs mainForm = null;
        private BindingSource plotBindingSource1 = new BindingSource();

        public frmAddJobPlot()
        {
            InitializeComponent();
        }

        public frmAddJobPlot(Form callingForm)
        {
            mainForm = callingForm as frmJobs;
            InitializeComponent();
        }

        private void frmAddJobPlot_Load(object sender, EventArgs e)
        {
            lblJobIdValue.Text = mainForm.SelectedJobId;
            PopulatePlots();
        }

        private void PopulatePlots() {
            DAL.DAL db = new DAL.DAL();
            dgUnscheduledPlots.DataSource = plotBindingSource1;

            plotBindingSource1.DataSource = db.GetUnsheduledPlots();


            
        }

        private void btnAddPlots_Click(object sender, EventArgs e)
        {
            if (dgUnscheduledPlots.SelectedRows.Count == 0)
            {
                MessageBox.Show("You have not selected any Plots", "Info", MessageBoxButtons.OK);
            }
            else
            {
                foreach (DataGridViewRow r in dgUnscheduledPlots.SelectedRows)
                {
                    Plot newPlot = new Plot((int)r.Cells[0].Value);
                    JobPlot newJPlot = new JobPlot(0, newPlot.ID, int.Parse(lblJobIdValue.Text), newPlot.PlotType, 0, 0, null, null, null);
                    newJPlot.Save();
                }
                PopulatePlots();
            }
        }

        private void frmAddJobPlot_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.PopulateJobPlots();
        }
    }
}

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

namespace ProductionSchedule
{
    public partial class frmDeadTime : Form
    {
        private frmJobs mainForm = null;
        private JobDeadTime jobDTime;
        public frmDeadTime()
        {
            InitializeComponent();
        }

        public frmDeadTime(Form callingForm)
        {
            mainForm = callingForm as frmJobs;
            InitializeComponent();
        }

        private void frmDeadTime_Load(object sender, EventArgs e)
        {
            lblJobId.Text = mainForm.SelectedJobId;
            jobDTime = new JobDeadTime(int.Parse(lblJobId.Text));
            tbDeadTime.Text = jobDTime.DeadTme.ToString();
            tbDeadNotes.Text = jobDTime.Notes;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveDeadTime_Click(object sender, EventArgs e)
        {
            int currJobID = 0;
            int.TryParse(lblJobId.Text, out currJobID);

            //JobDeadTime jobDTime = new JobDeadTime(currJobID, int.Parse(tbDeadTime.Text), tbDeadNotes.Text);
            jobDTime.DeadTme = int.Parse(tbDeadTime.Text);
            jobDTime.Notes = tbDeadNotes.Text;
            if (jobDTime.Save())
            {
                MessageBox.Show("Dead time Saved", "Saved", MessageBoxButtons.OK);
            }
        }
    }
}

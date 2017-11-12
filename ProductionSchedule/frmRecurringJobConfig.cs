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
    public partial class frmRecurringJobConfig : Form
    {
        private frmJobs mainForm = null;

        public frmRecurringJobConfig()
        {
            InitializeComponent();
        }

        public frmRecurringJobConfig(Form callingForm)
        {
            mainForm = callingForm as frmJobs;
            InitializeComponent();
        }

        private void frmRecurringJobConfig_Load(object sender, EventArgs e)
        {
            lblJobId.Text = mainForm.SelectedJobId;
            dtFirstProdDate.Value = mainForm.FirstProdDate;
        }

        private void rbCustom_CheckedChanged(object sender, EventArgs e)
        {
            tbFreqDays.Enabled = rbCustom.Checked && rbCustom.Enabled;

        }

        private void rbDaily_CheckedChanged(object sender, EventArgs e)
        {
            dtNextProdDate.Value = dtFirstProdDate.Value.AddDays(1);
        }

        private void rbWeekly_CheckedChanged(object sender, EventArgs e)
        {
            dtNextProdDate.Value = dtFirstProdDate.Value.AddDays(7);
        }

        private void rbFortnight_CheckedChanged(object sender, EventArgs e)
        {
            dtNextProdDate.Value = dtFirstProdDate.Value.AddDays(14);
        }

        private void rbMonthly_CheckedChanged(object sender, EventArgs e)
        {
            dtNextProdDate.Value = dtFirstProdDate.Value.AddDays(30);
        }

         private void CalcNextProdDateCustom(object sender, EventArgs e)
        {
            if (tbFreqDays.Text != "")
            {
                double custDays = double.Parse(tbFreqDays.Text);
                dtNextProdDate.Value = dtFirstProdDate.Value.AddDays(custDays);
            }
            else { dtNextProdDate.Value = dtFirstProdDate.Value; }
        }

        private void tbFreqDays_KeyUp(object sender, KeyEventArgs e)
        {
            CalcNextProdDateCustom(sender, e);
        }

        private void btnSaveRecurringSchedule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Schedule Saved", "Saved", MessageBoxButtons.OK);
        }
    }
}

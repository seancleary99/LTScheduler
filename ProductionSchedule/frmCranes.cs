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
    public partial class frmCranes : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private CraneHire selectedCrane;

        public frmCranes()
        {
            InitializeComponent();
        }

        private List<CraneHire> GetCraneHires()
        {
            DAL.DAL db = new DAL.DAL();
            List<CraneHire> lstCraneHires = db.GetAllCraneHire();
            return lstCraneHires;
        }
        private void SaveCraneHire_Click(object sender, EventArgs e)
        {
            if (tbCrane.Text != "")
            {
                if (selectedCrane != null)
                {
                    selectedCrane.CraneName = tbCrane.Text;
                    selectedCrane.Save();
                    bindingSource1.DataSource = GetCraneHires();
                }
                else
                {
                    CraneHire newCraneHire = new CraneHire();
                    newCraneHire.CraneName = tbCrane.Text;
                    if (!newCraneHire.Save())
                    {
                        MessageBox.Show("Error Saving Crane Hire", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                    {
                        bindingSource1.DataSource = GetCraneHires();
                    }
                }
            }
            else
            {
                MessageBox.Show("You must enter an Crane Hire", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void frmCranes_Load(object sender, EventArgs e)
        {
            dgCraneHire.DataSource = bindingSource1;

            bindingSource1.DataSource = GetCraneHires();

        }

        //private void dgCraneHire_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    int id = Convert.ToInt32(dgCraneHire.Rows[e.RowIndex].Cells[0].Value.ToString());
        //    tbCrane.Text = dgCraneHire.Rows[e.RowIndex].Cells[1].Value.ToString();

        //    selectedCrane = new CraneHire(id, tbCrane.Text);
        //}

        private void Delete_Click(object sender, EventArgs e)
        {
            selectedCrane.Delete();
            bindingSource1.DataSource = GetCraneHires();
            selectedCrane = null;
            tbCrane.Text = "";
        }

        private void dgCraneHire_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgCraneHire.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbCrane.Text = dgCraneHire.Rows[e.RowIndex].Cells[1].Value.ToString();

            selectedCrane = new CraneHire(id, tbCrane.Text);
        }
    }
}

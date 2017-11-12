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
    public partial class frmContractors : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private Contractor selectedContractor;
        public frmContractors()
        {
            InitializeComponent();
        }
        private List<Contractor> GetContractors()
        {
            DAL.DAL db = new DAL.DAL();
            List<Contractor> lstContractors = db.GetAllContractors();
            return lstContractors;
        }


        private void frmContractors_Load(object sender, EventArgs e)
        {
            dgContractor.DataSource = bindingSource1;

            bindingSource1.DataSource = GetContractors();
        }

        private void SaveContractor_Click(object sender, EventArgs e)
        {
            if (tbContractor.Text != "")
            {
                if (selectedContractor != null)
                {
                    selectedContractor.ContractorName = tbContractor.Text;
                    selectedContractor.Save();
                    bindingSource1.DataSource = GetContractors();
                }
                else
                {
                    Contractor newContractor = new Contractor();
                    newContractor.ContractorName = tbContractor.Text;
                    if (!newContractor.Save())
                    {
                        MessageBox.Show("Error Saving Contractor", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                    {
                        bindingSource1.DataSource = GetContractors();
                    }
                }
            }
            else
            {
                MessageBox.Show("You must enter a Contractor", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            selectedContractor.Delete();
            bindingSource1.DataSource = GetContractors();
            selectedContractor = null;
            tbContractor.Text = "";
        }

        private void dgContractor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgContractor.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbContractor.Text = dgContractor.Rows[e.RowIndex].Cells[1].Value.ToString();

            selectedContractor = new Contractor(id, tbContractor.Text);
        }
    }
}

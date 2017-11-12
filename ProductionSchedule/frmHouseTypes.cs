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
    public partial class frmHouseTypes : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private HouseType selectedHouseType;

        public frmHouseTypes()
        {
            InitializeComponent();
        }

        private List<HouseType> GetHouseTypes()
        {
            DAL.DAL db = new DAL.DAL();
            List<HouseType> lstHouseTypes = db.GetAllHouseTypes();
            return lstHouseTypes;
        }
        private void SaveHouseType_Click(object sender, EventArgs e)
        {
            if (tbHouseType.Text != "")
            {
                if (selectedHouseType != null)
                {
                    selectedHouseType.HsType = tbHouseType.Text;
                    selectedHouseType.Save();
                    bindingSource1.DataSource = GetHouseTypes();
                }
                else
                {
                    HouseType newHouseType = new HouseType();
                    newHouseType.HsType = tbHouseType.Text;
                    if (!newHouseType.Save())
                    {
                        MessageBox.Show("Error Saving House Type", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                    {
                        bindingSource1.DataSource = GetHouseTypes();
                    }
                }
            }
            else
            {
                MessageBox.Show("You must enter an House Type", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void frmHouseTypes_Load(object sender, EventArgs e)
        {
            dgHouseTypes.DataSource = bindingSource1;

            bindingSource1.DataSource = GetHouseTypes();

        }

        private void dgHouseTypes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgHouseTypes.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbHouseType.Text = dgHouseTypes.Rows[e.RowIndex].Cells[1].Value.ToString();

            selectedHouseType = new HouseType(id, tbHouseType.Text);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            selectedHouseType.Delete();
            bindingSource1.DataSource = GetHouseTypes();
            selectedHouseType = null;
            tbHouseType.Text = "";
        }
    }
}

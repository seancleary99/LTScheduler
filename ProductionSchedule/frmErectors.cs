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

    public partial class frmErectors : Form
    {

        private BindingSource bindingSource1 = new BindingSource();
        private Erector selectedErector;

        public frmErectors()
        {
            InitializeComponent();
        }
    
        private void SaveErector_Click(object sender, EventArgs e)
        {

            
            if (tbErectorName.Text != "")
            {
                if (selectedErector != null)
                {
                    selectedErector.ErectorName = tbErectorName.Text;
                    selectedErector.Save();
                    bindingSource1.DataSource = GetErectors();
                }
                else
                {
                    Erector newErector = new Erector();
                    newErector.ErectorName = tbErectorName.Text;
                    if (!newErector.Save())
                    {
                        MessageBox.Show("Error Saving Erector", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                    {
                        bindingSource1.DataSource = GetErectors();
                    }
                }
            }
            else
            {
                MessageBox.Show("You must enter an Erector Name", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void frmErectors_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
           
            bindingSource1.DataSource = GetErectors();           

        }

        private List<Erector> GetErectors()
        {
            DAL.DAL db = new DAL.DAL();
            List<Erector> lstErectors = db.GetAllErectors();
            return lstErectors;
        }



        private void Delete_Click(object sender, EventArgs e)
        {
            selectedErector.Delete();
            bindingSource1.DataSource = GetErectors();
            selectedErector = null;
            tbErectorName.Text = "";

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbErectorName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            selectedErector = new Erector(id, tbErectorName.Text);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbErectorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

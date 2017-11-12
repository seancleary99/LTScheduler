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
    public partial class frmPlot : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private BindingSource cbxBindingSource = new BindingSource();
        private Plot selectedPlot;

        public frmPlot()
        {
            InitializeComponent();
        }

        private List<Plot> GetPlots()
        {
            DAL.DAL db = new DAL.DAL();
            List<Plot> lstPlots = db.GetAllPlots();
            return lstPlots;
        }

        private List<HouseType> GetHouseTypes()
        {
            DAL.DAL db = new DAL.DAL();
            List<HouseType> lstHouseTypes = db.GetAllHouseTypes();
            return lstHouseTypes;
        }

        private void frmPlot_Load(object sender, EventArgs e)
        {
            ReloadPlots();

            cbxPlotType.DataSource = cbxBindingSource;

            DAL.DAL db = new DAL.DAL();
            List<HouseType> lstHouseTypes = db.GetAllHouseTypes();
            cbxPlotType.SelectedIndex = -1;
            cbxBindingSource.DataSource = lstHouseTypes;
            cbxPlotType.DisplayMember = "HsType";
            cbxPlotType.ValueMember = "ID";
           
        }

        private void ReloadPlots()
        {
            dgPlots.DataSource = bindingSource1;
            bindingSource1.DataSource = GetPlots();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            lblPlotIDVal.Text = "";
            tbPlotName.Text = "";
            tbPlotLineTot.Text = "";
            tbPlotFloorTot.Text = "";
            tbPlotBenchTot.Text = "";

            selectedPlot = null;
        }

        private void btnSavePlot_Click(object sender, EventArgs e)
        {
            int pID = 0;
            //if (lblPlotIDVal.Text != "")
            //{
            //    int.TryParse(lblPlotIDVal.Text, out pID);
            //}
            //Plot newPlot = new Plot(pID, tbPlotName.Text, (int)cbxPlotType.SelectedValue, float.Parse(tbPlotLineTot.Text), float.Parse(tbPlotBenchTot.Text), float.Parse(tbPlotFloorTot.Text));
            //pID = newPlot.Save();
            //if (pID > 0) {
            //    lblPlotIDVal.Text = pID.ToString();
            //    ReloadPlots();
            //}


            if (tbPlotName.Text != "")
            {
                //int.TryParse(lblPlotIDVal.Text, out pID);
                if (selectedPlot != null)
                {
                    selectedPlot.PlotName = tbPlotName.Text;
                    selectedPlot.PlotType = (int)cbxPlotType.SelectedValue;
                    selectedPlot.PlotLineTotal = float.Parse(tbPlotLineTot.Text);
                    selectedPlot.PlotBenchTotal = float.Parse(tbPlotBenchTot.Text);
                    selectedPlot.PlotFloorTotal = float.Parse(tbPlotFloorTot.Text);
                    pID = selectedPlot.Save();
                    if (pID > 0)
                    {
                        lblPlotIDVal.Text = pID.ToString();
                        ReloadPlots();
                    }
                }
                else
                {
                    Plot newPlot = new Plot(pID, tbPlotName.Text, (int)cbxPlotType.SelectedValue, float.Parse(tbPlotLineTot.Text), float.Parse(tbPlotBenchTot.Text), float.Parse(tbPlotFloorTot.Text));
                    pID = newPlot.Save();
                    if (pID > 0)
                    {
                        lblPlotIDVal.Text = pID.ToString();
                        ReloadPlots();
                    }
                    else
                    {
                        MessageBox.Show("Error Saving Plot", "ERROR", MessageBoxButtons.OK);
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("You must enter a Plot Name", "ERROR", MessageBoxButtons.OK);
            }


        }

        private void dgPlots_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgPlots.Rows[e.RowIndex].Cells[0].Value.ToString());
            lblPlotIDVal.Text = id.ToString();
            tbPlotName.Text = dgPlots.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbxPlotType.SelectedValue = Convert.ToInt32(dgPlots.Rows[e.RowIndex].Cells[2].Value.ToString());
            tbPlotLineTot.Text = dgPlots.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbPlotFloorTot.Text = dgPlots.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbPlotBenchTot.Text = dgPlots.Rows[e.RowIndex].Cells[5].Value.ToString();

            selectedPlot = new Plot(id);
        }

        private void btnDelPlot_Click(object sender, EventArgs e)
        {
            selectedPlot.Delete();
            bindingSource1.DataSource = GetPlots();
            selectedPlot = null;
            ClearAll();
        }
    }
}

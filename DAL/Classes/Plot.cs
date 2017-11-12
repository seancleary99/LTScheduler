using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Classes
{
    
    public class Plot
    {

        private int _id;
        private string _plotName;
        private int _plotType;
        private float _lineTot;
        private float _benchTot;
        private float _floorTot;

        public int ID { get { return _id; } set { _id = value; } }
        public string PlotName { get { return _plotName; } set { _plotName = value; } }

        public int PlotType { get { return _plotType; } set { _plotType = value; } }

        public float PlotLineTotal { get { return _lineTot; } set { _lineTot = value; } }
        public float PlotBenchTotal { get { return _benchTot; } set { _benchTot = value; } }
        public float PlotFloorTotal { get { return _floorTot; } set { _floorTot = value; } }

        #region Constructors
        public Plot() { }
        public Plot(int id)
        {
            DAL db = new DAL();
            DataTable dtPlot = db.GetPlot(id);

            _id = (int)dtPlot.Rows[0][0];
            _plotName = dtPlot.Rows[0][1].ToString();
            _plotType = (int)dtPlot.Rows[0][2];
            float.TryParse(dtPlot.Rows[0][3].ToString(), out _lineTot);
            float.TryParse(dtPlot.Rows[0][4].ToString(), out _floorTot);
            float.TryParse(dtPlot.Rows[0][5].ToString(), out _benchTot);

        }


        public Plot(int id, string PlotName, int PlotType, float LineTot, float BenchTot, float FloorTot)
        {
            _id = id;
            _plotName = PlotName;
            _plotType = PlotType;
            _lineTot = LineTot;
            _floorTot = FloorTot;
            _benchTot = BenchTot;
        }

        public int Save()
        {
            int plotID = 0;
            DAL db = new DAL();
            plotID = db.SavePlot(_id, _plotName, _plotType, _lineTot, _floorTot, _benchTot);
            return plotID;
        }

        public bool Delete()
        {
            bool isDeleted = false;
            DAL db = new DAL();
            isDeleted = db.DeletePlot(_id);
            return isDeleted;
        }
        #endregion

    

}
}

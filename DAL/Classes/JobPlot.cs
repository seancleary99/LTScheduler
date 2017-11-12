using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Classes
{
    
    public class JobPlot
    {

        private int _jobPlotId = 0;
        private Plot _plot;
        private int _jobId;
        private HouseType _houseType;
        private Erector _erector;
        private CraneHire _craneHire;
        //private DateTime? _prodDate;
        //private DateTime? _onsiteDate;
        //private DateTime? _completionDate;

        public int JobPlotId { get { return _jobPlotId; } set { _jobPlotId = value; } }
        public string PlotName { get { return _plot.PlotName; } set { _plot.PlotName = value; } }
        public int PlotId { get { return _plot.ID; } set { _plot.ID = value; } }

        public int JobID { get { return _jobId; } set { _jobId = value; } }
        public string PlotHouseType { get { return _houseType.HsType; } set { _houseType.HsType = value; } }

        public string PlotErector { get { return _erector.ErectorName; } set { _erector.ErectorName = value; } }
        public string PlotCraneHire { get { return _craneHire.CraneName; } set { _craneHire.CraneName = value; } }

        //public DateTime? ProductionDate { get { return _prodDate; } set { _prodDate = value; } }
        //public DateTime? OnsiteDate { get { return _onsiteDate; } set { _onsiteDate = value; } }
        //public DateTime? CompletionDate { get { return _completionDate; } set { _completionDate = value; } }

        #region Constructors
        public JobPlot() { }
        public JobPlot(int id)
        {
            DAL db = new DAL();
            DataTable dtPlot = db.GetJobPlots(id);

            if (dtPlot.Rows.Count == 1)
            {
                //_jobPlotId = id;
                //_plot = new Plot((int)dtPlot.Rows[0][1]);
                //_jobId = (int)dtPlot.Rows[0][2];
                //_houseType = new HouseType((int)dtPlot.Rows[0][3]);
                //_erector = new Erector((int)dtPlot.Rows[0][4]);
                //_craneHire = new CraneHire((int)dtPlot.Rows[0][5]);
                //_prodDate = (DateTime)dtPlot.Rows[0][6];
                //_onsiteDate = (DateTime)dtPlot.Rows[0][7];
                //_completionDate = (DateTime)dtPlot.Rows[0][8];

                //                InitJobPlot(id, (int)dtPlot.Rows[0][1], (int)dtPlot.Rows[0][2], (int)dtPlot.Rows[0][3], (int)dtPlot.Rows[0][4], (int)dtPlot.Rows[0][5], (DateTime)dtPlot.Rows[0][6], (DateTime)dtPlot.Rows[0][7], (DateTime)dtPlot.Rows[0][8] );
                InitJobPlot(id, (int)dtPlot.Rows[0][1], (int)dtPlot.Rows[0][2], (int)dtPlot.Rows[0][3], (int)dtPlot.Rows[0][4], (int)dtPlot.Rows[0][5]);
            }
        }

        public JobPlot(int id, int plotId, int jobId, int houseType, int erectorId, int craneId)
        {
            //InitJobPlot(id, plotId, jobId, houseType, erectorId, craneId, prodDate, onsiteDate, compDate);
            InitJobPlot(id, plotId, jobId, houseType, erectorId, craneId);
        }

        //private void InitJobPlot(int id, int plotId, int jobId, int houseType, int erectorId, int craneId, DateTime? prodDate, DateTime? onsiteDate, DateTime? compDate)
        private void InitJobPlot(int id, int plotId, int jobId, int houseType, int erectorId, int craneId)
        {
            _jobPlotId = id;
            _plot = new Plot(plotId);
            _jobId = jobId;
            _houseType = new HouseType(houseType);
            _erector = new Erector(erectorId);
            _craneHire = new CraneHire(craneId);
            //_prodDate = prodDate;
            //_onsiteDate = onsiteDate;
            //_completionDate = compDate;
        }


        public bool Save()
        {
            DAL db = new DAL();
            // _jobPlotId = db.SaveJobPlot(_jobPlotId, _plot.ID, _jobId, _houseType.ID, _erector.ID, _craneHire.ID, _prodDate, _onsiteDate, _completionDate);
            _jobPlotId = db.SaveJobPlot(_jobPlotId, _plot.ID, _jobId, _houseType.ID, _erector.ID, _craneHire.ID);
            if (_jobPlotId > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete()
        {            
            bool isDeleted = false;
            DAL db = new DAL();
            isDeleted = db.DeleteJobPlot(_jobPlotId);
            return isDeleted;
        }
        #endregion

    

}
}

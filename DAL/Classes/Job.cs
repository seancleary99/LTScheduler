using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DAL.Classes
{
    public class Job
    {
        private int _jobId;
        private string _line;
        private string _jobName;
        private int _contId;
        private string _siteName;
        private string _siteContact;
        private bool _siteComplete;
        private List<JobPlot> _jobPlots;
        private DateTime _prodDate;
        private DateTime? _prodCompDate;
        private DateTime _onsiteDate;
        private DateTime _completionDate;

        public int JobId { get { return _jobId; } set { _jobId = value; } }
        public string Line { get { return _line; } set { _line = value; } }
        public string JobName { get { return _jobName; } set { _jobName = value; } }
        public int ContractorID { get { return _contId; } set { _contId = value; } }

        public string SiteName { get { return _siteName; } set { _siteName = value; } }
        public string SiteContact { get { return _siteContact; } set { _siteContact = value; } }
        //public bool SiteComplete { get { return _siteComplete; } set { _siteComplete = value; } }
        public string SiteComplete { get { return _siteComplete.ToString(); } }
        public List<JobPlot> JobPlots { get { return _jobPlots; } set { _jobPlots = value; } }

        public DateTime ProductionDate { get { return _prodDate; } set { _prodDate = value; } }
        public DateTime? ProductionCompleteDate { get { return _prodCompDate; } set { _prodCompDate = value; } }
        public DateTime OnSiteDate { get { return _onsiteDate; }set { _onsiteDate = value; } }
        public DateTime CompletionDate { get { return _completionDate; } set { _completionDate = value; } }
        #region Constructors

        public Job()
        {

        }

        public Job(int jobId, string jobName, string line, int contractorId, string siteName, string siteContact, bool siteComplete, DateTime prodDate, DateTime? prodCompleteDate, DateTime onsiteDate, DateTime compDate, List<JobPlot> plots)
        {
            _jobId = jobId;
            _line = line;
            _jobName = jobName;
            _contId = contractorId;
            _siteName = siteName;
            _siteContact = siteContact;
            _siteComplete = siteComplete;
            _completionDate = compDate;
            _prodDate = prodDate;
            _prodCompDate = prodCompleteDate;
            _onsiteDate = onsiteDate;
            GetJobPlots();
            //_plots = GetJobPlots();
        }

        public Job(int jobId)
        {
            _jobId = jobId;
            GetJob(_jobId);
        }

        #endregion

      
        private void GetJob(int jobID)
        {
            DAL db = new DAL();
            
            DataTable dtJob = db.GetJob(jobID);
            if (dtJob != null && dtJob.Rows.Count == 1)
            {
                _jobId = jobID;
                _line = dtJob.Rows[0]["Line"].ToString();
                _jobName = dtJob.Rows[0]["JobName"].ToString();
                _contId = (int)dtJob.Rows[0]["JobContractorID"];
                _siteName = dtJob.Rows[0]["SiteName"].ToString();
                _siteContact = dtJob.Rows[0]["SiteContact"].ToString();
                _siteComplete = (bool)dtJob.Rows[0]["SiteComplete"];
                _onsiteDate = (DateTime)dtJob.Rows[0]["OnsiteDate"];
                _prodDate = (DateTime)dtJob.Rows[0]["ProductionDate"];
                _completionDate = (DateTime)dtJob.Rows[0]["CompletionDate"];
                _prodCompDate = dtJob.Rows[0]["ProductionCompleteDate"] == DBNull.Value ? (DateTime?)null : (DateTime)dtJob.Rows[0]["ProductionCompleteDate"];
                GetJobPlots();
            }
        }

        private void GetJobPlots()
        {
            DAL db = new DAL();
            _jobPlots = db.GetAllJobPlotsForJob(_jobId);
        }

        public bool Save()
        {
            bool isSaved = true;
            DAL db = new DAL();
            isSaved = db.SaveJob(_jobId, _line, _jobName, _contId, _siteName, _siteContact, _siteComplete, _prodDate, _onsiteDate, _completionDate, _jobPlots);
            return isSaved;
        }
    }
}

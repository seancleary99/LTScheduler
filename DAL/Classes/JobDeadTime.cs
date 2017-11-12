using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Classes
{
    public class JobDeadTime
    {
        private int _jobId;
        private int _deadTime;
        private string _notes;

        public int JobId { get { return _jobId; } set { _jobId = value; } }
        public int DeadTme { get { return _deadTime; } set { _deadTime = value; } }
        public string Notes { get { return _notes; } set { _notes = value; } }

        public JobDeadTime()
        { }

        public JobDeadTime(int JobId, int DeadTime, string Notes)
        {
            _jobId = JobId;
            _deadTime = DeadTime;
            _notes = Notes;
        }

        public JobDeadTime(int JobId)
        {
            _jobId = JobId;
            GetJobDeadTime();
        }

        public bool Save()
        {
            bool isSaved = true;
            DAL db = new DAL();
            try
            {
                db.SaveJobDeadTime(_jobId, _deadTime, _notes);
            }
            catch(Exception ex) {
                isSaved = false;
            }

            return isSaved;
        }

        private void GetJobDeadTime()
        {
            DAL db = new DAL();
            try {

                DataTable dtDets = db.GetJobDeadTime(_jobId);
                if (dtDets.Rows.Count == 1)
                {
                    _deadTime = (int)dtDets.Rows[0]["DeadTime"];
                    _notes = dtDets.Rows[0]["Notes"].ToString();
                }

            }
            catch (Exception ex) {

            }
            
        }
    }
}



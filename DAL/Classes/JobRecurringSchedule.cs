using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Classes;
using DAL;
using System.Data;

namespace DAL.Classes
{
    public class JobRecurringSchedule
    {
        private int _id;
        private int _jobId;
        private DateTime _scheduleStartDate;
	    private bool _daily;
        private bool _weekly;
        private bool _fortnightly;
        private bool _monthly;
        private bool _custom;
        private int _customDays;
        private DateTime _cancelledDate;

        public int ID { get { return _id; } set { _id = value; } }
        public int JobID { get { return _jobId; } set { _jobId = value; } }
        public DateTime ScheduleStartDate { get { return _scheduleStartDate; } set { _scheduleStartDate = value; } }
        public bool Daily { get { return _daily; } set { _daily = value; } }
        public bool Weekly { get { return _weekly; } set { _weekly = value; } }
        public bool Fortnightly { get { return _fortnightly; } set { _fortnightly = value; } }
        public bool Monthly { get { return _monthly; } set { _monthly = value; } }
        public bool Custom { get { return _custom; } set { _custom = value; } }
        public int CustomDays { get { return _customDays; } set { _customDays = value; } }
        public DateTime CancelledDate { get { return _cancelledDate; } set { _cancelledDate = value; } }


        public JobRecurringSchedule(){}

        public JobRecurringSchedule(int JobId) {
            _jobId = JobId;
            GetJobRecurringSchedule();
        }

        private void GetJobRecurringSchedule()
        {
            DAL db = new DAL();
            DataTable dtRecurConfig = db.GetJobRecurringConfig(_jobId);
            if (dtRecurConfig.Rows.Count == 1)
            {
                _id = (int)dtRecurConfig.Rows[0]["ID"];
                _scheduleStartDate = (DateTime)dtRecurConfig.Rows[0]["ID"];
            }
        }
    }
}

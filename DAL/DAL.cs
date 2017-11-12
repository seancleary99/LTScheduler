using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using DAL.Classes;
using System.Data;

namespace DAL
{
    public class DAL:IDal
    {
        private string connString = "";
        private SqlConnection conn = null;
        public DAL()
        {
            connString = ConfigurationManager.ConnectionStrings["LeadonTimberframeConnectionString"].ToString();
            conn = new SqlConnection(connString);
            
        }

        #region Erectors
        public List<Erector> GetAllErectors()
        {
            List<Erector> erectors = new List<Erector>();

            SqlCommand spGetErectors = new SqlCommand("GetErectors", conn);
            spGetErectors.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();
                SqlDataAdapter sDa = new SqlDataAdapter(spGetErectors);
                DataTable dtErectors = new DataTable();
                sDa.Fill(dtErectors);

                foreach (DataRow r in dtErectors.Rows)
                {
                    Erector e = new Erector((int)r["ID"], r["ErectorName"].ToString());
                    erectors.Add(e);
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                conn.Close();

            }
            return erectors;
        }

        public DataTable GetErector(int id)
        {
            DataTable dtErector = new DataTable();
            SqlCommand spGetErector = new SqlCommand("GetErector", conn);
            spGetErector.CommandType = System.Data.CommandType.StoredProcedure;
            spGetErector.Parameters.Add(
                new SqlParameter("@id", id));


            try
            {
                conn.Open();
                SqlDataAdapter sDa = new SqlDataAdapter(spGetErector);
                sDa.Fill(dtErector);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }
            return dtErector;

        }

        public bool SaveErector(int id, string name)
        {
            bool isSaved = true;
            SqlCommand spSaveErector = new SqlCommand("SaveErector", conn);
            spSaveErector.CommandType = System.Data.CommandType.StoredProcedure;
            spSaveErector.Parameters.Add(
                new SqlParameter("@ErectorID", id));
            spSaveErector.Parameters.Add(
                new SqlParameter("@Name", name));

            try
            {
                conn.Open();
                spSaveErector.ExecuteNonQuery();
            }
            catch (Exception ex){
                isSaved = false;
            }
            finally
            {
                conn.Close();
                
            }
            return isSaved;

        }

        public bool DeleteErector(int id)
        {
            bool isDeleted = true;
            SqlCommand spSaveErector = new SqlCommand("DeleteErector", conn);
            spSaveErector.CommandType = System.Data.CommandType.StoredProcedure;
            spSaveErector.Parameters.Add(
                new SqlParameter("@ID", id));

            try
            {
                conn.Open();
                spSaveErector.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                isDeleted = false;
            }
            finally
            {
                conn.Close();

            }
            return isDeleted;
        }

        #endregion

        #region HouseTypes
        public List<HouseType> GetAllHouseTypes()
        {
            List<HouseType> houseTypes = new List<HouseType>();

            SqlCommand spGetErectors = new SqlCommand("GetHouseTypes", conn);
            spGetErectors.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();
                SqlDataAdapter sDa = new SqlDataAdapter(spGetErectors);
                DataTable dtHouseTypes = new DataTable();
                sDa.Fill(dtHouseTypes);

                foreach (DataRow r in dtHouseTypes.Rows)
                {
                    HouseType e = new HouseType((int)r["ID"], r["HouseTypeName"].ToString());
                    houseTypes.Add(e);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }
            return houseTypes;
        }

        public bool SaveHouseType(int id, string name)
        {
            bool isSaved = true;
            SqlCommand spSaveHouseType = new SqlCommand("SaveHouseType", conn);
            spSaveHouseType.CommandType = System.Data.CommandType.StoredProcedure;
            spSaveHouseType.Parameters.Add(
                new SqlParameter("@HouseID", id));
            spSaveHouseType.Parameters.Add(
                new SqlParameter("@Name", name));

            try
            {
                conn.Open();
                spSaveHouseType.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                isSaved = false;
            }
            finally
            {
                conn.Close();

            }
            return isSaved;

        }

        public DataTable GetHouseType(int id)
        {
            DataTable dtHouseTypes = new DataTable();
            SqlCommand spGetHouseType = new SqlCommand("GetHouseType", conn);
            spGetHouseType.CommandType = System.Data.CommandType.StoredProcedure;
            spGetHouseType.Parameters.Add(
                new SqlParameter("@id", id));
            

            try
            {
                conn.Open();
                SqlDataAdapter sDa = new SqlDataAdapter(spGetHouseType);
                sDa.Fill(dtHouseTypes);
            }
            catch (Exception ex)
            {
              
            }
            finally
            {
                conn.Close();

            }
            return dtHouseTypes;

        }

        public bool DeleteHouseType(int id)
        {
            bool isDeleted = true;
            SqlCommand spDelHouseType = new SqlCommand("DeleteHouseType", conn);
            spDelHouseType.CommandType = System.Data.CommandType.StoredProcedure;
            spDelHouseType.Parameters.Add(
                new SqlParameter("@ID", id));

            try
            {
                conn.Open();
                spDelHouseType.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                isDeleted = false;
            }
            finally
            {
                conn.Close();

            }
            return isDeleted;
        }
        #endregion

        #region CraneHire
        public List<CraneHire> GetAllCraneHire()
        {
            List<CraneHire> craneHires = new List<CraneHire>();

            SqlCommand spGetCraneHires = new SqlCommand("GetCraneHires", conn);
            spGetCraneHires.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();
                SqlDataAdapter sDa = new SqlDataAdapter(spGetCraneHires);
                DataTable dtCranes = new DataTable();
                sDa.Fill(dtCranes);

                foreach (DataRow r in dtCranes.Rows)
                {
                    CraneHire e = new CraneHire((int)r["ID"], r["CraneHire"].ToString());
                    craneHires.Add(e);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }
            return craneHires;
        }

        public DataTable GetCraneHire(int id)
        {
            DataTable dtCrane = new DataTable();
            SqlCommand spCrane = new SqlCommand("GetCraneHire", conn);
            spCrane.CommandType = System.Data.CommandType.StoredProcedure;
            spCrane.Parameters.Add(
                new SqlParameter("@id", id));


            try
            {
                conn.Open();
                SqlDataAdapter sDa = new SqlDataAdapter(spCrane);
                sDa.Fill(dtCrane);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }
            return dtCrane;

        }

        public bool SaveCraneHire(int id, string craneName)
        {
            bool isSaved = true;
            SqlCommand spSaveCraneHire = new SqlCommand("SaveCraneHire", conn);
            spSaveCraneHire.CommandType = System.Data.CommandType.StoredProcedure;
            spSaveCraneHire.Parameters.Add(
                new SqlParameter("@CraneID", id));
            spSaveCraneHire.Parameters.Add(
                new SqlParameter("@CraneHire", craneName));

            try
            {
                conn.Open();
                spSaveCraneHire.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                isSaved = false;
            }
            finally
            {
                conn.Close();

            }
            return isSaved;

        }

        public bool DeleteCraneHire(int id)
        {
            bool isDeleted = true;
            SqlCommand spDelCraneHire = new SqlCommand("DeleteCraneHire", conn);
            spDelCraneHire.CommandType = System.Data.CommandType.StoredProcedure;
            spDelCraneHire.Parameters.Add(
                new SqlParameter("@ID", id));

            try
            {
                conn.Open();
                spDelCraneHire.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                isDeleted = false;
            }
            finally
            {
                conn.Close();

            }
            return isDeleted;
        }
        #endregion

        #region Contractors
        public List<Contractor> GetAllContractors()
        {
            List<Contractor> lstContractors = new List<Contractor>();

            SqlCommand spGetContractors = new SqlCommand("GetContractors", conn);
            spGetContractors.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();
                SqlDataAdapter sDa = new SqlDataAdapter(spGetContractors);
                DataTable dtContractors = new DataTable();
                sDa.Fill(dtContractors);

                foreach (DataRow r in dtContractors.Rows)
                {
                    Contractor e = new Contractor((int)r["ID"], r["Contractor"].ToString());
                    lstContractors.Add(e);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }
            return lstContractors;
        }

        public bool SaveContractor(int id, string contractorName)
        {
            bool isSaved = true;
            SqlCommand spSaveContractor = new SqlCommand("SaveContractor", conn);
            spSaveContractor.CommandType = System.Data.CommandType.StoredProcedure;
            spSaveContractor.Parameters.Add(
                new SqlParameter("@ContID", id));
            spSaveContractor.Parameters.Add(
                new SqlParameter("@ContName", contractorName));

            try
            {
                conn.Open();
                spSaveContractor.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                isSaved = false;
            }
            finally
            {
                conn.Close();

            }
            return isSaved;

        }

        public bool DeleteContractor(int id)
        {
            bool isDeleted = true;
            SqlCommand spDelContractor = new SqlCommand("DeleteContractor", conn);
            spDelContractor.CommandType = System.Data.CommandType.StoredProcedure;
            spDelContractor.Parameters.Add(
                new SqlParameter("@ID", id));

            try
            {
                conn.Open();
                spDelContractor.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                isDeleted = false;
            }
            finally
            {
                conn.Close();

            }
            return isDeleted;
        }
        #endregion

        #region Jobs

        public DataTable GetJob(int jobID)
        {
            DataTable dtJob = null;
            SqlCommand spGetJob = new SqlCommand("GetJob", conn);
            spGetJob.CommandType = System.Data.CommandType.StoredProcedure;
            spGetJob.Parameters.Add(
              new SqlParameter("@JobID", jobID));
            try
            {
                conn.Open();
                SqlDataAdapter sDa = new SqlDataAdapter(spGetJob);
                dtJob = new DataTable();
                sDa.Fill(dtJob);               
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }
            return dtJob;
        }

        public List<Job> GetAllJobs()
        {
            List<Job> lstJobs = new List<Job>();

            SqlCommand spGetJobs = new SqlCommand("GetJobs", conn);
            spGetJobs.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();
                SqlDataAdapter sDa = new SqlDataAdapter(spGetJobs);
                DataTable dtJobs = new DataTable();
                sDa.Fill(dtJobs);

                foreach (DataRow r in dtJobs.Rows)
                {
                    Job e = new Job((int)r["JobID"], r["JobName"].ToString(), r["Line"].ToString(), (int)r["JobContractorID"], r["SiteName"].ToString(),r["SiteContact"].ToString(), (bool)r["SiteComplete"],(DateTime)r["ProductionDate"], r["ProductionCompleteDate"] == DBNull.Value ? null : (DateTime?)r["ProductionCompleteDate"], (DateTime)r["OnsiteDate"], (DateTime)r["CompletionDate"],null);
                    lstJobs.Add(e);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }
            return lstJobs;
        }

        public DataTable GetJobPlots(int JobPlotID)
        {
            //List<JobPlots> lstJobPlots = new List<JobPlots>();
            // DataTable dtJobPlots;
            DataTable dtJobPlots = new DataTable();
            SqlCommand spGetJobs = new SqlCommand("GetJobPlots", conn);
            spGetJobs.CommandType = System.Data.CommandType.StoredProcedure;
            spGetJobs.Parameters.Add(
             new SqlParameter("@JobPlotID", JobPlotID));
            try
            {
                conn.Open();
                SqlDataAdapter sDa = new SqlDataAdapter(spGetJobs);
               
                sDa.Fill(dtJobPlots);

                //foreach (DataRow r in dtJobPlots.Rows)
                //{
                //    Plot jPlot = new Plot((int)r["PlotId"]);
                //    CraneHire jCrane = new 
                //    Job e = new Job((int)r["JobID"], r["JobName"].ToString(), r["Line"].ToString(), (int)r["JobContractorID"], r["SiteName"].ToString(), r["SiteContact"].ToString(), (bool)r["SiteComplete"], (DateTime)r["ProductionDate"], (DateTime)r["OnsiteDate"], (DateTime)r["CompletionDate"], null);
                //    lstJobs.Add(e);
                //}
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }
            return dtJobPlots;
        }

        public List<JobPlot> GetAllJobPlotsForJob(int jobId)
        {
            List<JobPlot> lstJobPlots = new List<JobPlot>();

            SqlCommand spJobPlotsByJob = new SqlCommand("GetJobPlotsByJob", conn);
            spJobPlotsByJob.CommandType = System.Data.CommandType.StoredProcedure;
            spJobPlotsByJob.Parameters.Add(
            new SqlParameter("@JobID", jobId));
            try
            {
                conn.Open();
                SqlDataAdapter sDa = new SqlDataAdapter(spJobPlotsByJob);
                DataTable dtJobPlots = new DataTable();
                sDa.Fill(dtJobPlots);

                foreach (DataRow r in dtJobPlots.Rows)
                {
                    //DateTime pDate;
                    //DateTime.TryParse(r[6].ToString(), out pDate);
                    //DateTime onDate;
                    //DateTime.TryParse(r[7].ToString(), out onDate);
                    //DateTime cDate;
                    //DateTime.TryParse(r[8].ToString(), out cDate);
                    JobPlot jp = new JobPlot((int)r[0], (int)r[1], (int)r[2], (int)r[3], (int)r[4], (int)r[5]);
                   
                    lstJobPlots.Add(jp);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }
            return lstJobPlots;
        }
        public bool SaveJob(int jobID, string line, string jobName, int jobContractorID, string siteName, string siteContact, bool siteComplete, DateTime prodDate, DateTime onsiteDate, DateTime completionDate, List<JobPlot> jobplots)
        {
            bool isSaved = true;
            int newJobID = 0;

            SqlCommand spSaveJob = new SqlCommand("SaveJob", conn);
            spSaveJob.CommandType = System.Data.CommandType.StoredProcedure;

            spSaveJob.Parameters.Add(new SqlParameter("@JobID", jobID));
            spSaveJob.Parameters.Add(new SqlParameter("@Line", line));
            spSaveJob.Parameters.Add(new SqlParameter("@JobName", jobName));
            spSaveJob.Parameters.Add(new SqlParameter("@JobContractorID", jobContractorID));
            spSaveJob.Parameters.Add(new SqlParameter("@SiteName", siteName));
            spSaveJob.Parameters.Add(new SqlParameter("@SiteContact", siteContact));
            spSaveJob.Parameters.Add(new SqlParameter("@ProdDate", prodDate));
            spSaveJob.Parameters.Add(new SqlParameter("@OnsiteDate", onsiteDate));
            spSaveJob.Parameters.Add(new SqlParameter("@CompletionDate", completionDate));
            int i = siteComplete ? 1 : 0;
            spSaveJob.Parameters.Add(new SqlParameter("@SiteComplete", i));

            try
            {
                conn.Open();
                int.TryParse(spSaveJob.ExecuteScalar().ToString(), out newJobID);
                if (newJobID > 0)
                {
                    foreach(JobPlot p in jobplots)
                    {
                        p.JobID = newJobID;
                        p.Save();
                    }

                }
            }
            catch (Exception ex)
            {
                isSaved = false;
            }
            finally
            {
                conn.Close();

            }
            return isSaved;

        }

        //public int SaveJobPlot(int jobPlotId, int plotId, int jobID, int houseType, int erectorId, int craneId, DateTime? prodDate, DateTime? onsiteDate, DateTime? completionDate)
        public int SaveJobPlot(int jobPlotId, int plotId, int jobID, int houseType, int erectorId, int craneId)
        {
            bool isSaved = true;
            int newJobPlotID = 0;

            SqlCommand spSaveJob = new SqlCommand("SaveJobPlot", conn);
            spSaveJob.CommandType = System.Data.CommandType.StoredProcedure;
            
            spSaveJob.Parameters.Add(new SqlParameter("@JobPlotID", jobPlotId));
            spSaveJob.Parameters.Add(new SqlParameter("@PlotID", plotId));
            spSaveJob.Parameters.Add(new SqlParameter("@JobID", jobID));
            spSaveJob.Parameters.Add(new SqlParameter("@HouseType", houseType));
            spSaveJob.Parameters.Add(new SqlParameter("@ErectorID", erectorId));
            spSaveJob.Parameters.Add(new SqlParameter("@CraneID", craneId));
            //spSaveJob.Parameters.Add(new SqlParameter("@ProdDate", prodDate));
            //spSaveJob.Parameters.Add(new SqlParameter("@OnsiteDate", onsiteDate));
            //spSaveJob.Parameters.Add(new SqlParameter("@CompDate", completionDate));


            try
            {
                conn.Open();
                int.TryParse(spSaveJob.ExecuteScalar().ToString(), out newJobPlotID);
                //if (newJobPlotID > 0)
                //{
                //    foreach (Plot p in plots)
                //    {
                //        //p.JobID = newJobID;
                //        // p.Save();
                //    }

                //}
            }
            catch (Exception ex)
            {
                newJobPlotID = 0;
            }
            finally
            {
                conn.Close();

            }
            return newJobPlotID;

        }

        public bool DeleteJobPlot(int jobPlotId)
        {
            bool isDeleted = true;
            SqlCommand spDel = new SqlCommand("DeleteJobPlot", conn);
            spDel.CommandType = System.Data.CommandType.StoredProcedure;
            spDel.Parameters.Add(new SqlParameter("@JobPlotID", jobPlotId));

            try
            {
                conn.Open();
                spDel.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                isDeleted = false;
            }
            finally
            {
                conn.Close();

            }
            return isDeleted;
        }

        public bool SaveJobDeadTime(int JobId, int DeadTime, string Notes)
        {
            bool isSaved = true;          

            SqlCommand SaveJobDeadTime = new SqlCommand("SaveJobDeadTime", conn);
            SaveJobDeadTime.CommandType = System.Data.CommandType.StoredProcedure;

            SaveJobDeadTime.Parameters.Add(new SqlParameter("@JobID", JobId));
            SaveJobDeadTime.Parameters.Add(new SqlParameter("@DeadTime", DeadTime));
            SaveJobDeadTime.Parameters.Add(new SqlParameter("@Notes", Notes));


            try
            {
                conn.Open();
                SaveJobDeadTime.ExecuteNonQuery();               
            }
            catch (Exception ex)
            {
                isSaved = false;
            }
            finally
            {
                conn.Close();

            }

            return isSaved;
        }

        public DataTable GetJobDeadTime(int JobID)
        {
            DataTable dtJobDeadTime = new DataTable();
            SqlCommand spGetJobDeadTime = new SqlCommand("GetJobDeadTime", conn);
            spGetJobDeadTime.CommandType = System.Data.CommandType.StoredProcedure;
            spGetJobDeadTime.Parameters.Add(
             new SqlParameter("@JobID", JobID));
            try
            {
                conn.Open();
                SqlDataAdapter sDa = new SqlDataAdapter(spGetJobDeadTime);

                sDa.Fill(dtJobDeadTime);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }
            return dtJobDeadTime;
        }

        public DataTable GetJobRecurringConfig(int JobID)
        {
            DataTable dtJobRecurrConfig = new DataTable();
            SqlCommand spGetJobRecurrConfig = new SqlCommand("GetJobRecurringConfig", conn);
            spGetJobRecurrConfig.CommandType = System.Data.CommandType.StoredProcedure;
            spGetJobRecurrConfig.Parameters.Add(
             new SqlParameter("@JobID", JobID));
            try
            {
                conn.Open();
                SqlDataAdapter sDa = new SqlDataAdapter(spGetJobRecurrConfig);

                sDa.Fill(dtJobRecurrConfig);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }
            return dtJobRecurrConfig;
        }

        public bool SaveJobRecurringConfig(int JobId, DateTime ScheduleStartDate, bool Daily, bool Weekly, bool Fortnightly, bool Monthly, bool Custom, int CustomDays, DateTime CancelledDate)
        {
            bool isSaved = true;

            SqlCommand SaveJobRecurringConfig = new SqlCommand("SaveJobRecurringConfig", conn);
            SaveJobRecurringConfig.CommandType = System.Data.CommandType.StoredProcedure;

            SaveJobRecurringConfig.Parameters.Add(new SqlParameter("@JobID", JobId));
            SaveJobRecurringConfig.Parameters.Add(new SqlParameter("@ScheduleStartDate", ScheduleStartDate));
            SaveJobRecurringConfig.Parameters.Add(new SqlParameter("@Daily", Daily));
            SaveJobRecurringConfig.Parameters.Add(new SqlParameter("@Weekly", Weekly));
            SaveJobRecurringConfig.Parameters.Add(new SqlParameter("@Fortnightly", Fortnightly));
            SaveJobRecurringConfig.Parameters.Add(new SqlParameter("@Monthly", Monthly));
            SaveJobRecurringConfig.Parameters.Add(new SqlParameter("@Custom", Custom));
            SaveJobRecurringConfig.Parameters.Add(new SqlParameter("@CustomDays", CustomDays));
            SaveJobRecurringConfig.Parameters.Add(new SqlParameter("@CancelledDate", CancelledDate));

            try
            {
                conn.Open();
                SaveJobRecurringConfig.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                isSaved = false;
            }
            finally
            {
                conn.Close();

            }

            return isSaved;
        }

        #endregion

        #region Plots
        public int SavePlot(int id, string plotName, int plotType, float lineTot, float floorTot, float benchTot)
        {
            int newPlotID = 0;

            SqlCommand spSave = new SqlCommand("SavePlot", conn);
            spSave.CommandType = System.Data.CommandType.StoredProcedure;
            spSave.Parameters.Add(new SqlParameter("@PlotID", id));
            spSave.Parameters.Add(new SqlParameter("@PlotName", plotName));
            spSave.Parameters.Add(new SqlParameter("@HouseTypeId", plotType));
            spSave.Parameters.Add(new SqlParameter("@LineTot", lineTot));
            spSave.Parameters.Add(new SqlParameter("@FloorTot", floorTot));
            spSave.Parameters.Add(new SqlParameter("@BenchTot", benchTot));

            try
            {
                conn.Open();
                int.TryParse(spSave.ExecuteScalar().ToString(), out newPlotID);
            }
            catch (Exception ex)
            {
                newPlotID = 0;
            }
            finally
            {
                conn.Close();

            }
            return newPlotID;
        }

        public List<Plot> GetAllPlots()
        {
            List<Plot> lstPlots = new List<Plot>();
            float tempLine;
            float tempFloor;
            float tempBench;

            SqlCommand spGetPlots = new SqlCommand("GetPlots", conn);
            spGetPlots.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();
                SqlDataAdapter sDa = new SqlDataAdapter(spGetPlots);
                DataTable dtPlots = new DataTable();
                sDa.Fill(dtPlots);

                foreach (DataRow r in dtPlots.Rows)
                {
                    
                    float.TryParse(r["Line_Total"].ToString(), out tempLine);
                    float.TryParse(r["Bench_Total"].ToString(), out tempBench);
                    float.TryParse(r["Floor_Total"].ToString(), out tempFloor);

                    Plot e = new Plot((int)r["PlotID"], r["PlotName"].ToString(), (int)r["HouseTypeID"], tempLine, tempBench, tempFloor);
                    lstPlots.Add(e);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }
            return lstPlots;
        }

        public DataTable GetPlot(int PlotID) {
            DataTable dtPlot = null;
            SqlCommand spGetPlot = new SqlCommand("GetPlot", conn);
            spGetPlot.CommandType = System.Data.CommandType.StoredProcedure;
            spGetPlot.Parameters.Add(
              new SqlParameter("@PlotID", PlotID));
            try
            {
                conn.Open();
                SqlDataAdapter sDa = new SqlDataAdapter(spGetPlot);
                dtPlot = new DataTable();
                sDa.Fill(dtPlot);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }
            return dtPlot;
        }

        public DataTable GetUnsheduledPlots()
        {
            DataTable dtPlot = null;
            SqlCommand spGetPlot = new SqlCommand("GetUnScheduledPlots", conn);
            spGetPlot.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();
                SqlDataAdapter sDa = new SqlDataAdapter(spGetPlot);
                dtPlot = new DataTable();
                sDa.Fill(dtPlot);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }
            return dtPlot;
        }

        /// <summary>
        /// Gets the jobs for a week for exporting to Excel
        /// </summary>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <returns></returns>
        public DataTable GetWeeklyJobsForExport(string dateFrom, string dateTo)
        {
            DataTable dtJobs = null;
            SqlCommand spGetWeeklyJobs = new SqlCommand("GetWeeklyScheduleForPrinting", conn);
            spGetWeeklyJobs.CommandType = System.Data.CommandType.StoredProcedure;
            spGetWeeklyJobs.Parameters.Add(
                new SqlParameter("@fromDate", dateFrom));
            spGetWeeklyJobs.Parameters.Add(
                new SqlParameter("@toDate", dateTo));

            try
            {
                conn.Open();
                SqlDataAdapter sDa = new SqlDataAdapter(spGetWeeklyJobs);
                dtJobs = new DataTable();
                sDa.Fill(dtJobs);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }
            return dtJobs;

        }


        public bool DeletePlot(int id)
        {
            bool isDeleted = true;
            SqlCommand spDel = new SqlCommand("DeletePlot", conn);
            spDel.CommandType = System.Data.CommandType.StoredProcedure;
            spDel.Parameters.Add(new SqlParameter("@PlotID", id));

            try
            {
                conn.Open();
                spDel.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                isDeleted = false;
            }
            finally
            {
                conn.Close();

            }
            return isDeleted;
        }

        #endregion

        #region Schedule
        public bool RecalculateSchedule(int weeklyHours, DateTime? fromDateTime)
        {
            bool recalcComplete = true;
            string formatteddtNow;
            if (fromDateTime == null)
            {
                DateTime dtNow = System.DateTime.Now.Date;
                formatteddtNow = String.Format("{0:yyyy/MM/dd}", dtNow);
            }
            else
            {
                formatteddtNow = String.Format("{0:yyyy/MM/dd}", (DateTime)fromDateTime);
            }
            SqlCommand spRecalc = new SqlCommand("RecalculateSchedule", conn);
            spRecalc.CommandType = System.Data.CommandType.StoredProcedure;
            spRecalc.Parameters.Add(
                new SqlParameter("@workingHours", weeklyHours));
            spRecalc.Parameters.Add(
                new SqlParameter("@weekStarting", formatteddtNow));

            try
            {
                conn.Open();
                spRecalc.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                recalcComplete = false;
            }
            finally
            {
                conn.Close();
            }

            return recalcComplete;
        }

        #endregion
    }
}

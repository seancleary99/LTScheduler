using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.Classes;

namespace DAL
{
    interface IDal
    {
        bool SaveErector(int id, string name);
        bool DeleteErector(int id);
        DataTable GetErector(int id);



        bool SaveHouseType(int id, string name);
        bool DeleteHouseType(int id);
        DataTable GetHouseType(int id);

        bool SaveCraneHire(int id, string craneName);
        bool DeleteCraneHire(int id);
        DataTable GetCraneHire(int id);

        bool SaveContractor(int id, string contractorName);
        bool DeleteContractor(int id);
        int SavePlot(int id, string plotName, int plotType, float lineTot, float floorTot, float benchTot);
        int SaveJobPlot(int jobPlotId, int plotId, int jobID, int houseType, int erectorId, int craneId, DateTime? prodDate, DateTime? onsiteDate, DateTime? completionDate);
        bool DeletePlot(int id);

        DataTable GetJobPlots(int JobPlotID);
        List<JobPlot> GetAllJobPlotsForJob(int jobId);
        DataTable GetUnsheduledPlots();

    }
}

using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.ICommunsService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.CommunsTable;

namespace CompetitionSystem.DAL.CommunsService
{
    public class ReportService : BaseService<Report>, IReportService
    {
        public ReportService() : base(new CompetitionSystemDB())
        {

        }
    }
}

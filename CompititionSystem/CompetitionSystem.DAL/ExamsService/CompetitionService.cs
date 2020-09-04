using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.IExamsService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.ExamsTable;

namespace CompetitionSystem.DAL.ExamsService
{
    public class CompetitionService : BaseService<Competition>, ICompetitionService
    {
        public CompetitionService() : base(new CompetitionSystemDB())
        {

        }
    }
}

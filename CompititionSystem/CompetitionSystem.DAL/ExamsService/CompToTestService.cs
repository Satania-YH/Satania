using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.IExamsService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.ExamsTable;

namespace CompetitionSystem.DAL.ExamsService
{
    public class CompToTestService : BaseService<CompToTest>, ICompToTestService
    {
        public CompToTestService() : base(new CompetitionSystemDB())
        {

        }
    }
}

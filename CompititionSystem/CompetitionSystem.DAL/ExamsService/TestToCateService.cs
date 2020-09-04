using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.IExamsService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.ExamsTable;

namespace CompetitionSystem.DAL.ExamsService
{
    public class TestToCateService : BaseService<TestToCate>, ITestToCateService
    {
        public TestToCateService() : base(new CompetitionSystemDB())
        {

        }
    }
}

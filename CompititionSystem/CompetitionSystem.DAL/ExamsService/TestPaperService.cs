using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.IExamsService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.ExamsTable;

namespace CompetitionSystem.DAL.ExamsService
{
    public class TestPaperService : BaseService<TestPaper>, ITestPaperService
    {
        public TestPaperService() : base(new CompetitionSystemDB())
        {

        }
    }
}

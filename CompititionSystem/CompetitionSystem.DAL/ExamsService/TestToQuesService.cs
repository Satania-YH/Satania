using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.IExamsService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.ExamsTable;

namespace CompetitionSystem.DAL.ExamsService
{
    public class TestToQuesService : BaseService<TestToQues>, ITestToQuesService
    {
        public TestToQuesService() : base(new CompetitionSystemDB())
        {

        }
    }
}

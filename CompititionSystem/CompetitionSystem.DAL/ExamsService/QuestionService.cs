using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.IExamsService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.ExamsTable;

namespace CompetitionSystem.DAL.ExamsService
{
    public class QuestionService : BaseService<Question>, IQuestionService
    {
        public QuestionService() : base(new CompetitionSystemDB())
        {

        }
    }
}

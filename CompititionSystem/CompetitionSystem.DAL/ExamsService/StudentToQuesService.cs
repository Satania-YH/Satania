using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.IExamsService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.ExamsTable;

namespace CompetitionSystem.DAL.ExamsService
{
    public class StudentToQuesService : BaseService<StudentToQues>, IStudentToQuesService
    {
        public StudentToQuesService() : base(new CompetitionSystemDB())
        {

        }
    }
}

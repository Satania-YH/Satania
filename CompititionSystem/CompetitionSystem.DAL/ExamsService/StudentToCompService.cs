using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.IExamsService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.ExamsTable;

namespace CompetitionSystem.DAL.ExamsService
{
    public class StudentToCompService : BaseService<StudentToComp>, IStudentToCompService
    {
        public StudentToCompService() : base(new CompetitionSystemDB())
        {

        }
    }
}

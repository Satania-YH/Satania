using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.IExamsService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.ExamsTable;

namespace CompetitionSystem.DAL.ExamsService
{
    public class StudentToTestService : BaseService<StudentToTest>, IStudentToTestService
    {
        public StudentToTestService() : base(new CompetitionSystemDB())
        {

        }
    }
}

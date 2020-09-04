using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.IUsersService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.UsersTable;

namespace CompetitionSystem.DAL.UsersService
{
    public class StudentService : BaseService<Student>, IStudentService
    {
        public StudentService() : base(new CompetitionSystemDB())
        {

        }
    }
}

using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.IUsersService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.UsersTable;

namespace CompetitionSystem.DAL.UsersService
{
    public class UserService : BaseService<User>, IUserService
    {
        public UserService() : base(new CompetitionSystemDB())
        {

        }
    }
}

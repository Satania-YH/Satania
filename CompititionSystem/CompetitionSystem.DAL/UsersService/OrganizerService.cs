using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.IUsersService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.UsersTable;

namespace CompetitionSystem.DAL.UsersService
{
    public class OrganizerService : BaseService<Organizer>, IOrganizerService
    {
        public OrganizerService() : base(new CompetitionSystemDB())
        {

        }
    }
}

using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.ICommunsService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.CommunsTable;

namespace CompetitionSystem.DAL.CommunsService
{
    public class JournalismService : BaseService<Journalism>, IJournalismService
    {
        public JournalismService() : base(new CompetitionSystemDB())
        {

        }
    }
}

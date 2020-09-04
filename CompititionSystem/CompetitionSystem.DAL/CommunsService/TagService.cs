using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.ICommunsService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.CommunsTable;

namespace CompetitionSystem.DAL.CommunsService
{
    public class TagService : BaseService<Tag>, ITagService
    {
        public TagService() : base(new CompetitionSystemDB())
        {

        }
    }
}

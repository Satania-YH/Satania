using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.ICommunsService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.CommunsTable;

namespace CompetitionSystem.DAL.CommunsService
{
    public class LikeService : BaseService<Like>, ILikeService
    {
        public LikeService() : base(new CompetitionSystemDB())
        {

        }
    }
}

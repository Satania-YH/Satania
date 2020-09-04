using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.ICommunsService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.CommunsTable;

namespace CompetitionSystem.DAL.CommunsService
{
    public class FavoriteService : BaseService<Favorite>, IFavoriteService
    {
        public FavoriteService() : base(new CompetitionSystemDB())
        {

        }
    }
}

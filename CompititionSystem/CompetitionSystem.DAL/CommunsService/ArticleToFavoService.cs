using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.ICommunsService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.CommunsTable;

namespace CompetitionSystem.DAL.CommunsService
{
    public class ArticleToFavoService : BaseService<ArticleToFavorite>, IArticleToFavoService
    {
        public ArticleToFavoService() : base(new CompetitionSystemDB())
        {

        }
    }
}

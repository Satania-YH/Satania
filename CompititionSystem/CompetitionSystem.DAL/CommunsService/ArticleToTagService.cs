using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.ICommunsService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.CommunsTable;

namespace CompetitionSystem.DAL.CommunsService
{
    public class ArticleToTagService : BaseService<ArticleToTag>, IArticleToTagService
    {
        public ArticleToTagService() : base(new CompetitionSystemDB())
        {

        }
    }
}

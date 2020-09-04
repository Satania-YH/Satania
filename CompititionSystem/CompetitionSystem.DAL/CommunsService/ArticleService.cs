using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.ICommunsService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.CommunsTable;
using System.Linq;

namespace CompetitionSystem.DAL.CommunsService
{
    public class ArticleService : BaseService<Article>, IArticleService
    {
        public ArticleService() : base(new CompetitionSystemDB())
        {

        }

        public IQueryable<Article> GetAllByPageOrderCollection(bool asc, int pageIndex, int pageSize)
        {
            return GetAllOrderCollection(asc).Skip(pageSize * pageIndex).Take(pageSize);
        }

        public IQueryable<Article> GetAllByPageOrderComment(bool asc, int pageIndex, int pageSize)
        {
            return GetAllOrderComment(asc).Skip(pageSize * pageIndex).Take(pageSize);
        }

        public IQueryable<Article> GetAllByPageOrderLike(bool asc, int pageIndex, int pageSize)
        {
            return GetAllOrderLike(asc).Skip(pageSize * pageIndex).Take(pageSize);
        }

        public IQueryable<Article> GetAllOrderCollection(bool asc)
        {
            var datas = GetAll();
            datas = asc ? datas.OrderBy(m => m.CollectionsNum) : datas.OrderByDescending(m => m.CollectionsNum);
            return datas;
        }

        public IQueryable<Article> GetAllOrderComment(bool asc)
        {
            var datas = GetAll();
            datas = asc ? datas.OrderBy(m => m.CommentsNum) : datas.OrderByDescending(m => m.CommentsNum);
            return datas;
        }

        public IQueryable<Article> GetAllOrderLike(bool asc)
        {
            var datas = GetAll();
            datas = asc ? datas.OrderBy(m => m.LikesNum) : datas.OrderByDescending(m => m.LikesNum);
            return datas;
        }
    }
}

using CompetitionSystem.IDAL.IBasesService;
using CompetitionSystem.Model.CommunsTable;
using System.Linq;

namespace CompetitionSystem.IDAL.ICommunsService
{
    public interface IArticleService : IBaseService<Article>
    {
        /// <summary>
        /// 获取点赞数、评论数、收藏数的排序后的序列
        /// </summary>
        /// <returns></returns>
        IQueryable<Article> GetAllOrderLike(bool asc);
        IQueryable<Article> GetAllByPageOrderLike(bool asc, int pageIndex, int pageSize);
        IQueryable<Article> GetAllOrderComment(bool asc);
        IQueryable<Article> GetAllByPageOrderComment(bool asc, int pageIndex, int pageSize);
        IQueryable<Article> GetAllOrderCollection(bool asc);
        IQueryable<Article> GetAllByPageOrderCollection(bool asc, int pageIndex, int pageSize);
    }
}

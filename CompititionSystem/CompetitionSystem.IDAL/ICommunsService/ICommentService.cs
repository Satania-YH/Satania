using CompetitionSystem.IDAL.IBasesService;
using CompetitionSystem.Model.CommunsTable;
using System.Linq;

namespace CompetitionSystem.IDAL.ICommunsService
{
    public interface ICommentService : IBaseService<Comment>
    {
        /// <summary>
        /// 获取点赞数的排序后的序列
        /// </summary>
        /// <returns></returns>
        IQueryable<Comment> GetAllOrderLike(bool asc);
        IQueryable<Comment> GetAllByPageOrderLike(bool asc, int pageIndex, int pageSize);
    }
}

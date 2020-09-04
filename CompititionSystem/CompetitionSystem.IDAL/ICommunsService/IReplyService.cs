using CompetitionSystem.IDAL.IBasesService;
using CompetitionSystem.Model.CommunsTable;
using System.Linq;

namespace CompetitionSystem.IDAL.ICommunsService
{
    public interface IReplyService : IBaseService<Reply>
    {
        // <summary>
        /// 获取点赞数的排序后的序列
        /// </summary>
        /// <returns></returns>
        IQueryable<Reply> GetAllOrderLike(bool asc);
        IQueryable<Reply> GetAllByPageOrderLike(bool asc, int pageIndex, int pageSize);
    }
}

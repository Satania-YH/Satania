using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.ICommunsService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.CommunsTable;
using System.Linq;

namespace CompetitionSystem.DAL.CommunsService
{
    public class ReplyService : BaseService<Reply>, IReplyService
    {
        public ReplyService() : base(new CompetitionSystemDB())
        {

        }

        public IQueryable<Reply> GetAllByPageOrderLike(bool asc, int pageIndex, int pageSize)
        {
            return GetAllOrderLike(asc).Skip(pageSize * pageIndex).Take(pageSize);
        }

        public IQueryable<Reply> GetAllOrderLike(bool asc)
        {
            var datas = GetAll();
            datas = asc ? datas.OrderBy(m => m.LikesNum) : datas.OrderByDescending(m => m.LikesNum);
            return datas;
        }
    }
}

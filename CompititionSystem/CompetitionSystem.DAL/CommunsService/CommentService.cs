using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.ICommunsService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.CommunsTable;
using System.Linq;

namespace CompetitionSystem.DAL.CommunsService
{
    public class CommentService : BaseService<Comment>, ICommentService
    {
        public CommentService() : base(new CompetitionSystemDB())
        {

        }

        public IQueryable<Comment> GetAllByPageOrderLike(bool asc, int pageIndex, int pageSize)
        {
            return GetAllOrderLike(asc).Skip(pageSize * pageIndex).Take(pageSize);
        }

        public IQueryable<Comment> GetAllOrderLike(bool asc)
        {
            var datas = GetAll();
            datas = asc ? datas.OrderBy(m => m.LikesNum) : datas.OrderByDescending(m => m.LikesNum);
            return datas;
        }
    }
}

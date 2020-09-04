using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.ICommunsService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.CommunsTable;

namespace CompetitionSystem.DAL.CommunsService
{
    public class NoticeToUserService : BaseService<NoticeToUser>, INoticeToUserService
    {
        public NoticeToUserService() : base(new CompetitionSystemDB())
        {

        }
    }
}

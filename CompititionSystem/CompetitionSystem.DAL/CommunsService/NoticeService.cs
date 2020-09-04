using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.ICommunsService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.CommunsTable;

namespace CompetitionSystem.DAL.CommunsService
{
    public class NoticeService : BaseService<Notice>, INoticeService
    {
        public NoticeService() : base(new CompetitionSystemDB())
        {

        }
    }
}

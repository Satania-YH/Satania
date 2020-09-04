using CompetitionSystem.DAL.BasesService;
using CompetitionSystem.IDAL.IExamsService;
using CompetitionSystem.Model;
using CompetitionSystem.Model.ExamsTable;

namespace CompetitionSystem.DAL.ExamsService
{
    public class QuesToCateService : BaseService<QuesToCate>, IQuesToCateService
    {
        public QuesToCateService() : base(new CompetitionSystemDB())
        {

        }
    }
}

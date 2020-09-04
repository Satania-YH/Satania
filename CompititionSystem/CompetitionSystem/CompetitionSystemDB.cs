using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CompetitionSystem
{
    public class CompetitionSystemDB : DbContext
    {
        public CompetitionSystemDB()
            : base("con")
        {
            Database.SetInitializer<CompetitionSystemDB>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //消除数据库一对多、多对多的级联删除关系
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
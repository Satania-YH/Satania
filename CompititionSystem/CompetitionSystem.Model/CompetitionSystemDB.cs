using CompetitionSystem.Model.CommunsTable;
using CompetitionSystem.Model.ExamsTable;
using CompetitionSystem.Model.UsersTable;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CompetitionSystem.Model
{
    /// <summary>
    /// enable-migrations
    /// add-migration 'CreateContest'
    /// update-database
    /// </summary>
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

        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Organizer> Organizers { get; set; }

        public DbSet<Competition> Competitions { get; set; }
        public DbSet<CompToTest> CompToTests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<StudentToComp> StudentToComps { get; set; }
        public DbSet<StudentToQues> StudentToQues { get; set; }
        public DbSet<StudentToTest> StudentToTests { get; set; }
        public DbSet<TestPaper> TestPapers { get; set; }
        public DbSet<TestToCate> TestToCates { get; set; }
        public DbSet<TestToQues> TestToQues { get; set; }
        public DbSet<QuesToCate> QuesToCates { get; set; }

        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleToFavorite> ArticleToFavorites { get; set; }
        public DbSet<ArticleToTag> ArticleToTags { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Journalism> Journalisms { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<NoticeToUser> NoticeToUsers { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}
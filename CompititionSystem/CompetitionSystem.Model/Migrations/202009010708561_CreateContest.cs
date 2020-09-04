namespace CompetitionSystem.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateContest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(nullable: false, maxLength: 40),
                        Content = c.String(nullable: false, storeType: "ntext"),
                        IsPublic = c.Boolean(nullable: false),
                        UserId = c.Guid(nullable: false),
                        ReadsNum = c.Int(nullable: false),
                        LikesNum = c.Int(nullable: false),
                        CommentsNum = c.Int(nullable: false),
                        CollectionsNum = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ArticleToFavorites",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        FavoriteId = c.Guid(nullable: false),
                        TargetId = c.Guid(nullable: false),
                        TargetType = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ArticleToTags",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ArticleId = c.Guid(nullable: false),
                        TagId = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ArticleId = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        ImagePath = c.String(nullable: false, maxLength: 400),
                        NickName = c.String(nullable: false, maxLength: 40),
                        Content = c.String(nullable: false, maxLength: 800),
                        LikesNum = c.Int(nullable: false),
                        IsRead = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Competitions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CompetitionName = c.String(nullable: false, maxLength: 80),
                        UserId = c.Guid(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        Rule = c.String(nullable: false, storeType: "ntext"),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        MaxPeople = c.Int(nullable: false),
                        Cover = c.String(maxLength: 400),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CompToTests",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CompetitionId = c.Guid(nullable: false),
                        TestPaperId = c.Guid(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        Duration = c.DateTime(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Favorites",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CategoryName = c.String(nullable: false, maxLength: 40),
                        UserId = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Journalism",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(nullable: false, maxLength: 40),
                        Content = c.String(nullable: false, storeType: "ntext"),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Likes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        TargetId = c.Guid(nullable: false),
                        TargetUserId = c.Guid(nullable: false),
                        TargetType = c.Int(nullable: false),
                        IsRead = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Notices",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        Content = c.String(nullable: false, maxLength: 800),
                        ImagePath = c.String(maxLength: 400),
                        NickName = c.String(maxLength: 40),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NoticeToUsers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NoticeId = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        IsRead = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Organizers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        Contact = c.String(maxLength: 200),
                        Profile = c.String(maxLength: 400),
                        IsProcess = c.Boolean(nullable: false),
                        ProcessingName = c.String(maxLength: 80),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Email = c.String(nullable: false, maxLength: 32, unicode: false),
                        Password = c.String(nullable: false, maxLength: 32, unicode: false),
                        UserType = c.String(nullable: false, maxLength: 40),
                        ImagePath = c.String(nullable: false, maxLength: 400),
                        NickName = c.String(nullable: false, maxLength: 40),
                        IsLogin = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Content = c.String(nullable: false, storeType: "ntext"),
                        Answer = c.String(nullable: false, maxLength: 400),
                        QuestionType = c.Int(nullable: false),
                        Difficulty = c.Int(nullable: false),
                        A_Option = c.String(maxLength: 200),
                        B_Option = c.String(maxLength: 200),
                        C_Option = c.String(maxLength: 200),
                        D_Option = c.String(maxLength: 200),
                        Analysis = c.String(storeType: "ntext"),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.QuesToCates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        QuestionId = c.Guid(nullable: false),
                        CategoryId = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Replies",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CommentId = c.Guid(nullable: false),
                        ReplyId = c.Guid(nullable: false),
                        ReplyType = c.Int(nullable: false),
                        Content = c.String(nullable: false, maxLength: 800),
                        FromUserId = c.Guid(nullable: false),
                        ImagePath = c.String(nullable: false, maxLength: 400),
                        NickName = c.String(nullable: false, maxLength: 40),
                        ToUserId = c.Guid(nullable: false),
                        LikesNum = c.Int(nullable: false),
                        IsRead = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        TargetId = c.Guid(nullable: false),
                        TargetUserId = c.Guid(nullable: false),
                        Reason = c.String(nullable: false, maxLength: 400),
                        IsRead = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        TrueName = c.String(maxLength: 20),
                        Sex = c.Boolean(nullable: false),
                        School = c.String(maxLength: 40),
                        Academy = c.String(maxLength: 40),
                        Class = c.String(maxLength: 40),
                        StudentID = c.String(maxLength: 40),
                        Contact = c.String(maxLength: 200),
                        Profile = c.String(maxLength: 400),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.StudentToComps",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        CompetitionId = c.Guid(nullable: false),
                        IsSigned = c.Boolean(nullable: false),
                        Grade = c.Int(nullable: false),
                        Ranking = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentToQues",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        QuestionId = c.Guid(nullable: false),
                        TestPaperId = c.Guid(nullable: false),
                        YourAnswer = c.String(nullable: false, maxLength: 400),
                        TrueAnswer = c.String(nullable: false, maxLength: 400),
                        IsTrue = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentToTests",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        TestPaperId = c.Guid(nullable: false),
                        Grade = c.Int(nullable: false),
                        Ranking = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TagName = c.String(nullable: false, maxLength: 40),
                        TagType = c.Int(nullable: false),
                        ParentTagId = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TestPapers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TestName = c.String(nullable: false, maxLength: 80),
                        UserId = c.Guid(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        TotalGrade = c.Int(nullable: false),
                        TotalNum = c.Int(nullable: false),
                        OneChoiceGrade = c.Int(nullable: false),
                        OneChoiceNum = c.Int(nullable: false),
                        ManyChoiceGrade = c.Int(nullable: false),
                        ManyChoiceNum = c.Int(nullable: false),
                        CompletionGrade = c.Int(nullable: false),
                        CompletionNum = c.Int(nullable: false),
                        JudgeGrade = c.Int(nullable: false),
                        JudgeNum = c.Int(nullable: false),
                        Explain = c.String(maxLength: 400),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TestToCates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TestPaperId = c.Guid(nullable: false),
                        CategoryId = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TestToQues",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TestPaperId = c.Guid(nullable: false),
                        QuestionId = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        EditTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "UserId", "dbo.Users");
            DropForeignKey("dbo.Organizers", "UserId", "dbo.Users");
            DropIndex("dbo.Students", new[] { "UserId" });
            DropIndex("dbo.Organizers", new[] { "UserId" });
            DropTable("dbo.TestToQues");
            DropTable("dbo.TestToCates");
            DropTable("dbo.TestPapers");
            DropTable("dbo.Tags");
            DropTable("dbo.StudentToTests");
            DropTable("dbo.StudentToQues");
            DropTable("dbo.StudentToComps");
            DropTable("dbo.Students");
            DropTable("dbo.Reports");
            DropTable("dbo.Replies");
            DropTable("dbo.QuesToCates");
            DropTable("dbo.Questions");
            DropTable("dbo.Users");
            DropTable("dbo.Organizers");
            DropTable("dbo.NoticeToUsers");
            DropTable("dbo.Notices");
            DropTable("dbo.Likes");
            DropTable("dbo.Journalism");
            DropTable("dbo.Favorites");
            DropTable("dbo.CompToTests");
            DropTable("dbo.Competitions");
            DropTable("dbo.Comments");
            DropTable("dbo.ArticleToTags");
            DropTable("dbo.ArticleToFavorites");
            DropTable("dbo.Articles");
        }
    }
}

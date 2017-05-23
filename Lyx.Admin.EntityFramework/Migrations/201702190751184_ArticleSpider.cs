namespace Lyx.Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ArticleSpider : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Spider_Novel",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Author = c.String(),
                        Category = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ArticleSpiders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        Novel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Spider_Novel", t => t.Novel_Id)
                .Index(t => t.Novel_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArticleSpiders", "Novel_Id", "dbo.Spider_Novel");
            DropIndex("dbo.ArticleSpiders", new[] { "Novel_Id" });
            DropTable("dbo.ArticleSpiders");
            DropTable("dbo.Spider_Novel");
        }
    }
}

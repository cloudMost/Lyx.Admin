namespace Lyx.Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ArticleSpider1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ArticleSpiders", newName: "Spider_Article");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Spider_Article", newName: "ArticleSpiders");
        }
    }
}

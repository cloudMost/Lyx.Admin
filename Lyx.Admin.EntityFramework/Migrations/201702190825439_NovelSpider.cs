namespace Lyx.Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NovelSpider : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Spider_Novel", "IsOver", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Spider_Novel", "IsOver");
        }
    }
}

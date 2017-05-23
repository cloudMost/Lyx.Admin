namespace Lyx.Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InterFruit1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TaoJin_InterFruit", "Order");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TaoJin_InterFruit", "Order", c => c.Int(nullable: false));
        }
    }
}

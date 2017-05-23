namespace Lyx.Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fruit3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TaoJin_Fruit", "Order", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TaoJin_Fruit", "Order");
        }
    }
}

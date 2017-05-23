namespace Lyx.Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InterFruit2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TaoJin_InterFruit", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.TaoJin_InterFruit", "CurrPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TaoJin_InterFruit", "CurrPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.TaoJin_InterFruit", "Price");
        }
    }
}

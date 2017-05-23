namespace Lyx.Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InterFruit3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TaoJin_InterFruit", "IncreaseRate", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.TaoJin_InterFruit", "Increase", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.TaoJin_InterFruit", "OpenPrice", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.TaoJin_InterFruit", "HighestPrice", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.TaoJin_InterFruit", "LowestPrice", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.TaoJin_InterFruit", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 6));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TaoJin_InterFruit", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.TaoJin_InterFruit", "LowestPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.TaoJin_InterFruit", "HighestPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.TaoJin_InterFruit", "OpenPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.TaoJin_InterFruit", "Increase", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.TaoJin_InterFruit", "IncreaseRate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}

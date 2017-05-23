namespace Lyx.Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InterFruit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaoJin_InterFruit",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductCode = c.String(),
                        IncreaseRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Increase = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OpenPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HighestPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LowestPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CurrPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Volume = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Order = c.Int(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TaoJin_InterFruit");
        }
    }
}

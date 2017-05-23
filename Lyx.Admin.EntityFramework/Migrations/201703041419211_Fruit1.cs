namespace Lyx.Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fruit1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaoJin_Fruit",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FruitName = c.String(),
                        ImageUrl = c.String(),
                        CurrPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Volume = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TaoJin_Fruit");
        }
    }
}

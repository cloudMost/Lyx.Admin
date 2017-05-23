namespace Lyx.Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fruit2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TaoJin_Fruit", "FruitCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TaoJin_Fruit", "FruitCode");
        }
    }
}

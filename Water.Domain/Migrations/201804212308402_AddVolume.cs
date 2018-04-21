namespace Water.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVolume : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "Volume", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "Volume");
        }
    }
}

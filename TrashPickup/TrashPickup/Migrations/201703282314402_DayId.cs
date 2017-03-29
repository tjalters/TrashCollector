namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DayId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DayId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "DayId");
        }
    }
}

namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Day : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Days",
                c => new
                    {
                        DayId = c.Int(nullable: false, identity: true),
                        DayOfWeek = c.String(),
                    })
                .PrimaryKey(t => t.DayId);
            
            CreateTable(
                "dbo.Weeks",
                c => new
                    {
                        WeekId = c.Int(nullable: false, identity: true),
                        WeekOf = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.WeekId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Weeks");
            DropTable("dbo.Days");
        }
    }
}

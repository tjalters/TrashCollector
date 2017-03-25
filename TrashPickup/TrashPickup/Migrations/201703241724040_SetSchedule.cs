namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetSchedule : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SetWeeklySchedules",
                c => new
                    {
                        ScheduleId = c.Int(nullable: false, identity: true),
                        week = c.Int(nullable: false),
                        day = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ScheduleId)
                .ForeignKey("dbo.Days", t => t.day, cascadeDelete: true)
                .ForeignKey("dbo.Weeks", t => t.week, cascadeDelete: true)
                .Index(t => t.week)
                .Index(t => t.day);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SetWeeklySchedules", "week", "dbo.Weeks");
            DropForeignKey("dbo.SetWeeklySchedules", "day", "dbo.Days");
            DropIndex("dbo.SetWeeklySchedules", new[] { "day" });
            DropIndex("dbo.SetWeeklySchedules", new[] { "week" });
            DropTable("dbo.SetWeeklySchedules");
        }
    }
}

namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedModels : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.SetWeeklySchedules");
            DropColumn("dbo.SetWeeklySchedules", "ScheduleId");
            RenameColumn(table: "dbo.SetWeeklySchedules", name: "day", newName: "DayId");
            RenameIndex(table: "dbo.SetWeeklySchedules", name: "IX_day", newName: "IX_DayId");
            AddColumn("dbo.SetWeeklySchedules", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.SetWeeklySchedules", "Id");
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.SetWeeklySchedules", "ScheduleId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.SetWeeklySchedules");
            DropColumn("dbo.SetWeeklySchedules", "Id");
            AddPrimaryKey("dbo.SetWeeklySchedules", "ScheduleId");
            RenameIndex(table: "dbo.SetWeeklySchedules", name: "IX_DayId", newName: "IX_day");
            RenameColumn(table: "dbo.SetWeeklySchedules", name: "DayId", newName: "day");
        }
    }
}

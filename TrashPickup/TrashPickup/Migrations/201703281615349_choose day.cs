namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chooseday : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChooseDays",
                c => new
                    {
                        ChooseDayId = c.Int(nullable: false, identity: true),
                        DayId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ChooseDayId)
                .ForeignKey("dbo.Days", t => t.DayId, cascadeDelete: true)
                .Index(t => t.DayId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChooseDays", "DayId", "dbo.Days");
            DropIndex("dbo.ChooseDays", new[] { "DayId" });
            DropTable("dbo.ChooseDays");
        }
    }
}

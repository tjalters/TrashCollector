namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RegisterViewModels", "Username", c => c.String());
            DropColumn("dbo.RegisterViewModels", "UserRoles");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RegisterViewModels", "UserRoles", c => c.String(nullable: false));
            AlterColumn("dbo.RegisterViewModels", "Username", c => c.String(nullable: false));
        }
    }
}

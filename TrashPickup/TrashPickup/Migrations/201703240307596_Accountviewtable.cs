namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Accountviewtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegisterViewModels",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        UserRoles = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        PhoneNumber = c.Double(nullable: false),
                        Address = c.String(nullable: false),
                        City = c.String(nullable: false),
                        ZipCode = c.Int(nullable: false),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 100),
                        ConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.Email);
            
            DropTable("dbo.Customers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        MembershipTypeId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.RegisterViewModels");
        }
    }
}

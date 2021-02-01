namespace JohannasApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        Price = c.Single(nullable: false),
                        User_Username = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExpensesCategories", t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Username)
                .Index(t => t.Id)
                .Index(t => t.User_Username);
            
            CreateTable(
                "dbo.ExpensesCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Expenses", "User_Username", "dbo.Users");
            DropForeignKey("dbo.Expenses", "Id", "dbo.ExpensesCategories");
            DropIndex("dbo.Expenses", new[] { "User_Username" });
            DropIndex("dbo.Expenses", new[] { "Id" });
            DropTable("dbo.Users");
            DropTable("dbo.ExpensesCategories");
            DropTable("dbo.Expenses");
        }
    }
}

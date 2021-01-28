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
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Single(nullable: false),
                        User_UserName = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_UserName)
                .Index(t => t.User_UserName);
            
            CreateTable(
                "dbo.ExpensesCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Expenses_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Expenses", t => t.Expenses_Id)
                .Index(t => t.Expenses_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Expenses", "User_UserName", "dbo.Users");
            DropForeignKey("dbo.ExpensesCategories", "Expenses_Id", "dbo.Expenses");
            DropIndex("dbo.ExpensesCategories", new[] { "Expenses_Id" });
            DropIndex("dbo.Expenses", new[] { "User_UserName" });
            DropTable("dbo.Users");
            DropTable("dbo.ExpensesCategories");
            DropTable("dbo.Expenses");
        }
    }
}

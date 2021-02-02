namespace JohannasApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        id = c.Int(nullable: false),
                        name = c.String(),
                        price = c.Single(nullable: false),
                        user_username = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.ExpensesCategories", t => t.id)
                .ForeignKey("dbo.Users", t => t.user_username)
                .Index(t => t.id)
                .Index(t => t.user_username);
            
            CreateTable(
                "dbo.ExpensesCategories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        username = c.String(nullable: false, maxLength: 128),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Expenses", "user_username", "dbo.Users");
            DropForeignKey("dbo.Expenses", "id", "dbo.ExpensesCategories");
            DropIndex("dbo.Expenses", new[] { "user_username" });
            DropIndex("dbo.Expenses", new[] { "id" });
            DropTable("dbo.Users");
            DropTable("dbo.ExpensesCategories");
            DropTable("dbo.Expenses");
        }
    }
}

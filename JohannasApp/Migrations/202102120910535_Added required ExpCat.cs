namespace JohannasApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedrequiredExpCat : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Expenses", "expensesCategories_id", "dbo.ExpensesCategories");
            DropIndex("dbo.Expenses", new[] { "expensesCategories_id" });
            AlterColumn("dbo.Expenses", "expensesCategories_id", c => c.Int(nullable: false));
            CreateIndex("dbo.Expenses", "expensesCategories_id");
            AddForeignKey("dbo.Expenses", "expensesCategories_id", "dbo.ExpensesCategories", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Expenses", "expensesCategories_id", "dbo.ExpensesCategories");
            DropIndex("dbo.Expenses", new[] { "expensesCategories_id" });
            AlterColumn("dbo.Expenses", "expensesCategories_id", c => c.Int());
            CreateIndex("dbo.Expenses", "expensesCategories_id");
            AddForeignKey("dbo.Expenses", "expensesCategories_id", "dbo.ExpensesCategories", "id");
        }
    }
}

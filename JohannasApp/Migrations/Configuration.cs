namespace JohannasApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<JohannasApp.JohannaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(JohannasApp.JohannaContext context)
        {
            context.Users.AddOrUpdate(new Models.User 
            { 
                Username = "andreas@hideblad.se", 
                Password = "11223344" 
            });
            
            context.ExpensesCategories.AddOrUpdate(new Models.ExpensesCategory 
            { 
                Id = 1, 
                Name = "Mat"
            });
            
            context.Expenses.AddOrUpdate(new Models.Expenses
            {
                Id = 1,
                Name = "ICA",
                Price = 200,
                ExpensesCategories = new Models.ExpensesCategory() { Id = 1 }
                
            });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}

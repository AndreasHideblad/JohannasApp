namespace JohannasApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using JohannasApp.Managers;
    using JohannasApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<JohannasApp.JohannaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(JohannaContext context)
        {
            //var Food = new ExpensesCategory { id = 1, name = "Food" };
            //var Transport = new ExpensesCategory { id = 2, name = "Transport" };
            //var Entertainment = new ExpensesCategory { id = 3, name = "Entertainment" };
            //context.ExpensesCategories.AddOrUpdate(Food, Transport, Entertainment);

            //var ICA = new Expenses { id = 1, name = "ICA", price = 200, new ExpensesCategories() { 1 } };
            //context.Expenses.AddOrUpdate(ICA);

            //context.Users.AddOrUpdate(new User 
            //{ 
            //    username = "andreas@hideblad.se", 
            //    password = "11223344" 
            //});

            //context.Expenses.AddOrUpdate(new Expenses
            //{
            //    id = 1,
            //    name = "ica",
            //    price = 200,
            //    expensesCategories = ExpensesCategoryManager.Instance.GetExpensesCategoryById(1)
            //});

            //context.ExpensesCategories.AddOrUpdate(new ExpensesCategory
            //{
            //    id = 1,
            //    name = "Mat"
            //});

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}

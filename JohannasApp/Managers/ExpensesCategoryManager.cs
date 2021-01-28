using JohannasApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JohannasApp.Managers
{
    public class ExpensesCategoryManager
    {
        public ExpensesCategory GetExpensesCategoryById(string id)
        {
            using (var db = new JohannaContext())
            {
                var expensesCategory = db.ExpensesCategories.Find(id);
                return expensesCategory;
            }
        }

        public void CreateExpensesCategory(ExpensesCategory expensesCategory)
        {
            using (var db = new JohannaContext())
            {
                db.ExpensesCategories.Add(expensesCategory);
                db.SaveChanges();
            }
        }
    }
}
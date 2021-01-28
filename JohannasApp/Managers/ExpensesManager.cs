using JohannasApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JohannasApp.Managers
{
    public class ExpensesManager
    {
        public Expenses GetExpensesById(string id)
        {
            using (var db = new JohannaContext())
            {
                var expenses = db.Expenses.Find(id);
                return expenses;
            }
        }

        public void CreateExpenses(Expenses expenses)
        {
            using (var db = new JohannaContext())
            {
                db.Expenses.Add(expenses);
                db.SaveChanges();
            }
        }
    }
}
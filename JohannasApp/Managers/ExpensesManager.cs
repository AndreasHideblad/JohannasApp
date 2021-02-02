using JohannasApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace JohannasApp.Managers
{
    public class ExpensesManager
    {
        private static ExpensesManager _instance;
        public static ExpensesManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ExpensesManager();
                return _instance;
            }
        }
        private ExpensesManager() { }

        public Expenses GetExpensesById(int id)
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
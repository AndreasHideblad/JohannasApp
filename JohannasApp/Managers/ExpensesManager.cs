using JohannasApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
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

        public List<Expenses> GetExpenses()
        {
            using (var db = new JohannaContext())
            {
                var expenses = db.Expenses.Include(e => e.expensesCategories).ToList();
                //var expenses = db.Expenses.ToList();
                return expenses;
            }
        }

        public void CreateExpenses(Expenses expenses)
        {
            using (var db = new JohannaContext())
            {
                var category = db.ExpensesCategories.FirstOrDefault(e => e.name == expenses.expensesCategories.name);
                if (category != null)
                {
                    expenses.expensesCategories = category;
                }
                db.Expenses.AddOrUpdate(expenses);
                db.SaveChanges();
            }        
        }
    }
}
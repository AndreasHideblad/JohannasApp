﻿using JohannasApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JohannasApp.Managers
{
    public class ExpensesCategoryManager
    {
        private static ExpensesCategoryManager _instance;
        public static ExpensesCategoryManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ExpensesCategoryManager();
                return _instance;
            }
        }
        private ExpensesCategoryManager() { }

        public ExpensesCategory GetExpensesCategoryById(int id)
        {
            using (var db = new JohannaContext())
            {
                var expensesCategory = db.ExpensesCategories.Find(id);
                return expensesCategory;
            }
        }

        //public IList<ExpensesCategory> GetExpensesCategoryById(int id)
        //{
        //    IList<ExpensesCategory> expensesCategories = null;

        //    using (var db = new JohannaContext())
        //    {
        //        expensesCategories = db.ExpensesCategories.Select(s => new ExpensesCategory()
        //        {
        //            id = s.id
        //        }).ToList<ExpensesCategory>();
        //    }
        //    return expensesCategories;
        //}

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
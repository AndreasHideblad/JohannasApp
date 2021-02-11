using JohannasApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JohannasApp.Managers
{
    public class IncomeManager
    {
        private static IncomeManager _instance;
        public static IncomeManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new IncomeManager();
                return _instance;
            }
        }
        private IncomeManager() { }

        public Income GetIncomeById(int id)
        {
            using (var db = new JohannaContext())
            {
                var income = db.Incomes.Find(id);
                return income;
            }
        }

        public void CreateIncome(Income incomes)
        {
            using (var db = new JohannaContext())
            {
                db.Incomes.Add(incomes);
                db.SaveChanges();
            }
        }
    }
}
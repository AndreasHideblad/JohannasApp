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

        public List<Income> GetIncome()
        {
            using (var db = new JohannaContext())
            {
                var incomes= db.Incomes.ToList();
                return incomes;
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
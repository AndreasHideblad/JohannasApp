﻿using JohannasApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JohannasApp
{
    public class JohannaContext : DbContext
    {
        public JohannaContext() : base("name=JohannasApp")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Expenses> Expenses { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<ExpensesCategory> ExpensesCategories { get; set; }
    }
}
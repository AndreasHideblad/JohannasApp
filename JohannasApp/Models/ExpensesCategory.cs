using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JohannasApp.Models
{
    public class ExpensesCategory
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public virtual Expenses expenses { get; set; }
    }
}
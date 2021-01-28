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
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Expenses Expenses { get; set; }
    }
}
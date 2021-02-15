using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JohannasApp.Models
{
    public class Expenses
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        [Required]
        public virtual ExpensesCategory expensesCategories { get; set; }
        public virtual User user { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JohannasApp.Models
{
    public class Expenses
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        [Required]
        public virtual ExpensesCategory ExpensesCategories { get; set; }
        public virtual User User { get; set; }
    }
}
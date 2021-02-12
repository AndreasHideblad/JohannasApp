using Newtonsoft.Json;
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
        [JsonIgnore]
        public virtual ICollection<Expenses> expenses { get; set; }
    }
}
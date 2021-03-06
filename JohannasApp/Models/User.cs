﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JohannasApp.Models
{
    public class User
    {
        [Key]
        public string username { get; set; }
        public string password { get; set; }
        public virtual ICollection<Expenses> expenses { get; set; }

    }
}
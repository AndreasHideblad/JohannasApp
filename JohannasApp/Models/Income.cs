﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JohannasApp.Models
{
    public class Income
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
    }
}
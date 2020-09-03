﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Patisserie.Models
{
    public class Order
    {
        [Key, ForeignKey("Account"), Column(Order=0)]
        public int AccountID { get; set; }
        public Account Account { get; set; }

        [Key, ForeignKey("Product"), Column(Order = 1)]
        public int ProductID { get; set; }
        public Product Product { get; set; }

        //Amount of each item 
        public int Amount { get; set; }
    }
}
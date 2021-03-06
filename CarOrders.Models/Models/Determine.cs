﻿using CarOrders.Models.BaseTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOrders.Models.Models
{
    public class Determine : BaseDictionary
    {
        public ICollection<Order> Orders { get; set; }

        public Determine()
        {
            Orders = new List<Order>();
            AuditDate = DateTime.Now;
        }
    }
}

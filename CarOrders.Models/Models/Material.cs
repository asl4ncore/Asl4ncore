﻿using CarOrders.Models.BaseTables;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarOrders.Models.Models
{
    public class Material : BaseDictionary
    {
        public ICollection<Order> Orders { get; set; }
        [Display(Name = "Тип работ")]
        public int ProviderId { get; set; }
        public Provider Provider { get; set; }

        public Material()
        {
            Orders = new List<Order>();
        }
    }
}
using CarOrders.Models.BaseTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOrders.Models.Models
{
    public class Machine : BaseDictionary
    {
        public string Type { get; set; }
        public string Driver { get; set; }
        public string Manufactor { get; set; }
        public ICollection<Order> Orders { get; set; }

        public Machine()
        {
            Orders = new List<Order>();
        }

    }
}

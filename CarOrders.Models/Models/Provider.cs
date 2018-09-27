using CarOrders.Models.BaseTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOrders.Models.Models
{
    public class Provider : BaseDictionary
    {
        public string ProviderCountry { get; set; }
        public ICollection<Material> Materials { get; }

        public Provider()
        {
            Materials = new List<Material>();
        }
    }
}

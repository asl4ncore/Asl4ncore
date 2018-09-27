using CarOrders.Models.BaseTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarOrders.Models.Models
{
    public class Weigh : BaseTable
    {
        [Display(Name = "Весоизмерение")]
        public int WeighFull { get; set; }
        [Display(Name = "Вес упаковки")]
        public double? WeighPacking { get; set; }
        [Display(Name = "Вес материала(нетто)")]
        public double? WeighMaterial { get; set; }
        [Display(Name = "Тип")]
        public bool WeighType { get; set; }
        [Display(Name = "Определение тары")]
        public bool WeighDetermine { get; set; }
        [Display(Name = "Загрезненость")]
        public int WeighContamination { get; set; }
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
    }
}

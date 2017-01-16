using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaTomasos.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalCost { get; set; }
        public bool Delivered { get; set; }
        public int CustomerId { get; set; }
    }
}

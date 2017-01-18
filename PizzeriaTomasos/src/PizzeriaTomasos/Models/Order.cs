using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaTomasos.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalCost { get; set; }
        public bool Delivered { get; set; }
        public Customer Customer { get; set; }
    }
}

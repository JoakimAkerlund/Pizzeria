using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaTomasos.Models
{
    public class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int Quantity { get; set; }
        public Dish Dish { get; set; }
        public Order Order { get; set; }
    }
}

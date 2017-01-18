using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaTomasos.Models
{
    
    public class DishCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<Dish> Dishes { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaTomasos.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string DishName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DishCategory DishCategory { get; set; }
        public List<DishIngredients> DishIngridients { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaTomasos.Models
{
    public class DishIngredients
    {
        public int Id { get; set; }
        public Ingredient Ingridient { get; set; }
        public virtual Dish Dish { get; set; }
    }
}

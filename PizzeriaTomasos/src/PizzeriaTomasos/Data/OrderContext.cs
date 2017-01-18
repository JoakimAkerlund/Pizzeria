using Microsoft.EntityFrameworkCore;
using PizzeriaTomasos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaTomasos.Data
{
    public class OrderContext:DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options )
            : base(options)
        {}
        public DbSet<Order> Order { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Dish> Dish { get; set; }
        public DbSet<DishCategory> DishCategory { get; set; }
        public DbSet<DishIngredients> DishIngredients { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
    }
}

using PizzeriaTomasos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaTomasos.Data
{
    public class DbInitializer
    {
        public static void Initialize(OrderContext context)
        {
            context.Database.EnsureCreated();
            if (context.Dish.Any())
            {
                return;
            }

            var PizzaCategory = new DishCategory() { CategoryName = "Pizza" };
            var SaladCategory = new DishCategory() { CategoryName = "Sallad" };
            var KebabCategory = new DishCategory() { CategoryName = "Kebab" };
            var PastaCategory = new DishCategory() { CategoryName = "Pasta" };

            var Capricciosa = new Dish() { DishName = "Capricciosa",DishCategory=PizzaCategory,Price=70,Description="" };
            var Ceasarsallad = new Dish() { DishName = "Ceasar sallad", DishCategory = SaladCategory, Price = 65, Description = "" };
            var KebabPlate = new Dish() { DishName = "Kebabtallrik", DishCategory = KebabCategory, Price = 75, Description = "" };
            var SpaghettiBolognese = new Dish() { DishName = "Spaghetti Bolognese", DishCategory = PastaCategory, Price = 70, Description = "" };

            var tomatosauce = new Ingredient() { IngredientName = "Tomatsås" };
            var ham = new Ingredient() { IngredientName = "Skinka" };
            var cheese = new Ingredient() { IngredientName = "Ost" };
            var mushrooms = new Ingredient() { IngredientName = "Champinjoner" };
            var chicken = new Ingredient() { IngredientName="Kyckling"};
            var onion = new Ingredient() { IngredientName = "Onion" };
            var croutons = new Ingredient() { IngredientName = "Krutonger" };
            var tomatoes = new Ingredient() { IngredientName = "Tomater" };
            var bacon = new Ingredient() { IngredientName = "Bacon" };
            var salad = new Ingredient() { IngredientName = "Sallad" };
            var FrenchFries = new Ingredient() { IngredientName = "Pommes frites" };
            var kebabMeat = new Ingredient() { IngredientName = "Kebab kött" };
            var garlicSauce = new Ingredient() { IngredientName = "Vitlökssås" };
            var mincedMeat = new Ingredient() { IngredientName = "Köttfärs" };
            var PastaIngredient = new Ingredient() { IngredientName = "Pasta" };
            var garlic = new Ingredient() { IngredientName = "Vitlök" };

            var dishIngredientsList = new List<DishIngredients>() {
            new DishIngredients { Dish = Capricciosa, Ingridient = tomatosauce },
            new DishIngredients { Dish = Capricciosa, Ingridient = ham },
            new DishIngredients { Dish = Capricciosa, Ingridient = cheese },
            new DishIngredients { Dish = Capricciosa, Ingridient = mushrooms },

            new DishIngredients {Dish=Ceasarsallad,Ingridient=chicken },
            new DishIngredients {Dish=Ceasarsallad,Ingridient=croutons },
            new DishIngredients {Dish=Ceasarsallad,Ingridient=tomatoes },
            new DishIngredients {Dish=Ceasarsallad,Ingridient=onion },
            new DishIngredients {Dish=Ceasarsallad,Ingridient=salad },

            new DishIngredients {Dish=KebabPlate,Ingridient=salad },
            new DishIngredients {Dish=KebabPlate,Ingridient=kebabMeat },
            new DishIngredients {Dish=KebabPlate,Ingridient=FrenchFries },
            new DishIngredients {Dish=KebabPlate,Ingridient=garlicSauce },

            new DishIngredients {Dish=SpaghettiBolognese,Ingridient=PastaIngredient },
            new DishIngredients {Dish=SpaghettiBolognese,Ingridient=mincedMeat },
            new DishIngredients {Dish=SpaghettiBolognese,Ingridient=garlic },
            new DishIngredients {Dish=SpaghettiBolognese,Ingridient=bacon },
            new DishIngredients {Dish=SpaghettiBolognese,Ingridient=onion },
            };
            foreach(var i in dishIngredientsList)
            {
                context.DishIngredients.Add(i);
            }
            context.SaveChanges();

            var Joakim = new Customer() { CustomerName = "Joakim", UserName = "joakim89", Address = "Sjösvägen 11", Zipcode = "12455", City = "Stockholm", Email = "joakim.akerlund@hotmail.com", PhoneNumber = "070-2296422", Password = "password" };
            var joakimOrder = new Order() { Customer = Joakim, Delivered = false, OrderDate = DateTime.Now};

            var random=new Customer() { CustomerName = "Random", UserName = "random123", Address = "randomaddress", Zipcode = "12345", City = "Stockholm", Email = "random@hotmail.com", PhoneNumber = "0123-456", Password = "random" };
            var randomOrder=new Order() { Customer = random, Delivered = false, OrderDate = DateTime.Now };
            var OrderDetailsList = new List<OrderDetails>()
            {
                new OrderDetails {Order=joakimOrder,Dish=Capricciosa, Quantity=1 },
                new OrderDetails {Order=joakimOrder,Dish=Ceasarsallad, Quantity=1 },
                new OrderDetails {Order=joakimOrder,Dish=KebabPlate, Quantity=1 },

                new OrderDetails {Order=randomOrder,Dish=KebabPlate, Quantity=2 },
                new OrderDetails {Order=randomOrder,Dish=Capricciosa, Quantity=1 }
            };
            joakimOrder.TotalCost = OrderDetailsList.Where(o => o.Order.Equals(joakimOrder)).Sum(s => s.Dish.Price * s.Quantity);
            randomOrder.TotalCost = OrderDetailsList.Where(o => o.Order.Equals(randomOrder)).Sum(s => s.Dish.Price * s.Quantity);
            foreach (var o in OrderDetailsList)
            {
                context.OrderDetails.Add(o);
            }
            context.SaveChanges();
            

        }
    }
}

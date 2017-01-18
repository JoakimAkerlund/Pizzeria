using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PizzeriaTomasos.Data;

namespace PizzeriaTomasos.Migrations
{
    [DbContext(typeof(OrderContext))]
    partial class OrderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzeriaTomasos.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("CustomerName");

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("UserName");

                    b.Property<string>("Zipcode");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("PizzeriaTomasos.Models.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int?>("DishCategoryId");

                    b.Property<string>("DishName");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("DishCategoryId");

                    b.ToTable("Dish");
                });

            modelBuilder.Entity("PizzeriaTomasos.Models.DishCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.HasKey("Id");

                    b.ToTable("DishCategory");
                });

            modelBuilder.Entity("PizzeriaTomasos.Models.DishIngredients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DishId");

                    b.Property<int?>("IngridientId");

                    b.HasKey("Id");

                    b.HasIndex("DishId");

                    b.HasIndex("IngridientId");

                    b.ToTable("DishIngredients");
                });

            modelBuilder.Entity("PizzeriaTomasos.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IngredientName");

                    b.HasKey("Id");

                    b.ToTable("Ingredient");
                });

            modelBuilder.Entity("PizzeriaTomasos.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CustomerId");

                    b.Property<bool>("Delivered");

                    b.Property<DateTime>("OrderDate");

                    b.Property<decimal>("TotalCost");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("PizzeriaTomasos.Models.OrderDetails", b =>
                {
                    b.Property<int>("OrderDetailsId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DishId");

                    b.Property<int?>("OrderId");

                    b.Property<int>("Quantity");

                    b.HasKey("OrderDetailsId");

                    b.HasIndex("DishId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("PizzeriaTomasos.Models.Dish", b =>
                {
                    b.HasOne("PizzeriaTomasos.Models.DishCategory", "DishCategory")
                        .WithMany("Dishes")
                        .HasForeignKey("DishCategoryId");
                });

            modelBuilder.Entity("PizzeriaTomasos.Models.DishIngredients", b =>
                {
                    b.HasOne("PizzeriaTomasos.Models.Dish", "Dish")
                        .WithMany("DishIngridients")
                        .HasForeignKey("DishId");

                    b.HasOne("PizzeriaTomasos.Models.Ingredient", "Ingridient")
                        .WithMany("DishIngredients")
                        .HasForeignKey("IngridientId");
                });

            modelBuilder.Entity("PizzeriaTomasos.Models.Order", b =>
                {
                    b.HasOne("PizzeriaTomasos.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("PizzeriaTomasos.Models.OrderDetails", b =>
                {
                    b.HasOne("PizzeriaTomasos.Models.Dish", "Dish")
                        .WithMany()
                        .HasForeignKey("DishId");

                    b.HasOne("PizzeriaTomasos.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");
                });
        }
    }
}

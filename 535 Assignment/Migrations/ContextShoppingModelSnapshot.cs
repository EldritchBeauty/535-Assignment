﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _535_Assignment.Models;

#nullable disable

namespace _535_Assignment.Migrations
{
    [DbContext(typeof(ContextShopping))]
    partial class ContextShoppingModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_535_Assignment.Models.AppUser", b =>
                {
                    b.Property<int>("AppUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppUserId"), 1L, 1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Password");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AppUserId");

                    b.ToTable("AppUsers");

                    b.HasData(
                        new
                        {
                            AppUserId = 1,
                            Password = "$2a$11$0xwyrJ15VGZ0jkROz0sxOeafbldvVyha/eitYtUj41onxCqC4nsq2",
                            Role = "Admin",
                            UserName = "You"
                        });
                });

            modelBuilder.Entity("_535_Assignment.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"), 1L, 1);

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(1064)
                        .HasColumnType("nvarchar(1064)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("Decimal(19,4)");

                    b.HasKey("ItemId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            ItemName = "Fresh Tomatoes",
                            Unit = "500g",
                            UnitPrice = 5.9m
                        },
                        new
                        {
                            ItemId = 2,
                            ItemName = "Watermelon",
                            Unit = "Whole",
                            UnitPrice = 6.6m
                        },
                        new
                        {
                            ItemId = 3,
                            ItemName = "Cucumber",
                            Unit = "1 whole",
                            UnitPrice = 1.9m
                        },
                        new
                        {
                            ItemId = 4,
                            ItemName = "Red Potato Washed",
                            Unit = "1kg",
                            UnitPrice = 4m
                        },
                        new
                        {
                            ItemId = 5,
                            ItemName = "Red Tipped Bananas",
                            Unit = "1kg",
                            UnitPrice = 4.9m
                        },
                        new
                        {
                            ItemId = 6,
                            ItemName = "Red Onion",
                            Unit = "1kg",
                            UnitPrice = 3.5m
                        },
                        new
                        {
                            ItemId = 7,
                            ItemName = "Carrots",
                            Unit = "1kg",
                            UnitPrice = 2m
                        },
                        new
                        {
                            ItemId = 8,
                            ItemName = "Iceburg Lettuce",
                            Unit = "1",
                            UnitPrice = 2.5m
                        },
                        new
                        {
                            ItemId = 9,
                            ItemName = "Helga's Wholemeal",
                            Unit = "1",
                            UnitPrice = 3.7m
                        },
                        new
                        {
                            ItemId = 10,
                            ItemName = "Free Range Chicken",
                            Unit = "1kg",
                            UnitPrice = 7.5m
                        },
                        new
                        {
                            ItemId = 11,
                            ItemName = "Manning Valley 6-pk",
                            Unit = "6 eggs",
                            UnitPrice = 3.6m
                        },
                        new
                        {
                            ItemId = 12,
                            ItemName = "A2 Light Milk",
                            Unit = "1 litre",
                            UnitPrice = 2.9m
                        },
                        new
                        {
                            ItemId = 13,
                            ItemName = "Chobani Strawberry Yoghurt",
                            Unit = "1",
                            UnitPrice = 1.5m
                        },
                        new
                        {
                            ItemId = 14,
                            ItemName = "Lurpark Salted Blend",
                            Unit = "250g",
                            UnitPrice = 5m
                        },
                        new
                        {
                            ItemId = 15,
                            ItemName = "Bega Farmers Tasty",
                            Unit = "250g",
                            UnitPrice = 4m
                        },
                        new
                        {
                            ItemId = 16,
                            ItemName = "Babybel Mini",
                            Unit = "100g",
                            UnitPrice = 4.2m
                        },
                        new
                        {
                            ItemId = 17,
                            ItemName = "Cobram EVOO",
                            Unit = "375ml",
                            UnitPrice = 8m
                        },
                        new
                        {
                            ItemId = 18,
                            ItemName = "Heinz Tomato Soup",
                            Unit = "535g",
                            UnitPrice = 2.5m
                        },
                        new
                        {
                            ItemId = 19,
                            ItemName = "John West Tuna can",
                            Unit = "95g",
                            UnitPrice = 1.5m
                        },
                        new
                        {
                            ItemId = 20,
                            ItemName = "Cadbury Dairy Milk",
                            Unit = "200g",
                            UnitPrice = 5m
                        },
                        new
                        {
                            ItemId = 21,
                            ItemName = "Coca Cola",
                            Unit = "2 litre",
                            UnitPrice = 2.85m
                        },
                        new
                        {
                            ItemId = 22,
                            ItemName = "Smith's Original Share Pack Crisps",
                            Unit = "170g",
                            UnitPrice = 3.29m
                        },
                        new
                        {
                            ItemId = 23,
                            ItemName = "Birds Eye Fish Fingers",
                            Unit = "375g",
                            UnitPrice = 4.5m
                        },
                        new
                        {
                            ItemId = 24,
                            ItemName = "Berri Orange Juice",
                            Unit = "2 litre",
                            UnitPrice = 6m
                        },
                        new
                        {
                            ItemId = 25,
                            ItemName = "Vegemite",
                            Unit = "380g",
                            UnitPrice = 6m
                        },
                        new
                        {
                            ItemId = 26,
                            ItemName = "Cheddar Shapes",
                            Unit = "175g",
                            UnitPrice = 2m
                        },
                        new
                        {
                            ItemId = 27,
                            ItemName = "Colgate Total ToothPaste",
                            Unit = "110g",
                            UnitPrice = 3.5m
                        },
                        new
                        {
                            ItemId = 28,
                            ItemName = "Milo Chocolate Malt",
                            Unit = "200g",
                            UnitPrice = 4m
                        },
                        new
                        {
                            ItemId = 29,
                            ItemName = "Weet Bix Saniatarium Organic",
                            Unit = "750g",
                            UnitPrice = 5.33m
                        },
                        new
                        {
                            ItemId = 30,
                            ItemName = "Lindt Excellence 70% Cocoa Block",
                            Unit = "100g",
                            UnitPrice = 4.25m
                        },
                        new
                        {
                            ItemId = 31,
                            ItemName = "Original Tim Tams Chocolate",
                            Unit = "200g",
                            UnitPrice = 3.65m
                        },
                        new
                        {
                            ItemId = 32,
                            ItemName = "Philadelphia Original Cream Cheese",
                            Unit = "250g",
                            UnitPrice = 4.3m
                        },
                        new
                        {
                            ItemId = 33,
                            ItemName = "Moccona Classic Instant Medium Roast",
                            Unit = "100g",
                            UnitPrice = 6m
                        },
                        new
                        {
                            ItemId = 34,
                            ItemName = "Capilano Sqeezable Honey",
                            Unit = "500g",
                            UnitPrice = 7.35m
                        },
                        new
                        {
                            ItemId = 35,
                            ItemName = "Nutella Jar",
                            Unit = "400g",
                            UnitPrice = 4m
                        },
                        new
                        {
                            ItemId = 36,
                            ItemName = "Arnott's Scotch Finger",
                            Unit = "250g",
                            UnitPrice = 2.85m
                        },
                        new
                        {
                            ItemId = 37,
                            ItemName = "South Cape Greek Feta",
                            Unit = "200g",
                            UnitPrice = 5m
                        },
                        new
                        {
                            ItemId = 38,
                            ItemName = "Salsa Pasta Tomato Basil Sauce",
                            Unit = "420g",
                            UnitPrice = 4.5m
                        },
                        new
                        {
                            ItemId = 39,
                            ItemName = "Primo English Ham",
                            Unit = "100g",
                            UnitPrice = 3m
                        },
                        new
                        {
                            ItemId = 40,
                            ItemName = "Primo Short Cut Rindless Bacon",
                            Unit = "175g",
                            UnitPrice = 5m
                        },
                        new
                        {
                            ItemId = 41,
                            ItemName = "Golden Circle Pinapple Pieces in natural juice",
                            Unit = "440g",
                            UnitPrice = 3.25m
                        },
                        new
                        {
                            ItemId = 42,
                            ItemName = "San Renmo Linguine Pasta No 1",
                            Unit = "500g",
                            UnitPrice = 1.95m
                        },
                        new
                        {
                            ItemId = 43,
                            ItemName = "Granny Smith Apples",
                            Unit = "1kg",
                            UnitPrice = 5.5m
                        });
                });

            modelBuilder.Entity("_535_Assignment.Models.ItemsToListConnection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("ListId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("ListId");

                    b.ToTable("ItemsInList");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ItemId = 38,
                            ListId = 1,
                            Quantity = 34
                        });
                });

            modelBuilder.Entity("_535_Assignment.Models.ShoppingList", b =>
                {
                    b.Property<int>("ShoppingListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoppingListId"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("ListName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ShoppingListId");

                    b.HasIndex("UserId");

                    b.ToTable("ShoppingList");

                    b.HasData(
                        new
                        {
                            ShoppingListId = 1,
                            Created = new DateTime(2023, 6, 7, 12, 24, 56, 114, DateTimeKind.Local).AddTicks(434),
                            ListName = "Your List",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("_535_Assignment.Models.ItemsToListConnection", b =>
                {
                    b.HasOne("_535_Assignment.Models.Item", "item")
                        .WithMany("ItemList")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_535_Assignment.Models.ShoppingList", "list")
                        .WithMany("ItemList")
                        .HasForeignKey("ListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("item");

                    b.Navigation("list");
                });

            modelBuilder.Entity("_535_Assignment.Models.ShoppingList", b =>
                {
                    b.HasOne("_535_Assignment.Models.AppUser", "users")
                        .WithMany("ShoppingLists")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("users");
                });

            modelBuilder.Entity("_535_Assignment.Models.AppUser", b =>
                {
                    b.Navigation("ShoppingLists");
                });

            modelBuilder.Entity("_535_Assignment.Models.Item", b =>
                {
                    b.Navigation("ItemList");
                });

            modelBuilder.Entity("_535_Assignment.Models.ShoppingList", b =>
                {
                    b.Navigation("ItemList");
                });
#pragma warning restore 612, 618
        }
    }
}

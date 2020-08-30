using Shop.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Shop.DAL
{
    public static class WebShopInitialiser
    {
        public static void SeedWebShopData(this ModelBuilder modelBuilder)
        {
            var categories = new List<Category>
            {
                new Category()
                {
                    CategoryId = 1,
                    Name = "Sport",
                    Icon = "sport.png",
                    Description = "sport category description"
                },
                new Category()
                {
                    CategoryId = 2,
                    Name = "Garden",
                    Icon = "garden.png",
                    Description = "garden category description"
                },
                new Category()
                {
                    CategoryId = 3,
                    Name = "Automotive",
                    Icon = "automotive.png",
                    Description = "automotive category description"
                },
                new Category()
                {
                    CategoryId = 4,
                    Name = "Home",
                    Icon = "home.png",
                    Description = "home category description"
                },
                new Category()
                {
                    CategoryId = 5,
                    Name = "Animals",
                    Icon = "animals.png",
                    Description = "animals category description"
                }
            };

            categories.ForEach(c => modelBuilder.Entity<Category>().HasData(c));

            var products = new List<Product>
            {
                new Product()
                {
                    ProductId = 2,
                    Name = "Gloves Everlast XL",
                    CategoryId = 1,
                    Description = "Gloves description",
                    Image = "gloves.png",
                    CreatedAt = DateTime.Now,
                    Price = "120,99",
                    IsActive = true
                },
                new Product()
                {
                    ProductId = 3,
                    Name = "T-shirt Everlast XL",
                    CategoryId = 1,
                    Description = "T-shirt description",
                    Image = "t-shirt.png",
                    CreatedAt = DateTime.Now,
                    Price = "60,99",
                    IsActive = true
                },
                new Product()
                {
                    ProductId = 4,
                    Name = "Adidas trousers",
                    CategoryId = 1,
                    Description = "trousers description",
                    Image = "trousers.png",
                    CreatedAt = DateTime.Now,
                    Price = "290,99",
                    IsActive = true
                },
                new Product()
                {
                    ProductId = 5,
                    Name = "Mi Band",
                    CategoryId = 1,
                    Description = "band description",
                    Image = "miband.png",
                    CreatedAt = DateTime.Now,
                    Price = "300,00",
                    IsActive = true
                },
                new Product()
                {
                    ProductId = 6,
                    Name = "Baseball cap",
                    CategoryId = 1,
                    Description = "Baseball cap description",
                    Image = "b_cap.png",
                    CreatedAt = DateTime.Now,
                    Price = "299,99",
                    IsActive = true
                },
                new Product()
                {
                    ProductId = 7,
                    Name = "Camping tent",
                    CategoryId = 1,
                    Description = "Camping tent description",
                    Image = "camping-tent.png",
                    CreatedAt = DateTime.Now,
                    Price = "179,99",
                    IsActive = true
                },
                new Product()
                {
                    ProductId = 8,
                    Name = "Bicycle helmet",
                    CategoryId = 1,
                    Description = "bicycle helmet description",
                    Image = "bike_helmet.png",
                    CreatedAt = DateTime.Now,
                    Price = "99,99",
                    IsActive = true
                },
                new Product()
                {
                    ProductId = 9,
                    Name = "Football F500 Kipsta",
                    CategoryId = 1,
                    Description = "football description",
                    Image = "football.png",
                    CreatedAt = DateTime.Now,
                    Price = "269,99",
                    IsActive = true
                }
            };
            products.ForEach(p => modelBuilder.Entity<Product>().HasData(p));

            var orders = new List<Order>
            {
                new Order()
                {
                    OrderId = 1,
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Address = "Jaśminowa 5",
                    City = "Warszawa",
                    PostalCode = "20-220",
                    Email = "janusz@gmail.com",
                    Comment = "comment",
                    CreatedAt = DateTime.Now,
                    State = State.New,
                    Price = "0,00"
                },
                new Order()
                {
                    OrderId = 2,
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Address = "Jaśminowa 5",
                    City = "Warszawa",
                    PostalCode = "20-220",
                    Email = "janusz@gmail.com",
                    Comment = "comment",
                    CreatedAt = DateTime.Now,
                    State = State.New,
                    Price = "0,00"
                },
                new Order()
                {
                    OrderId = 3,
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Address = "Jaśminowa 5",
                    City = "Warszawa",
                    PostalCode = "20-220",
                    Email = "janusz@gmail.com",
                    Comment = "comment",
                    CreatedAt = DateTime.Now,
                    State = State.New,
                    Price = "0,00"
                },
                new Order()
                {
                    OrderId = 4,
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Address = "Jaśminowa 5",
                    City = "Warszawa",
                    PostalCode = "20-220",
                    Email = "janusz@gmail.com",
                    Comment = "comment",
                    CreatedAt = DateTime.Now,
                    State = State.New,
                    Price = "0,00"
                },
                new Order()
                {
                    OrderId = 5,
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Address = "Jaśminowa 5",
                    City = "Warszawa",
                    PostalCode = "20-220",
                    Email = "janusz@gmail.com",
                    Comment = "comment",
                    CreatedAt = DateTime.Now,
                    State = State.New,
                    Price = "0,00"
                },
                new Order()
                {
                    OrderId = 6,
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Address = "Jaśminowa 5",
                    City = "Warszawa",
                    PostalCode = "20-220",
                    Email = "janusz@gmail.com",
                    Comment = "comment",
                    CreatedAt = DateTime.Now,
                    State = State.New,
                    Price = "0,00"
                },
                new Order()
                {
                    OrderId = 7,
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Address = "Jaśminowa 5",
                    City = "Warszawa",
                    PostalCode = "20-220",
                    Email = "janusz@gmail.com",
                    Comment = "comment",
                    CreatedAt = DateTime.Now,
                    State = State.New,
                    Price = "0,00"
                },
                new Order()
                {
                    OrderId = 8,
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Address = "Jaśminowa 5",
                    City = "Warszawa",
                    PostalCode = "20-220",
                    Email = "janusz@gmail.com",
                    Comment = "comment",
                    CreatedAt = DateTime.Now,
                    State = State.New,
                    Price = "0,00"
                },
                new Order()
                {
                    OrderId = 9,
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Address = "Jaśminowa 5",
                    City = "Warszawa",
                    PostalCode = "20-220",
                    Email = "janusz@gmail.com",
                    Comment = "comment",
                    CreatedAt = DateTime.Now,
                    State = State.New,
                    Price = "0,00"
                },
                new Order()
                {
                    OrderId = 10,
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Address = "Jaśminowa 5",
                    City = "Warszawa",
                    PostalCode = "20-220",
                    Email = "janusz@gmail.com",
                    Comment = "comment",
                    CreatedAt = DateTime.Now,
                    State = State.New,
                    Price = "0,00"
                },
                new Order()
                {
                    OrderId = 11,
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Address = "Jaśminowa 5",
                    City = "Warszawa",
                    PostalCode = "20-220",
                    Email = "janusz@gmail.com",
                    Comment = "comment",
                    CreatedAt = DateTime.Now,
                    State = State.New,
                    Price = "0,00"
                },
                new Order()
                {
                    OrderId = 12,
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Address = "Jaśminowa 5",
                    City = "Warszawa",
                    PostalCode = "20-220",
                    Email = "janusz@gmail.com",
                    Comment = "comment",
                    CreatedAt = DateTime.Now,
                    State = State.New,
                    Price = "0,00"
                },
                new Order()
                {
                    OrderId = 13,
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Address = "Jaśminowa 5",
                    City = "Warszawa",
                    PostalCode = "20-220",
                    Email = "janusz@gmail.com",
                    Comment = "comment",
                    CreatedAt = DateTime.Now,
                    State = State.New,
                    Price = "0,00"
                },
                new Order()
                {
                    OrderId = 14,
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Address = "Jaśminowa 5",
                    City = "Warszawa",
                    PostalCode = "20-220",
                    Email = "janusz@gmail.com",
                    Comment = "comment",
                    CreatedAt = DateTime.Now,
                    State = State.New,
                    Price = "0,00"
                },
                new Order()
                {
                    OrderId = 15,
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Address = "Jaśminowa 5",
                    City = "Warszawa",
                    PostalCode = "20-220",
                    Email = "janusz@gmail.com",
                    Comment = "comment",
                    CreatedAt = DateTime.Now,
                    State = State.New,
                    Price = "0,00"
                },
                new Order()
                {
                    OrderId = 16,
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Address = "Jaśminowa 5",
                    City = "Warszawa",
                    PostalCode = "20-220",
                    Email = "janusz@gmail.com",
                    Comment = "comment",
                    CreatedAt = DateTime.Now,
                    State = State.New,
                    Price = "0,00"
                }
            };
            orders.ForEach(o => modelBuilder.Entity<Order>().HasData(o));
        }
    }
}

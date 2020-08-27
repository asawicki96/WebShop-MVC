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
                }
            };
            products.ForEach(p => modelBuilder.Entity<Product>().HasData(p));
        }
    }
}

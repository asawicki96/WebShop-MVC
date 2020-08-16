using Shop.Migrations;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.DAL
{
    public class WebShopInitialiser : MigrateDatabaseToLatestVersion<WebShopContext, Configuration>
    {

        public static void SeedWebShopData(WebShopContext context)
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

            categories.ForEach(c => context.Categories.AddOrUpdate(c));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product()
                {
                    ProductId = 1,
                    Name = "Gloves Everlast XL",
                    CategoryId = 1,
                    Description = "Gloves description",
                    Image = "gloves.png",
                    CreatedAt = DateTime.Now,
                    Price = 120,
                    IsActive = true
                },
                new Product()
                {
                    ProductId = 2,
                    Name = "T-shirt Everlast XL",
                    CategoryId = 1,
                    Description = "T-shirt description",
                    Image = "t-shirt.png",
                    CreatedAt = DateTime.Now,
                    Price = 60,
                    IsActive = true
                },
                new Product()
                {
                    ProductId = 3,
                    Name = "Adidas trousers",
                    CategoryId = 1,
                    Description = "trousers description",
                    Image = "trousers.png",
                    CreatedAt = DateTime.Now,
                    Price = 290,
                    IsActive = true
                },
                new Product()
                {
                    ProductId = 4,
                    Name = "Mi Band",
                    CategoryId = 1,
                    Description = "band description",
                    Image = "miband.png",
                    CreatedAt = DateTime.Now,
                    Price = 300,
                    IsActive = true
                }
            };
            products.ForEach(p => context.Products.AddOrUpdate(p));
            context.SaveChanges();


        }
    }
}

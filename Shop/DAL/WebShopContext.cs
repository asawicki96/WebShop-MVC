using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using Shop.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Shop.DAL
{
    public class WebShopContext: DbContext
    {
        public WebShopContext(): base("WebShopContext")
        {

        }

        static WebShopContext()
        {
            Database.SetInitializer<WebShopContext>(new WebShopInitialiser());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

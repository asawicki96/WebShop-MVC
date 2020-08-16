namespace Shop.Migrations
{
    using Microsoft.AspNetCore.Identity;
    using Shop.DAL;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<Shop.DAL.WebShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Shop.DAL.WebShopContext";
           
        }

        protected override void Seed(Shop.DAL.WebShopContext context)
        {
            WebShopInitialiser.SeedWebShopData(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }

    }
}

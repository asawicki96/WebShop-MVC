using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.DAL
{
    public class IdentityWebShopContext : IdentityDbContext
    {
        public IdentityWebShopContext(DbContextOptions<IdentityWebShopContext> options) : base(options)
        {

        }
    }
}

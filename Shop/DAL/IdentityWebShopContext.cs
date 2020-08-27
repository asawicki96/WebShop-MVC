using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Shop.DAL
{
    public class IdentityWebShopContext : IdentityDbContext
    {
        public IdentityWebShopContext(DbContextOptions<IdentityWebShopContext> options) : base(options)
        {

        }
    }
}

using Microsoft.AspNetCore.Identity;
using System;


namespace Shop.DAL
{
    internal class IdentityInistialiser
    {
     
        public static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByNameAsync("ADMIN").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.Email = "admin@gmail.com";
                user.UserName = "ADMIN";

                var password = new PasswordHasher<IdentityUser>();
                var hashed = password.HashPassword(user, "ADMIN");
                user.PasswordHash = hashed;

                IdentityResult result = userManager.CreateAsync(user).Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                }
                else
                    throw new Exception("Nie dodano usera");
            }
        }


        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Administrator";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
        }


        public static void SeedData (UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }
    }
}


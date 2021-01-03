using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace AnimalShelterApp.Models
{
    public static class Initialize
    {
        public static async Task SeedAsync(UserManager<IdentityUser> userManager,RoleManager<IdentityRole> roleManager)
        {
            var list = new List<IdentityRole>()
            {
                new IdentityRole()
                {
                    Id=Guid.NewGuid().ToString(),
                    Name="Admin",

                },
                new IdentityRole()
                {
                    Id=Guid.NewGuid().ToString(),
                    Name="User",

                }
            };
            if (!roleManager.Roles.Any())
            {
                foreach (var item in list)
                {
                    await roleManager.CreateAsync(item).ConfigureAwait(false);
                }
            }
            var list2 = new List<IdentityUser>()
            {
                new IdentityUser(){Email="b171210373@sakarya.edu.tr",UserName="b171210373@sakarya.edu.tr",Id=Guid.NewGuid().ToString(),EmailConfirmed=true,PhoneNumberConfirmed=true},
                new IdentityUser(){Email="Onur@sakarya.edu.tr",UserName="Onur@sakarya.edu.tr",Id=Guid.NewGuid().ToString(),EmailConfirmed=true,PhoneNumberConfirmed=true}
            };
            if (!userManager.Users.Any())
            {
                foreach (var item in list2)
                {
                    await userManager.CreateAsync(item,"123").ConfigureAwait(false);
                    
                }
                await userManager.AddToRoleAsync(await userManager.FindByNameAsync("b171210373@sakarya.edu.tr"), "Admin");
                await userManager.AddToRoleAsync(await userManager.FindByNameAsync("Onur@sakarya.edu.tr"), "User");
            }

        }

    }
}

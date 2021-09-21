using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Insect_Tracker.Models;
using Microsoft.AspNetCore.Identity;

namespace Insect_Tracker.Data
{
    public static class ContextSeed
    {
        public static async Task SeedRolesAsync (UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(Configuration.Roles.SuperAdmin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Configuration.Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Configuration.Roles.User.ToString()));
        }

        public static async Task SeedSuperAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var defaultUser = new ApplicationUser
            {
                UserName = "admin",
                Email = "admin@insecttracker.com",
                FirstName = "Administrator",
                LastName = "",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);

                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "password");
                    await userManager.AddToRoleAsync(defaultUser, Configuration.Roles.SuperAdmin.ToString());
                }
            }
        }
    }
}

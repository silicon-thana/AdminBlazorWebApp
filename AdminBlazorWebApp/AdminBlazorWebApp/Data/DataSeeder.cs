using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AdminBlazorWebApp.Data
{
    public class DataSeeder
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public DataSeeder(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task SeedRolesAndUsersAsync()
        {
            // Seed roles
            string[] roleNames = { "SuperAdmin","Admin" };
            foreach (var roleName in roleNames)
            {
                var roleExist = await _roleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    await _roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            // Seed an admin user
            var adminUser = new ApplicationUser
            {
                UserName = "admin@admin.com",
                Email = "admin@admin.com",
                FirstName = "Admin",
                LastName = "Admin",
                EmailConfirmed = true
            };

            var user = await _userManager.FindByEmailAsync(adminUser.Email);
            if (user == null)
            {
                var createAdminUser = await _userManager.CreateAsync(adminUser, "Bytmig123!");
                if (createAdminUser.Succeeded)
                {
                    await _userManager.AddToRoleAsync(adminUser, "SuperAdmin");
                }
            }
        }
    }
}

using CRM_Mini.Models;
using Microsoft.AspNetCore.Identity;

namespace CRM_Mini.Data
{
	public static class DbInitializer
	{
		public static async Task SeedAdminAsync(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
		{
			// Ensure roles are created
			string[] roleNames = { "Admin", "User" };
			foreach (var roleName in roleNames)
			{
				if (!await roleManager.RoleExistsAsync(roleName))
				{
					await roleManager.CreateAsync(new IdentityRole(roleName));
				}
			}
			// Create a default admin user
			var adminEmail = "admin@crm.com";
			var adminPassword = "Admin@123";
			var adminUser = await userManager.FindByEmailAsync(adminEmail);
			if (adminUser == null)
			{
				adminUser = new AppUser
				{
					UserName = adminEmail,
                    Email = adminEmail,
                    FullName = "Administrator",
					EmailConfirmed = true
				};

				var result = await userManager.CreateAsync(adminUser, adminPassword);
				if (result.Succeeded)
				{
					await userManager.AddToRoleAsync(adminUser, "Admin");
				}
			}
			else
			{
				var token = await userManager.GeneratePasswordResetTokenAsync(adminUser);
				await userManager.ResetPasswordAsync(adminUser, token, adminPassword);

				if(!await userManager.IsInRoleAsync(adminUser, "Admin"))
				{
					await userManager.AddToRoleAsync(adminUser, "Admin");
				}

            }
			
		}
	}
}
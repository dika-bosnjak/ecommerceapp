using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager) 
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    UserName = "John Doe",
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john@doe.com",
                    Address = new Address {
                        Street = "9th Street",
                        City = "New York",
                        State = "NY",
                        ZipCode = "90210"
                    }

                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}
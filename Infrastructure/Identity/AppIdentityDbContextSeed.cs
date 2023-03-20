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
                    DisplayName = "John",
                    Email = "johndoe@gmail.com",
                    UserName = "JohnDoe",
                    Address = new Address
                    {
                        FirstName = "John",
                        LastName = "Doe",
                        Street = "Zmaja od Bosne bb",
                        City = "Zenica",
                        ZipCode = "72000",
                        Country = "BiH",

                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}
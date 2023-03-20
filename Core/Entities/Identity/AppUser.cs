using Microsoft.AspNetCore.Identity;

namespace Core.Entities.Identity
{
    //using extended .NET Identity user for users in the database
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public Address Address { get; set; }

    }
}
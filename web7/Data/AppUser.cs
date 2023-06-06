using Microsoft.AspNetCore.Identity;

namespace web7.Data
{
    public class AppUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}

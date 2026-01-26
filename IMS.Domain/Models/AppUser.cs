using Microsoft.AspNetCore.Identity;

namespace IMS.Domain.Models
{
    public class AppUser : IdentityUser
    {
        public required Profile Profile { get; set; }
    }

}
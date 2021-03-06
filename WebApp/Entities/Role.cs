using Microsoft.AspNetCore.Identity;

namespace WebApp.Entities
{
    public class Role : IdentityRole<int>
    {
        public ICollection<UserRole> UserRoles { get; set; }
    }
}

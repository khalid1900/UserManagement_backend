using Microsoft.AspNetCore.Identity;

namespace UserManageApp.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public string Role { get; set; }
    }
}

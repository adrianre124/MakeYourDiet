using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MakeYourDiet.Models
{
    public class User : IdentityUser<int>
    {
        public string Password { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime LastActive { get; set; } = DateTime.UtcNow;
        public string Gender { get; set; }

        public ICollection<ProductCollection> Meals { get; } = new List<ProductCollection>();
        public ICollection<AppUserRole> UserRoles { get; set; }

    }
}
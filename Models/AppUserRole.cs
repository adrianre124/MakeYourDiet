using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MakeYourDiet.Models
{
    public class AppUserRole : IdentityUserRole<int>
    {
        public User User { get; set; }
        public AppRole Role { get; set; }
    }
}
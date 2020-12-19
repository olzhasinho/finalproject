using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ArtShop3.Models
{
    public class User : IdentityUser
    {
        public int Money { get; set; }
    }
}

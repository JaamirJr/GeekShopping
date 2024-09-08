﻿using Microsoft.AspNetCore.Identity;

namespace GeekShopping.IdentityServer.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirtsName { get; set; }
        public string? LastName { get; set; }
    }
}

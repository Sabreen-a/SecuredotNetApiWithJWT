﻿using Microsoft.AspNetCore.Identity;
using SecureApiJWT.Models;
using System.ComponentModel.DataAnnotations;

namespace SecureApi.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required,MaxLength(10)]
        public string FirstName { get; set; }

        [Required, MaxLength(30)]
        public string LastName { get; set; }

        public List<RefreshToken>? RefreshTokens { get; set; }
    }
}

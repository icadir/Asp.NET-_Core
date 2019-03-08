using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityCore2.Models.IdentityModels
{
    public class ApplicationUser : IdentityUser
    {
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(50)]
        public string Surname { get; set; }

        public DateTime RegisterDate { get; set; } = DateTime.Now;
    }
}

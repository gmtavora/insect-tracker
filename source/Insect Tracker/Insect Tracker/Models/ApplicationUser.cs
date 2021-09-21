using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Insect_Tracker.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public DateTime DateSigned { get; set; }

        public char Gender { get; set; }

        [Required]
        [StringLength(32)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(32)]
        public string LastName { get; set; }

        public string ProfilePicture { get; set; }
    }
}

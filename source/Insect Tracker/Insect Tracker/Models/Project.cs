using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Insect_Tracker.Models
{
    public class Project
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [Required]
        [StringLength(512)]
        public string Description { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool Finished { get; set; }

        [Required]
        public ApplicationUser Creator { get; set; }

        [Required]
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }

        [Display(Name = "Date Finished")]
        public DateTime DateFinished { get; set; }

        [Required]
        [Display(Name = "Last Modified")]
        public DateTime LastModified { get; set; }

        public ICollection<IdentityRole> Roles { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<UserProject> Users { get; set; }

        public Project()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Insect_Tracker.Models;

namespace Insect_Tracker.Models
{
    public class Ticket
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public ApplicationUser Author { get; set; }

        [Required]
        [StringLength(256)]
        public string Title { get; set; }
        
        [Required]
        [DefaultValue(false)]
        public bool Closed { get; set; }

        [Required]
        [Display(Name = "Date Reported")]
        public DateTime DateReported { get; set; }

        [Display(Name = "Date Closed")]
        public DateTime DateClosed { get; set; }

        [Required]
        [Display(Name = "Last Modified")]
        public DateTime LastModified { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public Ticket()
        {

        }
    }
}

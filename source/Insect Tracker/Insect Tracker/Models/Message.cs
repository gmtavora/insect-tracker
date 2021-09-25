using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Insect_Tracker.Models
{
    public class Message
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Subject { get; set; }

        [Required]
        [StringLength(512)]
        public string Text { get; set; }

        [Required]
        public DateTime DateSent { get; set; }

        [Required]
        public ApplicationUser SentBy { get; set; }

        [Required]
        public ICollection<ApplicationUser> SentTo { get; set; }

        public Message()
        {

        }
    }
}

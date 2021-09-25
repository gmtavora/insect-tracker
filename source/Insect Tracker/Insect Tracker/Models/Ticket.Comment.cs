using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Insect_Tracker.Models
{
    public class Comment
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(512)]
        public string Message { get; set; }

        [Required]
        public DateTime DateSent { get; set; }
        [Required]
        public DateTime LastModified { get; set; }

        public ICollection<Attachment> Attachments { get; set; }

        public Ticket Topic { get; set; }

        public Comment()
        {

        }
    }
}

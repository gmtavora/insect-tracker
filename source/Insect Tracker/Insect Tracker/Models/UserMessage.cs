using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Insect_Tracker.Models
{
    public class UserMessage
    {
        public int Id { get; set; }


        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        [Required]
        public int MessageId { get; set; }
        public Message Message { get; set; }
    }
}

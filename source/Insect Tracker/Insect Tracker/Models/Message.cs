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
        [StringLength(512)]
        public string message { get; set; }

        [Required]
        public DateTime date_sent { get; set; }
    }
}

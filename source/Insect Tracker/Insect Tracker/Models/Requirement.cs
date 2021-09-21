using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Insect_Tracker.Models
{
    public class Requirement
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string title { get; set; }
        [Required]
        [StringLength(512)]
        public string description { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool finished { get; set; }
        [Required]
        public DateTime date_added { get; set; }
        public DateTime date_closed { get; set; }
        [Required]
        public DateTime last_modified { get; set; }
    }
}

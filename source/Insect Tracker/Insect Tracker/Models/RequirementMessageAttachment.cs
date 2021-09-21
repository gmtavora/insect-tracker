using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Insect_Tracker.Models
{
    public class RequirementMessageAttachment
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string file { get; set; }
    }
}

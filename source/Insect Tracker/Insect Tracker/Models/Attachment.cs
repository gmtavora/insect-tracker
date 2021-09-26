using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Insect_Tracker.Models
{
    public class Attachment
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string FileName { get; set; }

        [Required]
        [StringLength(256)]
        public string File { get; set; }

        public Comment Comment { get; set; }

        public Attachment()
        {

        }
    }
}

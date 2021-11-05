using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public virtual Menu Menu { get; set; }

        [Required]
        public virtual Product Product { get; set; }
    }
}

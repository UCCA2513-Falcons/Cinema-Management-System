using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class Showroom
    {
        [Key]
        [Display(Name ="Showroom ID")]
        public int ShowroomID { get; set; }

        [Required]
        [Display(Name = "Showroom Name")]
        public string ShowroomName { get; set; }

        public virtual ICollection <Showtime> Showtime { get; set; }
    }
}

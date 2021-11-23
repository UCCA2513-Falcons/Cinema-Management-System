using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class Showtime
    {
        [Key]
        [Display(Name = "Showtime ID")]
        public int ShowtimeID { get; set; }

        [Required]
        [Display(Name = "Showroom No.")]
        public int ShowroomNo { get; set; }

        [Required]
        [Display(Name = "Start Time")]
        public DateTime StartDateTime { get; set; }

        [Required]
        [Display(Name = "End Time")]
        public DateTime EndDateTime { get; set; }

        public virtual MovieDetails Movies { get; set; }
    }
}
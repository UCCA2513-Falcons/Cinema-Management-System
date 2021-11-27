using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class Booking
    {
        [Key]
        [Display(Name = "Booking ID")]
        public int ID { get; set; }

        [Required]
        [Display(Name = "User")]
        public int UID { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "Movie ID")]
        [ForeignKey("MovieDetails")]
        public int MID { get; set; }


        [Required]
        [ForeignKey("Showtime")]
        public int showtimeID { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "Amount")]
        [Column(TypeName = "decimal(6,2)")]
        public decimal amount { get; set; }

        public virtual MovieDetails Movies { get; set; }

        public virtual Showtime Showtime { get; set; }

    }
}

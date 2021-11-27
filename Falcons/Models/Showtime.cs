using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class Showtime
    {
        [Key]
        [Display(Name = "Showtime ID")]
        public int ShowtimeID { get; set; }

        public virtual Showroom Showroom { get; set; }

        [ForeignKey("Showroom")]
        public int ShowroomID { get; set; }
        //[Required]
        //[Display(Name = "Showroom No.")]
        //public int ShowroomNo { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public string StartDate { get; set; }

        [Required]
        [Display(Name = "Start Time")]
        public string StartTime { get; set; }

        //[Required]
        //[Display(Name = "End Date")]
        //public string EndDate { get; set; }

        //[Required]
        //[Display(Name = "End Time")]
        //public string EndTime { get; set; }

        //[ForeignKey("MovieDetails")]
        //public int MovieID { get; set; }

        public virtual int MoviesMovieID { get; set; }

        public virtual MovieDetails Movies { get; set; }

        public virtual ICollection<Booking> Booking { get; set; }



    }
}
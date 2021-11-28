using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class MovieDetails
    {
        [Key]
        [Display(Name = "Movie ID")]
        public int MovieID { get; set; }

        [Required]
        [MaxLength(1000)]
        [Display(Name = "Movie Name")]
        public string MovieName { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Duration")]
        public string Duration { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Subtitle")]
        public string Subtitle { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Language")]
        public string Language { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Genre")]
        public string Genre { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Director")]
        public string Director { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Category")]
        public string Category { get; set; }

        [Required]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        //               ApplyFormatInEditMode = true)]
        //[Display(Name = "Release Date")]
        [MaxLength(100)]
        [Display(Name = "Release Date")]
        public string ReleaseDate { get; set; }

        [Column(TypeName = "ntext")]
        [MaxLength(2000)]
        [Display(Name = "Synopsis")]
        public string Synopsis { get; set; }

        //[Required]
        //[MaxLength(100)]
        //[Display(Name = "Distributor")]
        //public string Distributor { get; set; }

        //[Display(Name = "Poster")]
        public string MoviesImgURL { get; set; }

        [Required]
        [MaxLength(200)]
        [Display(Name = "Cast")]
        public string Cast { get; set; }

        

        public virtual ICollection<Showtime> Showtimes { get; set; }

    }
}


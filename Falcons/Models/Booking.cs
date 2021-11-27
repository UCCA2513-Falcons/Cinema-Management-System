﻿using System;
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
        [MaxLength(100)]
        [Display(Name = "Email")]
        //[ForeignKey("Role")]
        public string email { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "Movie ID")]
        [ForeignKey("MovieDetails")]
        public int MID { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Movie Name")]
        public string movieName { get; set; }

        [Required]
        [Display(Name = "Created on")]
        public DateTime bookingDateTime { get; set; }

        [Required]
        [Display(Name = "Booked for")]
        public DateTime showDateTime { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "Amount")]
        [Column(TypeName = "decimal(6,2)")]
        public decimal amount { get; set; }

       // [Required]
       // public virtual Ticket ticket { get; set; }


        //[Required]
        //public virtual ICollection<Role> role { get; set; }
    }
}

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
        public Int32 BID { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "Payment ID")]
        public Int32 paymentID { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "Role ID")]
        //[ForeignKey("Role")]
        public Int32 RoleID { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "Movie ID")]
        public Int32 MID { get; set; }

        [Required]
        [Display(Name = "Booking Date")]
        public DateTime bookingDate { get; set; }

        [Required]
        [Display(Name = "Booking Time")]
        public DateTime bookingTime { get; set; }

        [Required]
        [Display(Name = "Showing Time")]
        public DateTime showTime { get; set; }

        [Required]
        [Display(Name = "Showing Date")]
        public DateTime showDate { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "Amount")]
        public double amount { get; set; }

        [Required]
        public virtual Ticket ticket { get; set; }

        

        //[Required]
        //public virtual ICollection<Role> role { get; set; }
    }
}

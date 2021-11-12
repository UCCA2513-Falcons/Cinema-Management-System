using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class Ticket
    {
        [Key]
        [Display(Name = "Ticket ID")]
        public Int32 TID { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "Amount")]
        public double amount { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "Booking ID")]
        [ForeignKey("Booking")]
        public Int32 bookingID { get; set; }

        [Required]
        public virtual ICollection<Booking> booking { get; set; }
    }
}

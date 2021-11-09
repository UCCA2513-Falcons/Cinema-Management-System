using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class Booking
    {
        [Key]
        public int BID { get; set; }

        [Required]
        [MaxLength(10)]
        public int paymentID { get; set; }

        [Required]
        [MaxLength(10)]
        public int UID { get; set; }

        [Required]
        [MaxLength(10)]
        public int MID { get; set; }

        [Required]
        public DateTime bookingDate { get; set; }

        [Required]
        public DateTime bookingTime { get; set; }

        [Required]
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class Ticket
    {
        [Key]
        public int TID { get; set; }

        [Required]
        [MaxLength(10)]
        public String MID { get; set; }

        [Required]
        [MaxLength(50)]
        public String movieName { get; set; }

        [Required]
        [MaxLength(3)]
        public int hallNo { get; set; }

        [Required]
        [MaxLength(5)]
        public String seatNo { get; set; }

        [Required]
        public DateTime showDate { get; set; }

        [Required]
        public DateTime showTime { get; set; }

        [Required]
        [MaxLength(10)]
        public int bookingID { get; set; }

        [Required]
        public virtual Booking booking { get; set; }
    }
}

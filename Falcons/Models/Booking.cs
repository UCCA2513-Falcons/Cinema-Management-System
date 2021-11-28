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
        public int BID { get; set; }

        public string ticketType { get; set; }

        public string Date { get; set; }

        public int qty { get; set; }

        public string username { get; set; }

        public string Seat { get; set; }

        [ForeignKey("Showtime")]
        public virtual int ShowtimeID { get; set; }

        public virtual Showtime Showtime { get; set; }
    }
}

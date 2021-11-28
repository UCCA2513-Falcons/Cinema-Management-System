using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class SeatReservation
    {
        [Key]
        public int RID { get; set; }

        public string seats { get; set; }

        public int BIDs { get; set; }

        public virtual Showtime Showtime { get; set; }

        public virtual int showtimeID { get; set; }
    }
}

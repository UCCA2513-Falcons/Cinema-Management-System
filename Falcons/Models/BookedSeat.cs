using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class BookedSeat
    {
        [Key]
        public string SeatID { get; set; }
    }
}

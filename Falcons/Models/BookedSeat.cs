using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class BookedSeat
    {
        [Key]
        public string SeatID { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal SeatPrice { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class SelectedSeat
    {
        public String SeatID { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public Decimal SeatPrice { get; set; }
    }
}

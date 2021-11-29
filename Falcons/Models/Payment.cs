using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class Payment
    {
        [Key]
        public int PID { get; set; }

        public string movieName { get; set; }

        public int qty { get; set; }

        public string type { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal price { get; set; }
    }
}

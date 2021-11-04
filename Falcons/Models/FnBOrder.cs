using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class FnBOrder
    {
        [Key]
        public int FnBOrderID { get; set; }

        public DateTime OrderDate { get; set; }

        [Required]
        public virtual User User { get; set; }

        public virtual ICollection<FnBOrderDetail> FnBOrderDetails { get; set; }
    }
}

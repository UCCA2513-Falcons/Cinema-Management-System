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
        [Display(Name = "Order ID")]
        public int FnBOrderID { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required]
        [Display(Name = "User")]
        public string UID { get; set; }

        public virtual ICollection<FnBOrderDetail> FnBOrderDetails { get; set; }
    }
}

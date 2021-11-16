using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class Hall
    {
        [Key]
        [Display(Name = "Hall Number")]
        public Int32 HID { get; set; }


        public virtual Seat seat { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class Seat
    {
        [Key]
        [Display(Name = "Seat Number")]
        public Int32 SID { get; set; }


        [Display(Name = "Seat Status")]
        public String status { get; set; }

        [Display(Name = "Hall No")]
        [ForeignKey("Hall")]
        public Int32 HID { get; set; }

        [Display(Name = "Booking ID")]
        [ForeignKey("Booking")]
        public Int32 BID { get; set; }

        [Required]
        public virtual ICollection<Hall> Halls { get; set; }

        [Required]
        public virtual ICollection<Booking> booking { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class FnBOrderDetail
    {
        [Key]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Order")]
        [ForeignKey("FnBOrder")]
        public int OrderID { get; set; }

        [Display(Name = "Product")]
        [Required]
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        

        [Required]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Price")]
        public int ProductPrice { get; set; }

        public Product Product { get; set; }
        public FnBOrder FnBOrder { get; set; }

    }
}

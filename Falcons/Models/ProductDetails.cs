using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class ProductDetails
    {
        [Key]
        public int ProductDetailID { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public Product Product { get; set; }

        [Required]
        [Display(Name = "Price")]
        [Column(TypeName = "decimal(6,2)")]
        public decimal ProductPrice { get; set; }

        [Required]
        [Display(Name = "Size")]
        public string Size { get; set; }
    }
}

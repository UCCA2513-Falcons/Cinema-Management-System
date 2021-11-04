using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [MaxLength(100)]
        public string ProductTitle { get; set; }

        [Required]
        [Column(TypeName = "decimal(6,2)")]
        public decimal ProductPrice { get; set; }

        [Column(TypeName = "ntext")]
        [MaxLength(2000)]
        public string ProductDescription { get; set; }

        [Required]
        public virtual ProductCategory ProductCategory { get; set; }

        public virtual ICollection<MenuItem> MenuItems { get; set; }

        public virtual ICollection<FnBOrderDetail> FnBOrderDetails { get; set; }
    }
}

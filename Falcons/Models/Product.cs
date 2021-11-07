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
        [Display(Name = "Product ID")]
        public int ProductID { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Name")]
        public string ProductTitle { get; set; }

        [Column(TypeName = "ntext")]
        [MaxLength(2000)]
        [Display(Name = "Description")]
        public string ProductDescription { get; set; }

        [Display(Name = "Category")]
        [ForeignKey("ProductCategory")]
        public int CategoryID { get; set; }

        public ProductCategory ProductCategory { get; set; }

        [Display(Name = "Image")]
        public string ImageURL { get; set; }

        public ICollection<MenuItem> MenuItems { get; set; }

        public ICollection<FnBOrderDetail> FnBOrderDetails { get; set; }
    }
}

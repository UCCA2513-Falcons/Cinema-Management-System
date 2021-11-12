using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class ProductCategory
    {
        [Key]
        [Display(Name ="Category ID")]
        public int CategoryID { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}

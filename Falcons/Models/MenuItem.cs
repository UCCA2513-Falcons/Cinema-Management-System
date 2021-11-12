using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class MenuItem
    {
        [Key]
        [Display(Name = "Menu Item")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Menu")]
        [ForeignKey("Menu")]
        public int MenuID { get; set; }
        public Menu Menu { get; set; }

        [Required]
        [Display(Name = "Product")]
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}

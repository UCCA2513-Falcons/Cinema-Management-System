using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class FoodType
    {
        [Key]
        [Display(Name = "Inventory Item ID")]
        public int FID { get; set; }

        [MaxLength(150)]
        [Required]
        [Display(Name = "Inventory Item")]
        public string Title { get; set; }

        [MaxLength(100)]
        [Required]
        [Display(Name = "Type")]
        public string Type { get; set; }

        public virtual ICollection<FoodInventory> FoodInventories { get; set; }
    }
}

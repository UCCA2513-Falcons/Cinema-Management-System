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
        [Display(Name = "Food Type ID")]
        public int FID { get; set; }

        [MaxLength(150)]
        [Required]
        [Display(Name = "Food Type Title")]
        public string Title { get; set; }

        [MaxLength(100)]
        [Required]
        [Display(Name = "Type")]
        public string Type { get; set; }

        public ICollection<FoodInventory> FoodInventories { get; set; }
    }
}

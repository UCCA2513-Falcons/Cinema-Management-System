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
        public int FID { get; set; }

        [MaxLength(150)]
        [Required]
        public string Title { get; set; }

        [MaxLength(100)]
        [Required]
        public string Type { get; set; }

        public virtual ICollection<FoodInventory> FoodInventories { get; set; }
    }
}

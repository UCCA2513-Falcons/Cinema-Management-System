using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class FoodInventory
    {
        [Key]
        public int RecordID { get; set; }

        [Required]
        [Column(TypeName = "decimal(6,2)")]
        public decimal Quantity { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(50)]
        public string RecordType { get; set; }

        [Required]
        public virtual FoodType FoodType { get; set; }
    }
}

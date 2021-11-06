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
        [Display(Name = "Record ID")]
        public int RecordID { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        [Column(TypeName = "decimal(6,2)")]
        public decimal Quantity { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [MaxLength(1000)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Price")]
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Record Type")]
        public string RecordType { get; set; }

        [Required]
        [Display(Name = "Food Type")]
        [ForeignKey("FoodType")]
        public int FID { get; set; }
        public FoodType FoodType { get; set; }
    }
}

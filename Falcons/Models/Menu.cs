using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class Menu
    {
        [Key]
        [Display(Name = "Menu ID")]
        public int MenuID { get; set; }

        [MaxLength(200)]
        [Display(Name = "Menu Name")]
        public string PackageName { get; set; }

        [Column(TypeName = "ntext")]
        [MaxLength(1000)]
        [Display(Name = "Menu Desccription")]
        public string Description { get; set; }
        [Display(Name = "Images")]
        public string ImageURL { get; set; }

        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}

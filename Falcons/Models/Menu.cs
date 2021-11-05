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
        public int MenuID { get; set; }

        [MaxLength(200)]
        public string PackageName { get; set; }

        [Column(TypeName = "ntext")]
        [MaxLength(1000)]
        public string Description { get; set; }

        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}

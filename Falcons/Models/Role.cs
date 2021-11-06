using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class Role
    {
        [Key]
        [Display(Name = "Role ID")]
        public int RoleID { get; set; }

        [Column(TypeName = "ntext")]
        [MaxLength(200)]
        [Required]
        [Display(Name = "Title")]
        public string RoleTitle { get; set; }

        [MaxLength(100)]
        [Display(Name = "Position")]
        public string Position { get; set; }

        public ICollection<User> Users { get; set; }
    }
}

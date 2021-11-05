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
        public int RoleID { get; set; }

        [Column(TypeName = "ntext")]
        [MaxLength(200)]
        [Required]
        public string RoleTitle { get; set; }

        [MaxLength(100)]
        public string Position { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}

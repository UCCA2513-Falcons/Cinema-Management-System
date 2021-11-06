using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class User
    {
        [Key]
        public int UID { get; set; }

        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(150)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(150)]
        public string Password { get; set; }

        [Required]
        [MaxLength(150)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [MaxLength(12)]
        public string PhoneNo { get; set; }

        public bool BlockSuspicious { get; set; } = false;

        public bool ApprovalStatus { get; set; } = false;

        [Required]
        [Display(Name = "Role")]
        [ForeignKey("Role")]
        public int RoleID { get; set; }

        public Role Role { get; set; }
        public ICollection<FnBOrder> FnBOrders { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public virtual Role Role { get; set; }
    }
}

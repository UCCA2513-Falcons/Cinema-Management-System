using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class Employee
    {
        [Key]
        public Int32 EmpID { get; set; }
        [MaxLength(100)]
        [Required]
        public string FName { get; set; }
        [Required]
        public string LName { get; set; }
        [Required]
        public Int32 Salary { get; set; }
        [Required]

        public string Department { get; set; }
        [Required]

        public virtual Employee Employees { get; set; }
    }
}

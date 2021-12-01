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
        [Display(Name = "Employee ID")]
        public int EmpID { get; set; }
        [MaxLength(50)]
        [Required]
        [Display(Name = "Employee First Name")]

        public string FName { get; set; }

        [MaxLength(50)]
        [Required]
        [Display(Name = "Employee Last name")]
        public string LName { get; set; }

        [Display(Name = "Salary")]
        [Required]
        public Int32 Salary { get; set; }
        [MaxLength(50)]
        [Display(Name = "Department")]
        public string Department { get; set; }


        public string UID { get; set; }

        public ICollection<EmployeeLeave> EmployeeLeave { get; set; }
    }
}

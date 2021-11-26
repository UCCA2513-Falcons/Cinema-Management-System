using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace Falcons.Models
{
    public class EmployeeLeave
    {
        [Key]
        [Display(Name = "Leave ID")]
        public int EmpLeaveID { get; set; }


        [Display(Name = "Leave Type")]
        public String Leavetype { get; set; }

        [Display(Name = "Leave Status")]
        public String Status { get; set; }

        [Display(Name = "Leave Comments")]
        public String Comments { get; set; }

        [Required]
        [Display(Name = "Leave Date")]
        [DataType(DataType.Date)]
        public DateTime LeaveDate { get; set; }

        [ForeignKey("Employee")]
        [Display(Name = "Employee ID")]
        public int EmpID { get; set; }

     
        public Employee Employees { get; set; }
    }
}

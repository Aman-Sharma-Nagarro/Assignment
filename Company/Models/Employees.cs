using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Company.Models
{
    public class Employees
    {
        public int Id { get; set; }

        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Joining Date")]
        public DateTime JoiningDate { get; set; }

        public string Department { get; set; }
        public decimal Salary { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        
        public string Address { get; set; }
    }
}

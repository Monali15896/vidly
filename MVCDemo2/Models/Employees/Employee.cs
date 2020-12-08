using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo2.Models.Employees
{
    [Table("tblEmployee")]
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage ="Enter Employee Name")]
        [Display(Name="Employee Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Enter Gender")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Enter City")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Enter City")]
        [Display(Name = "Salary")]
        public int Salary { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Age")]
        [Display(Name = "Age")]
        [Range(20,50)]
        public int Age { get; set; }


    }
}

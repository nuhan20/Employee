using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Employee.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Please do not enter values over 10 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Please do not enter values over 10 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> DOB { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Employee Type")]
        public string Type { get; set; }

        [Required]
        [Range(500, 25000, ErrorMessage = "Please enter the correct value")]
        public double Salary { get; set; }

        [Required]
        public EmployeeDesignation Designation { get; set; }

        [Required]
        public EmployeeDepartment Department { get; set; }

        [Required]
        [MinLength(11, ErrorMessage = "Do not enter less than 11")]
        [MaxLength(11, ErrorMessage = "do not enter more then 11")]
        public string Phone { get; set; }

        [Required]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Your Email is not valid.")]
        public string Email { get; set; }

    }
    public enum EmployeeDesignation
    {
        Officer,
        Manager,
        Director,
        President,
        Leader
    }
    public enum EmployeeDepartment
    {
        Management,
        IT,
        Accounts,
        HR,
        Information
    }
}
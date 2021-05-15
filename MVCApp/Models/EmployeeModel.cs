using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Employee ID")]
        [Range( 100, 999, ErrorMessage ="Please type in a 3 digit number.")]
        public int EmployeeID { get; set; }
        
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please type in your first name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please type in your last name.")]
        public string LastName{ get; set; }
        
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Adress")]
        [Required(ErrorMessage = "Please type in your Email Adress.")]
        public string EmailAdress { get; set; }
        
        [Display(Name = "Confirm Email")]
        [Compare("EmailAdress", ErrorMessage = "Please match Email and Confirm Email.")]
        public string ConfirmEmail { get; set; }
        
        [Display(Name = "Password")]
        [Required(ErrorMessage ="Please type in a password.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Please type in an at least 5 character long password.")]
        public string Password { get; set; }

        [Display(Name ="Confirm password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Please match password and Confirm password")]
        public string ConfirmPassword { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Y4C2.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name Required")]
        [DataType(DataType.Text,ErrorMessage ="Invalid First name")]
        public string FName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name Required")]
        public string LName { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email Address Required")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username Required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "Date of Birth Required")]
        [DataType(DataType.Date,ErrorMessage ="Invalid Date of Birth")]
        public DateTime Dob { get; set; }

        [Display(Name = "Have You Taken A Yoga Class Before?")]
        [Required(ErrorMessage = "Response Required")]
        public string TakenYogaClass { get; set; }

        public int RoleId { get; set; }
    }
}

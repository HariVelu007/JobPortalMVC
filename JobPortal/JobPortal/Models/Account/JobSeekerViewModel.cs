using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace JobPortal.Models.Account
{
    public class JobSeekerViewModel
    {
        [Required(ErrorMessage = "Name is required")]        
        public string Name { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        [DataType(DataType.Date)]
        [Display(Name="Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "gender is required")]
        public char Gender { get; set; }
        
        public string Address { get; set; }

        [Required(ErrorMessage = "About is required")]
        public string About { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Mobile is required")]
        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid mail id")]
        [DisplayName("E-Mail")]
        public string EMail { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Logo { get; set; }
        public int Status { get; set; }= 0;
    }

    public class JobSeekerRegViewModel : JobSeekerViewModel
    {
        [Required(ErrorMessage = "Confirm password is required")]
        [Compare("Password", ErrorMessage = "Password and Compare password not matched")]
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}

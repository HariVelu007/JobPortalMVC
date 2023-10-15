using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JobPortal.Models.Account
{
    public class EmployerViewModel
    {
        [Required(ErrorMessage ="Company name is required")]
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Contact person is required")]
        [DisplayName("Contact Person")]
        public string ContactPerson { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Mobile is required")]
        [DataType(DataType.PhoneNumber,ErrorMessage ="Invalid mobile number")]
        public string Mobile { get; set; }

        [DataType(DataType.MultilineText)]
        public string Detail { get; set; }

        public string Type { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Invalid mail id")]
        [DisplayName("E-Mail")]
        public string EMail { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Logo { get; set; }
    }
    public class EmployerRegViewModel: EmployerViewModel
    {
        [Required(ErrorMessage = "Confirm password is required")]
        [Compare("Password",ErrorMessage ="Password and Compare password not matched")]
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}

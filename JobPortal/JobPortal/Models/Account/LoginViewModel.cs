using System.ComponentModel.DataAnnotations;

namespace JobPortal.Models.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="User id required")]
        [EmailAddress(ErrorMessage ="Invalid user id")]
        public string UserID { get; set; }
        [Required(ErrorMessage ="Password required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Shopping_store.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Enter your email")]
        [EmailAddress]
        [Display(Name = "Mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Shopping_store.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Enter your email")]
        [EmailAddress]
        [Display(Name = "Mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^(\+8801[3-9]\d{8}|01[3-9]\d{8})$", ErrorMessage = "Invalid Bangladeshi phone number format.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Enter password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please re-enter your password")]
        [DataType(DataType.Password)]
        [Display(Name = "Repeat password")]
        [Compare("Password", ErrorMessage = "Passwords don't match")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}

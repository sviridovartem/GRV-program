using System.ComponentModel.DataAnnotations;

namespace Grv.Web.Models.AccountModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter your email address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(15, MinimumLength = 6)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
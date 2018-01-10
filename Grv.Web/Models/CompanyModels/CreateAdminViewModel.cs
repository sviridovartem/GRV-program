using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using Grv.BO;

namespace Grv.Web.Models.CompanyModels
{
    public class CreateAdminViewModel
    {
        [Required(ErrorMessage = "Please enter Admin's email")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Invalid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter Admin's password")]
        [DataType(DataType.Password)]
        [StringLength(15, MinimumLength = 6)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm password")]
        [DataType(DataType.Password)]
        [StringLength(15, MinimumLength = 6)]
        [Display(Name = "Confirm Password")]
        public string PasswordConfirmation { get; set; }

        public UserStatus Status { get; set; }

        public int CompanyId { get; set; }

        public static SelectList GetRankSelectList()
        {
            var enumValues = Enum.GetValues(typeof(UserStatus)).Cast<UserStatus>()
                .Select(e => new { Value = e.ToString(), Text = e.ToString() }).ToList();
            return new SelectList(enumValues, "Value", "Text");
        }

        public CreateAdminViewModel()
        {
            StatusList = GetRankSelectList();
        }

        public SelectList StatusList { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using Grv.BO;

namespace Grv.Web.Models.AdminModels
{
    public class UpdateAdminViewModel
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Password { get; set; }
        public UserStatus Status { get; set; }

        public string Email { get; set; }

        public static SelectList GetRankSelectList()
        {
            var enumValues = Enum.GetValues(typeof(UserStatus)).Cast<UserStatus>()
                .Select(e => new { Value = e.ToString(), Text = e.ToString() }).ToList();
            return new SelectList(enumValues, "Value", "Text");
        }

        public UpdateAdminViewModel()
        {
            StatusList = GetRankSelectList();
        }

        public SelectList StatusList { get; set; }
    }
}
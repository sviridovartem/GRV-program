using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using Grv.BO;

namespace Grv.Web.Models.UserModels
{
    public class EditSelectedUserViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Password { get; set; }
        public UserStatus Status { get; set; }

        public UserRole Role { get; set; }

        public static SelectList GetStatusSelectList()
        {
            var enumValues = Enum.GetValues(typeof(UserStatus)).Cast<UserStatus>()
                .Select(e => new { Value = e.ToString(), Text = e.ToString() }).ToList();
            return new SelectList(enumValues, "Value", "Text");
        }

        public static SelectList GetRoleSelectList()
        {
            var enumValues = Enum.GetValues(typeof(UserRole)).Cast<UserRole>()
                .Select(e => new { Value = e.ToString(), Text = e.ToString() }).Skip(2).ToList();
            return new SelectList(enumValues, "Value", "Text");
        }

        public EditSelectedUserViewModel()
        {
            StatusList = GetStatusSelectList();
            RoleList = GetRoleSelectList();
        }

        public SelectList StatusList { get; set; }
        public SelectList RoleList { get; set; }
    }
}
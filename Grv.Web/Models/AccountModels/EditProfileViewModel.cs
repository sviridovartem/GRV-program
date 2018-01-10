using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Grv.Web.Models.AccountModels
{
    public class EditProfileViewModel
    {
        public string Email { get; set; }
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Time zone")]
        public string TimeZoneId { get; set; }

        //TODO: 'Favorite' projects

        public IEnumerable<TimeZoneInfo> TimeZoneList
        {
            get { return TimeZoneInfo.GetSystemTimeZones(); }
        }
    }
}
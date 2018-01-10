using System.ComponentModel.DataAnnotations;

namespace Grv.Web.Models.AccountModels
{
    public class ProfileInfoViewModel
    {
        public int Id { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Display(Name = "Company")]
        public string CompanyName { get; set; }
        [Display(Name = "First name")]
        [DisplayFormat(NullDisplayText = "Never entered")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        [DisplayFormat(NullDisplayText = "Never entered")]
        public string LastName { get; set; }

        [Display(Name = "Timezone")]
        [DisplayFormat(NullDisplayText = "Never selected")]
        public string TimeZoneId { get; set; }
    }
}
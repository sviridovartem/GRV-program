using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace Grv.Web.Models.CompanyModels
{
    public class CreateCompanyViewModel
    {
        [Required(ErrorMessage = "Please enter company's name.")]
        [Display(Name = "Company's name")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Display(Name = "Default timezone")]
        public string TimeZoneId { get; set; }
        public SelectList TimezoneList { get; set; }
        public CreateCompanyViewModel()
        {
            TimezoneList = new SelectList(TimeZoneInfo.GetSystemTimeZones().ToList(), "Id", "DisplayName", TimeZoneId);
        }
    }

    public class UpdateCompanyViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter company's name.")]
        [Display(Name = "Company's name")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Display(Name = "Default timezone")]
        public string TimeZoneId { get; set; }
        public SelectList TimezoneList { get; set; }
        public UpdateCompanyViewModel()
        {
            TimezoneList = new SelectList(TimeZoneInfo.GetSystemTimeZones().ToList(), "Id", "DisplayName", TimeZoneId);
        }
    }

}

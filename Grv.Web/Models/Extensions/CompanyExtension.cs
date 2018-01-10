using Grv.BO;
using Grv.Web.Models.CompanyModels;

namespace Grv.Web.Models.Extensions
{
    public static class CompanyExtension
    {
        public static Company ToCompany(this CreateCompanyViewModel model)
        {
            return new Company
            {
                Name = model.Name,
                TimezoneId = model.TimeZoneId
            };
        }

        public static Company ToCompany(this UpdateCompanyViewModel model)
        {
            return new Company
            {
                Id = model.Id,
                Name = model.Name,
                TimezoneId = model.TimeZoneId
                
            };
        }
    }
}
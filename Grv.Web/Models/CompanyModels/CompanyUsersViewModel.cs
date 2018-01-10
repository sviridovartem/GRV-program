using System.Collections.Generic;

namespace Grv.Web.Models.CompanyModels
{
    public class CompanyUsersViewModel
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public IEnumerable<BO.User> UsersList { get; set; }
    }
}
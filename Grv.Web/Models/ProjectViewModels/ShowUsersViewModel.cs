using System.Collections.Generic;

namespace Grv.Web.Models.ProjectViewModels
{
    public class ShowUsersViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<UserViewModel> Users { get; set; }
    }

    public class UserViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
    }
}
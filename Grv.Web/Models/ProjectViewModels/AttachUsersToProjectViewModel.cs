using System.Collections.Generic;
using System.Web.Mvc;
using Grv.BO;

namespace Grv.Web.Models.ProjectViewModels
{
    public class AttachUsersToProjectViewModel
    {
        public IEnumerable<int> UsersIds { get; set; }
        
        
        public IEnumerable<User> Users { get; set; }
        public string ProjectName { get; set; }
        public int ProjectId { get; set; }

        public MultiSelectList UsersList { get; set; }

    }
}
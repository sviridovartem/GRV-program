using Grv.BO;
using Grv.Web.Models.ProjectViewModels;

namespace Grv.Web.Models.Extensions
{
    public static class ProjectExtension
    {
        public static Project ToProject(this CreateProjectViewModel model)
        {
            return new Project()
            {
                Name = model.Name, 
              //  Company = model.Company,
                Users = model.Users,
                ProjectType = model.ProjectType,
                
            };
        }
    }
}
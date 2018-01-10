using Grv.BO;
using Grv.Services;

namespace Grv.BLL
{
    public class ProjectManager
    {
        private readonly UserService _userService;
        private readonly CompanyService _companyService;
        private readonly ProjectService _projectService;

        public ProjectManager(UserService userService, CompanyService companyService, ProjectService projectService)
        {
            _userService = userService;
            _companyService = companyService;
            _projectService = projectService;
        }
        public bool Update(int id, string name, ProjectType type)
        {
            var project = _projectService.Get(id);
            if (project == null)
            {
                return false;
            }

            if (name != null)
            {
                project.Name = name;
            }
            project.ProjectType = type;
            _projectService.Update(project);
            return true;
        }

        public bool Delete(int id)
        {
            var project = _projectService.Get(id);
            if (project == null)
            {
                return false;
            }
            _projectService.Delete(id);
            return true;
        }
    }
}

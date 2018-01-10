using System.Threading.Tasks;
using Grv.Services;

namespace Grv.BLL
{
    public class TaskManager
    {
        private readonly UserService _userService;
        private readonly CompanyService _companyService;

        public TaskManager(UserService userService, CompanyService companyService)
        {
            _userService = userService;
            _companyService = companyService;
        }

        public bool AddTask(Task task)
        {
            
            return false;
        }
    }
}

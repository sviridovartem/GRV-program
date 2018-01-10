using System.Web.Mvc;
using Grv.Web.Filters;

namespace Grv.Web.Controllers
{
    [SimpleAuthorize(Roles = "Superadmin")]
    public class CompanyController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

    }
}

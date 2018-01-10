using System.Web.Mvc;
using Grv.Web.Filters;

namespace Grv.Web.Controllers
{
    [SimpleAuthorize(Roles = "Superadmin, Admin, User")]
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}

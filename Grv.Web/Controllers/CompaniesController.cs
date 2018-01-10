using System.Linq;
using System.Web.Mvc;
using Grv.BLL;
using Grv.BO;
using Grv.Services;
using Grv.Web.Filters;
using Grv.Web.Models.AdminModels;
using Grv.Web.Models.CompanyModels;
using Grv.Web.Models.Extensions;
using Grv.Web.Models.Shared;

namespace Grv.Web.Controllers
{
    [SimpleAuthorize(Roles = "Superadmin")]
    public class CompaniesController : Controller
    {
        private readonly UserService _userService;
        private readonly CompanyService _companyService;

        private readonly UserManager _userManager;

        public CompaniesController()
        {
            _userService = new UserService();
            _companyService = new CompanyService();

            _userManager = new UserManager(_userService, _companyService);
        }


        #region AddCompany

        [HttpGet]
        public ActionResult Add()
        {
            var model = new CreateCompanyViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(CreateCompanyViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            if (_companyService.Get(model.Name) != null)
            {
                ModelState.AddModelError("Name", "Company's name already registered");
                return View(model);
            }

            _companyService.Add(model.ToCompany());

            return RedirectToAction("Index");
        }

        #endregion //AddCompany

        #region UpdateCompany

        [HttpGet]
        public ActionResult Update(int id)
        {
            var company = _companyService.Get(id);

            if (company == null) return RedirectToAction("Index");

            var model = new UpdateCompanyViewModel
            {
                Id = id,
                Name = company.Name,
                TimeZoneId = company.TimezoneId
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(UpdateCompanyViewModel model)
        {
            var company = _companyService.Get(model.Id);

            if (company != null && company.Id != model.Id)
            {
                ModelState.AddModelError("Name", "Company's name already registered");
                return View(model);
            }

            _companyService.Update(model.ToCompany());

            return RedirectToAction("Index", "Companies");
        }

        #endregion //UpdateCompany

        [HttpGet]
        public ActionResult Index()
        {
            var model = _companyService.GetAll().ToList();

            return View(model);
        }

        [HttpGet]
        public ActionResult Admins(int id)
        {
            var company = _companyService.Get(id);

            if (company == null) return RedirectToAction("Index");

            var model = new CompanyUsersViewModel
            {
                CompanyId = company.Id,
                CompanyName = company.Name,
                UsersList = _userService.GetCompanyAdmins(company.Id)
            };

            return View(model);
        }

        #region CreateAdmin

        [HttpGet]
        public ActionResult CreateAdmin(int id)
        {
            var company = _companyService.Get(id);

            if (company == null) return RedirectToAction("Admins");

            var model = new CreateAdminViewModel
            {
                CompanyId = company.Id,
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateAdmin(CreateAdminViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.Password != model.PasswordConfirmation)
            {
                ModelState.AddModelError("Password", "Password doesn't match its confirmation");
                return View(model);
            }

            if (_userService.GetAll().Any(u => u.Email == model.Email))
            {
                ModelState.AddModelError("Email", "Email already is use");
                return View(model);
            }

            _userManager.Register(model.Email, model.Password, model.CompanyId, UserRole.Admin, model.Status);

            return RedirectToAction("Admins", "Companies", new {id = model.CompanyId});
        }

        #endregion //CreateAdmin

        #region UpdateAdmin

        [HttpGet]
        public ActionResult UpdateAdmin(int id)
        {
            var user = _userService.Get(id);

            if (user == null) return RedirectToAction("index");

            var model = new UpdateAdminViewModel()
            {
                Id = id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Status = user.Status,
                Email = user.Email
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateAdmin(UpdateAdminViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            _userManager.Update(model.Id, model.FirstName, model.LastName, model.Password, model.Status, UserRole.Admin);

            var user = _userService.Get(model.Id);
            return RedirectToAction("Admins", "Companies", new {id = user.CompanyId});
        }

        #endregion //UpdateAdmin

        [HttpGet]
        public ActionResult ConfirmDeleteAdmin(int? id)
        {
            var user = _userService.Get(id.GetValueOrDefault());
            if (user == null)
            {
                return RedirectToAction("Index");
            }
            var model = new ConfirmDeleteViewModel
            {
                Id = user.Id,
                Name = "'" + (user.FirstName ?? "") + " " + (user.LastName ?? "") + "'"
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmDeleteAdmin(ConfirmDeleteViewModel model)
        {
            _companyService.Delete(model.Id);

            return RedirectToAction("Index");
        }
    }
}

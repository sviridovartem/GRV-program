using System.Linq;
using System.Web.Mvc;
using Grv.BLL;
using Grv.Services;
using Grv.Web.Filters;
using Grv.Web.Models.Shared;
using Grv.Web.Models.UserModels;

namespace Grv.Web.Controllers
{
    [SimpleAuthorize(Roles = "Admin")]
    public class UsersController : Controller
    {
        private readonly UserService _userService;
        private readonly CompanyService _compService;

        private readonly UserManager _userManager;

        public UsersController()
        {
            _userService = new UserService();
            _compService = new CompanyService();

            _userManager = new UserManager(_userService, _compService);
        }

        [HttpGet]
        public ActionResult Index()
        {
            var company = _userService.Get(User.Identity.Name).Company;
            var users = _userService.GetByCompany(company.Id);
            var model = users
                .Select(user => new UserViewModel() {Id = user.Id, Email = user.Email, Role = user.Role.ToString("G"), Status = user.Status.ToString("G")}).ToList();

            return View(model);
        }

        #region Add
        [HttpGet]
        public ActionResult Add()
        {
            var model = new CreateUserViewModel { CompanyId = _userService.Get(User.Identity.Name).Company.Id };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(CreateUserViewModel model)
        {

            if (ModelState.IsValid && _userManager.Register(model.Email, model.Password, model.CompanyId, model.Role, model.Status))
            {
                _userManager.Update(model.Email, model.FirstName, model.LastName, null);
                return RedirectToAction("Index");
            }
            if (_userService.Get(model.Email) != null)
            {
                ModelState.AddModelError("Email", "E-mail address already in use");   
            }

            return View(model);
        }
        #endregion //AddUser




        #region EditSelectedUser
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (_userService.Get(User.Identity.Name).CompanyId != _userService.Get(id.GetValueOrDefault()).CompanyId)
                return new HttpStatusCodeResult(403); //Forbidden

            var user = _userService.Get(id.GetValueOrDefault());
            var model = new EditSelectedUserViewModel()
            {
                Email = user.Email,
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Status = user.Status,
                Role = user.Role
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditSelectedUserViewModel model)
        {
            if (ModelState.IsValid && _userManager.Update(model.Id, model.FirstName, model.LastName, model.Password, model.Status, model.Role))
            {
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("FirstName", "Failed to apply changes.");
            return View(model);
        }
        #endregion //EditSelectedUser

        #region ConfirmDelete
        [HttpGet]
        [SimpleAuthorize(Roles = "Admin")]
        public ActionResult ConfirmDelete(int? id)
        {
            var user = _userService.Get(id.GetValueOrDefault());
            if (user == null)
            {
                return RedirectToAction("Index");
            }
            var model = new ConfirmDeleteViewModel() { Id = user.Id, Name = user.Email };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [SimpleAuthorize(Roles = "Admin")]
        public ActionResult ConfirmDelete(ConfirmDeleteViewModel model)
        {
            if (_userManager.Delete(model.Id))
            {
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("Name", "Error deleting user");
            return RedirectToAction("Index");
        }
        #endregion //ConfirmDelete
    }
}

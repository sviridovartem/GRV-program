using System;
using System.Web.Mvc;
using System.Web.Security;
using Grv.BLL;
using Grv.Services;
using Grv.Web.Filters;
using Grv.Web.Models.AccountModels;

namespace Grv.Web.Controllers
{
    [SimpleAuthorize]
    public class AccountController : Controller
    {
        private readonly UserService _userService;
        private readonly CompanyService _compService;

        private readonly UserManager _userManager;

        public AccountController()
        {
            _userService = new UserService();
            _compService = new CompanyService();

            _userManager = new UserManager(_userService, _compService);
        }
        
        [HttpGet]
        [SimpleAuthorize(Roles = "Admin, User")]
        public ActionResult Index()
        {
            var user = _userService.Get(User.Identity.Name);
            var companyId = _userService.Get(User.Identity.Name).CompanyId;
            string companyName = null;
            if (companyId != null)
            {
                companyName = _compService.Get(companyId.GetValueOrDefault()).Name;
            }
            var model = new ProfileInfoViewModel() 
            {
                Id = user.Id, 
                CompanyName = companyName, 
                LastName = user.LastName, 
                FirstName  = user.FirstName, 
                Email = user.Email,
                TimeZoneId = user.TimeZoneId == null ? null : TimeZoneInfo.FindSystemTimeZoneById(user.TimeZoneId).DisplayName
            };
            return View(model); 
        }

        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }


        #region Login
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginModel);
            }

            if (_userManager.Login(loginModel.Email, loginModel.Password, loginModel.RememberMe))
            {
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("Email", "Login or password is incorrect");
            return View(loginModel);
        }
        #endregion //Login

        #region EditProfile
        [HttpGet]
        [SimpleAuthorize(Roles = "Admin, User")]
        public ActionResult EditProfile()
        {
            var user = _userService.Get(User.Identity.Name);
            var model = new EditProfileViewModel()
            {
                Email = user.Email,
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,

                TimeZoneId = user.TimeZoneId
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [SimpleAuthorize(Roles = "Admin, User")]
        public ActionResult EditProfile(EditProfileViewModel model)
        {
            if (ModelState.IsValid && _userManager.Update(User.Identity.Name, model.FirstName, model.LastName, model.TimeZoneId))
            {
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("FirstName", "Failed to apply changes.");
            return View(model);
        }
        #endregion //EditProfile
    }
}

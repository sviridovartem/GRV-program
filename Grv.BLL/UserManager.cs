using System;
using System.Web;
using System.Web.Security;
using Grv.BO;
using Grv.Services;

namespace Grv.BLL
{
    public class UserManager
    {
        private readonly UserService _userService;
        private readonly CompanyService _companyService;

        public UserManager(UserService userService, CompanyService companyService)
        {
            _userService = userService;
            _companyService = companyService;
        }

        public bool Login(string email, string password, bool rememberMe)
        {
            var user = _userService.Get(email);

            if (user == null) return false;
            if (user.Status == UserStatus.Inactive) return false;
            if (user.Password != password) return false; //TODO:Encode Sha256

            var ticket = new FormsAuthenticationTicket(1, email, DateTime.Now,
                rememberMe ? DateTime.Now.AddDays(2) : DateTime.Now.AddHours(2), rememberMe, "");
            var cookieData = FormsAuthentication.Encrypt(ticket);
            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, cookieData)
            {
                Expires = DateTime.Now.AddDays(7)
            };
            HttpContext.Current.Response.Cookies.Add(cookie);

            return true;
        }

        public bool Register(string email, string pass, int companyId, UserRole role, UserStatus status)
        {
            if (_userService.Get(email) != null) return false;

            _userService.Add(new User { Email = email, Password = pass, CompanyId = companyId, Role = role, Status = status});
            return true;
        }

        public bool Update(string email, string firstName, string lastName, string timeZoneId)
        {
            var user = _userService.Get(email);
            if (user == null)
            {
                return false;
            }

            if (firstName != null)
            {
                user.FirstName = firstName;
            }
            if (lastName != null)
            {
                user.LastName = lastName;
            }
            if (timeZoneId != null)
            {
                user.TimeZoneId = timeZoneId;
            }
            _userService.Update(user);
            return true;
        }

        public bool Update(int id, string firstName, string lastName, string password, UserStatus status, UserRole role)
        {
            var user = _userService.Get(id);
            if (user == null)
            {
                return false;
            }

            if (firstName != null)
            {
                user.FirstName = firstName;
            }
            if (lastName != null)
            {
                user.LastName = lastName;
            }
            if (password != null)
            {
                user.Password = password;
            }
            user.Status = status;
            user.Role = role;
            _userService.Update(user);
            return true;
        }

        public bool Delete(int id)
        {
            var project = _userService.Get(id);
            if (project == null)
            {
                return false;
            }
            _userService.Delete(id);
            return true;
        }
    }
}

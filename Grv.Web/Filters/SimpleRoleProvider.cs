using System;
using System.Web.Security;
using Grv.Services;

namespace Grv.Web.Filters
{
    public class SimpleRoleProvider : RoleProvider
    {
        private const string Argument = "Email";
        public override bool IsUserInRole(string email, string roleName)
        {
            var user = new UserService().Get(email);
            if (user == null) throw new ArgumentNullException(Argument);

            return user.Role.ToString() == roleName;
        }

        public override string[] GetRolesForUser(string email)
        {
            var user = new UserService().Get(email);
            if (user == null) throw new ArgumentNullException(Argument);

            return new[] { user.Role.ToString() };
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void AddUsersToRoles(string[] emails, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] emails, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string emailToMatch)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName { get; set; }
    }
}
using System.Linq;
using System.Web.Mvc;
using Grv.BLL;
using Grv.Services;
using Grv.Web.Filters;
using Grv.Web.Models.Extensions;
using Grv.Web.Models.ProjectViewModels;
using Grv.Web.Models.Shared;

namespace Grv.Web.Controllers
{
    [SimpleAuthorize(Roles = "Admin")]
    public class ProjectsController : Controller
    {
        private readonly UserService _userService;
        private readonly CompanyService _compService;
        private readonly ProjectService _projService;

        private readonly ProjectManager _projectManager;

        public ProjectsController()
        {
            _userService = new UserService();
            _compService = new CompanyService();
            _projService = new ProjectService();

            _projectManager = new ProjectManager(_userService,_compService, _projService);
        }

        [HttpGet]
        public ActionResult Index()
        {
            var user = _userService.Get(User.Identity.Name);
            var projects = _projService.GetAll().Where(x=>x.CompanyId == user.CompanyId);
            var items = projects.ToList();

            return View(items);
        }

        /*

        #region DetachUser
        [HttpGet]
        [TimeReportsAuthorize(Roles = "Admin")]
        public ActionResult DetachUser(int id, int userid)
        {
            _projService.RemoveUser(id, userid);
            return RedirectToAction("ShowUsers", new {id});
        }
        #endregion //DetachUsers

        #region AttachUsers
        [HttpGet]
        [TimeReportsAuthorize(Roles = "Admin")]
        public ActionResult AttachUsers(int id)
        {
            var project = _projService.Get(id);
            var users = _userService.GetWithoutProject(id).Where(x=>x.CompanyId == project.CompanyId);

            var model = new AttachUsersToProjectViewModel()
            {
                ProjectId = id, ProjectName = project.Name
            };
            model.UsersList = new MultiSelectList(users, "Id", "Email", model.Users);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [TimeReportsAuthorize(Roles = "Admin")]
        public ActionResult AttachUsers(AttachUsersToProjectViewModel model)
        {
            foreach (var userId in model.UsersIds)
            {
                _projService.AddUser(model.ProjectId, userId);
            }
            return RedirectToAction("ShowUsers", new {id = model.ProjectId});
        }
         
        #endregion //AttachUsers*/

        #region Add
        [HttpGet]
        [SimpleAuthorize(Roles = "Admin")]
        public ActionResult Add()
        {
            var model = new CreateProjectViewModel { CompanyName = _userService.Get(User.Identity.Name).Company.Name };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [SimpleAuthorize(Roles = "Admin")]
        public ActionResult Add(CreateProjectViewModel model)
        {
            if (ModelState.IsValid)
            {
                var proj = model.ToProject();
                proj.CompanyId = _compService.Get(model.CompanyName).Id;
                _projService.Add(proj);
                return RedirectToAction("Index");
            }
            if (_projService.Get(model.Name, model.CompanyName) != null)
            {
                ModelState.AddModelError("Name", "Project with that name already registered in this company");
            }

            return View(model);
        }
         
        #endregion //AddProject

        #region Edit
        [HttpGet]
        [SimpleAuthorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            var project = _projService.Get(id.GetValueOrDefault());
            if (project == null)
            {
                return RedirectToAction("Index");
            }

            var users = _userService.GetAll().Where(x => x.CompanyId == project.CompanyId);
            var selectedUsers = project.Users;
            var model = new EditProjectViewModel
            {
                Id = project.Id,
                Name = project.Name,
                ProjectType = project.ProjectType,
                UsersList = new MultiSelectList(users, "Id", "Email", selectedUsers.Select(user => user.Id).ToList()/*selectedUsers*/),
                UsersIds = selectedUsers.Select(user => user.Id).ToList()
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [SimpleAuthorize(Roles = "Admin")]
        public ActionResult Edit(EditProjectViewModel model)
        {
            if (ModelState.IsValid && _projectManager.Update(model.Id, model.Name, model.ProjectType))
            {
                var usersRemove = _userService.GetByProject(model.Id).Where(x => !model.UsersIds.Contains(x.Id));
                foreach (var user in usersRemove)
                {
                    _projService.RemoveUser(model.Id, user.Id);
                }
                //usersRemove.Where(x => model.UsersIds.Contains(x.Id));
                foreach (var userId in model.UsersIds)
                {
                    _projService.AddUser(model.Id, userId);
                }
                return RedirectToAction("Index");
            }
            var company = _projService.Get(model.Id).Company;
            if (_projService.GetAll().Where(x=>x.CompanyId == company.Id).Any(y=>y.Name == model.Name) )
            {
                ModelState.AddModelError("Name", "Project with that name already registered in this company");
            }
            
            return View(model);
        }
        #endregion //EditProject

        #region ConfirmDelete
        [HttpGet]
        [SimpleAuthorize(Roles = "Admin")]
        public ActionResult ConfirmDelete(int? id)
        {
            var project = _projService.Get(id.GetValueOrDefault());
            if (project == null)
            {
                return RedirectToAction("Index");
            }
            var model = new ConfirmDeleteViewModel { Id = project.Id, Name = project.Name };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [SimpleAuthorize(Roles = "Admin")]
        public ActionResult ConfirmDelete(ConfirmDeleteViewModel model)
        {
            if (_projectManager.Delete(model.Id))
            {
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("Name", "Error deleting project");
            return RedirectToAction("Index");
        }
        #endregion //ConfirmDelete

        /*#region Users
        [HttpGet]
        [TimeReportsAuthorize(Roles = "Admin")]
        public ActionResult Users(int? id)
        {
            var project = _projService.Get(id.GetValueOrDefault());
            if (project == null)
            {
                return RedirectToAction("Index");
            
            }

            var users = _userService.GetByProject(id.GetValueOrDefault()).ToList();
            var model = new ShowUsersViewModel
            {
                Name = project.Name,
                Id = id.GetValueOrDefault(),
                Users = users
                    .Select(
                        user =>
                            new UserViewModel()
                            {
                                Id = user.Id,
                                Email = user.Email,
                                Status = user.Status.ToString("G")
                            }).ToList()
            };

            return View(model);
        }

       
        #endregion //ShowUsers*/
    }
}

using System;
using System.Linq;
using System.Web.Mvc;
using Grv.BO;
using Grv.Services;
using Grv.Web.Filters;
using Grv.Web.Models.Extensions;
using Grv.Web.Models.TaskModels;

namespace Grv.Web.Controllers
{
    [SimpleAuthorize(Roles = "Admin, User")]
    public class TasksController : Controller
    {
        private readonly UserService _userService;
        private readonly TaskService _taskService;
        private readonly CompanyService _companyService;
        private readonly ProjectService _projectService;

        public TasksController()
        {
            _userService = new UserService();
            _taskService = new TaskService();
            _companyService = new CompanyService();
            _projectService = new ProjectService();
        }

        public ActionResult Index()
        {
            var user = _userService.Get(User.Identity.Name);

            var model = new TasksViewModel(user, _taskService, _projectService);
            return View(model);
        }

        [HttpPost]
        public ActionResult AddRow()
        {
            var user = _userService.Get(User.Identity.Name);
            var projects = _projectService.GetAll(user.CompanyId.GetValueOrDefault());
            var list = projects.Select(item => new { Id = item.Id, Name = item.Name }).ToList();
            return Json(list.ToJson());
        }

        [HttpPost]

        public ActionResult Save(SaveTaskViewModel model)
        {

            if (model.Summary == null || model.Summary.Length < 10)
            {
                return new HttpStatusCodeResult(400, "Your summary is to short!");
            }
            var user = _userService.Get(User.Identity.Name);
            var timezone = TimeZoneInfo.FindSystemTimeZoneById(user.TimeZoneId);
            model.From = DateTime.SpecifyKind(model.From, DateTimeKind.Unspecified);
            model.To = DateTime.SpecifyKind(model.To, DateTimeKind.Unspecified);
            model.From = TimeZoneInfo.ConvertTime(model.From, timezone, TimeZoneInfo.Utc);
            model.To = TimeZoneInfo.ConvertTime(model.To, timezone, TimeZoneInfo.Utc);
            var userId = _userService.Get(User.Identity.Name).Id;
            Task task;
            if (model.Id == -1)
            {
                task = new Task() {From = model.From.ToUniversalTime(), To = model.To.ToUniversalTime(), Summary = model.Summary, ProjectId = model.ProjectId, UserId = userId};
                int id = _taskService.Add(task);
                return Json(new { Message = "Task created!", Id = id });
            }
            task = _taskService.Get(model.Id);
            if (task == null)
                return new HttpStatusCodeResult(400, "Error updating task [id = " + model.Id + "]!");
            task.Summary = model.Summary;
            task.From = model.From;
            task.To = model.To;
            task.ProjectId = model.ProjectId;
            _taskService.Update(task);
            return Json(new { Message = "Task updated!", Id = task.Id });
        }

        [HttpPost]
        public ActionResult Delete(SaveTaskViewModel model)
        {
            var task = _taskService.Get(model.Id);
            if (task == null)
                return new HttpStatusCodeResult(400, "Error deleting task [id = " + model.Id + "]!");
            _taskService.Delete(task.Id);
            return Json(new { Message = "Task deleted!" });
        }

        [HttpPost]
        public ActionResult GetByDate(DateTime day)
        {
            var user = _userService.Get(User.Identity.Name);

            var model = new TasksViewModel(user, _taskService, _projectService, day:day);
            return PartialView(model);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Grv.BO;
using Grv.Services;

namespace Grv.Web.Models.TaskModels
{
    public class TasksViewModel
    {
        public DateTime CurrentDay { get; set; }
        public DateTime WeekStart { get; set; }
        public DateTime WeekEnd { get; set; }

        public IList<Task> Tasks { get; set; }
        public IList<Project> Projects { get; set; } 

        public TasksViewModel(User user, TaskService taskService, ProjectService projectService, DateTime? day = null)
        {
            var timeZone = TimeZoneInfo.FindSystemTimeZoneById(user.TimeZoneId);
            var x = DateTime.UtcNow;
            var y = day.GetValueOrDefault();

            CurrentDay = day == null 
                ? TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZone).Date 
                : TimeZoneInfo.ConvertTime(day.GetValueOrDefault(), timeZone).Date;
            WeekStart = CurrentDay.AddDays(-(int)CurrentDay.DayOfWeek).Date;
            WeekEnd = CurrentDay.AddDays(6 - (int)CurrentDay.DayOfWeek).Date;

            Tasks = taskService.GetTaskRange(user.Id, CurrentDay.AddDays(-1), CurrentDay.AddDays(2).Date).ToList();
            foreach (var task in Tasks)
            {
                task.From = TimeZoneInfo.ConvertTimeFromUtc(task.From, timeZone);
                task.To = TimeZoneInfo.ConvertTimeFromUtc(task.To, timeZone);
            }
            Tasks = Tasks.Where( z => (z.From.Date == CurrentDay.Date && z.To.Date == CurrentDay.Date)).ToList();

            Projects = projectService.GetAll(user.CompanyId.GetValueOrDefault()).ToList();
        }
    }
}
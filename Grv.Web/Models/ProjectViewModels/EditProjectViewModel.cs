using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using Grv.BO;

namespace Grv.Web.Models.ProjectViewModels
{
    public class EditProjectViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Type")]
        public ProjectType ProjectType { get; set; }
        public static SelectList GetRankSelectList()
        {
            var enumValues = Enum.GetValues(typeof(ProjectType)).Cast<ProjectType>().Select(e => new { Value = e.ToString(), Text = e.ToString() }).ToList();

            return new SelectList(enumValues, "Value", "Text");
        }
        public EditProjectViewModel()
        {
            TypeList = GetRankSelectList();
        }

        public SelectList TypeList { get; set; }


        public IEnumerable<int> UsersIds { get; set; }
        public IEnumerable<User> Users { get; set; }
        public MultiSelectList UsersList { get; set; }
    }
}
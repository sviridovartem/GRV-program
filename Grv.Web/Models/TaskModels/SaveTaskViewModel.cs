using System;

namespace Grv.Web.Models.TaskModels
{
    public class SaveTaskViewModel
    {
        public int Id { get; set; }
        public string Summary { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int ProjectId { get; set; }

    }
}
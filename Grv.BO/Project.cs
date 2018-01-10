using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grv.BO
{
    public enum ProjectType
    {
        Paid = 0,
        Unpaid
    } 

    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public ProjectType ProjectType { get; set; }
        public bool IsDeleted { get; set; }

        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}

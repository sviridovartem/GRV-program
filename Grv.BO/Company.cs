using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grv.BO
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public string TimezoneId { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}

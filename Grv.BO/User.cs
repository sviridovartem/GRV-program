using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grv.BO
{
    public enum UserRole
    {
        Superadmin = 0,
        Company,
        Admin,
        User‏
    }

    public enum UserStatus
    {
        Active = 1,
        Inactive
    }

    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }


        public UserRole Role { get; set; }

        public UserStatus Status { get; set; }

        
        public int? CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        public virtual ICollection<Project> Projects { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }

        public string TimeZoneId { get; set; }
    }
}

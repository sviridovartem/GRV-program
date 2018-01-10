using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Grv.BO;

namespace Grv.DAL
{
    public class WebContext : DbContext
    {
        private const string ConnectionStringName = "DefaultConnection";

        public WebContext() //string connectionString
            : base(ConnectionStringName) //connection string name
        {
         //   Configuration.LazyLoadingEnabled = false;

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; } 
    }
}

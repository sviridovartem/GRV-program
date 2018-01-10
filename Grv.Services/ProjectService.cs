using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using Grv.BO;
using Grv.DAL;

namespace Grv.Services
{
    public class ProjectService
    {
        public int Add(Project item)
        {
            using (var context = new WebContext())
            {
                context.Projects.Add(item);
                context.SaveChanges();

                return item.Id;
            }
        }

        public void Update(Project item)
        {
            using (var context = new WebContext())
            {
                context.Entry(item).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void AddUser(int projectId, int userId)
        {
            using (var context = new WebContext())
            {
                var project = context.Projects.Single(u => u.Id == projectId);
                var user = context.Users.Single(r => r.Id == userId);

                project.Users.Add(user);
                context.SaveChanges();
            }
        }

        public void RemoveUser(int projectId, int userId)
        {
            using (var context = new WebContext())
            {
                var project = context.Projects.Single(u => u.Id == projectId);
                var user = context.Users.Single(r => r.Id == userId);

                project.Users.Remove(user);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new WebContext())
            {
                var db = context.Projects.FirstOrDefault(a => a.Id == id);
                if (db != null)
                {
                    db.IsDeleted = true;
                }
                context.Entry(db).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Project Get(int id)
        {
            using (var context = new WebContext())
            {
                return context.Projects.Include(x=>x.Users).FirstOrDefault(a => a.Id == id && !a.IsDeleted);
            }
        }

        public Project Get(string name)
        {
            using (var context = new WebContext())
            {
                return context.Projects.Include(x => x.Users).FirstOrDefault(a => a.Name == name && !a.IsDeleted);
            }
        }

        public Project Get(string name, string compName)
        {
            using (var context = new WebContext())
            {
                return context.Projects.Include(x => x.Users).Where(x => x.Company.Name == compName && !x.IsDeleted).FirstOrDefault(y => y.Name == name);
            }
        }


        public IEnumerable<Project> GetAll()
        {
            using (var context = new WebContext())
            {
                return context.Projects.Include(x => x.Users).Include(x => x.Company).Where(x => !x.IsDeleted).ToArray();
            }
        }


        public IEnumerable<Project> GetAll(int companyId)
        {
            using (var context = new WebContext())
            {
                return context.Projects.Include(x => x.Users).Include(x => x.Company).Where(x => x.CompanyId == companyId && !x.IsDeleted).ToArray();
            }
        }

        public IEnumerable<Project> GetAllByUser(int userid)
        {
            using (var context = new WebContext())
            {
                var user = context.Users.FirstOrDefault(x => x.Id == userid);
                return user.Projects;
            }
        }
    }
}

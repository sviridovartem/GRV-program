using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using Grv.BO;
using Grv.DAL;

namespace Grv.Services
{
    public class UserService
    {
        public int Add(User item)
        {
            using (var context = new WebContext())
            {
                context.Users.Add(item);
                context.SaveChanges();
                return item.Id;             
            }
        }

        public void Update(User item)
        {
            using (var context = new WebContext())
            {
                context.Entry(item).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        private static void AssociateAndSave(int oId, int cId)
        {
            using (var context = new WebContext())
            {
                var owner = (from o in context.Users
                             select o).FirstOrDefault(o => o.Id == oId);
                var child = (from o in context.Projects
                             select o).FirstOrDefault(c => c.Id == cId);

                owner.Projects.Add(child);
            //    context.Attach(owner);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new WebContext())
            {
                var db = context.Users.FirstOrDefault(a => a.Id == id);
                if (db != null)
                {
                    db.IsDeleted = true;
                }
                context.Entry(db).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public User Get(int id)
        {
            using (var context = new WebContext())
            {
                return context.Users.Include(u => u.Company).Include(y=>y.Projects).FirstOrDefault(a => a.Id == id && !a.IsDeleted);
            }
        }


        public User Get(string email)
        {
            using (var context = new WebContext())
            {
                return context.Users
                    .Where(z => z.Email == email && !z.IsDeleted)
                    .Include(u=>u.Company)
                    .Include(y=>y.Projects)
                    .FirstOrDefault();
            }
        }

        public User Get(string email, string pass)
        {
            using (var context = new WebContext())
            {
                return context.Users
                    .Include(u => u.Company)
                    .Include(y=>y.Projects)
                    .FirstOrDefault(a => a.Email == email && a.Password == pass && !a.IsDeleted);
            }
        }

        public IEnumerable<User> GetCompanyAdmins(int id)
        {
            using (var context = new WebContext())
            {
                return context.Users.Where(u => u.CompanyId == id && u.Role == UserRole.Admin && !u.IsDeleted).ToArray();
            }
        }

        public IEnumerable<User> GetByCompany(int id)
        {
            using (var context = new WebContext())
            {
                return context.Users.Where(u => u.CompanyId == id && !u.IsDeleted).ToArray();
            }
        }

        public IEnumerable<User> GetByProject(int id)
        {
            using (var context = new WebContext())
            {
                return context.Users.Where(u => u.Projects.Any(x=>x.Id == id) && !u.IsDeleted).ToArray();
            }
        }
        public IEnumerable<User> GetWithoutProject(int id)
        {
            using (var context = new WebContext())
            {
                return context.Users.Where(u => u.Projects.All(x => x.Id != id) && !u.IsDeleted).ToArray();
            }
        } 


        public IEnumerable<User> GetAll()
        {
            using (var context = new WebContext())
            {
                return context.Users
                    .Include(u => u.Company)
                    .Include(y=>y.Projects)
                    .Where(a => !a.IsDeleted)
                    .ToArray();
            }
        }
    }
}

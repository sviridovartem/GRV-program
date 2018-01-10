using System.Collections.Generic;
using System.Data;
using System.Linq;
using Grv.BO;
using Grv.DAL;

namespace Grv.Services
{
    using WebDal = WebContext;
    public class CompanyService
    {
        public int Add(Company item)
        {
            using (var context = new WebDal())
            {
                context.Companies.Add(item);
                context.SaveChanges();

                return item.Id;
            }
        }

        public void Update(Company item)
        {
            using (var context = new WebDal())
            {
                context.Entry(item).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new WebDal())
            {
                var db = context.Companies.FirstOrDefault(a => a.Id == id);
                if (db != null)
                {
                    db.IsDeleted = true;
                }
                context.SaveChanges();
            }
        }

        public Company Get(int id)
        {
            using (var context = new WebDal())
            {
                return context.Companies.FirstOrDefault(a => a.Id == id && !a.IsDeleted);
            }
        }

        public Company Get(string name)
        {
            using (var context = new WebDal())
            {
                return context.Companies.FirstOrDefault(a => a.Name == name && !a.IsDeleted);
            }
        }

        public Company GetByUsername(string email)
        {
            using (var context = new WebDal())
            {
                var user = context.Users
                        .FirstOrDefault(y => y.Email == email && !y.IsDeleted);
                if (user == null)
                    return null;
                return user.Company.IsDeleted ? null : user.Company;
            }
        }

        public IEnumerable<Company> GetAll()
        {
            using (var context = new WebDal())
            {
                return context.Companies.Where(x => !x.IsDeleted).ToList();
            }
        }
    }
}

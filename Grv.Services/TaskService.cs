using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Grv.DAL;
using Task = Grv.BO.Task;

namespace Grv.Services
{
    public class TaskService
    {
          public int Add(Task item)
        {
            using (var context = new WebContext())
            {
                context.Tasks.Add(item);
                context.SaveChanges();

                return item.Id;
            }
        }

        public void Update(Task item)
        {
            using (var context = new WebContext())
            {
                context.Entry(item).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new WebContext())
            {
                var db = context.Tasks.FirstOrDefault(a => a.Id == id);
                if (db != null)
                {
                    db.IsDeleted = true;
                }
                context.SaveChanges();
            }
        }

        public Task Get(int id)
        {
            using (var context = new WebContext())
            {
                return context.Tasks.FirstOrDefault(a => a.Id == id && !a.IsDeleted);
            }
        }

        public IEnumerable<Task> GetAll()
        {
            using (var context = new WebContext())
            {
                return context.Tasks.Where(a=> !a.IsDeleted).ToArray();
            }
        }


        public IEnumerable<Task> GetAll(int userId)
        {
            using (var context = new WebContext())
            {
                return context.Tasks.Where(x => x.UserId == userId && !x.IsDeleted).ToArray();
            }
        }

        public IEnumerable<Task> GetTaskRange(int userId, DateTime from, DateTime to)
        {
            using (var context = new WebContext())
            {
                return context.Tasks.Where(x => x.UserId == userId && (x.From >= from && x.From < to)).Where(x => !x.IsDeleted).ToArray();
            }
        } 
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wunderlist.DataAccess.Interfaces.EF;
using Wunderlist.DataAccess.Interfaces.Entities;
using Wunderlist.DataAccess.Interfaces.Interfaces;
using System.Data.Entity;

namespace Wunderlist.DataAccess.Repositories
{
    public class TaskListRepository : IRepository<TaskList>
    {
        private WunderlistContext db;

        public TaskListRepository(WunderlistContext context)
        {
            this.db = context;
        }

        public void Create(TaskList item) => db.TaskLists.Add(item);

        public void Delete(int id)
        {
            var list = db.TaskLists.Find(id);
            if (list != null)
                db.TaskLists.Remove(list);
        }

        public TaskList Get(int id) => db.TaskLists.Find(id);

        public IEnumerable<TaskList> GetAll(int id) => db.TaskLists.Where(t => t.UserId == id);

        public void Update(TaskList item)
        {
            var updateList = db.TaskLists.FirstOrDefault(l => l.Id == item.Id);
            updateList.Name = item.Name;
            db.Entry(updateList).State = EntityState.Modified;
        }
    }
}

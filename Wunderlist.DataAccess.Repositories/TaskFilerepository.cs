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
    public class TaskFileRepository : IRepository<TaskFile>
    {
        private WunderlistContext db;

        public TaskFileRepository(WunderlistContext context)
        {
            this.db = context;
        }

        public void Create(TaskFile item) => db.TaskFiles.Add(item); 

        public void Delete(int id)
        {
            var file = db.TaskFiles.Find(id);
            if (file != null)
                db.TaskFiles.Remove(file);
        }

        public TaskFile Get(int id) => db.TaskFiles.Find(id);

        public IEnumerable<TaskFile> GetAll(int id) => db.TaskFiles.Where(t => t.TodoItemId == id);

        public void Update(TaskFile item)
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class SubtaskRepository : IRepository<Subtask>
    {
        private WunderlistContext db;

        public SubtaskRepository(WunderlistContext context)
        {
            this.db = context;
        }

        public void Create(Subtask item) => db.Subtasks.Add(item); 

        public void Delete(int id)
        {
            var subtask = db.Subtasks.Find(id);
            if (subtask != null)
                db.Subtasks.Remove(subtask);
        }

        public Subtask Get(int id) => db.Subtasks.Find(id);

        public IEnumerable<Subtask> GetAll(int id) => db.Subtasks.Where(s => s.TodoItemId == id);

        public void Update(Subtask item)
        {
            var updateSubtask = db.Subtasks.FirstOrDefault(s => s.Id == item.Id);
            updateSubtask.Record = item.Record;
            updateSubtask.IsComplited = item.IsComplited;
            db.Entry(updateSubtask).State = EntityState.Modified;
        }
    }
}

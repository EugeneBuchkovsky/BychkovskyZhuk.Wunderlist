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
    public class TodoItemRepository : IRepository<TodoItem>
    {
        private WunderlistContext db;

        public TodoItemRepository(WunderlistContext context)
        {
            this.db = context;
        }

        public void Create(TodoItem item) => db.TodoItems.Add(item);

        public void Delete(int id)
        {
            var item = db.TodoItems.Find(id);
            if (item != null)
                db.TodoItems.Remove(item);
        }

        public TodoItem Get(int id) => db.TodoItems.Find(id);

        public IEnumerable<TodoItem> GetAll(int id) => db.TodoItems.Where(i => i.TaskListId == id);

        public void Update(TodoItem item)
        {
            var updateItem = db.TodoItems.FirstOrDefault(i => i.Id == item.Id);
            updateItem.Record = item.Record;
            updateItem.CompletionDate = item.CompletionDate;
            updateItem.IsCompleted = item.IsCompleted;
            updateItem.IsMarked = item.IsMarked;
            updateItem.Note = item.Note;
            updateItem.NotificationDate = item.NotificationDate;
            db.Entry(updateItem).State = EntityState.Modified;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wunderlist.DataAccess.Interfaces.Entities;

namespace Wunderlist.DataAccess.Interfaces.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<User> Users { get; }
        IRepository<Comment> Comments { get; }
        IRepository<TodoItem> TodoItems { get; }
        IRepository<TaskList> TaskLists { get; }
        IRepository<TaskFile> TaskFiles { get; }
        IRepository<Subtask> Subtasks { get; }
        IRepository<Subscriber> Subscribers { get; }
        void Save();
    }
}

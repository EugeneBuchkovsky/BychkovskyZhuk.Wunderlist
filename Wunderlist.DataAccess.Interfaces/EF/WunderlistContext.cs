using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wunderlist.DataAccess.Interfaces.Entities;
using System.Data.Entity;

namespace Wunderlist.DataAccess.Interfaces.EF
{
    public class WunderlistContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<TaskList> TaskLists { get; set; }
        public DbSet<TaskFile> TaskFiles { get; set; }
        public DbSet<Subtask> Subtasks { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public WunderlistContext(string connectionString)
            : base(connectionString)
        { }
    }
}

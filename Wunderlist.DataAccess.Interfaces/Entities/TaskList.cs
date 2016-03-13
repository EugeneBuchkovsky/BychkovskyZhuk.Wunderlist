using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wunderlist.DataAccess.Interfaces.Entities
{
    public class TaskList
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? UserId { get; set; }

        public User User { get; set; }

        public ICollection<Subscriber> Subscribers { get; set; }

        public ICollection<TodoItem> TodoItems { get; set; }

        public TaskList()
        {
            Subscribers = new List<Subscriber>();
            TodoItems = new List<TodoItem>();
        }
    }
}

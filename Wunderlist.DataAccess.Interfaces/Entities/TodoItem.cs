using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class TodoItem
    {
        public int Id { get; set; }

        public string Record { get; set; }

        public bool IsCompleted { get; set; }

        public bool IsMarked { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime CompletionDate { get; set; }

        public DateTime NotificationDate { get; set; }

        public string Note { get; set; }

        public int TaskListId { get; set; }

        public TaskList TaskList { get; set; }
        
        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Subtask> Subtasks { get; set; }

        public virtual ICollection<TaskFile> TaskFiles { get; set; }

        public TodoItem()
        {
            Comments = new List<Comment>();
            Subtasks = new List<Subtask>();
            TaskFiles = new List<TaskFile>();
        }
    }
}

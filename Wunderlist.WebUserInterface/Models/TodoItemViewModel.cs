using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wunderlist.WebUserInterface.Models
{
    public class TodoItemViewModel
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
    }
}
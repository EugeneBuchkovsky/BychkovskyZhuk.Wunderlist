using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wunderlist.BusinessLogic.Services.DTO
{
    public class TodoItemDTO
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

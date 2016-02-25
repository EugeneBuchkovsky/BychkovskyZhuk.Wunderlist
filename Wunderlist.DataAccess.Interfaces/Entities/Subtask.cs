using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wunderlist.DataAccess.Interfaces.Entities
{
    public class Subtask
    {
        public int Id { get; set; }

        public string Record { get; set; }

        public bool IsComplited { get; set; }

        public int TodoItemId { get; set; }

        public TodoItem TodoItem { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wunderlist.DataAccess.Interfaces.Entities
{
    public class TaskFile
    {
        public int Id { get; set; }

        public string Path { get; set; }

        public int TodoItemId { get; set; }

        public TodoItem TodoItem { get; set; }

    }
}

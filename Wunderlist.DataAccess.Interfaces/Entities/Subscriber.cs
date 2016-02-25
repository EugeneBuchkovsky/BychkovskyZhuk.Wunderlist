using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Subscriber
    {
        public int Id { get; set; }

        public int TaskListId { get; set; }

        public TaskList TaskList { get; set; }

        public int UserId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wunderlist.DataAccess.Interfaces.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public int TodoItemId { get; set; }

        public TodoItem TodoItem { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}

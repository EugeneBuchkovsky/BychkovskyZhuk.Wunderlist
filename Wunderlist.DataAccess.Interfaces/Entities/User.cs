using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wunderlist.DataAccess.Interfaces.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string BackgroundImagePath { get; set; }

        public string PhotoPath { get; set; }

        public ICollection<TaskList> TaskLists { get; set; }

        public User()
        {
            TaskLists = new List<TaskList>();
        }
    }
}

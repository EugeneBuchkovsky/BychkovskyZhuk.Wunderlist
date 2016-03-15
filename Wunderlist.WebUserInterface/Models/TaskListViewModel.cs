using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wunderlist.WebUserInterface.Models
{
    public class TaskListViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int UserId { get; set; }
    }
}
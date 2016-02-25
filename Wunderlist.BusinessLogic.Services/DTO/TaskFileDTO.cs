using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wunderlist.BusinessLogic.Services.DTO
{
    public class TaskFileDTO
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public int TodoItemId { get; set; }
    }
}

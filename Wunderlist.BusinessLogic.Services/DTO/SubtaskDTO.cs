using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wunderlist.BusinessLogic.Services.DTO
{
    public class SubtaskDTO
    {
        public int Id { get; set; }
        public string Record { get; set; }
        public bool IsComplited { get; set; }
        public int TodoItemId { get; set; }
        
    }
}

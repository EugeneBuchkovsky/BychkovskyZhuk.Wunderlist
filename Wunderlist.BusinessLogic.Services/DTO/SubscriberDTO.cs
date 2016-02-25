using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wunderlist.BusinessLogic.Services.DTO
{
    public class SubscriberDTO
    {
        public int Id { get; set; }
        public int TaskListId { get; set; }
        public int UserId { get; set; }
    }
}

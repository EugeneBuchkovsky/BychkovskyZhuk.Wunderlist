using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wunderlist.BusinessLogic.Services.DTO;

namespace Wunderlist.BusinessLogic.Services.Services.TodoItemService
{
    public interface ITodoItemService
    {
        void Create(TodoItemDTO item);
        TodoItemDTO Get(int? id);
        IEnumerable<TodoItemDTO> GetAll(int? id);
        void Update(TodoItemDTO item);
        void Delete(int id);
    }
}

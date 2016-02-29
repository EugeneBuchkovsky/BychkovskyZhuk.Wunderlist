using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wunderlist.BusinessLogic.Services.DTO;

namespace Wunderlist.BusinessLogic.Services.Services.TaskListService
{
    public interface ITaskListService
    {
        void Create(TaskListDTO taskList);
        TaskListDTO Get(int? id);
        IEnumerable<TaskListDTO> GetAll(int? id);
        void Update(TaskListDTO taskList);
        void Delete(int id);
    }
}

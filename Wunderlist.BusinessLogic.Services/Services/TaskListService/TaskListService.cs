using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wunderlist.BusinessLogic.Services.DTO;
using Wunderlist.DataAccess.Interfaces.Entities;
using Wunderlist.DataAccess.Interfaces.Interfaces;
using Wunderlist.DataAccess.Repositories;

namespace Wunderlist.BusinessLogic.Services.Services.TaskListService
{
    public class TaskListService : ITaskListService
    {
        public void Create(TaskListDTO taskList)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TaskListDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TaskListDTO> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TaskListDTO taskList)
        {
            throw new NotImplementedException();
        }
    }
}

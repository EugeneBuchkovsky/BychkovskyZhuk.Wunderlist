using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wunderlist.BusinessLogic.Services.DTO;
using Wunderlist.DataAccess.Interfaces.Entities;
using Wunderlist.DataAccess.Interfaces.Interfaces;
using Wunderlist.DataAccess.Repositories;
using AutoMapper;

namespace Wunderlist.BusinessLogic.Services.Services.TaskListService
{
    public class TaskListService : ITaskListService
    {
        IUnitOfWork Database;

        public TaskListService(IUnitOfWork uow)
        {
            this.Database = uow;
        }

        public void Create(TaskListDTO taskList)
        {
            if (taskList == null)
                throw new ArgumentNullException();
            Mapper.CreateMap<TaskListDTO, TaskList>();
            Database.TaskLists.Create(Mapper.Map<TaskListDTO, TaskList>(taskList));
            Database.Save();
        }

        public void Delete(int id)
        {
            Database.TaskLists.Delete(id);
            Database.Save();
        }

        public TaskListDTO Get(int? id)
        {
            if (id == null)
                throw new ArgumentNullException();
            var list = Database.TaskLists.Get((int)id);
            if (list == null)
                throw new ArgumentNullException();
            Mapper.CreateMap<TaskList, TaskListDTO>();
            return Mapper.Map<TaskList, TaskListDTO>(list);
        }

        public IEnumerable<TaskListDTO> GetAll(int? id)
        {
            if (id == null)
                throw new ArgumentNullException();
            var list = Database.TaskLists.GetAll(id);
            Mapper.CreateMap<TaskList, TaskListDTO>();
            return Mapper.Map<IEnumerable<TaskList>,List<TaskListDTO>>(list);
        }

        public void Update(TaskListDTO taskList)
        {
            if (taskList == null)
                throw new ArgumentNullException();
            Mapper.CreateMap<TaskListDTO, TaskList>();
            Database.TaskLists.Update(Mapper.Map<TaskListDTO, TaskList>(taskList));
            Database.Save();
        }
    }
}

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

namespace Wunderlist.BusinessLogic.Services.Services.TodoItemService
{
    public class TodoItemService : ITodoItemService
    {
        IUnitOfWork Database;

        public TodoItemService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void Create(TodoItemDTO item)
        {
            if (item == null)
                throw new ArgumentNullException();
            Mapper.CreateMap<TodoItemDTO, TodoItem>();
            Database.TodoItems.Create(Mapper.Map<TodoItemDTO, TodoItem>(item));
            Database.Save();
        }

        public void Delete(int id)
        {
            Database.TodoItems.Delete(id);
            Database.Save();
        }

        public TodoItemDTO Get(int? id)
        {
            if (id == null)
                throw new ArgumentNullException();
            var item = Database.TodoItems.Get((int)id);
            if (item == null)
                throw new ArgumentNullException();
            Mapper.CreateMap<TodoItem, TodoItemDTO>();
            return Mapper.Map<TodoItem, TodoItemDTO>(item);
        }

        public IEnumerable<TodoItemDTO> GetAll(int? id)
        {
            if (id == null)
                throw new ArgumentNullException();
            var items = Database.TodoItems.GetAll((int)id);
            Mapper.CreateMap<TodoItem, TodoItemDTO>();
            return Mapper.Map<IEnumerable<TodoItem>, List<TodoItemDTO>>(items);
        }

        public void Update(TodoItemDTO item)
        {
            if (item == null)
                throw new ArgumentNullException();
            Mapper.CreateMap<TodoItemDTO, TodoItem>();
            Database.TodoItems.Update(Mapper.Map<TodoItemDTO, TodoItem>(item));
            Database.Save();
        }
    }
}

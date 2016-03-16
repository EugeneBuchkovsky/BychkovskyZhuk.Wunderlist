using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Wunderlist.BusinessLogic.Services.Services.UserService;
using Wunderlist.BusinessLogic.Services.Services.TaskListService;
using Wunderlist.BusinessLogic.Services.Services.TodoItemService;
using Wunderlist.BusinessLogic.Services.DTO;
using Wunderlist.WebUserInterface.Models;
using AutoMapper;
using Wunderlist.WebUserInterface.DependencyResolver;

namespace Wunderlist.WebUserInterface.Controllers
{
    public class TodoItemController : ApiController
    {
        private ITodoItemService itemService;

        public TodoItemController(ITodoItemService tis)
        {
            this.itemService = tis;
        }

        public IEnumerable<TodoItemViewModel> Get()
        {
            Mapper.CreateMap<TodoItemDTO, TodoItemViewModel>();
            return Mapper.Map<IEnumerable<TodoItemDTO>, List<TodoItemViewModel>>(itemService.GetAll(1));
        }
        

        // GET: api/User/5
        public TodoItemViewModel Get(int id)
        {
            Mapper.CreateMap<TodoItemDTO, TodoItemViewModel>();
            return Mapper.Map<TodoItemDTO, TodoItemViewModel>(itemService.Get(id));
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}

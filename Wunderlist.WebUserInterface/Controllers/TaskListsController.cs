using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Wunderlist.BusinessLogic.Services.Services.UserService;
using Wunderlist.BusinessLogic.Services.Services.TaskListService;
using Wunderlist.BusinessLogic.Services.DTO;
using Wunderlist.WebUserInterface.Models;
using AutoMapper;
using Wunderlist.WebUserInterface.DependencyResolver;

namespace Wunderlist.WebUserInterface.Controllers
{
    public class TaskListsController : ApiController
    {
        private IUserService userService;
        private ITaskListService taskListService;
        public TaskListsController(IUserService us, ITaskListService ts)
        {
            this.userService = us;
            this.taskListService = ts;
        }
        // GET: api/User
        public IEnumerable<TaskListViewModel> Get()
        {
            Mapper.CreateMap<TaskListDTO, TaskListViewModel>();
            return Mapper.Map<IEnumerable<TaskListDTO>, List<TaskListViewModel>>(taskListService.GetAll(1));
        }

        // GET: api/User/5
        public UserViewModel Get(int id)
        {
            Mapper.CreateMap<UserDTO, UserViewModel>();
            return Mapper.Map<UserDTO, UserViewModel>(userService.Get(id));
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

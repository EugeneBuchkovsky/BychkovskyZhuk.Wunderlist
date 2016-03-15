using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Wunderlist.BusinessLogic.Services.Services.UserService;
using Wunderlist.BusinessLogic.Services.DTO;
using Wunderlist.WebUserInterface.Models;
using AutoMapper;
using Wunderlist.WebUserInterface.DependencyResolver;

namespace Wunderlist.WebUserInterface.Controllers
{
    public class UserController : ApiController
    {
        private IUserService userService;
        public UserController(IUserService us)
        {
            this.userService = us;
        }
        // GET: api/User
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
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

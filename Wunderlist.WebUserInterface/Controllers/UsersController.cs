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

namespace Wunderlist.WebUserInterface.Controllers
{
    public class UsersController : ApiController
    {
        IUserService userService;
        public UsersController(IUserService us)
        {
            this.userService = us;
        }

        public UserViewModel Get(int? id)
        {
            Mapper.CreateMap<UserDTO, UserViewModel>();
            return Mapper.Map<UserDTO, UserViewModel>(userService.Get(id));
        }
    }
}

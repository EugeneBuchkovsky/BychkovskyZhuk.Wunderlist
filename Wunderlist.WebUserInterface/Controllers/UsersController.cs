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
        //IUserService userService;
        //public UsersController(IUserService us)
        //{
        //    this.userService = us;
        //}

        public List<UserDTO> Get(int? id)
        {
            return new List<UserDTO>
                {
                    new UserDTO {Id=1, Name="Война и мир", Email = "dbv", Password = "234"},
                    new UserDTO {Id=2, Name="Отцы и дети", Email = "oad", Password = "12312312" },
                };
            //Mapper.CreateMap<UserDTO, UserViewModel>();
            //return Mapper.Map<UserDTO, UserViewModel>(userService.Get(id));
        }
    }
}

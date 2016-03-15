using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wunderlist.BusinessLogic.Services.Services.UserService;
using Wunderlist.BusinessLogic.Services.DTO;
using Wunderlist.WebUserInterface.Models;
using AutoMapper;

namespace Wunderlist.WebUserInterface.Controllers
{
    public class HomeController : Controller
    {
        private IUserService userService;

        public HomeController(IUserService us)
        {
            this.userService = us;
        }

        public ActionResult Example()
        {
            //UserDTO nu = new UserDTO() {Name = "Zhuk", Email = "zhuk@epam.com", Password = "zhuk" };
            //userService.Create(nu);
            Mapper.CreateMap<UserDTO, UserViewModel>();
            ViewBag.e = Mapper.Map<UserDTO, UserViewModel>(userService.Get(1));
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
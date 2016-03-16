using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Wunderlist.BusinessLogic.Services.Services.UserService;
using Wunderlist.WebUserInterface.Models;
using Wunderlist.WebUserInterface.Providers;

namespace Wunderlist.WebUserInterface.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService service)
        {
            this._userService = service;
        }


        public ActionResult Login(string returnUrl)
        {
            //var type = HttpContext.User.GetType();
            //var iden = HttpContext.User.Identity.GetType();
            //ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(model.Email, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.Email, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Неправильный логин или пароль");
                }
            }
            return View(model);
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            var isRegistered = _userService.GetAll().Any(u => u.Email.Contains(model.Email));
            if (isRegistered)
            {
                //ModelState.AddModelError("","Уже зарегистрирован такой пользователь");
                return View(model);
            }

            if (ModelState.IsValid)
            {
                var membershipUser = ((SignupMembershipProvider)Membership.Provider).CreateUser(model.UserName,
                    model.Email, model.Password);

                if (membershipUser != null)
                {
                    FormsAuthentication.SetAuthCookie(model.Email, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    //ModelState.AddModelError("", "Ошибка регистрации");
                }
            }

            return View(model);
        }
    }
}
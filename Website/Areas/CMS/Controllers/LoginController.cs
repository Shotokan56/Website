using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using Resources;
using Website.Areas.CMS.Models;
using Website.Common;
using Website.Models;
using AutoMapper;

namespace Website.Areas.CMS.Controllers
{
    public class LoginController : Controller
    {
        public WebAPPEntities db = new WebAPPEntities();
        //
        // GET: /CMS/Login/
        public ActionResult Index()
        {
            var userVM = new UserViewModel();
            return View("Login", userVM); 
        }

        [HttpPost]
        public ActionResult Verify(UserViewModel userVm)
        {
            ModelState.Clear();
            if (!Validate(userVm))
            {
                ModelState.AddModelError("Message", TextMessage.LoginController_Validate_NotValid);
                return View("Login",userVm);
            }
            
            var objDbUser = db.Users.First(o => o.UserName == userVm.UserName);

            if (objDbUser == null)
                ModelState.AddModelError("Message", TextMessage.LoginController_Validate_NotValid);

            //Mapper.CreateMap<User, UserViewModel>();
            //var userViewModel = Mapper.Map<User>(user);

            if (!Hashing.VerifyHashedPassword(Hashing.HashPassword(objDbUser.PassWord), userVm.PassWord))
            {
                ModelState.AddModelError("Message", TextMessage.LoginController_Validate_NotValid);
            }

            ModelState.AddModelError("Message", "ok");
            return View("Login", userVm);
        }

        private bool Validate(UserViewModel userVm)
        {
            
            if (string.IsNullOrEmpty(userVm.UserName) || string.IsNullOrWhiteSpace(userVm.UserName))
            {
                ModelState.AddModelError("UserName", TextMessage.LoginController_Validate_UserName);
            }

            if (string.IsNullOrEmpty(userVm.PassWord) || string.IsNullOrWhiteSpace(userVm.PassWord))
            {
                ModelState.AddModelError("UserName", TextMessage.LoginController_Validate_PassWord);
            }
            return true;
        }
    }
}

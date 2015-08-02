using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Resources;
using Website.Common;
using Website.Models;

namespace Website.Areas.CMS.Controllers
{
    [SessionExpire]
    public class UserManagementController : Controller
    {
        private WebAPPEntities db = new WebAPPEntities();
        
        public ActionResult Index()
        {
            var lstData = db.Users.ToList();
            return View("ListUser", lstData);
        }

        public ActionResult NewUser()
        {
            return View("NewUser");
        }

        public ActionResult NewUserPatial()
        {
            return PartialView("NewUserPatial");
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            Validate(user);
            if (ModelState.IsValid)
            {
                ViewBag.Success = true;
                return View("NewUser");
            }
            else
            {
                //return View("NewUser", user);
                return PartialView("NewUserPatial", user);
            }
        }

        private void Validate(User user)
        {
            ModelState.Clear();
            if (string.IsNullOrEmpty(user.UserName))
                ModelState.AddModelError("UserName",TextMessage.LoginController_Validate_UserName);
            if (string.IsNullOrEmpty(user.PassWord))
                ModelState.AddModelError("PassWord", TextMessage.LoginController_Validate_PassWord);
        }
    }
}
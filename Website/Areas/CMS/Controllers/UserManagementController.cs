using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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

        public ActionResult NewUser(User user)
        {
            return View("NewUser", user);
        }

	}
}
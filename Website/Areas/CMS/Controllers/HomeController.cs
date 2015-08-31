﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Common;

namespace Website.Areas.CMS.Controllers
{
    [SessionExpire]
    public class HomeController : BaseController
    {
        [CustomAuthorizeUser(Users = "Admin")]
        public ActionResult Index()
        {
            return View();
        }
	}
}
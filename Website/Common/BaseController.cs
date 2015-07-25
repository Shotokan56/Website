using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;

namespace Website.Common
{
    public class BaseController : Controller
    {
        //
        // GET: /Base/
        public BaseController()
        {
           
        }

        public List<string> GetRolesForUser(string username)
        {
            using (var objContext = new WebAPPEntities())
            {
                var objUser = objContext.Users.FirstOrDefault(x => x.UserName == username);
                if (objUser == null || string.IsNullOrEmpty(objUser.Roles))
                {
                    return null;
                }
                else
                {
                    var result = objUser.Roles.Split(',').ToList();
                    return result;
                }
            }
        }

        public List<string> GetRolesForUser(User objUser)
        {
                if (objUser == null || string.IsNullOrEmpty(objUser.Roles))
                {
                    return null;
                }
                else
                {
                    var result = objUser.Roles.Split(',').ToList();
                    return result;
                }
        }
	}
}
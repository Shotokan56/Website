using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;

namespace Website.Common
{
    [AttributeUsage(AttributeTargets.Class| AttributeTargets.Method)]
    public class CustomAuthorizeUserAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool isAuthorized = base.AuthorizeCore(httpContext);

            if (!isAuthorized) return false;

            var a = Roles;

            return true;
        }
    }
}
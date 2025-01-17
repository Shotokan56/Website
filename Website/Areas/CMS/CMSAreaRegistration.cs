﻿using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.UI;

namespace Website.Areas.CMS
{
    public class CMSAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "CMS";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "CMS_default",
                "CMS/{controller}/{action}/{id}",
                new { controller ="Login", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Areas.CMS.Models
{
    public class UserViewModel
    {
            public int UserId { get; set; }
            public string UserName { get; set; }
            public string PassWord { get; set; }
            public bool Lock { get; set; }
            public string Roles { get; set; }


            //Add new
            
            public string Message { get; set; }
            public bool RememberMe { get; set; }
            public UserViewModel()
            {
                RememberMe = false;
            } 
    }

    
}
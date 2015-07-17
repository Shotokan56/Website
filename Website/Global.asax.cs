using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
//using Website.Models;
using System.Globalization;
using System.Threading;
using System.Data.Entity;


namespace Website
{
    public class MvcApplication : System.Web.HttpApplication
    {
        #region Các biến danh mục

        /// <summary>
        /// Lấy ID role admin
        /// </summary>
        //public static string RoleAdmin_ID()
        //{
        //    var db = new WebsiteEntities();
        //    var role = db.AspNetRoles.FirstOrDefault(o => o.Name.Equals("Admin"));
        //    if (role != null)
        //        return role.Id;
        //    return null;
        //}

        #endregion Các biến danh mục

        protected void Application_Start()
        {
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
            //Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            CultureInfo newCulture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            newCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            newCulture.DateTimeFormat.DateSeparator = "/";
            Thread.CurrentThread.CurrentCulture = newCulture;

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //Database.SetInitializer<ApplicationDbContext>(null);

            ClientDataTypeModelValidatorProvider.ResourceClassKey = "ModelBinders";
            DefaultModelBinder.ResourceClassKey = "ModelBinders";
        }
    }
}

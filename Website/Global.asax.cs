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

using System.Web;
using System.Web.Optimization;

namespace Website
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/style").Include(
                        "~/Content/bootstrap-3.3.2-dist/css/bootstrap.min.css",
                        "~/Content/bootstrap-3.3.2-dist/css/bootstrap-theme.min.css",
                        "~/Content/CMS/Style/Style.Cms.css",
                        "~/Content/CMS/Script/lib/font-awesome/css/font-awesome.css",
                        "~/Content/CMS/Style/stylesheets/theme.css"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/script").Include(
                       "~/Content/CMS/Script/lib/jquery-1.11.1.min.js",
                       "~/Content/CMS/Script/lib/jQuery-Knob/js/jquery.knob.js",
                       "~/Content/CMS/Script/lib/bootstrap/js/bootstrap.js",
                       "~/Scripts/modernizr-2.6.2.js",
                       "~/Scripts/respond.js"
                       ));
        }
    }
}

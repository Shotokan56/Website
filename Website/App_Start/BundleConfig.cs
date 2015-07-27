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
                       "~/Content/CMS/Script/lib/bootstrap/js/bootstrap.js"
                       ));
            


            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //bundles.Add(new ScriptBundle("~/bundles/Kendo").Include(
            //"~/Scripts/Kendo/kendo.all.min.js",
            //"~/Scripts/Kendo/kendo.aspnetmvc.min.js"));

            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            //bundles.Add(new StyleBundle("~/Content/Kendo/css").Include(
            //"~/Content/Kendo/kendo.common-bootstrap.min.css",
            //"~/Content/Kendo/kendo.bootstrap.min.css"));
            //bundles.IgnoreList.Clear();

            //bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
            //        "~/Content/themes/base/jquery.ui.core.css",
            //        "~/Content/themes/base/jquery.ui.resizable.css",
            //        "~/Content/themes/base/jquery.ui.selectable.css",
            //        "~/Content/themes/base/jquery.ui.accordion.css",
            //        "~/Content/themes/base/jquery.ui.autocomplete.css",
            //        "~/Content/themes/base/jquery.ui.button.css",
            //        "~/Content/themes/base/jquery.ui.dialog.css",
            //        "~/Content/themes/base/jquery.ui.slider.css",
            //        "~/Content/themes/base/jquery.ui.tabs.css",
            //        "~/Content/themes/base/jquery.ui.datepicker.css",
            //        "~/Content/themes/base/jquery.ui.progressbar.css",
            //        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}

using System.Web;
using System.Web.Optimization;

namespace Capstone
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/easy-responsive.css",
                      "~/Content/global.css",
                      "~/Content/slider.css",
                      "~/Content/style.css"));

            bundles.Add(new StyleBundle("~/Content/morris").Include(
                    "~/Content/morris.css"));

            bundles.Add(new StyleBundle("~/Content/sb-admin").Include(
                    "~/Content/sb-admin.css",
                    "~/Content/sb-admin-rtl.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                    "~/Content/bootstrap.css",
                    "~/Content/bootstrap.min.css",
                    "~/Content/bootstrap-rtl.min.css",
                    "~/Content/bootstrap-rtl.css"));

            bundles.Add(new ScriptBundle("~/bundles/javascript").Include(
                       "~/Scripts/easing.js",
                       "~/Scripts/easyResponsiveTabs.js",
                       "~/Scripts/jquery.accordion.js",
                       "~/Scripts/jquery.easing.js",
                       "~/Scripts/jquery-1.7.2.min.js",
                       "~/Scripts/move-top.js",
                       "~/Scripts/script.js",
                       "~/Scripts/slides.min.jquery.js",
                       "~/Scripts/startstop-slider.js",
                       "~/Scripts/layout.js",
                       "~/Scripts/validate.js",
                       "~/Scripts/registerForm.js"));
            bundles.Add(new ScriptBundle("~/bundles/flot").Include(
                "~/Scripts/excanvas.min.js",
                "~/Scripts/flot-data.js",
                "~/Scripts/jquery.flot.js",
                "~/Scripts/jquery.flot.pie.js",
                "~/Scripts/jquery.flot.resize.js",
                "~/Scripts/jquery.flot.tooltip.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/morris").Include(
                "~/Scripts/morris.js",
                "~/Scripts/morris.mins.js",
                "~/Scripts/morris-data.js",
                "~/Scripts/raphael.mins.js",
                "~/Scripts/raphaeljs"));
            bundles.Add(new StyleBundle("~/Content/fontawesome").Include(
                "~/font-awesome/css/font-awesome.css",
                "~/font-awesome/css/font-awesome.min.css"));
        }
    }
}

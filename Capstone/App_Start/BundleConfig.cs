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
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/easy-responsive.css",
                      "~/Content/global.css",
                      "~/Content/slider.css",
                      "~/Content/style.css"));

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
        }
    }
}

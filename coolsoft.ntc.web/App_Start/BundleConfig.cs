using System.Web;
using System.Web.Optimization;

namespace coolsoft.ntc.web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Clear();
            //bundles.ResetAll();
            BundleTable.EnableOptimizations = true;
            bundles.UseCdn = true;

            string cdnHost = "";

            if (HttpRuntime.BinDirectory.Contains("local"))
                cdnHost = "http://localhost:33787/";

            bundles.Add(new ScriptBundle("~/assets/js", cdnHost)
                .Include(
                        "~/Content/js/jquery.min.js",
                        "~/Content/js/bootstrap.min.js",
                        "~/Content/js/respond.min.js"));

            bundles.Add(new ScriptBundle("~/assets/js/jqueryval", cdnHost)
                .Include(
                        "~/Content/js/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/assets/js/modernizr", cdnHost)
                .Include("~/Content/js/modernizr-*"));

            
            bundles.Add(new StyleBundle("~/assets/css", cdnHost)
                .Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/media_screen.css"));

            bundles.Add(new StyleBundle("~/assets/fonts", cdnHost)
                .Include(
                      "~/Content/css/font-awesome.min.css"));


        }
    }
}

using System.Web;
using System.Web.Optimization;

namespace WebDeveloper.Angular
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular")
                .Include("~/Scripts/jquery-3.1.0.js")
                .Include("~/Scripts/angular.js")                
                );

            bundles.Add(new ScriptBundle("~/bundles/dependencies")
                .Include("~/Scripts/angular-route.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/app")
                .Include("~/app/app.js")                
                .Include("~/app/app.route.js")
                .Include("~/app/app.controller.js")
                .IncludeDirectory("~/app/private", "*.js", true)
                );

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}

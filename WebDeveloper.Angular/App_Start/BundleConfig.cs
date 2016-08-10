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
                .Include("~/Scripts/bootstrap.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/dependencies")
                .IncludeDirectory("~/Scripts/angular", "*.js", true)
                );

            bundles.Add(new ScriptBundle("~/bundles/app")
                .Include("~/app/app.js")                
                .Include("~/app/app.routes.js")
                .Include("~/app/app.controller.js")
                .IncludeDirectory("~/app/private", "*.js", true)
                .IncludeDirectory("~/app/components","*.js", true)
                );

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new DynamicFolderBundle("js", "*.js", false, new JsMinify()));
            bundles.Add(new DynamicFolderBundle("css", "*.css", false, new CssMinify()));

            BundleTable.EnableOptimizations = true;
        }
    }
}

using System.Web;
using System.Web.Optimization;

namespace WebDeveloper
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
                        
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",                      
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/datepicker")
                .Include("~/Scripts/moment.js")
                .Include("~/Scripts/bootstrap-datetimepicker.js")                
                );

            bundles.Add(new ScriptBundle("~/bundles/custom")
                .Include("~/Scripts/Shared/modal.js")                
                );

            bundles.Add(new ScriptBundle("~/bundles/Personal")
               .Include("~/Scripts/Personal/functions.js")
               );

            bundles.Add(new StyleBundle("~/Content/datepicker")
                .Include("~/Css/datepicker.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css")
                      .Include("~/Css/site.css"));

            bundles.Add(new DynamicFolderBundle("js", "*.js", false, new JsMinify()));
            bundles.Add(new DynamicFolderBundle("css", "*.css", false, new CssMinify()));

            #if DEBUG
            BundleTable.EnableOptimizations = false;
            #else
            BundleTable.EnableOptimizations = true;
            #endif
        }
    }
}

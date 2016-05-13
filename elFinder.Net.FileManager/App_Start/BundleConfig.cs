using System.Web;
using System.Web.Optimization;

namespace elFinder.Net.FileManager
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));


            #region elFinder bundles

            //bundles.Add(new ScriptBundle("~/Scripts/elfinder").Include(
            //                //"~/Content/elfinder/js/jquery-1.7.1.min.js",
            //                //"~/Content/elfinder/js/jquery-ui-1.8.11.min.js",
            //                "~/Content/elfinder/js/elfinder.min.js",
            //                "~/Content/elfinder/js/i18n/elfinder.ru.js"
            //                ));

            //bundles.Add(new StyleBundle("~/Content/elfinder").Include(
            //                //"~/Content/elfinder/css/smoothness-1.8.23/jquery-ui-1.8.23.custom.css",
            //                "~/Content/elfinder/css/elfinder.full.css"
            //                //"~/Content/elfinder/themes/windows-10/css/theme.css"
            //                ));


            bundles.Add(new ScriptBundle("~/Scripts/elfinder").Include(
                             "~/Content/elfinder/js/elfinder.min.js"
                             //"~/Content/elfinder/js/i18n/elfinder.pt_BR.js"
                             ));

            bundles.Add(new StyleBundle("~/Content/elfinder").Include(
                            "~/Content/elfinder/css/elfinder.min.css",
                            "~/Content/elfinder/css/theme.css"
                            //"~/Content/elfinder/themes/windows-10/css/theme.css"
                            ));

            #endregion

            #region TinyMCE bundles

            bundles.Add(new ScriptBundle("~/Scripts/tinymce").Include(
                            "~/Scripts/tinymce/tinymce.js"
                            ));

            #endregion


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/jqueryui").Include(
                                       "~/Content/themes/base/jquery.ui.all.css"));
        }
    }
}

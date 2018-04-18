using System.Web;
using System.Web.Optimization;

namespace HBSIS.Livraria.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region admin
            bundles.Add(new StyleBundle("~/admin/styles").Include(
                "~/Content/css/vendor/bootstrap.3.3.7.min.css"));

            bundles.Add(new ScriptBundle("~/admin/scripts").Include(
                       "~/Content/js/vendor/jquery-3.2.1.min.js",
                       "~/Content/js/vendor/bootstrap.3.3.7.min.js",
                       "~/Content/js/vendor/vue.min.js"));

            bundles.Add(new ScriptBundle("~/admin/book/index").Include(
                        "~/Content/js/vendor/moment.min.js",
                        "~/Content/js/view/admin/book/book.index.js"));
            
            #endregion

            BundleTable.EnableOptimizations = false;
        }
    }
}
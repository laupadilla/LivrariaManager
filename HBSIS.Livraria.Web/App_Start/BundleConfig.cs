using System.Web;
using System.Web.Optimization;

namespace HBSIS.Livraria.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            #region admin
            //bundles.Add(new StyleBundle("~/admin/styles").Include(
            //    "~/Content/css/vendor/bootstrap.3.3.7.min.css",
            //    "~/Content/css/admin/menu.css",
            //    "~/Content/css/admin/main.css",
            //    "~/Content/css/vendor/jquery-datepicker.min.css"
            //    ).Include("~/Content/css/vendor/materialdesignicons.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new ScriptBundle("~/admin/scripts").Include(
                        "~/Content/js/vendor/jquery-3.2.1.min.js",
                       "~/Content/js/vendor/bootstrap.3.3.7.min.js",
                        "~/Content/js/vendor/vue.min.js",
                        "~/Content/js/vendor/lodash.min.js",
                        "~/Content/js/vendor/async.min.js",
                        "~/Content/js/vendor/jquery-datepicker.min.js",
                        "~/Content/js/view/admin/admin.components.js",
                        "~/Content/js/view/admin/account/account.common.js"));

            bundles.Add(new ScriptBundle("~/admin/account/nav").Include(
                        "~/Content/js/view/admin/account/account.nav.js"));

            bundles.Add(new ScriptBundle("~/admin/account/login").Include(
                        "~/Content/js/view/admin/account/account.login.js"));

            bundles.Add(new ScriptBundle("~/admin/banner/index").Include(
                        "~/Content/js/view/admin/banner/banner.index.js"));

            bundles.Add(new ScriptBundle("~/admin/event/index").Include(
                        "~/Content/js/vendor/moment.min.js",
                        "~/Content/js/view/admin/event/event.index.js",
                        "~/Content/js/view/admin/event/event.unity-list.js",
                        "~/Content/js/view/admin/event/event.unity-import.js"));

            bundles.Add(new ScriptBundle("~/admin/event/album").Include(
                        "~/Content/js/view/admin/event/event.album.js"));

            bundles.Add(new ScriptBundle("~/admin/eventunity/index").Include(
                        "~/Content/js/view/admin/eventunity/eventunity.index.js"));
            #endregion

            #region common
            //bundles.Add(new StyleBundle("~/common/styles").Include(
            //    "~/Content/css/bundles.css").Include(
            //    "~/Content/css/vendor/bootstrap.3.3.7.min.css", new CssRewriteUrlTransform()).Include(
            //    "~/Content/css/vendor/slick.css",
            //    "~/Content/css/vendor/slick-theme.css").Include(
            //    "~/Content/css/vendor/materialdesignicons.2.1.19.min.css", new CssRewriteUrlTransform()).Include(
            //    "~/Content/css/bootstrap_custom.css").Include(
            //    "~/Content/css/styles.css", new CssRewriteUrlTransform()));




            bundles.Add(new ScriptBundle("~/common/scripts").Include(
                       "~/Content/js/vendor/jquery-2.2.4.min.js",
                       "~/Content/js/vendor/slick.js",
                       "~/Content/js/vendor/bootstrap.3.3.7.min.js",
                       "~/Content/js/vendor/vue.min.js",
                       "~/Content/js/vendor/lodash.min.js",
                       "~/Content/js/vendor/async.min.js",
                       "~/Content/js/vendor/ekko-lightbox.min.js",
                       "~/Content/js/view/layout.js",
                       "~/Content/js/view/common.js"));

            bundles.Add(new ScriptBundle("~/shared/nav").Include(
                       "~/Content/js/view/shared/shared.nav.js"));

            bundles.Add(new ScriptBundle("~/shared/login").Include(
                       "~/Content/js/view/shared/shared.login.js"));

            bundles.Add(new ScriptBundle("~/shared/course-search").Include(
                        "~/Content/js/vendor/jquery-ui.min.js",
                       "~/Content/js/view/shared/shared.course-search.js"));

            bundles.Add(new ScriptBundle("~/shared/registration").Include(
                    "~/Content/js/vendor/v-mask.min.js",
                    "~/Content/js/view/shared/shared.registration.js"));

            bundles.Add(new ScriptBundle("~/shared/trail-quiz").Include(
                    "~/Content/js/view/shared/shared.trail-quiz.js"));

            bundles.Add(new ScriptBundle("~/shared/profile-quiz").Include(
         "~/Content/js/view/shared/shared.profile-quiz.js"));

            bundles.Add(new ScriptBundle("~/home/banner").Include(
           "~/Content/js/view/home/home.banner.js"));

            bundles.Add(new ScriptBundle("~/shared/events").Include(
                       "~/Content/js/vendor/v-mask.min.js",
                       "~/Content/js/view/shared/shared.events.js"));

            bundles.Add(new ScriptBundle("~/shared/events-old").Include(
            "~/Content/js/view/shared/shared.events-old.js"));

            bundles.Add(new ScriptBundle("~/home/trail").Include(
            "~/Content/js/vendor/iframe_api.js",
            "~/Content/js/view/home/home.trail.js"));

            bundles.Add(new ScriptBundle("~/home/profile").Include(
            "~/Content/js/view/home/home.profile.js"));

            bundles.Add(new ScriptBundle("~/premium-trail/index").Include(
 "~/Content/js/view/premium-trail/premium-trail.index.js"));

            bundles.Add(new ScriptBundle("~/event/list").Include(
                "~/Content/js/vendor/v-mask.min.js",
                "~/Content/js/view/event/event.list.js"));

            bundles.Add(new ScriptBundle("~/event/detail").Include(
                "~/Content/js/vendor/v-mask.min.js",
                "~/Content/js/view/event/event.detail.js"));

            bundles.Add(new ScriptBundle("~/user/profile").Include(
                "~/Content/js/vendor/v-mask.min.js",
                "~/Content/js/view/user/user.profile.js"));

            bundles.Add(new ScriptBundle("~/user/nextevents").Include(
           "~/Content/js/view/user/user.nextevents.js"));

            bundles.Add(new ScriptBundle("~/user/completedevents").Include(
          "~/Content/js/view/user/user.completedevents.js"));

            bundles.Add(new ScriptBundle("~/career/video").Include(
          "~/Content/js/view/career/career.video.js"));

            bundles.Add(new ScriptBundle("~/career/articles-content").Include(
          "~/Content/js/view/career/career.articles.content.js"));

            bundles.Add(new ScriptBundle("~/career/articles").Include(
          "~/Content/js/view/career/career.articles.js"));

            bundles.Add(new ScriptBundle("~/career/articledetail").Include(
          "~/Content/js/view/career/career.articledetail.js"));

            #endregion


            BundleTable.EnableOptimizations = true;

        }
    }
}
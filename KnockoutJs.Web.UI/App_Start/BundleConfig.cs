using System.Web.Optimization;

namespace KnockoutJs.Web.UI.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/js/knockout").Include(
                "~/Scripts/knockout-{version}.js",
                "~/Scripts/knockout.validation.js"));

            bundles.Add(new ScriptBundle("~/js/wijmo").Include(
                "~/Scripts/jquery.wijmo-open.all.{version}.min.js",
                "~/Scripts/jquery.wijmo-complete.all.{version}.min.js"));

            bundles.Add(new ScriptBundle("~/js/knockoutwijmo").Include(
                "~/Scripts/knockout.wijmo.js"));

            bundles.Add(new ScriptBundle("~/js/jquery").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery-migrate-{version}.js",
                "~/Scripts/jquery.dateFormat-{version}.js"));

            bundles.Add(new ScriptBundle("~/js/jqueryui").Include(
                "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/js/jqueryval").Include(
                "~/Scripts/jquery.unobtrusive*",
                "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/js/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/css/wijmo").Include(
                "~/Content/jquery.wijmo-open.{version}.css",
                "~/Content/jquery.wijmo-complete.{version}.css",
                "~/Content/themes/aristo/jquery-wijmo.css"));

            bundles.Add(new StyleBundle("~/css/site").Include(
                "~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/css/themes/base/css").Include(
                "~/Content/themes/base/jquery.ui.core.css",
                "~/Content/themes/base/jquery.ui.resizable.css",
                "~/Content/themes/base/jquery.ui.selectable.css",
                "~/Content/themes/base/jquery.ui.accordion.css",
                "~/Content/themes/base/jquery.ui.autocomplete.css",
                "~/Content/themes/base/jquery.ui.button.css",
                "~/Content/themes/base/jquery.ui.dialog.css",
                "~/Content/themes/base/jquery.ui.slider.css",
                "~/Content/themes/base/jquery.ui.tabs.css",
                "~/Content/themes/base/jquery.ui.datepicker.css",
                "~/Content/themes/base/jquery.ui.progressbar.css",
                "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}
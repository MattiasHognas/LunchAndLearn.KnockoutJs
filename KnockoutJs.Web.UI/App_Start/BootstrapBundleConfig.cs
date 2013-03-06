using System.Web.Optimization;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(KnockoutJs.Web.UI.App_Start.BootstrapBundleConfig), "RegisterBundles")]

namespace KnockoutJs.Web.UI.App_Start
{
	public class BootstrapBundleConfig
	{
	    public static void RegisterBundles()
	    {
	        BundleTable.Bundles.Add(new ScriptBundle("~/js/bootstrap").Include("~/Scripts/bootstrap*"));
	        BundleTable.Bundles.Add(new StyleBundle("~/css/bootstrap").Include("~/Content/bootstrap.css",
	                                                                           "~/Content/bootstrap-responsive.css"));
	    }
	}
}

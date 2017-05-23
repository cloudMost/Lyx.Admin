using System.Web.Optimization;

namespace Lyx.Admin.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();
            AddCssLibs(bundles);
            bundles.Add(
                new ScriptBundle("~/Bundles/libs/js")
                    .Include(
                        ScriptPaths.JQuery,
                        ScriptPaths.JQuery_UI,
                        ScriptPaths.JQuery_Migrate,
                        ScriptPaths.Bootstrap,
                        ScriptPaths.Bootstrap_Hover_Dropdown,
                        ScriptPaths.JQuery_Slimscroll,
                        ScriptPaths.JQuery_BlockUi,
                        ScriptPaths.JQuery_Cookie,
                        ScriptPaths.Toastr,
                        ScriptPaths.SweetAlert,
                        ScriptPaths.Moment,
                        ScriptPaths.Ckeditor,
                        ScriptPaths.Abp,
                        ScriptPaths.Abp_JQuery,
                        ScriptPaths.Abp_Toastr,
                        ScriptPaths.Abp_BlockUi,
                        ScriptPaths.Abp_SpinJs,
                        ScriptPaths.Abp_SweetAlert,
                        ScriptPaths.Main
                ));
            bundles.Add(
                new ScriptBundle("~/Bundles/metronic/js")
                    .Include(
                        ScriptPaths.Metronic,
                        ScriptPaths.Metronic_Layout,
                        ScriptPaths.Metronic_Quick_Sidebar,
                        ScriptPaths.Metronic_Demo
                    )
                );

            //~/Bundles/css
            bundles.Add(
                new StyleBundle("~/Bundles/css")
                    .Include("~/css/main.css")
                );

            //~/Bundles/js
            bundles.Add(
                new ScriptBundle("~/Bundles/js")
                    .Include("~/js/main.js")
                );
        }

        private static void AddCssLibs(BundleCollection bundles)
        {
            bundles.Add(
                new StyleBundle("~/Bundles/base/css")
                    .Include(
                        StylePaths.FontAwesome,
                        StylePaths.Simple_Line_Icons,
                        StylePaths.Bootstrap,
                        StylePaths.JQuery_Uniform,
                        StylePaths.Bootstrap_Switch,
                        StylePaths.SweetAlert,
                        StylePaths.Toastr
                        )
                );
            bundles.Add(
                new StyleBundle("~/Bundles/metronic/css")
                    .Include(
                        StylePaths.Metronic_Layout,
                        StylePaths.Metronic_Custom,
                        StylePaths.Metronic_Theme_Custom,
                        StylePaths.Metronic_Global_Components,
                        StylePaths.Metronic_Global_Plugins
                    )
                );
            bundles.Add(new StyleBundle("~/Bundles/metronic/login/css")
                .Include(
                        StylePaths.Metronic_Login,
                        StylePaths.Metronic_Select
                    )
                );
        }
    }
}
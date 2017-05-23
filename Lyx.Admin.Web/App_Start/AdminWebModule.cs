using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Abp.Hangfire;
using Abp.Hangfire.Configuration;
using Abp.Zero.Configuration;
using Abp.Modules;
using Abp.Web.Mvc;
using Abp.Web.SignalR;
using Lyx.Admin.Api;
using Hangfire;
using System.Web;
using Lyx.Admin.Common;

namespace Lyx.Admin.Web
{
    [DependsOn(
        typeof(AdminDataModule),
        typeof(AdminApplicationModule),
        typeof(AdminWebApiModule),
        typeof(AbpWebSignalRModule),
        typeof(AbpHangfireModule), //使用后台工作
        typeof(AbpWebMvcModule),
        typeof(AdminCommonModule)
        )]
    public class AdminWebModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Enable database based localization
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            //Configure navigation/menu
            Configuration.Navigation.Providers.Add<AdminNavigationProvider>();

            //Configure Hangfire - ENABLE TO USE HANGFIRE INSTEAD OF DEFAULT JOB MANAGER
            Configuration.BackgroundJobs.UseHangfire(configuration =>
            {
                //初始化数据库
                configuration.GlobalConfiguration.UseSqlServerStorage("Default");
                
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public override void PostInitialize()
        {
            var server = HttpContext.Current.Server;

            var appPathSetting=IocManager.Resolve<AppPathSetting>();

            appPathSetting.FileUploadPath = server.MapPath("~/Files/Downloads");
        }
    }
}

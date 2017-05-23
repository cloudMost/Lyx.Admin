using System.Reflection;
using System.Web.Http;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using Swashbuckle.Application;
using System.Linq;

namespace Lyx.Admin.Api
{
    [DependsOn(typeof(AbpWebApiModule), typeof(AdminApplicationModule))]
    public class AdminWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(AdminApplicationModule).Assembly, "app")
                .Build();

            Configuration.Modules.AbpWebApi().HttpConfiguration.Filters.Add(new HostAuthenticationFilter("Bearer"));

            //集成Swagger UI
            ConfigureSwaggerUi();
        }

        private void ConfigureSwaggerUi()
        {
            var xmlFile = string.Format("{0}/bin/{1}.Application.xml", System.AppDomain.CurrentDomain.BaseDirectory, this.GetType().Namespace);
            Configuration.Modules.AbpWebApi().HttpConfiguration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", this.GetType().Namespace);
                    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                    if (System.IO.File.Exists(xmlFile)) { c.IncludeXmlComments(xmlFile); }
                })
                .EnableSwaggerUi();
        }
    }
}

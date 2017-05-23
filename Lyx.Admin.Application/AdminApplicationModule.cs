using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace Lyx.Admin
{
    [DependsOn(typeof(AdminCoreModule), typeof(AbpAutoMapperModule))]
    public class AdminApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                //Add your custom AutoMapper mappings here...
                //mapper.CreateMap<,>()
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

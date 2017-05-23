using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Lyx.Admin.Common;
using Castle.MicroKernel.Registration;
using Lyx.Admin.Common.IO;

namespace Lyx.Admin
{
    [DependsOn(typeof(AbpAutoMapperModule))]
    public class AdminCommonModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                //Add your custom AutoMapper mappings here...
                //mapper.CreateMap<,>()
            });
            //手动注入
            IocManager.IocContainer.Register(
                    Component.For<IFileUpload>().ImplementedBy<FileManager>().LifeStyle.Transient
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

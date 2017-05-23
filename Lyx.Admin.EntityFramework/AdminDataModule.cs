using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Lyx.Admin.EntityFramework;

namespace Lyx.Admin
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(AdminCoreModule))]
    public class AdminDataModule : AbpModule
    {
        public override void PreInitialize()
        {

            Database.SetInitializer(new CreateDatabaseIfNotExists<AdminDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

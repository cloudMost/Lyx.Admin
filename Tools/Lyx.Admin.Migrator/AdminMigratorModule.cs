using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Lyx.Admin.EntityFramework;

namespace Lyx.Admin.Migrator
{
    [DependsOn(typeof(AdminDataModule))]
    public class AdminMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<AdminDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
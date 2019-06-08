using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ABPDemo.EntityFramework;

namespace ABPDemo.Migrator
{
    [DependsOn(typeof(ABPDemoDataModule))]
    public class ABPDemoMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ABPDemoDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
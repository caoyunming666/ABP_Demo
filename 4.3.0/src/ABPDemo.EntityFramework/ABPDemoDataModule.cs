using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using ABPDemo.EntityFramework;

namespace ABPDemo
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(ABPDemoCoreModule))]
    public class ABPDemoDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ABPDemoDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

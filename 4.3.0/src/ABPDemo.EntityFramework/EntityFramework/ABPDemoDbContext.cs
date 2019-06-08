using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using ABPDemo.Authorization.Roles;
using ABPDemo.Authorization.Users;
using ABPDemo.MultiTenancy;

namespace ABPDemo.EntityFramework
{
    public class ABPDemoDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ABPDemoDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ABPDemoDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ABPDemoDbContext since ABP automatically handles it.
         */
        public ABPDemoDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ABPDemoDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public ABPDemoDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}

using System.Linq;
using ABPDemo.EntityFramework;
using ABPDemo.MultiTenancy;

namespace ABPDemo.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ABPDemoDbContext _context;

        public DefaultTenantCreator(ABPDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}

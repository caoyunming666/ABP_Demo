using ABPDemo.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ABPDemo.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ABPDemoDbContext _context;

        public InitialHostDbBuilder(ABPDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}

using Lyx.Admin.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Lyx.Admin.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly AdminDbContext _context;

        public InitialHostDbBuilder(AdminDbContext context)
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

using System.Linq;
using Lyx.Admin.EntityFramework;
using Lyx.Admin.MultiTenancy;

namespace Lyx.Admin.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly AdminDbContext _context;

        public DefaultTenantCreator(AdminDbContext context)
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

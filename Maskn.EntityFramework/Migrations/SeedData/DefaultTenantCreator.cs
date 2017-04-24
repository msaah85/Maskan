using System.Linq;
using Maskn.EntityFramework;
using Maskn.MultiTenancy;

namespace Maskn.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly MasknDbContext _context;

        public DefaultTenantCreator(MasknDbContext context)
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

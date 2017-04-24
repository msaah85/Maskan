using Maskn.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Maskn.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly MasknDbContext _context;

        public InitialHostDbBuilder(MasknDbContext context)
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

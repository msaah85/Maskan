using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Maskn.EntityFramework;

namespace Maskn.Migrator
{
    [DependsOn(typeof(MasknDataModule))]
    public class MasknMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MasknDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
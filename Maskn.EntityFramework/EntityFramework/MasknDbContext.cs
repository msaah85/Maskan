using System.Data.Common;
using Abp.Zero.EntityFramework;
using Maskn.Authorization.Roles;
using Maskn.MultiTenancy;
using Maskn.Users;

namespace Maskn.EntityFramework
{
    public class MasknDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public MasknDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in MasknDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of MasknDbContext since ABP automatically handles it.
         */
        public MasknDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public MasknDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public MasknDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}

using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Maskn.EntityFramework.Repositories
{
    public abstract class MasknRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MasknDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MasknRepositoryBase(IDbContextProvider<MasknDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MasknRepositoryBase<TEntity> : MasknRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MasknRepositoryBase(IDbContextProvider<MasknDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}

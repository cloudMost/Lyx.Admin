using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Lyx.Admin.EntityFramework.Repositories
{
    public abstract class AdminRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AdminDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AdminRepositoryBase(IDbContextProvider<AdminDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AdminRepositoryBase<TEntity> : AdminRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AdminRepositoryBase(IDbContextProvider<AdminDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
            
        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}

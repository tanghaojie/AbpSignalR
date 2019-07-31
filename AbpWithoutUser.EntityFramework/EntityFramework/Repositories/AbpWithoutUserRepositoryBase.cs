using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace AbpWithoutUser.EntityFramework.Repositories
{
    public abstract class AbpWithoutUserRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AbpWithoutUserDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AbpWithoutUserRepositoryBase(IDbContextProvider<AbpWithoutUserDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AbpWithoutUserRepositoryBase<TEntity> : AbpWithoutUserRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AbpWithoutUserRepositoryBase(IDbContextProvider<AbpWithoutUserDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}

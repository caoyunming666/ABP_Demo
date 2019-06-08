using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ABPDemo.EntityFramework.Repositories
{
    public abstract class ABPDemoRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ABPDemoDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ABPDemoRepositoryBase(IDbContextProvider<ABPDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ABPDemoRepositoryBase<TEntity> : ABPDemoRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ABPDemoRepositoryBase(IDbContextProvider<ABPDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}

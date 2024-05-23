using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;

namespace insurtech.EntityFrameworkCore.Repositories
{
    /// <summary>
    /// Base class for custom repositories of the application.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class insurtechRepositoryBase<TEntity, TPrimaryKey> : EfCoreRepositoryBase<insurtechDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected insurtechRepositoryBase(IDbContextProvider<insurtechDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Add your common methods for all repositories 


        //Asmaa
        //Implement from I
        //getAll()
        //getById(id)
        //insert(T entity)
        //update(T entity)
        //Delete(id)

    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="insurtechRepositoryBase{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class insurtechRepositoryBase<TEntity> : insurtechRepositoryBase<TEntity, int>, IRepository<TEntity>
        where TEntity : class, IEntity<int>
    {
        protected insurtechRepositoryBase(IDbContextProvider<insurtechDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Do not add any method here, add to the class above (since this inherits it)!!!
    }
}

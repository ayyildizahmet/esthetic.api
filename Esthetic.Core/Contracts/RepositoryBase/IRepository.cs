using System;
using System.ComponentModel;
using System.Linq;
using Esthetic.Core.Contracts.EntityBase;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Esthetic.Core.Contracts.RepositoryBase
{

    public interface IRepository<TEntity> : IQueryable<TEntity>, IInfrastructure<IServiceProvider>, IListSource, IRepository
        where TEntity : class, IEntity
    {
        #region DbSet

        EntityEntry<TEntity> Add(TEntity entity);

        EntityEntry<TEntity> Remove(TEntity entity);

        EntityEntry<TEntity> Delete(TEntity entity);

        #endregion DbSet
    }

    public interface IRepository : IDisposable
    {

    }
}

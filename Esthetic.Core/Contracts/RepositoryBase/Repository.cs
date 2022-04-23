using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using MakeEat.Core.Contracts.Data;
using MakeEat.Core.Contracts.EntityBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MakeEat.Core.Contracts.RepositoryBase

{
    public class Repository<TEntity> : DbSet<TEntity>, IRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly DbContext _context;

        public Repository(IDbContext context)
        {
            _context = context as DbContext;
        }

        #region IDisposable

        ~Repository()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                ReleaseManagedResources();
            }

            ReleaseUnmanagedResources();
        }

        protected virtual void ReleaseManagedResources()
        {
        }

        protected virtual void ReleaseUnmanagedResources()
        {
        }

        #endregion IDisposable

        #region IEnumerable

        public IEnumerator<TEntity> GetEnumerator() => (_context.Set<TEntity>() as IEnumerable<TEntity>).GetEnumerator();

        public Expression Expression => (_context.Set<TEntity>() as IQueryable<TEntity>).Expression;

        public Type ElementType => (_context.Set<TEntity>() as IQueryable<TEntity>).ElementType;

        public IQueryProvider Provider => (_context.Set<TEntity>() as IQueryable<TEntity>).Provider;

        //public IAsyncEnumerable<TEntity> AsyncEnumerable => (_context.Set<TEntity>() as IAsyncEnumerableAccessor<TEntity>).AsyncEnumerable;

        public IServiceProvider Instance => (_context.Set<TEntity>() as IInfrastructure<IServiceProvider>).Instance;
        public bool ContainsListCollection => (_context.Set<TEntity>() as IListSource).ContainsListCollection;

        public override IEntityType EntityType => throw new NotImplementedException();

        IEnumerator IEnumerable.GetEnumerator() => (_context.Set<TEntity>() as IEnumerable).GetEnumerator();

        public IList GetList() => (_context.Set<TEntity>() as IListSource).GetList();

        #endregion IEnumerable

        #region DbSet

        public override EntityEntry<TEntity> Add(TEntity entity) => _context.Add(entity);
        public EntityEntry<TEntity> Delete(TEntity entity) => (_context as IDbContext)?.Delete(entity);
        public override EntityEntry<TEntity> Remove(TEntity entity) => _context.Remove(entity);

        #endregion DbSet
    }

    public class Repository : IRepository
    {
        #region IDisposable

        ~Repository()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                ReleaseManagedResources();
            }

            ReleaseUnmanagedResources();
        }

        protected virtual void ReleaseManagedResources()
        {
        }

        protected virtual void ReleaseUnmanagedResources()
        {
        }

        #endregion IDisposable
    }

 

}
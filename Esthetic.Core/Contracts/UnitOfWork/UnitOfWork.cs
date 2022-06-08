using System;
using System.Threading.Tasks;
using System.Transactions;
using Esthetic.Core.Contracts.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Esthetic.Core.Contracts.UnitOfWork
{
    public class UnitOfWork<TContext> : UnitOfWork, IUnitOfWork<TContext> where TContext : DbContext, IDbContext
    {
        public UnitOfWork(TContext context) : base(context)
        {
        }
    }

    public class UnitOfWork : IUnitOfWork
    {
        private DbContext _context;
        private TransactionScope _transactionScope;
        private IDbContextTransaction _transaction;
        private IDisposable _scope;

        public UnitOfWork(IDbContext context)
        {
            _context = context as DbContext;
        }

        public void SetScope(IDisposable scope)
        {
            _scope = scope;
        }


        public TransactionScope BeginTransaction(IsolationLevel isolationLevel) => _transactionScope ??= new TransactionScope(TransactionScopeOption.Required,
            new TransactionOptions { IsolationLevel = isolationLevel });

        public IDbContextTransaction BeginTransaction(System.Data.IsolationLevel isolationLevel = System.Data.IsolationLevel.ReadUncommitted) => _transaction ??= _context.Database.BeginTransaction();

        public virtual void Flush() => ReleaseManagedResources();

        public void Rollback()
        {
            _transaction?.Rollback();
            _transaction = null;

            _transactionScope?.Dispose();

            _transactionScope = null;
        }

        public void Commit()
        {
            _transaction?.Commit();
            _transaction = null;

            _transactionScope?.Complete();
            _transactionScope?.Dispose();
            _transactionScope = null;
        }

        public int SaveChanges(QueryTrackingBehavior? queryTrackingBehavior = null) => _context?.SaveChanges() ?? -1;

        public Task<int> SaveChangesAsync(QueryTrackingBehavior? queryTrackingBehavior = null) => _context == null ? Task.FromResult(-1) : _context.SaveChangesAsync();


        #region IDisposable

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Flush();
            }

            ReleaseUnmanagedResources();
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }

        protected virtual void ReleaseManagedResources()
        {
            Rollback();

            _context?.Dispose();
            _context = null;

            
            //Factory.Release(_transactionScope);
            _transactionScope = null;

            _scope?.Dispose();
            //Factory.Release(_scope);
            _scope = null;
        }

        protected virtual void ReleaseUnmanagedResources()
        {
        }

        #endregion IDisposable
    }

}

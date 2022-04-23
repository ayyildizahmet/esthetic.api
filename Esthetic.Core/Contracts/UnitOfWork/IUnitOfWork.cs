using System;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace MakeEat.Core.Contracts.UnitOfWork
{
    public interface IUnitOfWork<TContext> : IUnitOfWork where TContext : DbContext
    {
    }

    public interface IUnitOfWork : IDisposable
    {
        void SetScope(IDisposable scope);

        TransactionScope BeginTransaction(IsolationLevel isolationLevel);
        IDbContextTransaction BeginTransaction(System.Data.IsolationLevel isolationLevel = System.Data.IsolationLevel.ReadUncommitted);

        void Rollback();

        void Commit();

        int SaveChanges(QueryTrackingBehavior? queryTrackingBehavior = null);
        Task<int> SaveChangesAsync(QueryTrackingBehavior? queryTrackingBehavior = null);

        void Flush();
    }
}

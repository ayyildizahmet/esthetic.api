using System;
using Esthetic.Core.Contracts.EntityBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Esthetic.Core.Contracts.Data
{
    public interface IDbContext : IInfrastructure<IServiceProvider>
    {
        void SetGlobalQuery<T>(ModelBuilder builder) where T : class, IEntity;
        void Configure<T>(ModelBuilder builder) where T : class, IEntity;
        EntityEntry<TEntity> Delete<TEntity>(TEntity entity) where TEntity : class, IEntity;
    }
}

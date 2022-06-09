using Esthetic.Core.Contracts.Data;
using Esthetic.Core.Contracts.RepositoryBase;
using Esthetic.DataAccess.Repositories.Contracts;
using Esthetic.Domain;

namespace Esthetic.DataAccess.Repositories
{
    public class OperationTypeRepository : Repository<OperationType>, IOperationTypeRepository
    {
        public OperationTypeRepository(IDbContext context) : base(context)
        {
        }
    }
}
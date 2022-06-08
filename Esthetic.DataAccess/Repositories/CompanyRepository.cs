using Esthetic.Core.Contracts.Data;
using Esthetic.Core.Contracts.RepositoryBase;
using Esthetic.DataAccess.Repositories.Contracts;
using Esthetic.Domain;

namespace Esthetic.DataAccess.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(IDbContext context) : base(context)
        {
        }
    }
}
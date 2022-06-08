using Esthetic.Core.Contracts.Data;
using Esthetic.Core.Contracts.RepositoryBase;
using Esthetic.DataAccess.Repositories.Contracts;
using Esthetic.Domain;

namespace Esthetic.DataAccess.Repositories
{
    public class CityRepository:Repository<City>, ICityRepository
    {
        public CityRepository(IDbContext context) : base(context)
        {
        }
    }
}
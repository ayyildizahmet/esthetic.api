using MakeEat.Core.Contracts.Data;
using MakeEat.Core.Contracts.RepositoryBase;
using MakeEat.DataAccess.Repositories.Contracts;
using MakeEat.Domain;

namespace MakeEat.DataAccess.Repositories
{
    public class CityRepository:Repository<City>, ICityRepository
    {
        public CityRepository(IDbContext context) : base(context)
        {
        }
    }
}
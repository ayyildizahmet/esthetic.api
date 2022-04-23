using MakeEat.Core.Contracts.Data;
using MakeEat.Core.Contracts.RepositoryBase;
using MakeEat.DataAccess.Repositories.Contracts;
using MakeEat.Domain;

namespace MakeEat.DataAccess.Repositories
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(IDbContext context) : base(context)
        {
        }
    }
}
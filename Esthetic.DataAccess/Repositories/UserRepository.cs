using MakeEat.Core.Contracts.Data;
using MakeEat.Core.Contracts.RepositoryBase;
using MakeEat.DataAccess.Repositories.Contracts;
using MakeEat.Domain;

namespace MakeEat.DataAccess.Repositories
{
    public class UserRepository:Repository<User>, IUserRepository
    {
        public UserRepository(IDbContext context) : base(context)
        {
        }
    }
}
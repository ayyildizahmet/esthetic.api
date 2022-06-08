using Esthetic.Core.Contracts.Data;
using Esthetic.Core.Contracts.RepositoryBase;
using Esthetic.DataAccess.Repositories.Contracts;
using Esthetic.Domain;

namespace Esthetic.DataAccess.Repositories
{
    public class UserRepository:Repository<User>, IUserRepository
    {
        public UserRepository(IDbContext context) : base(context)
        {
        }
    }
}
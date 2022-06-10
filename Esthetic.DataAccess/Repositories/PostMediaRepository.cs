using Esthetic.Core.Contracts.Data;
using Esthetic.Core.Contracts.RepositoryBase;
using Esthetic.DataAccess.Repositories.Contracts;
using Esthetic.Domain;

namespace Esthetic.DataAccess.Repositories
{
    public class PostMediaRepository : Repository<PostMedia>, IPostMediaRepository
    {
        public PostMediaRepository(IDbContext context) : base(context)
        {
        }
    }
}
using Esthetic.Core.Contracts.Data;
using Esthetic.Core.Contracts.RepositoryBase;
using Esthetic.DataAccess.Repositories.Contracts;
using Esthetic.Domain;

namespace Esthetic.DataAccess.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(IDbContext context) : base(context)
        {
        }
    }
}
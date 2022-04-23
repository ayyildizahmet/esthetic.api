using MakeEat.Core.Contracts.Data;
using MakeEat.Core.Contracts.RepositoryBase;
using MakeEat.DataAccess.Repositories.Contracts;
using MakeEat.Domain;

namespace MakeEat.DataAccess.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(IDbContext context) : base(context)
        {
        }
    }
}
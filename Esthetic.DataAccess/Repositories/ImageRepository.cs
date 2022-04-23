using MakeEat.Core.Contracts.Data;
using MakeEat.Core.Contracts.RepositoryBase;
using MakeEat.DataAccess.Repositories.Contracts;
using MakeEat.Domain;

namespace MakeEat.DataAccess.Repositories
{
    public class ImageRepository : Repository<Image>, IImageRepository
    {
        public ImageRepository(IDbContext context) : base(context)
        {
        }
    }
}
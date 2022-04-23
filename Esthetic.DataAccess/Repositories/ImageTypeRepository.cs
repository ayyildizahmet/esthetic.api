using MakeEat.Core.Contracts.Data;
using MakeEat.Core.Contracts.RepositoryBase;
using MakeEat.DataAccess.Repositories.Contracts;
using MakeEat.Domain;

namespace MakeEat.DataAccess.Repositories
{
    public class ImageTypeRepository : Repository<ImageType>, IImageTypeRepository
    {
        public ImageTypeRepository(IDbContext context) : base(context)
        {
        }
    }
}
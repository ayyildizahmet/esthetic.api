using Esthetic.Core.Contracts.UnitOfWork;
using Esthetic.Service.Contracts;

namespace Esthetic.Service
{
    public class ProductService : Core.Contracts.ServiceBase.Service, IProductService
    {
       private readonly IUnitOfWork _unitOfWork;
        
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

    }
}
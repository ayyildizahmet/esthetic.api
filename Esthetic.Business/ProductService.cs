using MakeEat.Core.Contracts.UnitOfWork;
using MakeEat.Service.Contracts;

namespace MakeEat.Service
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
using MakeEat.Core.Contracts.UnitOfWork;
using MakeEat.Service.Contracts;

namespace MakeEat.Service
{
    public class ImageService : Core.Contracts.ServiceBase.Service, IImageService
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public ImageService(IUnitOfWork unitOfWork)
        {
           
            _unitOfWork = unitOfWork;
        }

      
    }
}
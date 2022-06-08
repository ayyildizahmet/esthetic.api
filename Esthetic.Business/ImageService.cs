using Esthetic.Core.Contracts.UnitOfWork;
using Esthetic.Service.Contracts;

namespace Esthetic.Service
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
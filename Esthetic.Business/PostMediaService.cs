using Esthetic.Core.Contracts.UnitOfWork;
using Esthetic.Service.Contracts;

namespace Esthetic.Service
{
    public class PostMediaService : Core.Contracts.ServiceBase.Service, IPostMediaService
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public PostMediaService(IUnitOfWork unitOfWork)
        {
           
            _unitOfWork = unitOfWork;
        }

      
    }
}
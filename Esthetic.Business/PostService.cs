using Esthetic.Core.Contracts.UnitOfWork;
using Esthetic.Service.Contracts;

namespace Esthetic.Service
{
    public class PostService : Core.Contracts.ServiceBase.Service, IPostService
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public PostService(IUnitOfWork unitOfWork)
        {
           
            _unitOfWork = unitOfWork;
        }

      
    }
}
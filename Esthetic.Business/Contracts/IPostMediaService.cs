using Esthetic.Core.Contracts.ServiceBase;
using Esthetic.Model;

namespace Esthetic.Service.Contracts
{
    public interface IPostMediaService : IService
    {
        public bool Create(PostMediaModel postMediaModel);
    }
}
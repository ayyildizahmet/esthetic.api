using Esthetic.Core.Contracts.ServiceBase;
using Esthetic.Model;
using System.Collections.Generic;

namespace Esthetic.Service.Contracts
{
    public interface IPostService : IService
    {
        public bool CreatePost(PostModel postModel);

        List<PostModel> GetList();

    }
}
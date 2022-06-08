using System.Collections.Generic;
using Esthetic.Core.Contracts.ServiceBase;
using Esthetic.Domain;
using Esthetic.Model;

namespace Esthetic.Service.Contracts
{
    public interface IUserService : IService
    {
        List<OperationClaim> GetClaims(UserLoginResponseModel user);

        bool Add(UserRegisterRequestModel userRegisterRequestModel, byte[] passwordHash, byte[] passwordSalt);
        User GetById(int id);
        User GetByMail(string email);
    }
}
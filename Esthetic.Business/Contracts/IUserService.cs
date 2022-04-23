using System.Collections.Generic;
using MakeEat.Core.Contracts.ServiceBase;
using MakeEat.Domain;
using MakeEat.Model;

namespace MakeEat.Service.Contracts
{
    public interface IUserService : IService
    {
        List<OperationClaim> GetClaims(UserLoginResponseModel user);

        bool Add(UserRegisterRequestModel userRegisterRequestModel, byte[] passwordHash, byte[] passwordSalt);
        User GetById(int id);
        User GetByMail(string email);
    }
}
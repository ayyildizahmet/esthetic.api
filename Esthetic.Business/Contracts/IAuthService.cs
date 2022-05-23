using System;
using MakeEat.Core.Contracts.ServiceBase;
using MakeEat.Domain;
using MakeEat.Model;

namespace MakeEat.Service.Contracts
{
    public interface IAuthService : IService
    {
        UserLoginResponseModel Login(UserLoginRequestModel userLoginRequestModel);
        UserRegisterResponseModel Register(UserRegisterRequestModel userRegisterRequestModel);
        AccessTokenModel CreateAccessToken(UserLoginResponseModel user);
        bool IsUserExists(string email);
    }
}
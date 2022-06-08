using System;
using Esthetic.Core.Contracts.ServiceBase;
using Esthetic.Domain;
using Esthetic.Model;

namespace Esthetic.Service.Contracts
{
    public interface IAuthService : IService
    {
        UserLoginResponseModel Login(UserLoginRequestModel userLoginRequestModel);
        UserRegisterResponseModel Register(UserRegisterRequestModel userRegisterRequestModel);
        AccessTokenModel CreateAccessToken(UserLoginResponseModel user);
        bool IsUserExists(string email);
    }
}
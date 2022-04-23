using System;
using AutoMapper;
using MakeEat.Domain;
using MakeEat.Model;
using MakeEat.Service.Contracts;
using MakeEat.Utility.Security;
using MakeEat.Utility.Token;

namespace MakeEat.Service
{
    public class AuthService : Core.Contracts.ServiceBase.Service, IAuthService
    {
        private readonly IUserService _userService;
        private readonly ITokenHelper _tokenHelper;
        private readonly IMapper _mapper;

        public AuthService(IUserService userService, ITokenHelper tokenHelper, IMapper mapper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
            _mapper = mapper;
        }

        public UserLoginResponseModel Login(UserLoginRequestModel userLoginRequestModel)
        {
            var result = new UserLoginResponseModel();

            var user = _userService.GetByMail(userLoginRequestModel.Email);

            if (user != null)
            {
                var isVerifiedPassword = HashingHelper.VerifyPasswordHash(userLoginRequestModel.Password, user.PasswordHash, user.PasswordSalt);

                if (isVerifiedPassword)
                {
                    result.Id = user.Id;
                    result.FirstName = user.FirstName;
                    result.LastName = user.LastName;
                    result.Email = user.Email;
                }
            }

            return result;
        }

        public bool Register(UserRegisterRequestModel userRegisterRequestModel)
        {
            HashingHelper.CreatePasswordHash(userRegisterRequestModel.Password, out var passwordHash, out var passwordSalt);
            return _userService.Add(userRegisterRequestModel, passwordHash, passwordSalt); 
        }

        public bool IsUserExists(string email)
        {
            return _userService.GetByMail(email) != null;
        }

        public AccessTokenModel CreateAccessToken(UserLoginResponseModel user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return accessToken;
        }
    }
}

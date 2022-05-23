using AutoMapper;
using Esthetic.Core.Contracts.Utilities;
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
        private readonly IStringUtility _stringUtility;

        public AuthService(IUserService userService, ITokenHelper tokenHelper, IMapper mapper, IStringUtility stringUtility)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
            _mapper = mapper;
            _stringUtility = stringUtility;
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

        public UserRegisterResponseModel Register(UserRegisterRequestModel userRegisterRequestModel)
        {
            UserRegisterResponseModel result = new UserRegisterResponseModel();
            userRegisterRequestModel.FirstName = _stringUtility.ToPascalCase(userRegisterRequestModel.FirstName);
            userRegisterRequestModel.LastName = _stringUtility.ToPascalCase(userRegisterRequestModel.LastName);
            HashingHelper.CreatePasswordHash(userRegisterRequestModel.Password, out var passwordHash, out var passwordSalt);
            result.IsSuccess = _userService.Add(userRegisterRequestModel, passwordHash, passwordSalt);
            return result;
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

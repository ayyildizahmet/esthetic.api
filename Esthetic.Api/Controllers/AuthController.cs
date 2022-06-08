using System;
using Esthetic.Model;
using Esthetic.Model.Validation;
using Esthetic.Service.Contracts;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Esthetic.Api.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public ResponseModel<UserLoginResponseModel> Login(UserLoginRequestModel userLoginRequestModel)
        {
            var response = new ResponseModel<UserLoginResponseModel>();

            var validator = new UserLoginRequestModelValidator();
            var validate=validator.Validate(userLoginRequestModel);
            
            if (!validate.IsValid)
            {
                response.Success = false;
                response.Message = string.Join(", ", Array.ConvertAll(validate.Errors.ToArray(), i => i.ToString()));
                return response;
            }

            var user = _authService.Login(userLoginRequestModel);

            if (user.Id != default)
            {
                response.Data = user;
                var token = _authService.CreateAccessToken(user);
                if (token != null) {
                    response.Data.Security = token;
                    response.Message = "Giriş işlemi başarılı";
                }
            }
            else
            {
                response.Success = false;
                response.Message = "Kullanıcı adı yada şifre yanlış.";
            }

            return response;
        }

        [HttpPost("register")]
        public ResponseModel<UserRegisterResponseModel> Register(UserRegisterRequestModel userRegisterRequestModel)
        {
            var response = new ResponseModel<UserRegisterResponseModel>();

            if (_authService.IsUserExists(userRegisterRequestModel.Email))
            {
                response.Success = false;
                response.Message = "Kullanıcı zaten mevcut.";
            }
            
            else
            {
                UserRegisterResponseModel result = _authService.Register(userRegisterRequestModel);
                if (result.IsSuccess)
                {
                    response.Data = result;
                    response.Message = "Kayıt işlemi başarılı.";
                }
                else
                {
                    response.Success = false;
                    response.Message = "Kullanıcı kayıt edilirken bir sorun meydana geldi.";
                }
            }
         
            return response;
        }
    }
}

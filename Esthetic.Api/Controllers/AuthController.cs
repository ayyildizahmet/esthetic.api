using System;
using System.Text;
using MakeEat.Model;
using MakeEat.Model.Validation;
using MakeEat.Service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace MakeEat.Api.Controllers
{
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

            if (user.Id != default(int))
            {
                response.Data = user;
                var token = _authService.CreateAccessToken(user);
                if (token != null)
                    response.Data.Security = token;
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
            else if (_authService.Register(userRegisterRequestModel) == false)
            {
                response.Success = false;
                response.Message = "Kullanıcı kayıt edilirken bir sorun meydana geldi.";
            }
            else
            {
                response.Message = "Kayıt işlemi başarılı.";
            }

            return response;
        }
    }
}

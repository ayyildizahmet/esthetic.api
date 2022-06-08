using System;
using FluentValidation;

namespace Esthetic.Model.Validation
{
    public class UserLoginRequestModelValidator:AbstractValidator<UserLoginRequestModel>
    {
        public UserLoginRequestModelValidator()
        {
            RuleFor(m => m.Email).EmailAddress().NotNull();
            RuleFor(m => m.Password).NotNull().MinimumLength(8);
        }
    }
}

using System;
using FluentValidation;

namespace Esthetic.Model.Validation
{
    public class AddressCreateRequestModelValidator : AbstractValidator<AddressCreateRequestModel>
    {
        public AddressCreateRequestModelValidator()
        {
            RuleFor(m => m.Name).NotNull();
            RuleFor(m => m.CityId).NotNull().GreaterThan(0);
            RuleFor(m => m.DistrictId).NotNull().GreaterThan(0);
            RuleFor(m => m.UserId).NotNull().GreaterThan(0);
        }
    }
}

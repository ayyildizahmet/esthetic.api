using System;
using System.Collections.Generic;
using MakeEat.Model;
using MakeEat.Model.Validation;
using MakeEat.Service.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MakeEat.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet("getlist")]
        public ResponseModel<List<AddressModel>> GetList(int userId)
        {
            var response = new ResponseModel<List<AddressModel>>();
            var addressList = _addressService.GetListByUserId(userId);
            response.Data = addressList;
            return response;
        }

        [HttpPost("create")]
        public ResponseModel<bool> Create(AddressCreateRequestModel addressCreateRequestModel)
        {
            var response = new ResponseModel<bool>();

            var validator = new AddressCreateRequestModelValidator();
            var validate = validator.Validate(addressCreateRequestModel);

            if (!validate.IsValid)
            {
                response.Success = false;
                response.Message = string.Join(", ", Array.ConvertAll(validate.Errors.ToArray(), i => i.ToString()));
                return response;
            }

            response.Data = _addressService.Add(addressCreateRequestModel);
            return response;
        }

        [HttpPost("update")]
        public ResponseModel<bool> Update(AddressUpdateRequestModel addressUpdateRequestModel)
        {
            var response = new ResponseModel<bool>();

            var validator = new AddressUpdateRequestModelValidator();
            var validate = validator.Validate(addressUpdateRequestModel);

            if (!validate.IsValid)
            {
                response.Success = false;
                response.Message = string.Join(", ", Array.ConvertAll(validate.Errors.ToArray(), i => i.ToString()));
                return response;
            }

            response.Data = _addressService.Update(addressUpdateRequestModel);
            return response;
        }

        [HttpGet("delete")]
        public ResponseModel<bool> Delete(int id)
        {
            var response = new ResponseModel<bool> {Data = _addressService.Delete(id)};
            return response;
        }

    }
}

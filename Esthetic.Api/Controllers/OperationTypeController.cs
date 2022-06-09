using System.Collections.Generic;
using Esthetic.Model;
using Esthetic.Service.Contracts;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Esthetic.Api.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class OperationTypeController : Controller
    {
        private readonly IOperationTypeService _OperationTypeService;

        public OperationTypeController(IOperationTypeService OperationTypeService)
        {
            _OperationTypeService = OperationTypeService;
        }

        [HttpGet("getlist")]
        public ResponseModel<List<OperationTypeModel>> GetList()
        {
            var response = new ResponseModel<List<OperationTypeModel>>();
            var OperationTypeList = _OperationTypeService.GetList();
            response.Data = OperationTypeList;
            return response;
        }

    }
}

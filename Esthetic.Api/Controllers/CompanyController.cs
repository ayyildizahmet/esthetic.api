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
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet("getlist")]
        public ResponseModel<List<CompanyModel>> GetList()
        {
            var response = new ResponseModel<List<CompanyModel>>();
            var CompanyList = _companyService.GetList();
            response.Data = CompanyList;
            return response;
        }

    }
}

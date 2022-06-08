using AutoMapper;
using Esthetic.DataAccess.Repositories.Contracts;
using Esthetic.Model;
using Esthetic.Service.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Esthetic.Service
{
    public class CompanyService : Core.Contracts.ServiceBase.Service, ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public CompanyService(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public List<CompanyModel> GetList()
        {
            var companies = _companyRepository.ToList();
            var companyList = _mapper.Map<List<CompanyModel>>(companies);
            return companyList;
        }
    }
}
using AutoMapper;
using Esthetic.DataAccess.Repositories.Contracts;
using Esthetic.Model;
using Esthetic.Service.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Esthetic.Service
{
    public class OperationTypeService : Core.Contracts.ServiceBase.Service, IOperationTypeService
    {
        private readonly IOperationTypeRepository _operationTypeRepository;
        private readonly IMapper _mapper;

        public OperationTypeService(IOperationTypeRepository operationTypeRepository, IMapper mapper)
        {
            _operationTypeRepository = operationTypeRepository;
            _mapper = mapper;
        }

        public List<OperationTypeModel> GetList()
        {
            var operationTypes = _operationTypeRepository.ToList();
            var companyList = _mapper.Map<List<OperationTypeModel>>(operationTypes);
            return companyList;
        }
    }
}
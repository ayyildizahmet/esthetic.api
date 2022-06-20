using AutoMapper;
using Esthetic.DataAccess.Repositories.Contracts;
using Esthetic.Model;
using Esthetic.Service.Contracts;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Esthetic.Service
{
    public class OperationTypeService : Core.Contracts.ServiceBase.Service, IOperationTypeService
    {
        private readonly IOperationTypeRepository _operationTypeRepository;
        private readonly IImageService _imageService;
        private readonly IMapper _mapper;

        public OperationTypeService(IOperationTypeRepository operationTypeRepository, IImageService imageService, IMapper mapper)
        {
            _operationTypeRepository = operationTypeRepository;
            _imageService = imageService;
            _mapper = mapper;
        }

        public List<OperationTypeModel> GetList()
        {
            var operationTypes = _operationTypeRepository.Include(x=>x.Image).ToList();
            var operationTypeModelList = _mapper.Map<List<OperationTypeModel>>(operationTypes);
            if (operationTypeModelList.Any())
            {
                operationTypeModelList.ForEach(x =>
                {
                    //Todo: OperationType entitisine ImageId eklenecek. include kaldırılacak. Include yapılırsa data alanı da dolu geliyor. bunun yerine image id ile image service without data servisi kullanılarak image objesi doldurulacak.
                    x.Image = _imageService.GetImageWithoutData(x.Image.Id);
                });
            }
            return operationTypeModelList;
        }
    }
}
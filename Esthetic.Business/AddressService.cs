using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MakeEat.Core.Contracts.UnitOfWork;
using MakeEat.DataAccess.Repositories.Contracts;
using MakeEat.Domain;
using MakeEat.Model;
using MakeEat.Service.Contracts;

namespace MakeEat.Service
{
    public class AddressService : Core.Contracts.ServiceBase.Service, IAddressService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public AddressService(IUnitOfWork unitOfWork, IAddressRepository addressRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public List<AddressModel> GetListByUserId(int userId)
        {
            var address = _addressRepository.Where(x => x.UserId == userId);
            var addressList = _mapper.Map<List<AddressModel>>(address);
            return addressList;
        }

        public bool Add(AddressCreateRequestModel addressCreateRequestModel)
        {
            var address = _mapper.Map<Address>(addressCreateRequestModel);
            _addressRepository.Add(address);
            return _unitOfWork.SaveChanges() > 0;
        }

        public bool Update(AddressUpdateRequestModel addressUpdateRequestModel)
        {
            var selectedAddress = _addressRepository.FirstOrDefault(x => x.Id == addressUpdateRequestModel.Id);

            if (selectedAddress == null) return false;

            selectedAddress.Name = addressUpdateRequestModel.Name;
            selectedAddress.Description = addressUpdateRequestModel.Description;
            selectedAddress.UserId = addressUpdateRequestModel.UserId;
            selectedAddress.CityId = addressUpdateRequestModel.CityId;
            selectedAddress.DistrictId = addressUpdateRequestModel.DistrictId;
            selectedAddress.Latitude = addressUpdateRequestModel.Latitude;
            selectedAddress.Longitude = addressUpdateRequestModel.Longitude;
            selectedAddress.IsDefault = addressUpdateRequestModel.IsDefault;
            return _unitOfWork.SaveChanges() > 0;
        }

        public bool Delete(int addressId)
        {
            var address = _addressRepository.FirstOrDefault(x => x.Id == addressId);
            if (address == null) return false;
            _addressRepository.Delete(address);
            return _unitOfWork.SaveChanges() > 0;
        }
    }
}
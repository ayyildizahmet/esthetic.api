using System.Collections.Generic;
using MakeEat.Core.Contracts.ServiceBase;
using MakeEat.Model;

namespace MakeEat.Service.Contracts
{
    public interface IAddressService : IService
    {
        List<AddressModel> GetListByUserId(int userId);
        bool Add(AddressCreateRequestModel addressModel);
        bool Update(AddressUpdateRequestModel addressModel);
        bool Delete(int addressId);
    }
}
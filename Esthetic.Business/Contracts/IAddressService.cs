using System.Collections.Generic;
using Esthetic.Core.Contracts.ServiceBase;
using Esthetic.Model;

namespace Esthetic.Service.Contracts
{
    public interface IAddressService : IService
    {
        List<AddressModel> GetListByUserId(int userId);
        bool Add(AddressCreateRequestModel addressModel);
        bool Update(AddressUpdateRequestModel addressModel);
        bool Delete(int addressId);
    }
}
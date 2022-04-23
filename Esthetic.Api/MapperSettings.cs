using AutoMapper;
using MakeEat.Domain;

namespace MakeEat.Model.Mapper
{
    public class MapperSettings : Profile
    {
        public MapperSettings()
        {
            CreateMap<UserRegisterRequestModel, User>();
            CreateMap<AddressCreateRequestModel, Address>();
            CreateMap<AddressUpdateRequestModel, Address>();
            CreateMap<AddressModel, Address>().ReverseMap();
        }
    }
}

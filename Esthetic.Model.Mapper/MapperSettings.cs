using AutoMapper;
using MakeEat.Domain;

namespace MakeEat.Model.Mapper
{
    public class MapperSettings : Profile
    {
        public MapperSettings()
        {
            CreateMap<UserRegisterRequestModel, User>();
        }
    }
}

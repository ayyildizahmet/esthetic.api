using AutoMapper;
using Esthetic.Domain;

namespace Esthetic.Model.Mapper
{
    public class MapperSettings : Profile
    {
        public MapperSettings()
        {
            CreateMap<UserRegisterRequestModel, User>();
        }
    }
}

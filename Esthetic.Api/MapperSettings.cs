using AutoMapper;
using Esthetic.Domain;

namespace Esthetic.Model.Mapper
{
    public class MapperSettings : Profile
    {
        public MapperSettings()
        {
            CreateMap<UserRegisterRequestModel, User>();
            CreateMap<AddressCreateRequestModel, Address>();
            CreateMap<AddressUpdateRequestModel, Address>();
            CreateMap<AddressModel, Address>().ReverseMap();
            CreateMap<CompanyModel, Company>().ReverseMap();
            CreateMap<OperationTypeModel, OperationType>().ReverseMap();
            CreateMap<PostModel, Post>().ReverseMap();
            CreateMap<PostMediaModel, PostMedia>().ReverseMap();
            CreateMap<ImageModel, Image>().ReverseMap().ForMember(dest => dest.Url, act => act.Ignore());
            CreateMap<VideoModel, Video>().ReverseMap();
        }
    }
}
